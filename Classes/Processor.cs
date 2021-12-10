using System;
using System.Management;
using System.Text.RegularExpressions;

namespace DevIdent.Classes
{
    public class Processor
    {

        #region Получение информации

        public static readonly string[] cpuInfoList = { "", "", "", "", "", "", "" };

        public static void GetCpuinfo(ManagementObjectSearcher searcher)
        {
            if (cpuInfoList[0]?.Length != 0)
            {
                return;
            }

            int i = 0;
            foreach (ManagementBaseObject o in searcher.Get())
            {
                ManagementObject queryObj = (ManagementObject)o;
                try
                {
                    string line = Regex.Replace((string)queryObj["Name"], @"\s+", " ");
                    cpuInfoList[i] = "Название: " + line;
                    ++i;
                }
                catch
                {
                    cpuInfoList[i] = "Не удалось получить название процессора";
                    ++i;
                }

                try
                {
                    cpuInfoList[i] = "Тип процессора: " + GetProcessorType(queryObj);
                    ++i;
                }
                catch
                {
                    cpuInfoList[i] = "Не удалось получить тип процессора";
                    ++i;
                }

                try
                {
                    cpuInfoList[i] = "Архитектура: " + GetArchitecture(queryObj);
                    ++i;
                }
                catch
                {
                    cpuInfoList[i] = "Не удалось получить архитектуру процессора";
                    ++i;
                }

                try
                {
                    cpuInfoList[i] = "Количество ядер: " + queryObj["NumberOfCores"];
                    ++i;
                }
                catch
                {
                    cpuInfoList[i] = "Не удалось получить количество ядер";
                    ++i;
                }

                try
                {
                    cpuInfoList[i] = "Количество включенных ядер: " + queryObj["NumberOfEnabledCore"];
                    ++i;
                }
                catch
                {
                    cpuInfoList[i] = "Не удалось получить количество включенных ядер";
                    ++i;
                }

                try
                {
                    cpuInfoList[i] = "Количество потоков: " + queryObj["ThreadCount"];
                    ++i;
                }
                catch
                {
                    cpuInfoList[i] = "Не удалось получить количество потоков";
                    ++i;
                }

                try
                {
                    cpuInfoList[i] = "Тактовая частота: " + queryObj["MaxClockSpeed"];
                }
                catch
                {
                    cpuInfoList[i] = "Не удалось получить тактовую частоту";
                }
            }
        }

        #endregion

        #region Архитектура процессора

        private static string GetArchitecture(ManagementBaseObject managementObject)
        {
            int arc = Convert.ToInt32(managementObject["Architecture"]);
            switch (arc)
            {
                case 0:
                    return "x86";

                case 1:
                    return "MIPS";

                case 2:
                    return "Alpha";

                case 3:
                    return "PowerPC";

                case 5:
                    return "ARM";

                case 6:
                    return "ia64";

                case 9:
                    return "x64";

                default:
                    return "Неизвестно";
            }
        }

        #endregion Архитектура процессора

        #region Тип процессора

        private static string GetProcessorType(ManagementBaseObject managementObject)
        {
            int i = Convert.ToInt32(managementObject["ProcessorType"]);
            switch (i)
            {
                case 3: return "Центральный процессор";
                case 4: return "Математический процессор";
                case 5: return "Цифровой процессор";
                case 6: return "Видеопроцессор";
            }

            return "Неизвестно";
        }

        #endregion Тип процессора

    }
}