using System;
using System.Collections;
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
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            foreach (FileInfo file in fileInfo)
            {
                try
                {
                    DeleteFile(file.FullName);
                    File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + file.FullName);
                    size += file.Length;
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

        public static long FileCleaner(Hashtable hashtable)
        {
            foreach (DictionaryEntry keyValue in hashtable)
            {
                if (!Directory.Exists((string)keyValue.Key))
                {
                    return 0;
                }
                try
                {
                    foreach (string file in Directory.GetFiles((string)keyValue.Key, (string)keyValue.Value))
                    {
                        try
                        {
                            DeleteFile(file);
                            File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + file);
                            size += new FileInfo(file).Length;
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }
            }

            return size;
        }

        public static long FileCleaner(string[] pathes)
        {
            foreach (string path in pathes)
            {
                if (!File.Exists(path))
                {
                    return 0;
                }

                try
                {
                    try
                    {
                        DeleteFile(path);
                        File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + path);
                        size += new FileInfo(path).Length;
                    }
                    catch
                    {
                    }
                }
                catch
                {
                }
            }
            return size;
        }

    }
}
