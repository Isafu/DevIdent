using System.Drawing;
using System.Windows.Forms;

namespace DevIdent.Classes
{
    public class ColorChanger
    {
        #region Изменение цвета

        public static void ChangeColor(Control control, byte r, byte g, byte b)
        {
            control.BackColor = Color.FromArgb(r, g, b);
        }

        #endregion
    }
}