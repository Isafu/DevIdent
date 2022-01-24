using DevIdent.Properties;
using NotificationManager;
using System.Drawing;

namespace DevIdent.Classes
{
    public static class Notify
    {
        private static readonly Manager notify = new Manager();

        public static void ShowNotify(string text, Image image)
        {
            notify.Font = new Font("Consolas", 12);
            notify.MaxTextWidth = 1000;
            notify.Alert(text, NotificationType.Custom,
                ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty)), image);
        }
    }
}