using DevIdent.Classes;
using DevIdent.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class UninstallForm : Form
    {

        #region Переменные

        private readonly List<string> _programmsOnLocalMachine = new List<string>();
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

        #region Получение разрядности системы

        #endregion

        #region Извлечение путей к деинсталлятору из реестра

        private void GetInstalledProgramms(RegistryHive registryHive, string registryPath)
        {
            _pathToProgramm = RegistryKey.OpenBaseKey(registryHive, registryView).OpenSubKey(registryPath);
            foreach (string keyName in _pathToProgramm.GetSubKeyNames())
            {
                RegistryKey subkey = _pathToProgramm.OpenSubKey(keyName);
                string displayName = (string)subkey.GetValue("DisplayName");
                if (string.IsNullOrEmpty((string)subkey.GetValue("DisplayName")))
                {
                    continue;
                }

                if (string.IsNullOrEmpty((string)subkey.GetValue("UninstallString")))
                {
                    if (string.IsNullOrEmpty((string)subkey.GetValue("InstallLocation")) &&
                        !Directory.Exists((string)subkey.GetValue("InstallLocation")))
                    {
                        continue;
                    }

                    if (!UninstallBox.Items.Contains(displayName))
                    {
                        _programmsOnLocalMachine.Add(displayName);
                        _registyPathes.Add(subkey.Name);
                        UninstallBox.Items.Add("Приложение без деинсталлятора " + displayName);
                        _searchPathes.Add(displayName);

                    }
                }
                else
                {
                    _programmsOnLocalMachine.Add((string)subkey.GetValue("UninstallString"));
                    _registyPathes.Add(subkey.Name);
                    UninstallBox.Items.Add(displayName);
                    _searchPathes.Add(displayName);
                }
            }
        }

        #endregion

        #region Получение программ по битности

        private void GetInstalledProgramms()
        {
            try
            {
                GetInstalledProgramms(RegistryHive.CurrentUser,
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            }
            catch
            {
            }

            try
            {
                GetInstalledProgramms(RegistryHive.LocalMachine,
                    @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            }
            catch
            {
            }

            try
            {
                GetInstalledProgramms(RegistryHive.LocalMachine,
                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            }
            catch
            {
            }
        }

        #endregion

        #region Размер файлов

        private string FileSize(int index)
        {
            string[] hive = _registyPathes[index].Split('\\');
            RegistryHive registryHive = hive[0] == "HKEY_CURRENT_USER" ? RegistryHive.CurrentUser : RegistryHive.LocalMachine;
            _pathToProgramm = RegistryKey.OpenBaseKey(registryHive, registryView)
                .OpenSubKey(GetPathByDepth() + @"\" + hive[hive.Length - 1]) ?? RegistryKey
                .OpenBaseKey(registryHive, registryView)
                .OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall" + @"\" + hive[hive.Length - 1]);
            string locationPath = (string)_pathToProgramm.GetValue("InstallLocation");
            if (string.IsNullOrEmpty(locationPath) || !Directory.Exists(locationPath))
            {
                string[] array = _pathToProgramm.GetValue("UninstallString").ToString().Split('\\');
                string path = "";
                for (int i = 0; i < array.Length - 1; i++)
                {
                    path += array[i] + '\\';
                }

                if (!Directory.Exists(path))
                {
                    return "";
                }

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
            else
            {
                IEnumerable<FileInfo> fullfilesPath = new DirectoryInfo(locationPath).EnumerateFiles("*.*", SearchOption.AllDirectories);
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

        public UninstallForm()
        {
            InitializeComponent();
            Click += (s, e) => { BringToFront(); };
            DoubleClick += (s, e) => { CenterToScreen(); };
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

        private static void DeleteProgrammWithoutUninstaller(string locationPath)
        {
            if (!Directory.Exists(locationPath))
            {
                return;
            };
            foreach (string dir in Directory.GetDirectories(locationPath))
            {
                try
                {
                    Directory.Delete(dir, true);
                }
                catch
                {
                }
            }

            foreach (string file in Directory.GetFiles(locationPath))
            {
                try
                {
                    File.Delete(file);
                }
                catch
                {
                }
            }

            try
            {
                Directory.Delete(locationPath);
            }
            catch
            {
            }
        }

        private void DeleteProgrammByUninstallString(int index)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + "\"" + _programmsOnLocalMachine[index] + "\"",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process process = new Process
            {
                StartInfo = startInfo
            };
            process.EnableRaisingEvents = true;
            process.Start();
            process.WaitForExit();
            if (process.ExitCode == 0)
            {
                RemoveFromListAndRegistry(index);
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
            int ind = indexOfProgramm;
            DeleteInfoFromRegistry(ind);
            UninstallBox.Items.RemoveAt(UninstallBox.SelectedIndex);
            _programmsOnLocalMachine.RemoveAt(ind);
            _registyPathes.RemoveAt(ind);
            _searchPathes.RemoveAt(ind);
        }

        private void Uninstall(int index)
        {
            string[] hive = _registyPathes[index].Split('\\');
            RegistryHive registryHive = hive[0] == "HKEY_CURRENT_USER" ? RegistryHive.CurrentUser : RegistryHive.LocalMachine;
            _pathToProgramm = RegistryKey.OpenBaseKey(registryHive, registryView)
                .OpenSubKey(GetPathByDepth() + @"\" + hive[hive.Length - 1]) ?? RegistryKey
                .OpenBaseKey(registryHive, registryView)
                .OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall" + @"\" + hive[hive.Length - 1]);

            if ((string)_pathToProgramm.GetValue("UninstallString") != null && File.Exists((string)_pathToProgramm.GetValue("UninstallString")))
            {
                DeleteProgrammByUninstallString(index);
                RemoveFromListAndRegistry(index);
                return;
            }

            if ((string)_pathToProgramm.GetValue("InstallSource") != null)
            {
                DeleteProgrammWithoutUninstaller((string)_pathToProgramm.GetValue("InstallSource"));
                RemoveFromListAndRegistry(index);
                return;
            }

            if ((string)_pathToProgramm.GetValue("UninstallString_Hidden") != null)
            {
                DeleteProgrammByHiddenUninstall((string)_pathToProgramm.GetValue("UninstallString_Hidden"));
                RemoveFromListAndRegistry(index);
                return;
            }

            if (_pathToProgramm.GetValue("InstallLocation") != null)
            {
                DeleteProgrammWithoutUninstaller((string)_pathToProgramm.GetValue("InstallLocation"));
                RemoveFromListAndRegistry(index);
            }
        }

        #endregion

        #region Работа в Menu

        #region Создание txt файла

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                BeginInvoke((Action)(() =>
                {
                    if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.txt")))
                    {
                        Notify.ShowNotify("Файл уже был создан", Resources.CloseIcon);
                        return;
                    }
                    File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.txt")).Close();
                    using (StreamWriter myWriter = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.txt")))
                    {
                        myWriter.WriteLine("   Список установленных программ:" + Environment.NewLine);
                        for (int i = 0; i < _programmsOnLocalMachine.Count - 1; i++)
                        {
                            myWriter.WriteLine("-- " + UninstallBox.Items[i] + " " + FileSize(i));
                        }
                    }

                    Notify.ShowNotify("Файл создан на рабочем столе", Resources.CloseIcon);
                }));
            }).Start();
        }

        #endregion

        #region Создание html файла

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                BeginInvoke((Action)(() =>
                {
                    if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.html")))
                    {
                        Notify.ShowNotify("Файл уже был создан", Resources.CloseIcon);
                        return;
                    }
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                "\\Установленное ПО.html").Close();
                    using (StreamWriter myWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.html"))
                    {
                        myWriter.WriteLine("<h1>Список установленных программ:</h1>");
                        for (int i = 0; i < _programmsOnLocalMachine.Count - 1; i++)
                        {
                            myWriter.Write("<p>-- " + UninstallBox.Items[i] + " " + FileSize(i) + "</p>");
                        }
                    }

                    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Установленное ПО.html");
                    Notify.ShowNotify("Файл создан на рабочем столе", Resources.CloseIcon);
                }));
            }).Start();
        }

        #endregion

        #region Удаление из реестра

        private void удалитьИзРеестраStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1)
            {
                return;
            }

            int programm = _searchPathes.IndexOf((string)UninstallBox.SelectedItem);
            RemoveFromListAndRegistry(programm);
        }

        #endregion

        #region Нажатие на Удалить

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1)
            {
                return;
            }

            int programm = _searchPathes.IndexOf((string)UninstallBox.SelectedItem);
            Uninstall(programm);

        }

        #endregion

        #region Показать запись в реестре

        private void записьВРеестреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1)
            {
                return;
            }

            foreach (Process process in Process.GetProcessesByName("regedit"))
            {
                process.Kill();
            }

            int programm = _searchPathes.IndexOf((string)UninstallBox.SelectedItem);
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Applets\Regedit")
                .SetValue("LastKey", _registyPathes[programm]);
            Process.Start("regedit");
        }

        #endregion

        #region Открытие пути программы в проводнике

        #region Изменение InfoForm если не найден путь

        private readonly InfoForm _infoForm = new InfoForm();

        private void InfoForm()
        {
            _infoForm.label2.Visible = false;
            _infoForm.OkButton.Size = new Size(125, 25);
            _infoForm.OkButton.Location = new Point(88, 90);
            _infoForm.OkButton.Visible = true;
            _infoForm.Show();
        }

        #endregion

        #region Открытие проводника

        private void расположениеНаДискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1)
            {
                return;
            }

            int programm = _searchPathes.IndexOf((string)UninstallBox.SelectedItem);
            string[] hive = _registyPathes[programm].Split('\\');
            _pathToProgramm = RegistryKey.OpenBaseKey(GetHive(programm), registryView)
                .OpenSubKey(GetPathByDepth() + @"\" + hive[hive.Length - 1]) ?? RegistryKey
                .OpenBaseKey(GetHive(programm), registryView)
                .OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall" + @"\" + hive[hive.Length - 1]);
            if (_pathToProgramm.GetValue("InstallLocation") == null || !Directory.Exists((string)_pathToProgramm.GetValue("InstallLocation")))
            {
                if (_pathToProgramm.GetValue("InstallSource") != null)
                {
                    string[] installSource = _pathToProgramm.GetValue("InstallSource").ToString().Split('\\');
                    string line = "";
                    for (int i = 0; i < installSource.Length - 1; i++)
                    {
                        line += installSource[i] + '\\';
                    }

                    Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = "/n, " + line });
                }
                else
                {
                    if (_pathToProgramm.GetValue("UninstallString") != null)
                    {
                        string[] uninstall = _pathToProgramm.GetValue("UninstallString").ToString().Split('\\');
                        string path = "";
                        for (int i = 0; i < uninstall.Length - 1; i++)
                        {
                            path += uninstall[i] + '\\';
                        }

                        if (Directory.Exists(path))
                        {
                            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = "/n, " + path });
                        }
                    }
                    else
                    {
                        _infoForm.label1.Text = "Путь к программе не найден :(";
                        InfoForm();
                    }
                }
            }
            else
            {
                Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = "/n, " + _pathToProgramm.GetValue("InstallLocation") });
            }
        }

        #endregion

        #endregion

        #region Поиск в браузере

        private void чтоЭтоЗаПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UninstallBox.SelectedIndex == -1)
            {
                return;
            }

            int programm = _searchPathes.IndexOf((string)UninstallBox.SelectedItem);
            string target = @"https://www.google.com/search?q=" + _searchPathes[programm] + " что это?";
            Process.Start(target);
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