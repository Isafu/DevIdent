using System;
using System.Collections.Generic;
using System.IO;

namespace DevIdent.Classes
{
    public struct SystemCleaner
    {

        private static readonly string User = Environment.UserName;

        public static readonly DirectoryInfo[] directoryPathes =
        {
            new DirectoryInfo("C:\\temp"),
            new DirectoryInfo("C:\\Windows\\SoftwareDistribution"),
            new DirectoryInfo("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\PTC"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Temp"),
            new DirectoryInfo("C:\\Windows\\Temp"),
            new DirectoryInfo("C:\\Windows\\Minidump"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\D3DSCache"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\CrashDumps"),
            new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Recent)),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\WER\\ReportArchive"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\Explorer"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\CLR_v4.0\\UsageLogs"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\CLR_v4.0_32\\UsageLogs"),
            new DirectoryInfo("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\CLR_v2.0\\UsageLogs"),
            new DirectoryInfo("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\CLR_v4.0"),
            new DirectoryInfo("C:\\Windows\\Logs\\WindowsUpdate"),
            new DirectoryInfo("C:\\ProgramData\\Microsoft\\Network\\Downloader"),
            new DirectoryInfo("C:\\Windows\\Prefetch"),
            new DirectoryInfo("C:\\Windows\\Logs"),
            new DirectoryInfo("C:\\Windows\\servicing\\LCU"),
            new DirectoryInfo("C:\\Windows\\Logs\\SIH"),
            new DirectoryInfo("C:\\Users\\Isafu-\\AppData\\Local\\ElevatedDiagnostics"),
        };

        public static readonly List<Tuple<string, string>> filePathes = new List<Tuple<string, string>>
        {
            new Tuple<string,string>("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\Explorer", "thumbcache_*.db"),
            new Tuple<string,string>("C:\\ProgramData\\Microsoft\\Windows Defender\\Scans\\History\\Results\\Resource", "*"),
            new Tuple<string,string>("C:\\ProgramData\\Microsoft\\Windows Defender\\Scans\\History\\Results\\Quick", "*"),
            new Tuple<string, string>("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft\\Windows\\WebCache", "*.log"),
            new Tuple<string, string>("C:\\Windows\\Microsoft.NET", "*.log"),
            new Tuple<string, string>("C:\\Windows\\", "MEMORY.DMP"),
            new Tuple<string, string>("C:\\Users\\" + User + "\\AppData\\Local\\Microsoft", "CLR_*"),
            new Tuple<string, string>("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft", "CLR_*"),
            new Tuple<string, string>("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft", "CLR_*"),
            new Tuple<string, string>("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319", "*.log" )
        };

    }
}