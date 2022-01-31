using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DevIdent.Classes
{
    static class NotepadMessager
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        public static void SendMessage(string line)
        {
            var notepad = Process.Start("notepad.exe");
            notepad.WaitForInputIdle();
            SendMessage(FindWindowEx(notepad.MainWindowHandle, new IntPtr(0), "Edit", null), 0x000C, 0, line);
        }
    }
}
