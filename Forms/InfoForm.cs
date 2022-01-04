using DevIdent.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            FormSettings();
            InitializeComponent();
            BringToFront();
        }

        private void FormSettings()
        {
            BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}