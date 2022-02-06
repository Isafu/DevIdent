using DevIdent.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DevIdent.Classes
{
    public struct WindowsSettings
    {

        public static readonly List<Tuple<string, string>> settingInfo = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("Отключить гибернацию","В режиме гибернации содержимое оперативной памяти сохраняется в специальный файл " +
                "на жёстком диске, а сам компьютер переходит в состояние с минимальным расходом электроэнергии. " +
                "Владельцам ноутбуков данный пункт применять не желательно."),
            new Tuple<string, string>("Убрать задержку запуска Windows","Убирает задержку запуска Windows и автозагрузки, " +
                "тем самым вы ускоряете запуск системы. (Не работает на Windows 7)"),
            new Tuple<string, string>("Отключить автозапуск съёмных носителей","Съёмные устройства продолжат работать как и раньше, только Windows будет " +
                "игнорировать наличие файла Autorun.inf, который чаще всего используется злоумышлиниками."),
            new Tuple<string, string>("Увеличить кэш файловой системы","Желательно применять данный пункт, если у вас больше 4 ГБ оперативной памяти."),
            new Tuple<string, string>("Отключить предупреждение безопасности для .exe файлов","Отключает окошко безопасности при запуске .exe файлов."),
            new Tuple<string, string>("Отключить синхронизацию","Отключает синхронизацию паролей, настроек, тем, браузеров и другие виды синхронизации."),
            new Tuple<string, string>("Отключить телеметрию","Отключает фирменный сбор данных от Microsoft Corporation."),
            new Tuple<string, string>("Отключить сбор данных об установленных приложениях",
                "Microsoft собирает информацию об приложениях, когда вы их используете или устанавливаете. (Не работает на Windows 7)"),
            new Tuple<string, string>("Отключить сбор информации о местоположении", "Microsoft собирает информацию о вашем местоположении," +
                " если вам это не нужно подтверждаем этот пункт."),
            new Tuple<string, string>("Отображать все иконки в трее", "Включает отображение всех иконок трея в развернутом виде."),
            new Tuple<string, string>("Удалить стрелочки с ярлыков", "Убирает стрелки с ярлыков на рабочем столе и тд."),
        };

        public static readonly List<List<Tuple<string, string, string, object>>> registyInfo = new List<List<Tuple<string, string, string, object>>>()
        {
            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("LocalMachine",@"SYSTEM\CurrentControlSet\Control\Power","HiberFileSizePercent",0),
                new Tuple<string, string, string, object>("LocalMachine",@"SYSTEM\CurrentControlSet\Control\Power","HibernateEnabled",0)
            },

            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("CurrentUser",@"Software\Microsoft\Windows\CurrentVersion\Explorer\Serialize","Startupdelayinmsec",0)
            },

            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("CurrentUser",@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers","DisableAutoplay",1)
            },

            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("LocalMachine", @"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management","LargeSystemCache",1)
            },

            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("LocalMachine", @"SOFTWARE\Microsoft\Internet Explorer\Security","DisableSecuritySettingsCheck",1),
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", "1806", 0)
            },

            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Accessibility","Enabled", 0),
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\BrowserSettings","Enabled", 0),
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Credentials","Enabled", 0),
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Language","Enabled", 0),
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Personalization", "Enabled", 0),
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Windows", "Enabled", 0)
            },

            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("LocalMachine", @"SYSTEM\CurrentControlSet\Control\WMI\Autologger\Diagtrack-Listener", "Start", 0),
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", "SaveZoneInformation", 1),
                new Tuple<string, string, string, object>("LocalMachine", @"SYSTEM\CurrentControlSet\Services\DiagTrack", "Start", 4),
                new Tuple<string, string, string, object>("LocalMachine", @"SYSTEM\CurrentControlSet\Services\dmwappushservice", "Start", 4)
            },
            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("LocalMachine", @"SOFTWARE\Policies\Microsoft\Windows\AppCompat", "DisableInventory", 1)
            },
            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("LocalMachine", @"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", "DisableLocation", 1),
                new Tuple<string, string, string, object>("LocalMachine", @"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", "DisableLocationScripting", 1),
                new Tuple<string, string, string, object>("LocalMachine", @"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", "DisableWindowsLocationProvider", 1)
            },
            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("CurrentUser", @"Software\Microsoft\Windows\CurrentVersion\Explorer", "EnableAutoTray", 0)
            },
            new List<Tuple<string, string, string, object>>
            {
                new Tuple<string, string, string, object>("LocalMachine", @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons", "29"
                    , "%systemroot%\\RemoveArrow.ico,0")
            }
        };

        public static MethodInfo[] methods = typeof(WindowsSettings).GetMethods();

        #region Отключает гибернацию

        public static void Checker1(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Power", true).SetValue("HiberFileSizePercent", 0);
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Power", true).SetValue("HibernateEnabled", 0);
                    Process.Start(new ProcessStartInfo { FileName = "cmd", Arguments = "/c powercfg -h off", WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit();
                }
                else
                {
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Power", true).SetValue("HiberFileSizePercent", 1);
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Power", true).SetValue("HibernateEnabled", 1);
                    Process.Start(new ProcessStartInfo { FileName = "cmd", Arguments = "/c powercfg -h on", WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit();
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при попытке отключить гибернацию", Resources.Information);
            }
        }

        #endregion

        #region Убирает задержку запуска

        public static void Checker2(bool enabled)
        {
            try
            {
                if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1)
                {
                    Notify.ShowNotify("Невозможно убрать задержку запуска на Windows 7", Resources.Information);
                    return;
                }
                if (enabled)
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Serialize", true).SetValue("Startupdelayinmsec", 0);
                }
                else
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Serialize", true).SetValue("Startupdelayinmsec", "");
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при попытке убрать задержку запуска", Resources.Information);
            }
        }

        #endregion

        #region Отключает автозапуск съемных носителей

        public static void Checker3(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers", true).SetValue("DisableAutoplay", 1);
                }
                else
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers", true).SetValue("DisableAutoplay", 0);
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при попытке отключить автозапуск съемных носителей", Resources.Information);
            }
        }

        #endregion

        #region Увеличить кэш файловой системы

        public static void Checker4(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", true).SetValue("LargeSystemCache", 1);
                }
                else
                {
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", true).SetValue("LargeSystemCache", 0);
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при попытке увеличить кэш файловой системы", Resources.Information);
            }
        }

        #endregion

        #region Отключить предупреждение при запуске ехе

        public static void Checker5(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Security", true).SetValue("DisableSecuritySettingsCheck", 1);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", true).SetValue("1806", 0);
                }
                else
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Security", true).SetValue("DisableSecuritySettingsCheck", "");
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3", true).SetValue("1806", "");
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при отключении предупреждений при запуске .ехе", Resources.Information);
            }
        }

        #endregion

        #region Отключение синхронизаций

        public static void Checker6(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Accessibility", true).SetValue("Enabled", 0);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\BrowserSettings", true).SetValue("Enabled", 0);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Credentials", true).SetValue("Enabled", 0);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Language", true).SetValue("Enabled", 0);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Personalization", true).SetValue("Enabled", 0);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Windows", true).SetValue("Enabled", 0);
                }
                else
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Accessibility", true).SetValue("Enabled", 1);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\BrowserSettings", true).SetValue("Enabled", 1);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Credentials", true).SetValue("Enabled", 1);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Language", true).SetValue("Enabled", 1);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Personalization", true).SetValue("Enabled", 1);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\SettingSync\Groups\Windows", true).SetValue("Enabled", 1);
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при отключении синхронизации", Resources.Information);
            }
        }

        #endregion

        #region Отключает телеметрию

        public static void Checker7(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1)
                    {
                        Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\WMI\Autologger\Diagtrack-Listener", true).SetValue("Start", 0);
                        Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DiagTrack", true).SetValue("Start", 4);
                        Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dmwappushservice", true).SetValue("Start", 4);
                        return;
                    }
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\WMI\Autologger\Diagtrack-Listener", true).SetValue("Start", 0);
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DiagTrack", true).SetValue("Start", 4);
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dmwappushservice", true).SetValue("Start", 4);
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", true).SetValue("SaveZoneInformation ", 1);
                }
                else
                {
                    if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1)
                    {
                        Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\WMI\Autologger\Diagtrack-Listener", true).SetValue("Start", 1);
                        Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DiagTrack", true).SetValue("Start", "");
                        Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dmwappushservice", true).SetValue("Start", "");
                        return;
                    }
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\WMI\Autologger\Diagtrack-Listener", true).SetValue("Start", 1);
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\DiagTrack", true).SetValue("Start", "");
                    Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\dmwappushservice", true).SetValue("Start", "");
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Attachments", true).SetValue("SaveZoneInformation ", "");
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при отключении телеметрии", Resources.Information);
            }
        }

        #endregion

        #region Отключиение сбора данных об установленных приложениях

        public static void Checker8(bool enabled)
        {
            try
            {
                if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1)
                {
                    Notify.ShowNotify("Невозможно отключить сбор данных о приложениях на Windows 7", Resources.Information);
                    return;
                }
                if (enabled)
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\AppCompat", true).SetValue("DisableInventory", 1);
                }
                else
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\AppCompat", true).SetValue("DisableInventory", "");
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при отключении сбора данных об установленных программах", Resources.Information);
            }
        }

        #endregion

        #region Откючение отслеживания местоположения

        public static void Checker9(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", true).SetValue("DisableLocation", 1);
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", true).SetValue("DisableLocationScripting", 1);
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", true).SetValue("DisableWindowsLocationProvider", 1);
                }
                else
                {
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", true).SetValue("DisableLocation", "");
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", true).SetValue("DisableLocationScripting", "");
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows\LocationAndSensors", true).SetValue("DisableWindowsLocationProvider", "");
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при отключении отслеживания местоположения", Resources.Information);
            }
        }

        #endregion

        #region Откючение всех иконок в трее

        public static void Checker10(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true).SetValue("EnableAutoTray", 0);

                }
                else
                {
                    Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true).SetValue("EnableAutoTray", "");
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при отключении сбора данных об установленных программах", Resources.Information);
            }
        }

        #endregion

        #region Убрать стрелки с иконок

        public static void Checker11(bool enabled)
        {
            try
            {
                if (enabled)
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons")
                        .SetValue("29", "%systemroot%\\RemoveArrow.ico,0");
                    using (FileStream stream = new FileStream("C:\\Windows\\RemoveArrow.ico", FileMode.Create))
                        Resources.RemoveArrow.Save(stream);
                }
                else
                {
                    Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons").SetValue("29", "");
                    if (File.Exists("C:\\Windows\\RemoveArrow.ico"))
                    {
                        File.Delete("C:\\Windows\\RemoveArrow.ico");
                    }
                }
            }
            catch
            {
                Notify.ShowNotify("Непредвиденная ошибка при попытке убрать стрелки с иконок", Resources.Information);
            }
        }

        #endregion

    }
}