using DevIdent.Classes;
using DevIdent.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class UninstallForm : Form
    {

        #region Переменные

        private readonly List<string> _registyPathes = new List<string>();
        private readonly List<string> _searchPathes = new List<string>();
        private static readonly RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
        private RegistryKey _pathToProgramm;

        #endregion

        #region Получение пути к реестру 32 / 64 битности

        private static string GetPathByDepth()
        {
            return registryView == RegistryView.Registry64
                ? @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
                : @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        }

        #endregion

        #region Извлечение путей к деинсталлятору из реестра

        private void GetInstalledProgramms(RegistryHive registryHive, string registryPath)
        {
            try
            {
                _pathToProgramm = RegistryKey.OpenBaseKey(registryHive, registryView).OpenSubKey(registryPath);
                foreach (string keyName in _pathToProgramm.GetSubKeyNames())
                {
                    RegistryKey subkey = _pathToProgramm.OpenSubKey(keyName);
                    string displayName = (string)subkey.GetValue("DisplayName");
                    if (string.IsNullOrEmpty((string)subkey.GetValue("DisplayName"))) continue;
                    if (string.IsNullOrEmpty((string)subkey.GetValue("UninstallString")))
                    {
                        if (string.IsNullOrEmpty((string)subkey.GetValue("InstallLocation")) &&
                            !Directory.Exists((string)subkey.GetValue("InstallLocation"))) continue;
                        if (!UninstallBox.Items.Contains(displayName))
                        {
                            _registyPathes.Add(subkey.Name);
                            UninstallBox.Items.Add("Приложение без деинсталлятора " + displayName);
                            _searchPathes.Add("Приложение без деинсталлятора " + displayName);
                        }
                    }
                    else
                    {
                        _registyPathes.Add(subkey.Name);
                        UninstallBox.Items.Add(displayName);
                        _searchPathes.Add(displayName);
                    }
                }
            }
            catch (Exception ex)
            {
                Notify.ShowNotify(ex.Message, Resources.Close);
            }
        }


        #endregion

        #region Получение программ по битности

        private void GetInstalledProgramms()
        {
            GetInstalledProgramms(RegistryHive.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            GetInstalledProgramms(RegistryHive.LocalMachine, @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            GetInstalledProgramms(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
        }

        #endregion

        #region Размер файлов

        private string FileSize(int index)
        {
            if (Registry.GetValue(_registyPathes[index], "InstallLocation", "NULL").ToString() == "NULL" ||
                !Directory.Exists(Registry.GetValue(_registyPathes[index], "InstallLocation", "NULL").ToString()))
            {
                if (!Registry.GetValue(_registyPathes[index], "UninstallString", "").ToString().StartsWith("MsiExec.exe"))
                {
                    string path = Registry.GetValue(_registyPathes[index], "UninstallString", "").ToString();
                    path = path.Remove(path.LastIndexOf("\\"));
                    if (!Directory.Exists(path)) return "";
                    else
                    {
                        IEnumerable<FileInfo> fullfilesPath = new DirectoryInfo(path).EnumerateFiles("*.*", SearchOption.AllDirectories);
                        long size = 0;
                        try
                        {
                            size += fullfilesPath.Sum(fi => fi.Length);
                            return "(Примерный размер: " + size / 1048576 + " MB)";
                        }
                        catch
                        {
                            return "";
                        }
                    }
                }
                else return "";
            }
            else
            {
                IEnumerable<FileInfo> fullfilesPath = new DirectoryInfo(Registry.GetValue(_registyPathes[index],
                    "InstallLocation", "").ToString()).EnumerateFiles("*.*", SearchOption.AllDirectories);
                long size = 0;
                try
                {
                    size += fullfilesPath.Sum(fi => fi.Length);
                    return "(Примерный размер: " + size / 1048576 + " MB)";
                }
                catch
                {
                    return "";
                }
            }
        }

        #endregion

        #region Форма

        public void FormSettings()
        {
            ContentPanel.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorContent.Name);
            BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Name);
            foreach (PictureBox button in this.Controls.OfType<PictureBox>())
            {
                button.ChangeColor(ColorTranslator.FromHtml("#" + Settings.Default.ColorButtonsDefault.Name));
            }
            UninstallBox.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorContent.Name);
            foreach (ToolStripMenuItem item in MenuStrip.Items)
            {
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Name);
            }
            foreach (ToolStripMenuItem item in CreateInfoFileToolStripMenuItem.DropDownItems)
            {
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Name);
            }
        }

        public UninstallForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
            Click += (s, e) => { BringToFront(); };
            DoubleClick += (s, e) => { CenterToScreen(); };
            foreach (PictureBox picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) => { picture.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorButtonsHover.Name); };
                picture.MouseLeave += (s, e) => { picture.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorButtonsDefault.Name); };
            }
            FormSettings();
        }

        #region Закрытие Формы

        private void CloseBth_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Запуск формы

        private void UninstallForm_Load(object sender, EventArgs e)
        {
            GetInstalledProgramms();
        }

        #endregion

        #region Перемещение формы

        private void UninstallForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion

        #endregion

        #region Работа с ListBox

        #region Рассчет высоты ListBox

        private void UninstallBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics
                .MeasureString(UninstallBox.Items[e.Index].ToString(), UninstallBox.Font, UninstallBox.Width).Height;
        }

        #endregion

        #region Отрисовка элементов

        private void UninstallBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (UninstallBox.Items.Count <= 0)
            {
                return;
            }

            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(UninstallBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor),
                e.Bounds);
        }

        #endregion

        #endregion

        #region Удаление данных о приложении из реестра

        #region Получение RegistryHive

        private RegistryHive GetHive(int index)
        {
            string[] hive = _registyPathes[index].Split('\\');
            return hive[0] == "HKEY_CURRENT_USER" ? RegistryHive.CurrentUser : RegistryHive.LocalMachine;
        }

        #endregion

        #region Получение ProgrammName

        private string GetProgrammName(int index)
        {
            string[] subKey = _registyPathes[index].Split('\\');
            return subKey[subKey.Length - 1];
        }

        #endregion

        #endregion

        #region Удаление программы

        private static void DeleteProgrammByHiddenUninstall(string hiddenUninstallPath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + hiddenUninstallPath,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.EnableRaisingEvents = true;
            process.Start();
            process.WaitForExit();
        }

        private void DeleteProgrammByUninstallString(string path, int index)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                int indexOfExe = path.IndexOf(".exe");
                if (indexOfExe > 0 && path.Contains('-') || path.Contains('/'))
                {
                    path = path.Replace(@"""", string.Empty);
                    string uninstallerPath = path.Substring(0, indexOfExe + 4);
                    startInfo.FileName = uninstallerPath;
                    if (uninstallerPath.Length != path.Length)
                    {
                        string args = path.Substring(uninstallerPath.Length);
                        if (!string.IsNullOrEmpty(args))
                        {
                            startInfo.UseShellExecute = false;
                            startInfo.Arguments = args;
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        }
                    }
                }
                else
                {
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/c " + path;
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                }
                Process process = new Process
                {
                    StartInfo = startInfo
                };
                process.EnableRaisingEvents = true;
                process.Start();
                process.WaitForExit();
                if (process.ExitCode == 1614 && process.HasExited)
                {
                    RemoveFromListAndRegistry(index);
                }
            }
            catch (Exception ex)
            {
                Notify.ShowNotify(ex.Message, Resources.Close);
            }
        }

        #region Удаление инфы из реестра

        private RegistryKey _key;

        private void DeleteInfoFromRegistry(int index)
        {
            string[] hive = _registyPathes[index].Split('\\');
            _key = RegistryKey.OpenBaseKey(GetHive(index), registryView);

            if (RegistryKey.OpenBaseKey(GetHive(index), RegistryView.Registry32)
                .OpenSubKey(GetPathByDepth() + @"\" + hive[hive.Length - 1]) == null)
            {
                try
                {
                    _key.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall" + @"\" +
                                      GetProgrammName(index));
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    _key.DeleteSubKey(GetPathByDepth() + @"\" + GetProgrammName(index));
                }
                catch
                {
                }
            }
        }

        #endregion

        private void RemoveFromListAndRegistry(int indexOfProgramm)
        {
            DeleteInfoFromRegistry(indexOfProgramm);
            UninstallBox.Items.RemoveAt(UninstallBox.SelectedIndex);
            _registyPathes.RemoveAt(indexOfProgramm);
            _searchPathes.RemoveAt(indexOfProgramm);
        }

        private void Uninstall(int index)
        {
            if (Registry.GetValue(_registyPathes[index], "UninstallString", "NULL").ToString() != "NULL")
            {
                DeleteProgrammByUninstallString(Registry.GetValue(_registyPathes[index], "UninstallString", "").ToString(), index);
                return;
            }
            if (Registry.GetValue(_registyPathes[index], "InstallSource", "NULL").ToString() != "NULL")
            {
                UniversalCleaner.DirectoryCleanerWithoutSize(new DirectoryInfo(Registry.GetValue(_registyPathes[index], "InstallSource", "").ToString()));
                RemoveFromListAndRegistry(index);
                return;
            }
            if (Registry.GetValue(_registyPathes[index], "UninstallString_Hidden", "NULL").ToString() != "NULL")
            {
                DeleteProgrammByHiddenUninstall(Registry.GetValue(_registyPathes[index], "UninstallString_Hidden", "").ToString());
                RemoveFromListAndRegistry(index);
                return;
            }
            if (Registry.GetValue(_registyPathes[index], "InstallLocation", "NULL").ToString() != "NULL")
            {
                UniversalCleaner.DirectoryCleanerWithoutSize(new DirectoryInfo(Registry.GetValue(_registyPathes[index], "InstallLocation", "").ToString()));
                RemoveFromListAndRegistry(index);
            }
        }

        #endregion

        #region Работа в Menu

        #region Создание txt файла

        private void CreateTxtFile(object sender, DoWorkEventArgs e)
        {
            File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.txt")).Close();
            using (StreamWriter myWriter = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.txt")))
            {
                myWriter.WriteLine("   Список установленных программ:" + Environment.NewLine);
                for (int i = 0; i < UninstallBox.Items.Count - 1; i++)
                {
                    myWriter.WriteLine("-- " + UninstallBox.Items[i] + " " + FileSize(i));
                }
            }
        }

        private void TxtFileCreated(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify("Файл создан на рабочем столе", Resources.Close);
        }

        private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundWorker _txtWorker = new BackgroundWorker();
            _txtWorker.DoWork += CreateTxtFile;
            _txtWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(TxtFileCreated);
            _txtWorker.RunWorkerAsync();
            Notify.ShowNotify("Начало создания файла", Resources.Close);
        }


        #endregion

        #region Создание html файла

        private void CreateHTMLFile(object sender, DoWorkEventArgs e)
        {
            File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                        "\\Установленное ПО.html").Close();
            using (StreamWriter myWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.html"))
            {
                myWriter.WriteLine("<h1>Список установленных программ:</h1>");
                for (int i = 0; i < UninstallBox.Items.Count - 1; i++)
                {
                    myWriter.Write("<p>-- " + UninstallBox.Items[i] + " " + FileSize(i) + "</p>");
                }
            }
        }

        private void HTMLFileCreated(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify("Файл создан на рабочем столе", Resources.Close);
        }

        private void HTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundWorker _htmlWorker = new BackgroundWorker();
            _htmlWorker.DoWork += CreateHTMLFile;
            _htmlWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(HTMLFileCreated);
            _htmlWorker.RunWorkerAsync();
            Notify.ShowNotify("Начало создания файла", Resources.Close);
        }

        #endregion

        #region Удаление из реестра

        private void удалитьИзРеестраStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            RemoveFromListAndRegistry(_searchPathes.IndexOf((string)UninstallBox.SelectedItem));
        }

        #endregion

        #region Нажатие на Удалить

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            Uninstall(_searchPathes.IndexOf((string)UninstallBox.SelectedItem));
        }

        #endregion

        #region Показать запись в реестре

        private void записьВРеестреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            foreach (Process process in Process.GetProcessesByName("regedit"))
            {
                process.Kill();
            }
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Applets\Regedit")
                .SetValue("LastKey", _registyPathes[_searchPathes.IndexOf((string)UninstallBox.SelectedItem)]);
            Process.Start("regedit");
        }

        #endregion

        #region Открытие проводника

        private void расположениеНаДискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            try
            {
                int programm = _searchPathes.IndexOf((string)UninstallBox.SelectedItem);
                if (Registry.GetValue(_registyPathes[programm], "InstallLocation", "NULL").ToString() == "NULL"
                    || !Directory.Exists(Registry.GetValue(_registyPathes[programm], "InstallLocation", "NULL").ToString()))
                {
                    if (Registry.GetValue(_registyPathes[programm], "UninstallString", "NULL").ToString() != "NULL"
                        && !Registry.GetValue(_registyPathes[programm], "UninstallString", "NULL").ToString().StartsWith("MsiExec.exe"))
                    {
                        string path = Registry.GetValue(_registyPathes[programm], "UninstallString", "").ToString();
                        path = path.Remove(path.LastIndexOf("\\"));
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "explorer",
                            Arguments = "/n, " + path
                        });
                    }
                    else
                    {
                        Notify.ShowNotify("Путь к программе не найден :(", Resources.Close);
                    }
                }
                else
                {
                    Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = "/n, " + Registry.GetValue(_registyPathes[programm], "InstallLocation", "") });
                }
            }
            catch (Exception ex)
            {
                Notify.ShowNotify(ex.Message, Resources.Close);
            }
        }

        #endregion

        #region Поиск в браузере

        private void чтоЭтоЗаПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1)
            {
                return;
            }
            Process.Start(@"https://www.google.com/search?q=" +
                _searchPathes[_searchPathes.IndexOf((string)UninstallBox.SelectedItem)].Replace("Приложение без деинсталлятора ", string.Empty) + " что это?");
        }

        #endregion

        #region Поиск

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            UninstallBox.Items.Clear();
            UninstallBox.Items.AddRange(_searchPathes.Where(item => item.ToLower().Contains(SearchBox.Text.ToLower())).ToArray());
        }

        #endregion

        #endregion
    }
}