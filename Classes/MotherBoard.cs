using System;
using System.Management;

namespace DevIdent.Classes
{
    public class MotherBoard : ComputerComponent
    {
        #region Получение информации

        public static string[] motherBoardInfoList = { "", "", "", "", "" };

        public static void GetMotherBoardInfo()
        {
            if (motherBoardInfoList[0]?.Length != 0)
            {
                return;
            }
            int i = 0;
            var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard").Get();
            if (searcher.Count > 1)
            {
                Array.Resize(ref motherBoardInfoList, motherBoardInfoList.Length * searcher.Count);
            }
            foreach (ManagementBaseObject o in searcher)
            {
                ManagementObject queryObj = (ManagementObject)o;
                try
                {
                    motherBoardInfoList[i] = "Чип: " + queryObj["Manufacturer"];
                    ++i;
                }
                catch
                {
                    motherBoardInfoList[i] = "Не удалось получить чип материнской платы";
                    ++i;
                }

                try
                {
                    motherBoardInfoList[i] = "Модель: " + queryObj["Product"];
                    ++i;
                }
                catch
                {
                    motherBoardInfoList[i] = "Не удалось получить информацию о модели";
                    ++i;
                }

                try
                {
                    motherBoardInfoList[i] = "Тип шины: " + queryObj["PrimaryBusType"];
                    ++i;
                }
                catch
                {
                    motherBoardInfoList[i] = "Не удалось получить информацию о типе шины";
                    ++i;
                }

                try
                {
                    if (queryObj["SerialNumber"].ToString().Length > 6)
                    {
                        motherBoardInfoList[i] = "Серийный номер: " + queryObj["SerialNumber"];
                        ++i;
                    }
                    else
                    {
                        motherBoardInfoList[i] = "Не удалось получить серийный номер материнской платы";
                        ++i;
                    }
                }
                catch
                {
                    motherBoardInfoList[i] = "Не удалось получить серийный номер материнской платы";
                    ++i;
                }

                try
                {
                    motherBoardInfoList[i] = "Подключение" + queryObj["PrimaryBusType"];
                    ++i;
                }
                catch
                {
                    motherBoardInfoList[i] = "Не удалось получить информацию о подключении";
                    ++i;
                }
            }
        }

        #endregion
    }
}