using DevIdent.Classes;
using DevIdent.Properties;
using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using System;
using System.Diagnostics;
using System.Linq;
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
            foreach (PictureBox picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) => { picture.BackColor = Settings.Default.ColorButtonsHover; };
                picture.MouseLeave += (s, e) => { picture.BackColor = Settings.Default.ColorButtonsDefault; };
            }
        }

        #region Перемещение формы

        private void AutorunForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion

        public void FormSettings()
        {
            BackColor = Settings.Default.ColorForm;
            foreach (PictureBox picture in Controls.OfType<PictureBox>())
            {
                picture.ChangeColor(Settings.Default.ColorButtonsDefault);
            }
            foreach (ToolStripMenuItem item in MenuStrip.Items)
            {
                item.BackColor = Settings.Default.ColorForm;
            }
            AutorunList.BackColor = Settings.Default.ColorContent;
        }

        private void GetProgramsFromSchedul()
        {
            TaskFolder tf = TaskService.Instance.RootFolder;
            foreach (Task t in tf.Tasks)
            {
                try
                {
                    ListViewItem item = new ListViewItem(t.Name);
                    item.SubItems.Add("C:\\Windows\\System32\\Tasks");
                    item.SubItems.Add(t.Enabled ? "Да" : "Нет");
                    AutorunList.Items.Add(item);
                }
                catch { }
            }
        }

        private void GetProgramsFromRegistry()
        {
            RegistryHive[] hives = { RegistryHive.LocalMachine, RegistryHive.CurrentUser };
            string[] autorunKeys = { @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run" };

            foreach (var hive in hives)
            {
                using (var baseKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64))
                {
                    foreach (var keyName in autorunKeys)
                    {
                        using (var key = baseKey.OpenSubKey(keyName))
                        {
                            if (key != null)
                            {
                                foreach (var valueName in key.GetValueNames())
                                {
                                    ListViewItem item = new ListViewItem(valueName);
                                    item.SubItems.Add(key.GetValue(valueName).ToString());
                                    AutorunList.Items.Add(item);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void AutorunForm_Load(object sender, EventArgs e)
        {
            GetProgramsFromSchedul();
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
                string path = AutorunList.SelectedItems[0].SubItems[0].Text;
                switch (AutorunList.SelectedItems[0].SubItems[1].Text)
                {
                    case "C:\\Windows\\System32\\Tasks":
                        OpenExplorer(AutorunList.SelectedItems[0].SubItems[1].Text + "\\" + path);
                        break;
                    default:
                        if (path.Contains('-'))
                        {
                            OpenExplorer(path.Remove(path.IndexOf('-')));
                        }
                        else if (path.Contains('/'))
                        {
                            OpenExplorer(path.Remove(path.IndexOf('/')));
                        }
                        else
                        {
                            OpenExplorer(path);
                        }

                        break;
                }
            }
            catch (Exception ex)
            {
                Notify.ShowNotify(ex.Message, Resources.Close);
            }
        }

        private void EnableDisableItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AutorunList.SelectedIndices.Count == 0) return;
                TaskFolder tf = TaskService.Instance.RootFolder;
                tf.Tasks[AutorunList.SelectedIndices[0]].Enabled = !tf.Tasks[AutorunList.SelectedIndices[0]].Enabled;
                if (tf.Tasks[AutorunList.SelectedIndices[0]].Enabled)
                {
                    AutorunList.SelectedItems[0].SubItems[2].Text = "Да";
                }
                else
                {
                    AutorunList.SelectedItems[0].SubItems[2].Text = "Нет";
                }
            }
            catch (Exception ex)
            {
                Notify.ShowNotify(ex.Message, Resources.Close);
            }
        }
    }
}
