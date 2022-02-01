using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DevIdent.Classes
{
    public class UniversalCleaner
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DeleteFile(string lpFileName);

        public static long size = 0;
        public static long sysSize = 0;
        public static long browserSize = 0;

        public static void DirectoryCleanerWithoutSize(DirectoryInfo folder)
        {
            if (!Directory.Exists(folder.FullName)) return;
            DirectoryInfo directoryInfo = new DirectoryInfo(folder.FullName);
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach (FileInfo file in fileInfo)
            {
                try
                {
                    DeleteFile(file.FullName);
                }
                catch
                {

                }
            }
            foreach (DirectoryInfo directory in directories)
            {
                DirectoryCleanerWithoutSize(directory);
            }
            if (directoryInfo.GetDirectories().Length == 0 && directoryInfo.GetFiles().Length == 0)
            {
                try
                {
                    directoryInfo.Delete();
                    Notify.ShowNotify("Директория удалена", Properties.Resources.Close);
                }
                catch
                {
                }
            }
        }

        public static long DirectoryCleaner(DirectoryInfo folder)
        {
            if (!Directory.Exists(folder.FullName))
            {
                return 0;
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(folder.FullName);
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            FileInfo[] filesInfo = directoryInfo.GetFiles();
            foreach (FileInfo file in filesInfo)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(file.FullName);
                    long fileSize = fileInfo.Length;
                    DeleteFile(file.FullName);
                    size += fileSize;
                    File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + fileInfo.FullName);
                }
                catch
                {

                }
            }
            foreach (DirectoryInfo directory in directories)
            {
                DirectoryCleaner(directory);
            }
            if (directoryInfo.GetDirectories().Length == 0 && directoryInfo.GetFiles().Length == 0)
            {
                try
                {
                    directoryInfo.Delete();
                    File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + directoryInfo.FullName);
                }
                catch
                {
                }
            }
            return size;
        }

        public static long FileCleaner(Tuple<string, string> table)
        {
            if (!Directory.Exists(table.Item1))
            {
                return 0;
            }
            try
            {
                foreach (string file in Directory.GetFiles(table.Item1, table.Item2))
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        long fileSize = fileInfo.Length;
                        DeleteFile(file);
                        size += fileSize;
                        File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + fileInfo.FullName);
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
            return size;
        }

        public static long FileCleaner(string path)
        {
            if (!File.Exists(path))
            {
                return 0;
            }
            try
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(path);
                    long fileSize = fileInfo.Length;
                    DeleteFile(path);
                    size += fileSize;
                    File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + fileInfo.FullName);
                }
                catch
                {
                }
            }
            catch
            {
            }
            return size;
        }

    }
}
