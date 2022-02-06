using DevIdent.Classes;
using DevIdent.Properties;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class AutorunForm : Form
    {
        public AutorunForm(MainForm owner)
        {

            Owner = owner;
            InitializeComponent();
            FormSettings();
            CloseBth.Click += (s, e) => { Close(); };
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
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Windows\System32\Tasks")
            {
                EnableRaisingEvents = true,
                SynchronizingObject = this
            };
            watcher.Changed += Watcher_Changed;
            watcher.Created += Watcher_Changed;
            watcher.Deleted += Watcher_Changed;
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            new Thread(() =>
            {
                System.Action action = () =>
                {
                    AutorunList.Items.Clear();
                    GetProgramsFromSchedul();
                    GetProgramsFromRegistry();
                };
                if (InvokeRequired)
                    Invoke(action);
                else action();
            }).Start();
        }

        #region Перемещение формы

        private void AutorunForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion

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

        public void FormSettings()
        {
            try
            {
                Opacity = Settings.Default.Opacity;
            }
            catch
            {
            }

            BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            foreach (var picture in Controls.OfType<PictureBox>())
                picture.ChangeColor(Settings.Default.ColorButtonsDefault.Replace("#", string.Empty));
            foreach (ToolStripMenuItem item in MenuStrip.Items)
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            AutorunList.BackColor =
                ColorTranslator.FromHtml("#" + Settings.Default.ColorMenu.Replace("#", string.Empty));
        }

        private void GetProgramsFromSchedul()
        {
            var tf = TaskService.Instance.RootFolder;
            foreach (var t in tf.Tasks)
                try
                {
                    var item = new ListViewItem(t.Name);
                    item.SubItems.Add("C:\\Windows\\System32\\Tasks");
                    item.SubItems.Add(t.Enabled ? "Да" : "Нет");
                    AutorunList.Items.Add(item);
                }
                catch
                {
                }
        }

        private void GetProgramsFromRegistry()
        {
            RegistryHive[] hives = { RegistryHive.LocalMachine, RegistryHive.CurrentUser };
            string[] autorunKeys =
            {
                @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run",
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                 @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Run\Disabled",
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\Disabled"
            };

            foreach (var hive in hives)
            {
                using (var baseKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
                {
                    try
                    {
                        foreach (var keyName in autorunKeys)
                        {
                            using (var key = baseKey.OpenSubKey(keyName))
                            {
                                if (key != null)
                                {
                                    foreach (var valueName in key.GetValueNames())
                                    {
                                        var item = new ListViewItem(valueName);
                                        item.SubItems.Add(key.ToString());
                                        if (keyName.ToString().EndsWith("Disabled"))
                                        {
                                            item.SubItems.Add("Нет");
                                        }
                                        else
                                        {
                                            item.SubItems.Add("Да");
                                        }
                                        AutorunList.Items.Add(item);
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void AutorunForm_Load(object sender, EventArgs e)
        {
            GetProgramsFromSchedul();
            GetProgramsFromRegistry();
        }

        public void OpenExplorer(string path)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer",
                Arguments = "/n, /select, " + path
            });
        }

        private void PathItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AutorunList.SelectedIndices.Count == 0) return;
                var path = AutorunList.SelectedItems[0].SubItems[0].Text;
                switch (AutorunList.SelectedItems[0].SubItems[1].Text)
                {
                    case "C:\\Windows\\System32\\Tasks":
                        OpenExplorer(AutorunList.SelectedItems[0].SubItems[1].Text + "\\" + path);
                        break;
                    default:
                        foreach (var process in Process.GetProcessesByName("regedit")) process.Kill();
                        Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Applets\Regedit")
                            .SetValue("LastKey", AutorunList.SelectedItems[0].SubItems[1].Text);
                        Process.Start("regedit");
                        break;
                }
            }
            catch
            {
                Notify.ShowNotify("Путь не найден", Resources.Information);
            }
        }

        #region Отключить и включить в реестре

        private void EnableInRegistry(string registryPath, string name)
        {
            string path = registryPath;
            if (path.Split('\\')[0] == "HKEY_CURRENT_USER")
            {
                if (Registry.CurrentUser.OpenSubKey(path.Replace("HKEY_CURRENT_USER\\", string.Empty).Replace("\\Disabled", string.Empty)).GetValue(name) != null)
                {
                    string value = Registry.CurrentUser.OpenSubKey(path.Replace("HKEY_CURRENT_USER\\", string.Empty))
                        .GetValue(name).ToString();
                    Registry.CurrentUser.CreateSubKey(path.Replace("HKEY_CURRENT_USER\\", string.Empty) + "\\Disabled")
                        .SetValue(name, value);
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(path.Replace("HKEY_CURRENT_USER\\", string.Empty), true))
                    {
                        key.DeleteValue(name);
                    }
                    AutorunList.SelectedItems[0].SubItems[1].Text = path + "\\Disabled";
                    AutorunList.SelectedItems[0].SubItems[2].Text = "Нет";
                }
                else
                {
                    string value = Registry.CurrentUser.OpenSubKey(path.Replace("HKEY_CURRENT_USER\\", string.Empty)).GetValue(name).ToString();
                    Registry.CurrentUser.CreateSubKey(path.Replace("HKEY_CURRENT_USER\\", string.Empty).Replace("\\Disabled", string.Empty)).SetValue(name, value);
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(path.Replace("HKEY_CURRENT_USER\\", string.Empty), true))
                    {
                        key.DeleteValue(name);
                    }
                    AutorunList.SelectedItems[0].SubItems[1].Text = path.Replace("\\Disabled", string.Empty);
                    AutorunList.SelectedItems[0].SubItems[2].Text = "Да";
                }
            }
            else
            {
                if (Registry.LocalMachine.OpenSubKey(path.Replace("HKEY_LOCAL_MACHINE\\", string.Empty).Replace("\\Disabled", string.Empty)).GetValue(name) != null)
                {
                    string value = Registry.LocalMachine.OpenSubKey(path.Replace("HKEY_LOCAL_MACHINE\\", string.Empty))
                        .GetValue(name).ToString();
                    Registry.LocalMachine.CreateSubKey(path.Replace("HKEY_LOCAL_MACHINE\\", string.Empty) + "\\Disabled")
                        .SetValue(name, value);
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path.Replace("HKEY_LOCAL_MACHINE\\", string.Empty), true))
                    {
                        key.DeleteValue(name);
                    }
                    AutorunList.SelectedItems[0].SubItems[1].Text = path + "\\Disabled";
                    AutorunList.SelectedItems[0].SubItems[2].Text = "Нет";
                }
                else
                {
                    string value = Registry.LocalMachine.OpenSubKey(path.Replace("HKEY_LOCAL_MACHINE\\", string.Empty)).GetValue(name).ToString();
                    Registry.LocalMachine.CreateSubKey(path.Replace("HKEY_LOCAL_MACHINE\\", string.Empty).Replace("\\Disabled", string.Empty)).SetValue(name, value);
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path.Replace("HKEY_LOCAL_MACHINE\\", string.Empty), true))
                    {
                        key.DeleteValue(name);
                    }
                    AutorunList.SelectedItems[0].SubItems[1].Text = path.Replace("\\Disabled", string.Empty);
                    AutorunList.SelectedItems[0].SubItems[2].Text = "Да";
                }
            }
        }

        #endregion

        private void EnableDisableItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AutorunList.SelectedIndices.Count == 0) return;
                if (AutorunList.SelectedItems[0].SubItems[1].Text == "C:\\Windows\\System32\\Tasks")
                {
                    var tf = TaskService.Instance.RootFolder;
                    tf.Tasks[AutorunList.SelectedIndices[0]].Enabled = !tf.Tasks[AutorunList.SelectedIndices[0]].Enabled;
                    AutorunList.SelectedItems[0].SubItems[2].Text = tf.Tasks[AutorunList.SelectedIndices[0]].Enabled ? "Да" : "Нет";
                }
                else
                {
                    EnableInRegistry(AutorunList.SelectedItems[0].SubItems[1].Text, AutorunList.SelectedItems[0].SubItems[0].Text);
                }
                Logger.Log(Environment.NewLine + DateTime.Now + " || Программа " + AutorunList.SelectedItems[0].Text + (AutorunList.SelectedItems[0].SubItems[2].Text == "Да" ? " добавлена в автозапуск " : " удалена из автозапуска") + Environment.NewLine);

            }
            catch
            {
                Notify.ShowNotify("Не удалось отключить программу", Resources.Information);
            }
        }
    }
}