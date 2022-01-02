using DevIdent.Properties;
using System;
using System.Drawing;

namespace DevIdent.Classes
{
    internal static class ThemeChanger
    {
        public static Color contentColor;
        public static Color buttonColor;
        public static Color buttonHoverColor;
        public static Color panelColor;

        public static void SetDefaultTheme()
        {
            Settings.Default.ColorContent = Color.FromArgb(23, 28, 42);
            Settings.Default.ColorPanel = Color.FromArgb(29, 34, 47);
            Settings.Default.ColorMenu = Color.FromArgb(23, 28, 42);
            Settings.Default.ColorForm = Color.FromArgb(0, 0, 125);
            Settings.Default.ColorButtonsDefault = Color.FromArgb(0, 0, 200);
            Settings.Default.ColorButtonsHover = Color.FromArgb(0, 0, 255);
            Settings.Default.Save();
        }

        public static void SetUserTheme(Color color)
        {
            contentColor = Color.FromArgb(Math.Min((color.R + 20), 255), Math.Min((color.G + 20), 255), Math.Min((color.B + 20), 255));
            panelColor = Color.FromArgb(Math.Min(Math.Abs(color.R - 10), 255), Math.Min(Math.Abs(color.G - 10), 255), Math.Min(Math.Abs(color.B - 10), 255));
            contentColor = Color.FromArgb(Math.Min((color.R + 20), 255), Math.Min((color.G + 20), 255), Math.Min((color.B + 20), 255));
            buttonColor = Color.FromArgb(Math.Min((color.R + 40), 255), Math.Min((color.G + 40), 255), Math.Min((color.B + 40), 255));
            buttonHoverColor = Color.FromArgb(Math.Min((color.R + 69), 255), Math.Min((color.G + 60), 255), Math.Min((color.B + 60), 255));

            Settings.Default.ColorContent = contentColor;
            Settings.Default.ColorPanel = panelColor;
            Settings.Default.ColorMenu = contentColor;
            Settings.Default.ColorForm = color;
            Settings.Default.ColorButtonsDefault = buttonColor;
            Settings.Default.ColorButtonsHover = buttonHoverColor;
            Settings.Default.Save();
        }
    }
}
