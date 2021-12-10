using Microsoft.Win32;
using System;

namespace DevIdent.Classes
{
    public class OS
    {

        #region Получение информации

        public static int counter = 0;
        public static readonly string[] sysInfoList = { "", "", "", "", "", "", "" };

        public static void GetSysInfo()
        {
            if (sysInfoList[0]?.Length != 0)
            {
                return;
            }

            int i = 0;
            try
            {
                sysInfoList[i] = "Версия ОС: " + GetOSVersion();
                ++i;
            }
            catch
            {
                sysInfoList[i] = "Не удалось считать информацию о версии ОС";
                ++i;
            }

            sysInfoList[i] = GetOSBuild();
            ++i;

            sysInfoList[i] = GetInstallTime();
            ++i;

            try
            {
                sysInfoList[i] = GetBitDepth();
                ++i;
            }
            catch
            {
                sysInfoList[i] = "Не удалось считать информацию о разрядности ОС";
                ++i;
            }

            try
            {
                sysInfoList[i] = "Имя пользователя: " + Environment.UserName;
                ++i;
            }
            catch
            {
                sysInfoList[i] = "Не удалось считать информацию о имени пользователя";
                ++i;
            }

            try
            {
                sysInfoList[i] = "Имя сетевого домена: " + Environment.UserDomainName;
                ++i;
            }
            catch
            {
                sysInfoList[i] = "Не удалось считать информацию о имени сетевого домена";
                ++i;
            }

            try
            {
                sysInfoList[i] = "Логические диски: " + string.Join(", ", Environment.GetLogicalDrives())
                    .Replace("\\", "").Replace(":", "").TrimEnd(',', ' ');
            }
            catch
            {
                sysInfoList[i] = "Не удалось считать информацию о логических дисках";
            }
        }

        #endregion

        public static string HKLM_GetString(string path, string key)
        {
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(path);
                if (rk == null)
                {
                    return "";
                }

                RegistryValueKind kind = rk.GetValueKind(key);
                return kind == RegistryValueKind.DWord ? Convert.ToString((uint)(int)rk.GetValue(key)) : (string)rk.GetValue(key);
            }
            catch { return ""; }
        }

        #region Версия ОС

        public static string GetOSVersion()
        {
            string productName = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName");
            string CSDVersion = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CSDVersion");
            string dispayedVersion = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "DisplayVersion");
            if (productName != "")
            {
                return (productName.StartsWith("Microsoft") ? "" : "Microsoft ") + productName +
                            (CSDVersion != "" ? " " + CSDVersion : "") + (dispayedVersion != "" ? " " + dispayedVersion : "");
            }
            return "Не удалось получить версию ОС";
        }

        #endregion Версия ОС

        #region Сборка ОС

        public static string GetOSBuild()
        {
            string build = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild");
            string buildRevision = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "UBR");
            if (build != "")
            {
                if (buildRevision != "")
                {
                    return "Сборка ОС: " + build + "." + buildRevision;
                }
                else
                {
                    return "Сборка ОС: " + build;
                }
            }
            return "Не удалось получить сборку ОС";
        }

        #endregion

        #region Время установки ОС

        private static string GetInstallTime()
        {
            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                string date = key.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion").GetValue("InstallDate").ToString();
                DateTime dateDef = new DateTime(1970, 1, 1);
                return "Время установки ОС: " + dateDef.AddSeconds(Convert.ToInt64(date)).ToString();
            }
            catch
            {
                return "Не удалось получить время установки ОС";
            }
        }

        #endregion

        #region Разрядность системы

        private static string GetBitDepth()
        {
            bool bit = Environment.Is64BitOperatingSystem;
            return bit ? "Разрядность ОС: 64" : "Разрядность ОС: 32";
        }

        #endregion Разрядность системы

    }
}