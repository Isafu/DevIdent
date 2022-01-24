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

        private static readonly RegistryView registryView =
            Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

        private RegistryKey _pathToProgramm;

        #endregion

        #region Получение RegistryHive

        private RegistryHive GetHive(int index)
        {
            var hive = _registyPathes[index].Split('\\');
            return hive[0] == "HKEY_CURRENT_USER" ? RegistryHive.CurrentUser : RegistryHive.LocalMachine;
        }

        #endregion

        #region Получение ProgrammName

        private string GetProgrammName(int index)
        {
            var subKey = _registyPathes[index].Split('\\');
            return subKey[subKey.Length - 1];
        }

        #endregion

        #region Получение пути к реестру 32 / 64 битности

        private static string GetPathByDepth()
        {
            return registryView == RegistryView.Registry64
                ? @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
                : @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        }

        #endregion

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            _registyPathes.Clear();
            _searchPathes.Clear();
            UninstallBox.Items.Clear();
            GetInstalledProgramms();
            SearchBox.Text = "";
        }

        #region Извлечение путей к деинсталлятору из реестра

        private void GetInstalledProgramms(RegistryHive registryHive, string registryPath)
        {
            try
            {
                _pathToProgramm = RegistryKey.OpenBaseKey(registryHive, registryView).OpenSubKey(registryPath);
                foreach (var keyName in _pathToProgramm.GetSubKeyNames())
                {
                    var subkey = _pathToProgramm.OpenSubKey(keyName);
                    var displayName = (string)subkey.GetValue("DisplayName");
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
            catch
            {
            }
        }

        #endregion

        #region Получение программ по битности

        private void GetInstalledProgramms()
        {
            GetInstalledProgramms(RegistryHive.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            GetInstalledProgramms(RegistryHive.LocalMachine,
                @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            GetInstalledProgramms(RegistryHive.LocalMachine, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
        }

        #endregion

        #region Размер файлов

        private string FileSize(int index)
        {
            if (Registry.GetValue(_registyPathes[index], "InstallLocation", "NULL").ToString() == "NULL" ||
                !Directory.Exists(Registry.GetValue(_registyPathes[index], "InstallLocation", "NULL").ToString()))
            {
                if (!Registry.GetValue(_registyPathes[index], "UninstallString", "").ToString()
                        .StartsWith("MsiExec.exe"))
                {
                    var path = Registry.GetValue(_registyPathes[index], "UninstallString", "").ToString();
                    path = path.Remove(path.LastIndexOf("\\"));
                    if (!Directory.Exists(path)) return "";

                    var fullfilesPath = new DirectoryInfo(path).EnumerateFiles("*.*", SearchOption.AllDirectories);
                    long size = 0;
                    try
                    {
                        size += fullfilesPath.Sum(fi => fi.Length);
                        if (size / 1048576 > 1) return "(Примерный размер: " + size / 1048576 + " MB)";
                        else return "(Примерный размер: < 1 MB)";
                    }
                    catch
                    {
                        return "";
                    }
                }

                return "";
            }

            {
                var fullfilesPath = new DirectoryInfo(Registry.GetValue(_registyPathes[index],
                    "InstallLocation", "").ToString()).EnumerateFiles("*.*", SearchOption.AllDirectories);
                long size = 0;
                try
                {
                    size += fullfilesPath.Sum(fi => fi.Length);
                    if (size / 1048576 > 1) return "(Примерный размер: " + size / 1048576 + " MB)";
                    else return "(Примерный размер: < 1 MB)";
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
            try
            {
                Opacity = Settings.Default.Opacity;
            }
            catch
            {
            }

            ContentPanel.ChangeColor(Settings.Default.ColorContent.Replace("#", string.Empty));
            this.ChangeColor(Settings.Default.ColorForm.Replace("#", string.Empty));
            foreach (var button in Controls.OfType<PictureBox>())
                button.ChangeColor(Settings.Default.ColorButtonsDefault.Replace("#", string.Empty));
            UninstallBox.ChangeColor(Settings.Default.ColorContent);
            foreach (ToolStripMenuItem item in MainMenu.Items)
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            foreach (ToolStripMenuItem item in CreateInfoFileToolStripMenuItem.DropDownItems)
                item.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
        }

        public UninstallForm(MainForm owner)
        {
            Owner = owner;
            InitializeComponent();
            Click += (s, e) => { BringToFront(); };
            DoubleClick += (s, e) => { CenterToScreen(); };
            foreach (var picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) => { picture.ChangeColor(Settings.Default.ColorButtonsHover); };
                picture.MouseLeave += (s, e) => { picture.ChangeColor(Settings.Default.ColorButtonsDefault); };
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
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion

        #endregion

        #region Работа с ListBox

        #region Рассчет высоты ListBox

        private void UninstallBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics
                .MeasureString(UninstallBox.Items[e.Index].ToString(), UninstallBox.Font, UninstallBox.Width).Height + 3;
        }

        #endregion

        #region Отрисовка элементов

        private void UninstallBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (UninstallBox.Items.Count <= 0) return;
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(UninstallBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds);
            }
            catch
            { }
        }

        #endregion

        #endregion

        #region Удаление программы

        private static void DeleteProgrammByHiddenUninstall(string hiddenUninstallPath)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + hiddenUninstallPath,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            var process = new Process
            {
                StartInfo = startInfo
            };
            process.EnableRaisingEvents = true;
            process.Start();
            process.WaitForExit();
        }

        private void DeleteProgrammByUninstallString(string path, int index, string item)
        {
            try
            {
                string uninstallerPath = "";
                var startInfo = new ProcessStartInfo();
                var indexOfExe = path.IndexOf(".exe");
                if (indexOfExe > 0 && path.Contains('-') || path.Contains('/'))
                {
                    path = path.Replace(@"""", string.Empty);
                    uninstallerPath = path.Substring(0, indexOfExe + 4);
                    startInfo.FileName = uninstallerPath;
                    if (uninstallerPath.Length != path.Length)
                    {
                        var args = path.Substring(uninstallerPath.Length);
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

                var process = new Process
                {
                    StartInfo = startInfo
                };
                process.EnableRaisingEvents = true;
                process.Start();
                process.WaitForExit();
                if (process.ExitCode == 1604)
                {
                    RemoveFromListAndRegistry(index);
                    LogDelete(item);
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
            var hive = _registyPathes[index].Split('\\');
            _key = RegistryKey.OpenBaseKey(GetHive(index), registryView);

            if (RegistryKey.OpenBaseKey(GetHive(index), RegistryView.Registry32)
                    .OpenSubKey(GetPathByDepth() + @"\" + hive[hive.Length - 1]) == null)
                try
                {
                    _key.DeleteSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall" + @"\" +
                                      GetProgrammName(index));
                }
                catch
                {
                }
            else
                try
                {
                    _key.DeleteSubKey(GetPathByDepth() + @"\" + GetProgrammName(index));
                }
                catch
                {
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

        private void LogDelete(string item)
        {
            if (!File.Exists(@"C:\DevLog.txt")) File.AppendAllText(@"C:\DevLog.txt", "Добро пожаловать " + Environment.NewLine);
            File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + DateTime.Now + " || Программа " + item + " удалена с компьютера" + Environment.NewLine);
            Notify.ShowNotify(item + " удалена с компьютера", Resources.Close);
        }

        private void Uninstall(int index)
        {
            var programm = (string)UninstallBox.SelectedItem;
            if (Registry.GetValue(_registyPathes[index], "UninstallString", "NULL").ToString() != "NULL")
            {
                DeleteProgrammByUninstallString(
                    Registry.GetValue(_registyPathes[index], "UninstallString", "").ToString(), index, programm);
                return;
            }

            if (Registry.GetValue(_registyPathes[index], "InstallSource", "NULL").ToString() != "NULL")
            {
                UniversalCleaner.DirectoryCleanerWithoutSize(
                    new DirectoryInfo(Registry.GetValue(_registyPathes[index], "InstallSource", "").ToString()));
                RemoveFromListAndRegistry(index);
                LogDelete(programm);
                return;
            }

            if (Registry.GetValue(_registyPathes[index], "UninstallString_Hidden", "NULL").ToString() != "NULL")
            {
                DeleteProgrammByHiddenUninstall(Registry.GetValue(_registyPathes[index], "UninstallString_Hidden", "")
                    .ToString());
                RemoveFromListAndRegistry(index);
                LogDelete(programm);
                return;
            }

            if (Registry.GetValue(_registyPathes[index], "InstallLocation", "NULL").ToString() != "NULL")
            {
                UniversalCleaner.DirectoryCleanerWithoutSize(
                    new DirectoryInfo(Registry.GetValue(_registyPathes[index], "InstallLocation", "").ToString()));
                LogDelete(programm);
                RemoveFromListAndRegistry(index);
            }
        }

        #endregion

        #region Работа в Menu

        #region Создание txt файла

        private void CreateTxtFile(object sender, DoWorkEventArgs e)
        {
            File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                     "\\Установленное ПО.txt")).Close();
            using (var myWriter =
                   new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                                 "\\Установленное ПО.txt")))
            {
                myWriter.WriteLine("   Список установленных программ:" + Environment.NewLine);
                for (var i = 0; i < UninstallBox.Items.Count - 1; i++)
                    myWriter.WriteLine("-- " + UninstallBox.Items[i] + " " + FileSize(i));
            }
        }

        private void TxtFileCreated(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify($"Файл \"Установленное ПО.txt\" создан на рабочем столе", Resources.Close);
        }

        private void TxtFileMenuItem_Click(object sender, EventArgs e)
        {
            var _txtWorker = new BackgroundWorker();
            _txtWorker.DoWork += CreateTxtFile;
            _txtWorker.RunWorkerCompleted += TxtFileCreated;
            _txtWorker.RunWorkerAsync();
            Notify.ShowNotify($"Начало создания \"Установленное ПО.txt\"", Resources.Close);
        }

        #endregion

        #region Создание html файла

        private void CreateHTMLFile(object sender, DoWorkEventArgs e)
        {
            File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                        "\\Установленное ПО.html").Close();
            using (var myWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                                   "\\Установленное ПО.html"))
            {
                myWriter.WriteLine("<h1>Список установленных программ:</h1>");
                for (var i = 0; i < UninstallBox.Items.Count - 1; i++)
                    myWriter.Write("<p>-- " + UninstallBox.Items[i] + " " + FileSize(i) + "</p>");
            }
        }

        private void HTMLFileCreated(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify($"Файл \"Установленное ПО.html\" создан на рабочем столе", Resources.Close);
        }

        private void HTMLMenuItem_Click(object sender, EventArgs e)
        {
            var _htmlWorker = new BackgroundWorker();
            _htmlWorker.DoWork += CreateHTMLFile;
            _htmlWorker.RunWorkerCompleted += HTMLFileCreated;
            _htmlWorker.RunWorkerAsync();
            Notify.ShowNotify($"Начало создания \"Установленное ПО.html\"", Resources.Close);
        }

        #endregion

        #region Удаление из реестра

        private void УдалитьИзРеестраStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            var item = (string)UninstallBox.SelectedItem;
            RemoveFromListAndRegistry(_searchPathes.IndexOf((string)UninstallBox.SelectedItem));
            if (!File.Exists(@"C:\DevLog.txt")) File.AppendAllText(@"C:\DevLog.txt", "Добро пожаловать " + Environment.NewLine);
            File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + DateTime.Now + " || " + item + " удалена из реестра" + Environment.NewLine);
            Notify.ShowNotify(item + " удалена из реестра", Resources.Close);
        }

        #endregion

        #region Нажатие на Удалить

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            var item = (string)UninstallBox.SelectedItem;
            Uninstall(_searchPathes.IndexOf(item));
            
        }

        #endregion

        #region Показать запись в реестре

        private void ЗаписьВРеестреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            try
            {
                foreach (var process in Process.GetProcessesByName("regedit")) process.Kill();
                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Applets\Regedit")
                    .SetValue("LastKey", _registyPathes[_searchPathes.IndexOf((string)UninstallBox.SelectedItem)]);
                Process.Start("regedit");
            }
            catch
            {
                Notify.ShowNotify("Путь в реестре не найден :(", Resources.Close);
            }
        }

        #endregion

        #region Открытие проводника

        private void РасположениеНаДискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            try
            {
                var programm = _searchPathes.IndexOf((string)UninstallBox.SelectedItem);
                if (Registry.GetValue(_registyPathes[programm], "InstallLocation", "NULL").ToString() == "NULL"
                    || !Directory.Exists(Registry.GetValue(_registyPathes[programm], "InstallLocation", "NULL")
                        .ToString()))
                {
                    if (Registry.GetValue(_registyPathes[programm], "UninstallString", "NULL").ToString() != "NULL"
                        && !Registry.GetValue(_registyPathes[programm], "UninstallString", "NULL").ToString()
                            .StartsWith("MsiExec.exe"))
                    {
                        var path = Registry.GetValue(_registyPathes[programm], "UninstallString", "").ToString();
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
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "explorer",
                        Arguments = "/n, " + Registry.GetValue(_registyPathes[programm], "InstallLocation", "")
                    });
                }
            }
            catch
            {
                Notify.ShowNotify("Путь к программе не найден :(", Resources.Close);
            }
        }

        #endregion

        #region Поиск в браузере

        private void ЧтоЭтоЗаПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1) return;
            Process.Start(@"https://www.google.com/search?q=" +
                          _searchPathes[_searchPathes.IndexOf((string)UninstallBox.SelectedItem)]
                              .Replace("Приложение без деинсталлятора ", string.Empty) + " что это?");
        }

        #endregion

        #region Поиск

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            UninstallBox.Items.Clear();
            UninstallBox.Items.AddRange(_searchPathes.Where(item => item.ToLower().Contains(SearchBox.Text.ToLower()))
                .ToArray());
        }




        #endregion

        #endregion

    }
}