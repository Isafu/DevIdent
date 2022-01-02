using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIdent.Classes
{
    internal class FormTheme
    {
        static void SetTheme()
        {
            Opacity = 0.85;
            ContentPanel.BackColor = Settings.Default.ColorContent;
            MenuPanel.BackColor = Settings.Default.ColorMenu;
            BackColor = Settings.Default.ColorForm;
            foreach (PictureBox button in this.Controls.OfType<PictureBox>())
            {
                button.ChangeColor(Settings.Default.ColorButtonsDefault);
            }
        }
    }
}
