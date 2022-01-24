using DevIdent.Properties;
using System;
using System.Drawing;

namespace DevIdent.Classes
{
    internal static class ThemeChanger
    {
        public static void SetDefaultTheme()
        {
            Settings.Default.Opacity = 0.85;
            Settings.Default.ColorForm = $"{0:X2}{0:X2}{125:X2}";
            Settings.Default.ColorMenu = $"{29:X2}{34:X2}{47:X2}";
            Settings.Default.ColorButtonsDefault = $"{0:X2}{0:X2}{200:X2}";
            Settings.Default.ColorButtonsHover = $"{0:X2}{0:X2}{254:X2}";
            Settings.Default.ColorContent = $"{23:X2}{28:X2}{42:X2}";
            Settings.Default.Save();
        }

        public static void SetUserTheme(Color color, double opacity)
        {
            Settings.Default.Opacity = opacity / 100;

            Settings.Default.ColorContent =
                $"#{Math.Min(color.R + 5, 255):X2}{Math.Min(color.G + 5, 255):X2}{Math.Min(color.B + 5, 255):X2}";

            Settings.Default.ColorMenu =
                $"#{Math.Min(color.R + 20, 255):X2}{Math.Min(color.G + 20, 255):X2}{Math.Min(color.B + 20, 255):X2}";

            Settings.Default.ColorForm = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

            Settings.Default.ColorButtonsDefault =
                $"#{Math.Min(color.R + 40, 255):X2}{Math.Min(color.G + 40, 255):X2}{Math.Min(color.B + 40, 255):X2}";

            Settings.Default.ColorButtonsHover =
                $"#{Math.Min(color.R + 69, 255):X2}{Math.Min(color.G + 60, 255):X2}{Math.Min(color.B + 60, 255):X2}";

            Settings.Default.Save();
        }
    }
}