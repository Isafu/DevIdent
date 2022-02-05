using System;
using System.Management;

namespace DevIdent.Classes
{
    public class BIOS
    {
        #region Получение информации

        public static string[] biosInfoList = { "", "", "", "", "", "" };

        public static void GetBIOSInfo()
        {
            if (biosInfoList[0]?.Length != 0)
            {
                return;
            }
            int i = 0;
            var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS").Get();
            if (searcher.Count > 1)
            {
                Array.Resize(ref biosInfoList, biosInfoList.Length * searcher.Count);
            }
            foreach (ManagementBaseObject o in searcher)
            {
                ManagementObject queryObj = (ManagementObject)o;
                try
                {
                    biosInfoList[i] = "Название: " + queryObj["Name"];
                    ++i;
                }
                catch
                {
                    biosInfoList[i] = "Не удалось получить название БИОС";
                    ++i;
                }

                try
                {
                    biosInfoList[i] = "Производитель: " + queryObj["Manufacturer"];
                    ++i;
                }
                catch
                {
                    biosInfoList[i] = "Не удалось получить производителя БИОС";
                    ++i;
                }

                try
                {
                    biosInfoList[i] = "Версия: " + queryObj["Version"].ToString().Trim();
                    ++i;
                }
                catch
                {
                    biosInfoList[i] = "Не удалось получить версию БИОС";
                    ++i;
                }

                try
                {
                    biosInfoList[i] = "Дата выхода текущей драйвера: " + DateTime
                        .ParseExact(queryObj["ReleaseDate"].ToString().Remove(8), "yyyyMdd", null).ToShortDateString();
                    ++i;
                }
                catch
                {
                    biosInfoList[i] = "Не удалось получить дату выхода драйвера";
                    ++i;
                }

                try
                {
                    biosInfoList[i] = "Идентификатор: " + queryObj["Description"];
                    ++i;
                }
                catch
                {
                    biosInfoList[i] = "Не удалось получить идентификатор БИОС";
                    ++i;
                }

                try
                {
                    if (queryObj["SerialNumber"].ToString() == "Default string")
                    {
                        biosInfoList[i] = "Не удалось получить серийный номер";
                        ++i;
                    }
                    else if (queryObj["SerialNumber"].ToString().Length > 5)
                    {
                        biosInfoList[i] = "Серийный номер: " + queryObj["SerialNumber"];
                        ++i;
                    }
                    else
                    {
                        biosInfoList[i] = "Не удалось получить серийный номер";
                        ++i;
                    }
                }
                catch
                {
                    biosInfoList[i] = "Не удалось получить серийный номер";
                    ++i;
                }
            }
        }

        #endregion
    }
}