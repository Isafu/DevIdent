using System;
using System.Management;

namespace DevIdent.Classes
{
    public class VideoController
    {

        private static readonly ManagementObjectSearcher Searcher =
            new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

        #region Получение информации

        public static readonly string[] videoInfoList = { "", "", "", "", "", "", "" };

        public static void GetVideoInfo(ManagementObjectSearcher searcher)
        {
            if (videoInfoList[0]?.Length != 0)
            {
                return;
            }

            foreach (ManagementBaseObject o in searcher.Get())
            {
                int i = 0;
                ManagementObject queryObj = (ManagementObject)o;
                try
                {
                    videoInfoList[i] = "Название видеокарты: " + queryObj["Name"];
                    ++i;
                }
                catch
                {
                    videoInfoList[i] = "Не удалось получить название видеокарты";
                    ++i;
                }

                try
                {
                    videoInfoList[i] = GetVideoMemory();
                    ++i;
                }
                catch
                {
                    videoInfoList[i] = "Не удалось получить объем памяти";
                    ++i;
                }

                try
                {
                    videoInfoList[i] = "Версия драйвера: " + queryObj["DriverVersion"];
                    ++i;
                }
                catch
                {
                    videoInfoList[i] = "Не удалось получить версию драйвера";
                    ++i;
                }

                try
                {
                    videoInfoList[i] = "Дата выхода текущего драйвера: " + DateTime
                        .ParseExact(queryObj["DriverDate"].ToString().Remove(8), "yyyyMdd", null).ToShortDateString();
                    ++i;
                }
                catch
                {
                    videoInfoList[i] = "Не удалось получить дату выхода драйвера";
                    ++i;
                }

                try
                {
                    videoInfoList[i] = "Разрешение экрана: " + queryObj["CurrentHorizontalResolution"] + "X" +
                                       queryObj["CurrentVerticalResolution"];
                    ++i;
                }
                catch
                {
                    videoInfoList[i] = "Не удалось получить информацию о разрешении экрана";
                    ++i;
                }

                try
                {
                    videoInfoList[i] = "Архитектура: " + GetVideoArchitecture();
                    ++i;
                }
                catch
                {
                    videoInfoList[i] = "Не удалось получить информацию о архитектуре видеокарты";
                    ++i;
                }

                try
                {
                    videoInfoList[i] = "Тип видеопамяти: " + GetTypeOfMemory();
                }
                catch
                {
                    videoInfoList[i] = "Не удалось получить тип видеопамяти";
                }
            }
        }

        #endregion

        #region Видеопамять

        private static string GetVideoMemory()
        {
            const int converter = 1048576;
            foreach (ManagementBaseObject o in Searcher.Get())
            {
                ManagementObject queryObj = (ManagementObject)o;
                return "Объём видеопамяти: " + Convert.ToDouble(queryObj["AdapterRam"]) / converter + " МБ";
            }

            return "";
        }

        #endregion Видеопамять

        #region Архитектура видеокарты

        private static string GetVideoArchitecture()
        {
            foreach (ManagementBaseObject o in Searcher.Get())
            {
                ManagementObject queryObj = (ManagementObject)o;
                int arc = Convert.ToInt32(queryObj["VideoArchitecture"]);
                switch (arc)
                {
                    case 3:
                        return "CGA";

                    case 4:
                        return "EGA";

                    case 5:
                        return "VGA";

                    case 6:
                        return "SVGA";

                    case 7:
                        return "MDA";

                    case 8:
                        return "HGC";

                    case 9:
                        return "MCGA";

                    case 10:
                        return "8514A";

                    case 11:
                        return "XGA";

                    case 12:
                        return "Linear Frame Buffer";

                    case 160:
                        return "PC-98";

                    default:
                        return "Неизвестно";
                }
            }

            return "";
        }

        #endregion Архитектура видеокарты

        #region Тип видеопамяти

        private static string GetTypeOfMemory()
        {
            foreach (ManagementBaseObject o in Searcher.Get())
            {
                ManagementObject queryObj = (ManagementObject)o;
                int type = Convert.ToInt32(queryObj["VideoMemoryType"]);
                switch (type)
                {
                    case 3:
                        return "VRAM";

                    case 4:
                        return "DRAM";

                    case 5:
                        return "SRAM";

                    case 6:
                        return "WRAM";

                    case 7:
                        return "EDO RAM";

                    case 8:
                        return "Burst Synchronous DRAM";

                    case 9:
                        return "Pipelined Burst SRAM";

                    case 10:
                        return "CDRAM";

                    case 11:
                        return "3DRAM";

                    case 12:
                        return "SDRAM";

                    case 13:
                        return "SGRAM";

                    default:
                        return "неизвестно";
                }
            }

            return "";
        }

        #endregion Тип видеопамяти

    }
}