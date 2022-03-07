using System;
using System.Management;

namespace DevIdent.Classes
{
    public class RAM : ComputerComponent
    {
        private static readonly ManagementObjectSearcher RamSearcherFromOs =
            new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");

        private static readonly ManagementObjectSearcher Searcher =
            new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

        private static ulong _totalMemoryCapacity;

        #region Количество оперативной памяти

        public static ulong GetRamCapacity()
        {
            foreach (var o in RamSearcherFromOs.Get())
            {
                var queryObj = (ManagementObject)o;
                _totalMemoryCapacity = (ulong)queryObj["TotalVisibleMemorySize"] / 1024;
                return _totalMemoryCapacity;
            }

            return 0;
        }

        #endregion Количество оперативной памяти

        #region Тип памяти ОЗУ

        private static string GetTypeOfRamMemory()
        {
            foreach (var o in Searcher.Get())
            {
                var queryObj = (ManagementObject)o;
                var arc = Convert.ToInt32(queryObj["MemoryType"]);
                switch (arc)
                {
                    case 2:
                        return "DRAM";

                    case 3:
                        return "Synchronous DRAM";

                    case 4:
                        return "Cache DRAM";

                    case 5:
                        return "EDO";

                    case 6:
                        return "EDRAM";

                    case 7:
                        return "VRAM";

                    case 8:
                        return "SRAM";

                    case 9:
                        return "RAM";

                    case 10:
                        return "ROM";

                    case 11:
                        return "Flash";

                    case 12:
                        return "EEPROM";

                    case 13:
                        return "FEPROM";

                    case 14:
                        return "EPROM";

                    case 15:
                        return "CDRAM";

                    case 16:
                        return "3DRAM";

                    case 17:
                        return "SDRAM";

                    case 18:
                        return "SGRAM";

                    case 19:
                        return "RDRAM";

                    case 20:
                        return "DDR";

                    case 21:
                        return "DDR2";

                    case 22:
                        return "DDR2 FB-DIMM";

                    case 24:
                        return "DDR3";

                    case 25:
                        return "FBD2";

                    case 26:
                        return "DDR4";

                    default:
                        return "неизвестно";
                }
            }

            return "";
        }

        #endregion Тип памяти ОЗУ

        #region Форм фактор

        private static string GetFormFactorOfRam()
        {
            foreach (var o in Searcher.Get())
            {
                var queryObj = (ManagementObject)o;
                var formFactor = Convert.ToInt32(queryObj["FormFactor"]);
                switch (formFactor)
                {
                    case 2:
                        return "SIP";

                    case 3:
                        return "DIP";

                    case 4:
                        return "ZIP";

                    case 5:
                        return "SOJ";

                    case 6:
                        return "Proprietary";

                    case 7:
                        return "SIMM";

                    case 8:
                        return "DIMM";

                    case 9:
                        return "TSOP";

                    case 10:
                        return "PGA";

                    case 11:
                        return "RIMM";

                    case 12:
                        return "SODIMM";

                    case 13:
                        return "SRIMM";

                    case 14:
                        return "SMD";

                    case 15:
                        return "SSMP";

                    case 16:
                        return "QFP";

                    case 17:
                        return "TQFP";

                    case 18:
                        return "SOIC";

                    case 19:
                        return "LCC";

                    case 20:
                        return "PLCC";

                    case 21:
                        return "BGA";

                    case 22:
                        return "FPBGA";

                    case 23:
                        return "LGA";
                }
            }

            return "";
        }

        #endregion Форм фактор

        #region Получение информации

        public static string[] ramInfoList = { "", "", "", "", "", "" };

        public static void GetRamInfo()
        {
            if (ramInfoList[0]?.Length != 0) return;
            var searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory").Get();
            foreach (var o in searcher)
            {
                var i = 0;
                var queryObj = (ManagementObject)o;
                try
                {
                    ramInfoList[i] = "Общий объем памяти ОЗУ: " + GetRamCapacity() + "МБ";
                    ++i;
                }
                catch
                {
                    ramInfoList[i] = "Не удалось получить информацию о объеме памяти ОЗУ";
                    ++i;
                }

                try
                {
                    ramInfoList[i] = "Тактовая частота ОЗУ: " + queryObj["ConfiguredClockSpeed"];
                    ++i;
                }
                catch
                {
                    ramInfoList[i] = "Не удалось получить информацию о тактовой частоте ОЗУ";
                    ++i;
                }

                try
                {
                    ramInfoList[i] = "Тип памяти ОЗУ: " + GetTypeOfRamMemory();
                    ++i;
                }
                catch
                {
                    ramInfoList[i] = "Не удалось получить информацию о типе памяти ОЗУ";
                    ++i;
                }

                try
                {
                    ramInfoList[i] = "Форм фактор ОЗУ: " + GetFormFactorOfRam();
                    ++i;
                }
                catch
                {
                    ramInfoList[i] = "Не удалось получить информацию о форм факторе ОЗУ";
                    ++i;
                }

                try
                {
                    ramInfoList[i] = "Минимальный вольтаж: " + double.Parse(queryObj["MinVoltage"].ToString()) / 1000 +
                                     " В";
                    ++i;
                }
                catch
                {
                    ramInfoList[i] = "Не удалось получить данные о минимальном вольтаже";
                    ++i;
                }

                try
                {
                    ramInfoList[i] = "Максимальный вольтаж: " + double.Parse(queryObj["MaxVoltage"].ToString()) / 1000 +
                                     " В";
                    ++i;
                }
                catch
                {
                    ramInfoList[i] = "Не удалось получить данные о максимальном вольтаже";
                }
            }
        }

        #endregion
    }
}