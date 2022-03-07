﻿using DevIdent.Classes;
using DevIdent.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class ServicesForm : Form
    {
        #region Поиск

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            ServiceBox.Items.Clear();
            ServiceBox.Items.AddRange(ServiceList.Where(item => item.ToLower().Contains(SearchBox.Text.ToLower()))
                .ToArray());
        }

        #endregion

        #region Форма

        public void FormSettings()
        {
            try
            {
                Opacity = Settings.Default.Opacity;
            }
            catch
            {
            }

            ContentPanel.BackColor =
                ColorTranslator.FromHtml("#" + Settings.Default.ColorMenu.Replace("#", string.Empty));
            MenuPanel.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            foreach (var button in Controls.OfType<PictureBox>())
                button.ChangeColor("#" + Settings.Default.ColorButtonsDefault.Replace("#", string.Empty));
            ServiceBox.BackColor =
                ColorTranslator.FromHtml("#" + Settings.Default.ColorMenu.Replace("#", string.Empty));
            foreach (ToolStripMenuItem item in MainMenu.Items)
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            foreach (ToolStripMenuItem item in WorkWithServicesMenuItem.DropDownItems)
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            foreach (ToolStripMenuItem item in SettingsMenuItem.DropDownItems)
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
        }

        #region Убрать мерцаниеы

        protected override CreateParams CreateParams
        {
            get
            {
                var handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        #endregion

        public ServicesForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
            Width = 500;

            ServiceBox.DoubleClick += (s, e) => Width = 500;
            MenuPanel.Click += (s, e) => Width = 500;
            SearchBox.DoubleClick += (s, e) => SearchBox.Text = "";
            ServiceInfoLb.Click += (s, e) =>
            {
                if (ServiceInfoLb.Text.StartsWith("Слишком длинное описание службы, кликните по тексту, чтобы прочитать полное описание"))
                {
                    var wmiService = new ManagementObject("Win32_Service.Name='"
                                                      + GetName() + "'");
                    NotepadMessager.SendMessage((string)wmiService["Description"]);
                }
            };
            foreach (var picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) =>
                {
                    picture.BackColor =
                        ColorTranslator.FromHtml(
                            "#" + Settings.Default.ColorButtonsHover.Replace("#", string.Empty));
                };
                picture.MouseLeave += (s, e) =>
                {
                    picture.BackColor =
                        ColorTranslator.FromHtml("#" +
                                                 Settings.Default.ColorButtonsDefault.Replace("#", string.Empty));
                };
            }

            ServiceBox.Click += (s, e) =>
            {
                GetInfoAboutSelectedService();
                Width = 800;
            };
            FormSettings();

            ManagementEventWatcher watcher = new ManagementEventWatcher(@"SELECT * FROM RegistryTreeChangeEvent WHERE Hive='HKEY_LOCAL_MACHINE' AND RootPath='SYSTEM'");
            watcher.EventArrived += new EventArrivedEventHandler(Watcher_Changed);
            watcher.Start();

        }

        #region Чекаем изменения в реестре в реальном времени

        private void Watcher_Changed(object sender, EventArrivedEventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    Invoke((Action)(() =>
                    {

                        GetActiveServices();
                        SearchBox.Text = prevSearch;

                    }));
                }
                catch
                {

                }
            }).Start();
        }

        #endregion

        #region Перемещение формы

        private void ServicesForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion

        #region Закрытие формы

        private void CloseBth_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #endregion

        #region Работа с службами

        #region Получение активных служб

        private static ServiceController[] RunningServices = ServiceController.GetServices();
        private static readonly List<string> ServiceList = new List<string>();

        string prevSearch;

        private void GetActiveServices()
        {
            prevSearch = SearchBox.Text;
            Array.Clear(RunningServices, 0, RunningServices.Length);
            RunningServices = ServiceController.GetServices();
            ServiceBox.Items.Clear();
            ServiceList.Clear();
            foreach (var service in RunningServices)
            {
                try
                {
                    ServiceBox.Items.Add(service.ServiceName + " / " + service.DisplayName + " / Тип запуска: " + GetServiceSettings(service.ServiceName));
                    ServiceList.Add(service.ServiceName + " / " + service.DisplayName + " / Тип запуска: " + GetServiceSettings(service.ServiceName));
                }
                catch
                {
                }
            }
            SearchBox.Text = "";
        }

        #endregion Получение активных служб

        #region Загрузка формы

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            GetActiveServices();
        }

        #endregion

        #region Получение инфы о выбранном элементе

        private string GetName()
        {
            return ServiceBox.SelectedItem.ToString().Split('/')[0].Trim();
        }

        private string GetServiceSettings(string serviceName)
        {
            try
            {
                if (Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\" + serviceName).GetValue("Start") == null)
                {

                }
                switch (Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\" + serviceName).GetValue("Start"))
                {
                    case 1: return "автоматический (отложенный запуск)";
                    case 2: return "автоматический";
                    case 3: return "вручную";
                    case 4: return "отключена";
                }
                return "";
            }
            catch
            {
                return "";
            }

        }

        private void GetInfoAboutSelectedService()
        {
            try
            {
                var wmiService = new ManagementObject("Win32_Service.Name='" + GetName() + "'");
                wmiService.Get();
                if (string.IsNullOrEmpty((string)wmiService["Description"]))
                    ServiceInfoLb.Text = "Не удалось получить информацию о службе " + ServiceBox.SelectedItem;
                else
                    ServiceInfoLb.Text = (string)wmiService["Description"];
                if (ServiceInfoLb.Height > Height)
                {
                    ServiceInfoLb.Text = "Слишком длинное описание службы, кликните по тексту для доп. информации";
                }
            }
            catch
            {
                ServiceInfoLb.Text = "Не удалось получить информацию о службе " + ServiceBox.SelectedItem;
            }
        }

        #endregion

        #endregion

        #region Работа с listBox

        #region Расчёт высоты

        private void ServiceBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics
                .MeasureString(ServiceBox.Items[e.Index].ToString(), ServiceBox.Font, ServiceBox.Width).Height + 3;
        }

        #endregion

        #region Отрисовка элементов

        private void ServiceBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (ServiceBox.Items.Count <= 0) return;
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(ServiceBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds);
            }
            catch
            {

            }
        }

        #endregion

        #endregion

        #region Работа с службами

        private void ServiceSettings(int typeOfRun, string line)
        {
            if (ServiceBox.SelectedIndex == -1) return;
            try
            {
                RegistryKey regkey = Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\" + ServiceBox.SelectedItem.ToString().Split('/')[0].Trim());
                regkey.SetValue("Start", typeOfRun, RegistryValueKind.DWord);
                regkey.Close();
                Notify.ShowNotify($"Для службы {ServiceBox.SelectedItem.ToString().Split('/')[0].Trim()} установлен тип запуска: {line}", Resources.Information);
                string value = ServiceBox.SelectedItem.ToString();
                ServiceBox.Items[ServiceBox.Items.IndexOf(ServiceBox.SelectedItem)] = value.Replace(value.Split('/')[2], $" Тип запуска: {line}");
                ServiceList[ServiceList.IndexOf(value)] = value.Replace(value.Split('/')[2], $" Тип запуска: {line}");
                Logger.Log(Environment.NewLine + DateTime.Now + " || Для службы "
                    + ServiceBox.SelectedItem.ToString().Split('/')[0].Trim() + $" установлен тип запуска: {line}" + Environment.NewLine);
            }
            catch
            {
                Notify.ShowNotify("Не удалось применить настройку к службе", Resources.Information);
            }
        }

        private void AutoMenuItem_Click(object sender, EventArgs e)
        {
            ServiceSettings(2, "автоматический");
        }

        private void AutoDelayedMenuItem_Click(object sender, EventArgs e)
        {
            ServiceSettings(1, "автоматический (отложенный запуск)");
        }

        private void ManualMenuItem_Click(object sender, EventArgs e)
        {
            ServiceSettings(3, "вручную");
        }

        private void OffMenuItem_Click(object sender, EventArgs e)
        {
            ServiceSettings(4, "отключена");
        }

        private void OpenServicesMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Services.msc");
        }

        private void RunMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex == -1) return;

            var service = RunningServices[ServiceList.IndexOf((string)ServiceBox.SelectedItem)];
            try
            {
                if (service.Status == ServiceControllerStatus.Running)
                {
                    Notify.ShowNotify("Служба " + GetName() + " уже запущена ", Resources.Information);
                }
                else
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
                    Notify.ShowNotify("Служба " + GetName() + " запущена ", Resources.Information);
                }
            }
            catch
            {
                Notify.ShowNotify("Не удалось запустить службу " + GetName(), Resources.Information);
            }
        }

        private void StopMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex == -1) return;

            var service = RunningServices[ServiceList.IndexOf((string)ServiceBox.SelectedItem)];
            try
            {
                if (service.CanStop)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1));
                    Notify.ShowNotify("Служба " + GetName() + " остановлена", Resources.Information);
                }
                else
                {
                    Notify.ShowNotify("Не удалось остановить службу " + GetName(), Resources.Information);
                }
            }
            catch
            {
                Notify.ShowNotify("Не удалось остановить службу " + GetName(), Resources.Information);
            }
        }

        private void RestartMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex == -1) return;

            var service = RunningServices[ServiceList.IndexOf((string)ServiceBox.SelectedItem)];
            try
            {
                if (service.Status != ServiceControllerStatus.Stopped && service.CanStop)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1));
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
                    Notify.ShowNotify("Служба " + GetName() + " перезапущена", Resources.Information);
                }
                else if (service.Status == ServiceControllerStatus.Stopped)
                {
                    Notify.ShowNotify("Служба " + GetName() + " не запущена", Resources.Information);
                }
                else
                {
                    Notify.ShowNotify("Не удалось перезапустить службу " + GetName(), Resources.Information);
                }
            }
            catch
            {
                Notify.ShowNotify("Не удалось перезапустить службу " + GetName(), Resources.Information);
            }
        }

        #endregion

    }
}