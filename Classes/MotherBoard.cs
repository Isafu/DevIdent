using System.Management;

namespace DevIdent.Classes
{
    public class MotherBoard
    {
        #region Получение информации

        public static readonly string[] motherBoardInfoList = { "", "", "", "", "" };

        public static void GetMotherBoardInfo(ManagementObjectSearcher searcher)
        {
            if (motherBoardInfoList[0]?.Length != 0)
            {
                return;
            }

            int i = 0;
            foreach (ManagementBaseObject o in searcher.Get())
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
                    if (queryObj["SerialNumber"].ToString().Length < 6)
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
                }
                catch
                {
                    motherBoardInfoList[i] = "Не удалось получить информацию о подключении";
                }
            }
        }

        #endregion
    }
}