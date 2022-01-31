using System;
using System.IO;

namespace DevIdent.Classes
{
    public static class Drives
    {
        public static string[] drivesInfo;

        public static int GetDiskInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            drivesInfo = new string[drives.Length];
            for (int i = 0; i < drives.Length; i++)
            {
                try
                {
                    drivesInfo[i] = "Диск " + drives[i].Name + ", общий объем: " +
                                       drives[i].TotalSize / 1073741824
                                       + " ГБ" + ", доступный объем: " + drives[i].AvailableFreeSpace / 1073741824 +
                                       " ГБ" + Environment.NewLine + "Файловая система: " + drives[i].DriveFormat;
                }
                catch
                {
                    drivesInfo[i] = "Не удалось получить инфомацию о диске " + drives[i].Name + Environment.NewLine;
                }
            }
            return drivesInfo.Length;
        }
    }
}
