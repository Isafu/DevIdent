using DevIdent.Classes;
using DevIdent.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class ServicesForm : Form
    {
        #region Поиск

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            ServiceBox.Items.Clear();
            ServiceBox.Items.AddRange(serviceList.Where(item => item.ToLower().Contains(SearchBox.Text.ToLower())).ToArray());
        }

        #endregion

        #region Форма

        public void FormSettings()
        {
            ContentPanel.BackColor = Settings.Default.ColorContent;
            MenuPanel.BackColor = Settings.Default.ColorMenu;
            BackColor = Settings.Default.ColorForm;
            foreach (PictureBox button in this.Controls.OfType<PictureBox>())
            {
                button.ChangeColor(Settings.Default.ColorButtonsDefault);
            }
            ServiceBox.BackColor = Settings.Default.ColorContent;
            foreach (ToolStripMenuItem item in MenuStrip.Items)
            {
                item.BackColor = Settings.Default.ColorForm;
            }
            foreach (ToolStripMenuItem item in WorkWithServicesMenuItem.DropDownItems)
            {
                item.BackColor = Settings.Default.ColorForm;
            }
        }

        public ServicesForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
            Width = 500;
            ServiceBox.DoubleClick += (s, e) => Width = 500;
            MenuPanel.Click += (s, e) => Width = 500;
            SearchBox.DoubleClick += (s, e) => SearchBox.Text = "";

            foreach (PictureBox picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) => { picture.BackColor = Settings.Default.ColorButtonsHover; };
                picture.MouseLeave += (s, e) => { picture.BackColor = Settings.Default.ColorButtonsDefault; };
            }

            ServiceBox.Click += (s, e) =>
            {
                GetInfoAboutSelectedService();
                Width = 800;
            };
            FormSettings();
        }

        #region Перемещение формы

        private void ServicesForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
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

        private static readonly ServiceController[] RunningServices = ServiceController.GetServices();
        private static readonly List<string> serviceList = new List<string>();

        private void GetActiveServices()
        {
            foreach (ServiceController service in RunningServices)
            {
                try
                {
                    ServiceBox.Items.Add(service.ServiceName + " / " + service.DisplayName);
                    serviceList.Add(service.ServiceName + " / " + service.DisplayName);
                }
                catch
                {
                }
            }
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

        private void GetInfoAboutSelectedService()
        {
            try
            {
                ManagementObject wmiService = new ManagementObject("Win32_Service.Name='"
                                                      + GetName() + "'");
                wmiService.Get();
                if (string.IsNullOrEmpty((string)wmiService["Description"]))
                {
                    ServiceInfoLb.Text = "Не удалось получить информацию о службе " + ServiceBox.SelectedItem;
                }
                else
                {
                    ServiceInfoLb.Text = (string)wmiService["Description"];
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

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics
                .MeasureString(ServiceBox.Items[e.Index].ToString(), ServiceBox.Font, ServiceBox.Width).Height;
        }

        #endregion

        #region Отрисовка элементов

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (ServiceBox.Items.Count <= 0)
            {
                return;
            }

            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(ServiceBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor),
                e.Bounds);
        }

        #endregion

        #endregion

        #region Работа с службами

        private void OpenServicesMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Services.msc");
        }

        private void запуситьСлужбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex == -1)
            {
                return;
            }

            ServiceController service = RunningServices[serviceList.IndexOf((string)ServiceBox.SelectedItem)];
            try
            {
                if (service.Status == ServiceControllerStatus.Running)
                {
                    Notify.ShowNotify("Служба " + GetName() + " уже запущена ", Resources.Close);
                }
                else
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
                    Notify.ShowNotify("Служба " + GetName() + " запущена ", Resources.Close);
                }
            }
            catch
            {
                Notify.ShowNotify("Не удалось запустить службу " + GetName(), Resources.Close);
            }
        }

        private void остановитьСлужбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex == -1)
            {
                return;
            }

            ServiceController service = RunningServices[serviceList.IndexOf((string)ServiceBox.SelectedItem)];
            try
            {
                if (service.CanStop)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1));
                    Notify.ShowNotify("Служба " + GetName() + " остановлена", Resources.Close);
                }
                else
                {
                    Notify.ShowNotify("Не удалось остановить службу " + GetName(), Resources.Close);
                }
            }
            catch
            {
                Notify.ShowNotify("Не удалось остановить службу " + GetName(), Resources.Close);
            }
        }

        private void приостановитьСлужбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex == -1)
            {
                return;
            }

            ServiceController service = RunningServices[serviceList.IndexOf((string)ServiceBox.SelectedItem)];
            try
            {
                if (service.CanPauseAndContinue)
                {
                    service.Pause();
                    service.WaitForStatus(ServiceControllerStatus.Paused, TimeSpan.FromMinutes(1));
                    Notify.ShowNotify("Служба " + GetName() + " на паузе", Resources.Close);
                }
                else
                {
                    Notify.ShowNotify("Не удалось приостановить службу " + GetName(), Resources.Close);
                }
            }
            catch
            {
                Notify.ShowNotify("Не удалось приостановить службу " + GetName(), Resources.Close);
            }
        }

        private void перезапуститьСлужбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex == -1)
            {
                return;
            }

            ServiceController service = RunningServices[serviceList.IndexOf((string)ServiceBox.SelectedItem)];
            try
            {
                if (service.Status != ServiceControllerStatus.Stopped && service.CanStop)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(1));
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(1));
                    Notify.ShowNotify("Служба " + GetName() + " перезапущена", Resources.Close);
                }
                else if (service.Status == ServiceControllerStatus.Stopped)
                {
                    Notify.ShowNotify("Служба " + GetName() + " не запущена", Resources.Close);
                }
                else
                {
                    Notify.ShowNotify("Не удалось перезапустить службу " + GetName(), Resources.Close);
                }
            }
            catch
            {
                Notify.ShowNotify("Не удалось перезапустить службу " + GetName(), Resources.Close);
            }
        }

        #endregion
    }
}