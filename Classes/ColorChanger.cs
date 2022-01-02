using System.Drawing;
using System.Windows.Forms;

namespace DevIdent.Classes
{
    public static class ColorChanger
    {
        #region Изменение цвета

        public static void ChangeColor(Control control, byte r, byte g, byte b)
        {
            control.BackColor = Color.FromArgb(r, g, b);
        }

        public static void ChangeColor(this Control control, Color color)
        {
            control.BackColor = color;
        }

        #endregion
    }
}