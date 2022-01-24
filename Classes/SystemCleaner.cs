using System;
using System.Collections;
using System.IO;

namespace DevIdent.Classes
{
    public struct SystemCleaner
    {

        private static readonly string User = Environment.UserName;

        public static readonly DirectoryInfo[] directoryPathes =
        {
            new DirectoryInfo("C:\\temp\\"),
            new DirectoryInfo("C:\\Windows\\SoftwareDistribution\\"),
            new DirectoryInfo("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\PTC"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Temp\\"),
            new DirectoryInfo("C:\\Windows\\Temp\\"),
            new DirectoryInfo("C:\\Windows\\Minidump\\"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\D3DSCache\\"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\CrashDumps\\"),
            new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Recent)),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\WER\\ReportArchive\\"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\Explorer\\")
        };

        public static readonly Hashtable filePathes = new Hashtable
        {
            {"C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\Explorer", "thumbcache_*.db"},
            {"C:\\Windows\\", "*.log"},
            {"C:\\Windows\\", "MEMORY.DMP"},
            {"C:\\ProgramData\\Microsoft\\Windows Defender\\Scans\\History\\Results\\Resource", "*"},
            {"C:\\ProgramData\\Microsoft\\Windows Defender\\Scans\\History\\Results\\Quick", "*"},
            {"C:\\Users\\" + User + "\\AppData\\Local\\Microsoft", "*"},
            {"C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\WebCache", "*.log"},
            {"C:\\Windows\\Microsoft.NET", "*.log"},
            {"C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\", "CLR_*"},
            {"C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\", "CLR_*"},
            {"C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\", "CLR_*"}
        };

    }
}