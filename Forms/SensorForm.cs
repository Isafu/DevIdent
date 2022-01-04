using DevIdent.Classes;
using DevIdent.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class SensorForm : Form
    {
        private static readonly MainForm Main = new MainForm();
        private static readonly ulong RamCapacity = RAM.GetRamCapacity();
        private static ulong _currentBusyCapacity;

        public SensorForm()
        {
            InitializeComponent();
            FormSettings();
            StartPositionOfForm();
            SensorInfoPanel.DoubleClick += (s, e) => StartPositionOfForm();
            SensorLb1.DoubleClick += (s, e) => StartPositionOfForm();
            SensorLb2.DoubleClick += (s, e) => StartPositionOfForm();
            foreach (PictureBox picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) => { picture.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorButtonsHover.Name); };
                picture.MouseLeave += (s, e) => { picture.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorButtonsDefault.Name); };
            }
        }

        public void FormSettings()
        {
            BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Name);
            SensorInfoPanel.BackColor = ColorTranslator.FromHtml("#" + Settings.Default.ColorContent.Name);
            foreach (PictureBox button in Controls.OfType<PictureBox>())
            {
                button.ChangeColor(ColorTranslator.FromHtml("#" + Settings.Default.ColorButtonsDefault.Name));
            }
        }

        #region Перемещение формы

        private void SensorForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion Перемещение формы

        #region Начальное положение формы

        private void StartPositionOfForm()
        {
            foreach (Screen scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(Location))
                {
                    Location = new Point(scrn.Bounds.Right - Width, scrn.Bounds.Top);
                    return;
                }
            }
        }

        #endregion Начальное положение формы

        #region Закрытие приложения

        private void AppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion Закрытие приложения

        #region Закрытие формы

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            Visible = false;
            Main.Show();
        }

        #endregion Закрытие формы

        #region Данные датчиков

        private void GetSensorInfo()
        {
            try
            {
                _currentBusyCapacity = RAM.GetBusyRamCapacity();
                SensorLb1.Text = "Объем занятой памяти ОЗУ: " + _currentBusyCapacity + " МБ";
            }
            catch
            {
                SensorLb1.Text = "";
            }

            try
            {
                SensorLb2.Text = "Объем свободной памяти ОЗУ: " + (RamCapacity - _currentBusyCapacity) + " МБ";
            }
            catch
            {
                SensorLb2.Text = "";
            }

            try
            {
                SensorLb3.Text = "Процент занятой памяти: " + RAM.GetProcentOfBusyRam() + "%";
            }
            catch
            {
                SensorLb3.Text = "";
            }
        }

        #endregion Данные датчиков

        #region Вывод значений датчиков

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            Invoke(new Action(GetSensorInfo));
        }

        #endregion Вывод значений датчиков

        #region Активация таймера

        private void SensorForm_Activated(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        #endregion Активация таймера

        #region Tray

        private void TurnBtn_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            WindowState = FormWindowState.Minimized;
        }

        private void MainInfo_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            Hide();
            Main.Visible = true;
        }

        #endregion Tray

        #region Загрузка и активация формы

        private void SensorForm_Load(object sender, EventArgs e)
        {
            GetSensorInfo();
        }

        private void SensorForm_Deactivate(object sender, EventArgs e)
        {
            BringToFront();
        }

        #endregion

    }
}