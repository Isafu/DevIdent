using System;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}