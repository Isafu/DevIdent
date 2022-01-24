using System.Drawing;
using System.Windows.Forms;

namespace DevIdent.Classes
{
    public static class ColorChanger
    {
        #region Изменение цвета

        public static void ChangeColor(this Control control, string color)
        {
            control.BackColor = ColorTranslator.FromHtml("#" + color.Replace("#", string.Empty));
        }

        #endregion
    }
}