using DevIdent.Classes;
using DevIdent.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevIdent.Forms
{
    public partial class MainForm : Form
    {
        #region Работа с главной формой

        #region Права администратора

        private static bool IsAdministrator()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        #endregion

        #region Изменение формы если не админ

        private static void ReconForm()
        {
            Info.label1.Text = "Отсутствуют права администратора";
            Info.label2.Text = "Функции удаления и очистки отключены";
            Info.OkButton.Size = new Size(125, 25);
            Info.OkButton.Location = new Point(88, 90);
            Info.OkButton.Visible = true;
        }

        #endregion

        #region Форма

        public MainForm()
        {
            InitializeComponent();
            ContentPanel.DoubleClick += (s, e) => CenterToScreen();
            MenuPanel.DoubleClick += (s, e) => CenterToScreen();
            TitleLabel.Click += (s, e) => Process.Start("https://github.com/Isafu");

            foreach (Label label in MenuPanel.Controls.OfType<Label>())
            {
                label.MouseEnter += (s, e) => { label.Font = new Font("Consolas", 12, FontStyle.Underline); };
            }

            foreach (Label label in MenuPanel.Controls.OfType<Label>())
            {
                label.MouseLeave += (s, e) => { label.Font = new Font("Consolas", 12); };
            }

            foreach (PictureBox picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) => { picture.BackColor = Settings.Default.ColorButtonsHover; };
                picture.MouseLeave += (s, e) => { picture.BackColor = Settings.Default.ColorButtonsDefault; };
            }

            Click += (s, e) => { BringToFront(); };

        }

        #endregion

        #region Свернуть и развернуть при нажатии на иконку

        private const int WsMinimizebox = 0x20000;
        private const int CsDblclks = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WsMinimizebox;
                cp.ClassStyle |= CsDblclks;
                return cp;
            }
        }

        #endregion

        #region Загрузка формы

        private void MainForm_Load(object sender, EventArgs e)
        {
            Parallel.Invoke(
                () => Processor.GetCpuinfo(new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor")),
                () => OS.GetSysInfo(),
                () => BIOS.GetBIOSInfo(new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS")),
                () => VideoController.GetVideoInfo(new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController")),
                () => RAM.GetRamInfo(new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory")),
                () => MotherBoard.GetMotherBoardInfo(new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard")),
                () => GetDiskInfo()
                );
            SysInfoLabel_Click(sender, e);
            FormSettings();
            BringToFront();
            if (!IsAdministrator())
            {
                MenuPanel.Controls.Remove(SysClearBtn);
                MenuPanel.Controls.Remove(UninstallBtn);
                MenuPanel.Controls.Remove(ServicesBtn);
                MenuPanel.Controls.Remove(AutorunBtn);
                BrowserBtn.Location = new Point(10, 220);
                if (OS.counter == 0)
                {
                    OS.counter++;
                    ReconForm();
                    Info.Show();
                }
            }
        }

        #endregion

        #endregion

        #region Скрытие и появление Label

        private void LabelVisible(int start, int end, bool visible)
        {
            for (int i = start; i < end + 1; i++)
            {
                ContentPanel.Controls["InfoLb" + i].Visible = visible;
            }
        }

        #region Трей

        private void TurnBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            _sensorForm.Show();
        }

        #endregion Трей

        #region Настройка формы

        private void FormSettings()
        {
            Width = 650;
            Controls.Add(MenuPanel);
            Controls.Add(ContentPanel);
            Opacity = 0.85;
            ContentPanel.BackColor = Settings.Default.ColorPanel;
            MenuPanel.BackColor = Settings.Default.ColorMenu;
            BackColor = Settings.Default.ColorForm;
            
            foreach (PictureBox picture in Controls.OfType<PictureBox>())
            {
                picture.ChangeColor(Settings.Default.ColorButtonsDefault);
            }
            colorEditor1.Color = Settings.Default.ColorForm;
        }

        #endregion Настройка формы

        #region Перемещение формы

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion Перемещение формы

        #region Закрытие программы

        private void CloseBth_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Закрытие программы

        #endregion

        #region Компоненты

        #region Обработчик нажатия

        private void ClickOnComponent(int countOfLines, string[] array)
        {
            for (int i = 1; i < countOfLines; i++)
            {
                ContentPanel.Controls["InfoLb" + i].Text = array[i - 1];
            }
        }

        #endregion

        #region Система

        private void SysInfoLabel_Click(object sender, EventArgs e)
        {
            LabelVisible(1, 8, true);
            LabelVisible(8, 12, false);
            ClickOnComponent(8, OS.sysInfoList);
        }

        #endregion Система

        #region БИОС

        private void BiosBtn_Click(object sender, EventArgs e)
        {
            LabelVisible(1, 7, true);
            LabelVisible(7, 12, false);
            ClickOnComponent(7, BIOS.biosInfoList);
        }

        #endregion БИОС

        #region Материнская плата

        private void MotherBoardBtn_Click(object sender, EventArgs e)
        {
            LabelVisible(1, 6, true);
            LabelVisible(6, 12, false);
            ClickOnComponent(6, MotherBoard.motherBoardInfoList);
        }

        #endregion Материнская плата

        #region Процессор

        private void CPUInfoLabel_Click(object sender, EventArgs e)
        {
            LabelVisible(1, 7, true);
            LabelVisible(8, 9, false);
            ClickOnComponent(8, Processor.cpuInfoList);
        }

        #endregion

        #region Видеокарта

        private void VideoInfoLabel_Click(object sender, EventArgs e)
        {
            LabelVisible(1, 7, true);
            LabelVisible(8, 12, false);
            ClickOnComponent(8, VideoController.videoInfoList);
        }

        #endregion

        #region ОЗУ

        private void RAMInfoLb_Click(object sender, EventArgs e)
        {
            LabelVisible(1, 6, true);
            LabelVisible(7, 12, false);
            ClickOnComponent(7, RAM.ramInfoList);
        }

        #endregion ОЗУ

        #region Винчестер

        public static readonly List<string> driveInfoList = new List<string>();
        public static bool check = false;
        public static DriveInfo[] drives = DriveInfo.GetDrives();

        private static void GetDiskInfo()
        {
            driveInfoList.Clear();
            drives = DriveInfo.GetDrives();
            int i = 0;
            try
            {
                foreach (DriveInfo drive in drives)
                {
                    try
                    {
                        driveInfoList.Add("Диск " + drives[i].Name + ", общий объем: " + drives[i].TotalSize / 1073741824
                            + " ГБ" + ", доступный объем: " + drives[i].AvailableFreeSpace / 1073741824 +
                        " ГБ" + Environment.NewLine + "Файловая система: " + drives[i].DriveFormat);
                    }
                    catch
                    {
                        driveInfoList.Add("Не удалось получить инфомацию о диске " + drives[i].Name);
                    }
                    i++;
                }
            }

            catch
            {

            }
        }

        private void DiskInfoBtn_Click(object sender, EventArgs e)
        {
            GetDiskInfo();
            LabelVisible(1, driveInfoList.Count + 1, true);
            LabelVisible(driveInfoList.Count + 1, 12, false);
            ClickOnComponent(driveInfoList.Count + 1, driveInfoList.ToArray());
        }

        #endregion Винчестер

        #endregion

        #region Работа с очисткой

        private static readonly InfoForm Info = new InfoForm();

        #region Очистка браузера

        private void BrowserWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify(((UniversalCleaner.browserSize) / 1048576) > 1024 ? "Браузеры: очищено " + (UniversalCleaner.browserSize) / 1073741824
                   + " ГБ" : "Браузеры: очищено " + (UniversalCleaner.browserSize) / 1048576 + " МБ", Resources.Close);
        }

        private void BrowserBtn_Click(object sender, EventArgs e)
        {
            BackgroundWorker _browserWorker = new BackgroundWorker();
            _browserWorker.DoWork += CleanBrowser;
            _browserWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BrowserWorkerCompleted);
            _browserWorker.RunWorkerAsync();
            Notify.ShowNotify("Начало очистки браузеров, подождите", Resources.Close);
        }

        private void CleanBrowser(object sender, DoWorkEventArgs e)
        {
            UniversalCleaner.browserSize = 0;
            long length = 0;
            for (int i = 0; i < Browser.directoryOfChrome.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.DirectoryCleaner(Browser.directoryOfChrome[i]);
            }
            for (int i = 0; i < Browser.directoryOfGx.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.DirectoryCleaner(Browser.directoryOfGx[i]);
            }
            for (int i = 0; i < Browser.directoryOfOpera.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.DirectoryCleaner(Browser.directoryOfOpera[i]);
            }
            UniversalCleaner.size = 0;
            length += UniversalCleaner.FileCleaner(Browser.operaGxCachePathes);
            UniversalCleaner.size = 0;
            length += UniversalCleaner.FileCleaner(Browser.chromeCachePathes);
            UniversalCleaner.size = 0;
            length += UniversalCleaner.FileCleaner(Browser.operaCachePathes);
            UniversalCleaner.browserSize = length;
            UniversalCleaner.size = 0;
        }

        #endregion

        #region Очистка системы

        private void CleanSystem(object sender, DoWorkEventArgs e)
        {
            UniversalCleaner.sysSize = 0;
            long length = 0;
            for (int i = 0; i < SystemCleaner.directoryPathes.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.DirectoryCleaner(SystemCleaner.directoryPathes[i]);
            }
            UniversalCleaner.size = 0;
            length += UniversalCleaner.FileCleaner(SystemCleaner.filePathes);
            UniversalCleaner.size = 0;
            UniversalCleaner.sysSize = length;
        }

        public void SysClearBtn_Click(object sender, EventArgs e)
        {
            BackgroundWorker _sysWorker = new BackgroundWorker();
            _sysWorker.DoWork += CleanSystem;
            _sysWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SysWorkerCompleted);
            _sysWorker.RunWorkerAsync();
            Notify.ShowNotify("Начало очистки системы, подождите", Resources.Close);
        }

        private void SysWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify(((UniversalCleaner.sysSize) / 1048576) > 1024 ? "Система: очищено " + (UniversalCleaner.sysSize) / 1073741824
                   + " ГБ" : "Система: очищено " + (UniversalCleaner.sysSize) / 1048576 + " МБ", Resources.Close);
        }

        #endregion

        #endregion

        #region Побочные формы

        #region Сенсор форма

        public SensorForm _sensorForm;

        private void SensorBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            _sensorForm = new SensorForm();
            _sensorForm.Show();
        }

        #endregion

        #region Службы

        public ServicesForm _servicesForm;

        private void ServicesLb_Click(object sender, EventArgs e)
        {
            if (_servicesForm == null || _servicesForm.IsDisposed)
            {
                _servicesForm = new ServicesForm(this);
                _servicesForm.Show();
            }
            else
            {
                _servicesForm.Show();
                _servicesForm.Focus();
            }
        }

        #endregion Службы

        #region Uninstall Форма

        public UninstallForm _uninstallForm;

        private void UninstallBtn_Click(object sender, EventArgs e)
        {
            if (_uninstallForm == null || _uninstallForm.IsDisposed)
            {
                _uninstallForm = new UninstallForm(this);
                _uninstallForm.Show();
            }
            else
            {
                _uninstallForm.Show();
                _uninstallForm.Focus();
            }
        }

        #endregion

        #endregion

        private void ОчисткаStripMenuItem1_Click(object sender, EventArgs e)
        {
            SysClearBtn_Click(sender, e);
        }

        private void БраузерыStripMenuItem1_Click(object sender, EventArgs e)
        {
            BrowserBtn_Click(sender, e);
        }

        public AutorunForm _autorunForm;

        private void AutorunBtn_Click(object sender, EventArgs e)
        {
            if (_autorunForm == null || _autorunForm.IsDisposed)
            {
                _autorunForm = new AutorunForm(this);
                _autorunForm.Show();
            }
            else
            {
                _autorunForm.Show();
                _autorunForm.Focus();
            }
        }

        private void ChangeFormStyle()
        {
            if (_servicesForm != null)
            {
                _servicesForm.FormSettings();
            }
            if (_uninstallForm != null)
            {
                _uninstallForm.FormSettings();
            }
            if (_sensorForm != null)
            {
                _sensorForm.FormSettings();
            }
            if (_autorunForm != null)
            {
                _autorunForm.FormSettings();
            }
        }

        private void SetTheme_Click(object sender, EventArgs e)
        {
            var color = colorEditor1.Color;
            ThemeChanger.SetUserTheme(color);
            this.ChangeColor(color);
            ContentPanel.ChangeColor(ThemeChanger.panelColor);
            TransparencyKey = Color.FromArgb(Math.Min(Math.Abs(color.R - 13), 255), Math.Min(Math.Abs(color.G - 12), 255), Math.Min(Math.Abs(color.B - 11), 255));
            InvPanel.BackColor = TransparencyKey;
            MenuPanel.ChangeColor(ThemeChanger.contentColor);
            foreach (PictureBox button in this.Controls.OfType<PictureBox>())
            {
                button.ChangeColor(ThemeChanger.buttonColor);
            }
            ChangeFormStyle();
        }

        private void SetDefaultTheme_Click(object sender, EventArgs e)
        {
            ContentPanel.BackColor = Color.FromArgb(23, 28, 42);
            MenuPanel.BackColor = Color.FromArgb(29, 34, 47);
            BackColor = Color.FromArgb(0, 0, 125);
            foreach (PictureBox button in this.Controls.OfType<PictureBox>())
            {
                button.ChangeColor(Color.FromArgb(0, 0, 200));
            }
            ThemeChanger.SetDefaultTheme();
            colorEditor1.Color = Settings.Default.ColorForm;
            ChangeFormStyle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Width = 950;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Width = 650;
        }
    }
}