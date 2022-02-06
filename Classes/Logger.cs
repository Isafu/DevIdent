using DevIdent.Properties;
using System.IO;

namespace DevIdent.Classes
{
    public static class Logger
    {

        public static void Log(string line)
        {
            if (Settings.Default.LogStatus == true)
            {
                File.AppendAllText("C:\\DevLog.txt", line);
            }
        }

    }
}
