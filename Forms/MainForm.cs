using DevIdent.Classes;
using DevIdent.Properties;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        #region Форма

        public MainForm()
        {
            InitializeComponent();
            if (Settings.Default.ResetParams == 0)
            {
                Settings.Default.Reset();
                Settings.Default.ResetParams = 1;
            }
            ContentPanel.DoubleClick += (s, e) => CenterToScreen();
            MenuPanel.DoubleClick += (s, e) => CenterToScreen();
            TitleLabel.Click += (s, e) => Process.Start("https://github.com/Isafu");

            foreach (var label in MenuPanel.Controls.OfType<Label>())
                label.MouseEnter += (s, e) => { label.Font = new Font("Consolas", 12, FontStyle.Underline); };

            foreach (var label in MenuPanel.Controls.OfType<Label>())
                label.MouseLeave += (s, e) => { label.Font = new Font("Consolas", 12); };

            foreach (var picture in Controls.OfType<PictureBox>())
            {
                picture.MouseEnter += (s, e) => { picture.ChangeColor(Settings.Default.ColorButtonsHover); };
                picture.MouseLeave += (s, e) => { picture.ChangeColor(Settings.Default.ColorButtonsDefault); };
            }

            Click += (s, e) => { BringToFront(); };
        }

        #endregion

        #region Загрузка формы

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormSettings();
            if (!IsAdministrator())
            {
                MenuPanel.Controls.Remove(SysClearBtn);
                MenuPanel.Controls.Remove(UninstallBtn);
                MenuPanel.Controls.Remove(ServicesBtn);
                MenuPanel.Controls.Remove(AutorunBtn);
                MenuPanel.Controls.Remove(BrowserBtn);
                Notify.ShowNotify("Без прав администратора некоторые функции отключены", Resources.Close);
            }
            Parallel.Invoke(
                () => Processor.GetCpuinfo(),
                () => OS.GetSysInfo(),
                () => BIOS.GetBIOSInfo(),
                () => VideoController.GetVideoInfo(),
                () => RAM.GetRamInfo(),
                () => MotherBoard.GetMotherBoardInfo(),
                () => Network.GetNetworkInformation()
            );
            SysInfoLabel_Click(sender, e);
            BringToFront();
        }

        #endregion

        #endregion

        #region Трей

        private void TurnBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Трей

        #region Настройка формы

        #region Убрать мерцаниеы

        protected override CreateParams CreateParams
        {
            get
            {
                var handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        #endregion

        private void FormSettings()
        {
            CurrentOpacityValueLb.Text = Settings.Default.Opacity * 100 + "%";
            OpacityBar.Value = (int)(Settings.Default.Opacity * 100);
            Opacity = Settings.Default.Opacity;
            Controls.Add(MenuPanel);
            Controls.Add(ContentPanel);
            MenuPanel.ChangeColor(Settings.Default.ColorMenu);
            ContentPanel.ChangeColor(Settings.Default.ColorContent);
            this.ChangeColor(Settings.Default.ColorForm);
            foreach (var picture in Controls.OfType<PictureBox>())
                picture.ChangeColor(Settings.Default.ColorButtonsDefault);
            ColorEditor.Color = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
        }

        #region Тема для окон

        private void ChangeFormStyle()
        {
            if (_servicesForm != null) _servicesForm.FormSettings();
            if (_uninstallForm != null) _uninstallForm.FormSettings();
            if (_autorunForm != null) _autorunForm.FormSettings();
        }

        private void SetTheme_Click(object sender, EventArgs e)
        {
            var color = ColorEditor.Color;
            Opacity = (double)OpacityBar.Value / 100;
            ThemeChanger.SetUserTheme(color, OpacityBar.Value);
            this.ChangeColor(string.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B));
            MenuPanel.ChangeColor(Settings.Default.ColorMenu);
            ContentPanel.ChangeColor(Settings.Default.ColorContent);
            foreach (var button in Controls.OfType<PictureBox>())
                button.ChangeColor(Settings.Default.ColorButtonsDefault);
            ChangeFormStyle();
        }

        private void SetDefaultTheme_Click(object sender, EventArgs e)
        {
            Opacity = 0.85;
            CurrentOpacityValueLb.Text = "85%";
            OpacityBar.Value = 85;
            ContentPanel.BackColor = ColorTranslator.FromHtml("#171c2a");
            MenuPanel.BackColor = ColorTranslator.FromHtml("#1d222f");
            BackColor = ColorTranslator.FromHtml("#00007d");
            foreach (var button in Controls.OfType<PictureBox>()) button.ChangeColor("0000c8");
            ThemeChanger.SetDefaultTheme();
            ColorEditor.Color = ColorTranslator.FromHtml("#" + Settings.Default.ColorForm.Replace("#", string.Empty));
            ChangeFormStyle();
        }

        private void OpacityBar_Scroll(object sender, EventArgs e)
        {
            CurrentOpacityValueLb.Text = OpacityBar.Value + "%";
            Settings.Default.Opacity = (double)OpacityBar.Value / 100;
            ChangeFormStyle();
            Opacity = Settings.Default.Opacity;
            Settings.Default.Save();
        }

        private void ColorEditor_ColorChanged(object sender, EventArgs e)
        {
            CurrentColorBtn.BackColor = ColorEditor.Color;
        }

        private void OpenThemeEditorBtn_Click(object sender, EventArgs e)
        {
            Width = 950;
        }

        private void CloseThemeEditorBtn_Click(object sender, EventArgs e)
        {
            Width = 650;
        }

        #endregion

        #region Перемещение формы

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            var m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        #endregion Перемещение формы

        #endregion

        #region Закрытие программы

        private void CloseBth_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Закрытие программы

        #region Компоненты

        #region Обработчик нажатия

        private void FirstLabel_Click(object sender, EventArgs e)
        {
            if (((Label)sender).Height > Height)
            {
                ((Label)sender).Text = "Слишком большое кол-во адаптеров, кликните для доп. информации";
            }
            else if (((Label)sender).Text.Contains("Кликните по тексту, чтобы получить доп. информацию о сети"))
            {
                Network.GetAdvancedNetworkInformation();
            }
            else if (((Label)sender).Text.Contains("Слишком большое кол-во адаптеров, кликните для доп. информации"))
            {
                Network.GetAdvancedNetworkInformation();
            }
        }

        private void ClickOnComponent(string[] array)
        {
            ContentPanel.Controls.Clear();
            for (var i = 0; i < array.Length; i++)
            {
                Label label = new Label
                {
                    Name = "InfoLb" + i,
                    Location = new Point(10, 10 + ((i) * 30)),
                    Font = new Font("Consolas", 9),
                    FlatStyle = FlatStyle.Flat,
                    AutoSize = true,
                    Text = array[i]

                };
                ContentPanel.Controls.Add(label);
            }
            ContentPanel.Controls[0].Click += FirstLabel_Click;
        }

        #endregion

        #region Система

        private void SysInfoLabel_Click(object sender, EventArgs e)
        {
            ClickOnComponent(OS.sysInfoList);
        }

        #endregion

        #region БИОС

        private void BiosBtn_Click(object sender, EventArgs e)
        {
            ClickOnComponent(BIOS.biosInfoList);
        }

        #endregion

        #region Материнская плата

        private void MotherBoardBtn_Click(object sender, EventArgs e)
        {
            ClickOnComponent(MotherBoard.motherBoardInfoList);
        }

        #endregion

        #region Процессор

        private void CPUInfoLabel_Click(object sender, EventArgs e)
        {
            ClickOnComponent(Processor.cpuInfoList);
        }

        #endregion

        #region Видеокарта

        private void VideoInfoLabel_Click(object sender, EventArgs e)
        {
            ClickOnComponent(VideoController.videoInfoList);
        }

        #endregion

        #region ОЗУ

        private void RAMInfoLb_Click(object sender, EventArgs e)
        {
            ClickOnComponent(RAM.ramInfoList);
        }

        #endregion

        #region Винчестер

        private void DiskInfoBtn_Click(object sender, EventArgs e)
        {
            Drives.GetDiskInfo();
            ClickOnComponent(Drives.drivesInfo);
        }

        #endregion

        #region Сеть

        private void NetworkBtn_Click(object sender, EventArgs e)
        {
            ClickOnComponent(Network.networkInfoList);
        }

        #endregion

        #region Настройка винды

        private void WinSettinsBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            for (int i = 0; i < 11; i++)
            {
                int check = 0;
                CheckBox box = new CheckBox();
                for (int j = 0; j < WindowsSettings.registyInfo[i].Count; j++)
                {
                    switch (WindowsSettings.registyInfo[i][j].Item1)
                    {

                        case "CurrentUser":
                            if (Registry.CurrentUser.OpenSubKey(WindowsSettings.registyInfo[i][j].Item2) != null)
                            {
                                if (Registry.CurrentUser.OpenSubKey(WindowsSettings.registyInfo[i][j].Item2, true)
                                    .GetValue(WindowsSettings.registyInfo[i][j].Item3) != null 
                                    && Registry.CurrentUser.OpenSubKey(WindowsSettings.registyInfo[i][j].Item2, true)
                                    .GetValue(WindowsSettings.registyInfo[i][j].Item3).Equals(WindowsSettings.registyInfo[i][j].Item4))
                                {
                                    check++;
                                }
                            }
                            break;

                        case "LocalMachine":
                            if (Registry.LocalMachine.OpenSubKey(WindowsSettings.registyInfo[i][j].Item2) != null)
                            {
                                if (Registry.LocalMachine.OpenSubKey(WindowsSettings.registyInfo[i][j].Item2, true)
                                    .GetValue(WindowsSettings.registyInfo[i][j].Item3) != null 
                                    && Registry.LocalMachine.OpenSubKey(WindowsSettings.registyInfo[i][j].Item2, true)
                                    .GetValue(WindowsSettings.registyInfo[i][j].Item3).Equals(WindowsSettings.registyInfo[i][j].Item4))
                                {
                                    check++;
                                }
                            }
                            break;
                    }
                }
                if (check == WindowsSettings.registyInfo[i].Count)
                {
                    box.Font = new Font("Consolas", 9, FontStyle.Strikeout);
                    box.Checked = true;
                }
                else
                {
                    box.Font = new Font("Consolas", 9);
                }
                box.Location = new Point(35, 10 + i * 30);
                box.Name = "CheckBox" + (i + 1);
                box.FlatStyle = FlatStyle.Flat;
                box.Text = WindowsSettings.settingInfo[i].Item1;
                box.MouseEnter += HelpInfo;
                box.MouseLeave += DeleteInfo;
                box.AutoSize = true;
                PictureBox picture = new PictureBox
                {
                    Location = new Point(10, 10 + i * 30),
                    Size = new Size(15, 15),
                    Name = "Picture" + (i + 1),
                    Image = Resources.Remove
                };
                picture.Click += RemoveSetting_Click;
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(picture, "Нажатие восстанавливает значение по умолчанию");
                ContentPanel.Controls.Add(picture);
                ContentPanel.Controls.Add(box);
            }
            Label acceptLb = new Label
            {
                Name = "AcceptSettingsLb",
                Location = new Point(10, 340),
                Font = new Font("Consolas", 12),
                AutoSize = true,
                Text = "Применить настройки"
            };
            acceptLb.Click += AcceptLb_Click;
            ContentPanel.Controls.Add(acceptLb);

            Label label = new Label
            {
                Name = "HelpLb",
                Location = new Point(10, 370),
                Font = new Font("Consolas", 10),
                Size = new Size(465, 100)
            };
            ContentPanel.Controls.Add(label);
        }

        private void AcceptLb_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                var checkBox = ContentPanel.Controls.OfType<CheckBox>().SingleOrDefault(t => t.Name == "CheckBox" + (i + 1));
                if (checkBox.Checked)
                {
                    WindowsSettings.methods[i].Invoke(null, new object[] { true });
                    checkBox.Font = new Font("Consolas", 9, FontStyle.Strikeout);
                }
            }
        }

        private void RemoveSetting_Click(object sender, EventArgs e)
        {
            int index = int.Parse(((PictureBox)sender).Name.Replace("Picture", string.Empty)) - 1;
            WindowsSettings.methods[index].Invoke(null, new object[] { false });
            var checkBox = ContentPanel.Controls.OfType<CheckBox>().SingleOrDefault(t => t.Name == "CheckBox" + (index + 1));
            checkBox.Font = new Font("Consolas", 9);
            checkBox.Checked = false;
        }

        private void HelpInfo(object sender, EventArgs e)
        {
            int index = int.Parse(((CheckBox)sender).Name.Replace("CheckBox", string.Empty)) - 1;
            Label lb = Controls.Find("HelpLb", true).FirstOrDefault() as Label;
            lb.Text = WindowsSettings.settingInfo[index].Item2;
        }

        private void DeleteInfo(object sender, EventArgs e)
        {
            Label lb = Controls.Find("HelpLb", true).FirstOrDefault() as Label;
            lb.Text = "";
        }

        #endregion

        #endregion

        #region Работа с очисткой

        #region Очистка браузера

        private void BrowserWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify(UniversalCleaner.browserSize / 1048576 > 1024
                ? "Браузеры: очищено " + UniversalCleaner.browserSize / 1073741824
                                       + " ГБ"
                : "Браузеры: очищено " + UniversalCleaner.browserSize / 1048576 + " МБ", Resources.Close);
            File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + Environment.NewLine + DateTime.Now + "  || Конец очистки браузеров, размер удаленных данных: "
                + (UniversalCleaner.browserSize / 1048576 > 1024 ? UniversalCleaner.browserSize / 1073741824
                + " ГБ" : UniversalCleaner.browserSize / 1048576 + " МБ") + Environment.NewLine);
        }

        private void BrowserBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\DevLog.txt")) File.AppendAllText(@"C:\DevLog.txt", "Добро пожаловать " + Environment.NewLine);
            File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + DateTime.Now + "  || Начало очистки браузеров" + Environment.NewLine);
            var _browserWorker = new BackgroundWorker();
            _browserWorker.DoWork += CleanBrowser;
            _browserWorker.RunWorkerCompleted += BrowserWorkerCompleted;
            _browserWorker.RunWorkerAsync();
            Notify.ShowNotify("Начало очистки браузеров, подождите", Resources.Close);
        }

        private void CleanBrowser(object sender, DoWorkEventArgs e)
        {
            UniversalCleaner.browserSize = 0;
            long length = 0;

            for (int i = 0; i < BrowserCleaner.directoryOfChrome.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.DirectoryCleaner(BrowserCleaner.directoryOfChrome[i]);
            }

            for (int i = 0; i < BrowserCleaner.directoryOfOpera.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.DirectoryCleaner(BrowserCleaner.directoryOfOpera[i]);
            }

            for (int i = 0; i < BrowserCleaner.directoryOfGx.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.DirectoryCleaner(BrowserCleaner.directoryOfGx[i]);
            }

            for (int i = 0; i < BrowserCleaner.operaGxCachePathes.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.FileCleaner(BrowserCleaner.operaGxCachePathes[i]);
            }

            for (int i = 0; i < BrowserCleaner.chromeCachePathes.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.FileCleaner(BrowserCleaner.chromeCachePathes[i]);
            }

            for (int i = 0; i < BrowserCleaner.operaCachePathes.Length; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.FileCleaner(BrowserCleaner.operaCachePathes[i]);
            }
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
            for (int i = 0; i < SystemCleaner.filePathes.Count; i++)
            {
                UniversalCleaner.size = 0;
                length += UniversalCleaner.FileCleaner(SystemCleaner.filePathes[6]);
            }
            UniversalCleaner.size = 0;
            UniversalCleaner.sysSize = length;
        }

        public void SysClearBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\DevLog.txt")) File.AppendAllText(@"C:\DevLog.txt", "Добро пожаловать " + Environment.NewLine);
            File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + DateTime.Now + "  || Начало очистки системы" + Environment.NewLine);
            var _sysWorker = new BackgroundWorker();
            _sysWorker.DoWork += CleanSystem;
            _sysWorker.RunWorkerCompleted += SysWorkerCompleted;
            _sysWorker.RunWorkerAsync();
            Notify.ShowNotify("Начало очистки системы, подождите", Resources.Close);
        }

        private void SysWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Notify.ShowNotify(UniversalCleaner.sysSize / 1048576 > 1024
                ? "Система: очищено " + UniversalCleaner.sysSize / 1073741824
                                      + " ГБ"
                : "Система: очищено " + UniversalCleaner.sysSize / 1048576 + " МБ", Resources.Close);
            File.AppendAllText(@"C:\DevLog.txt", Environment.NewLine + Environment.NewLine + DateTime.Now + "  || Конец очистки системы, размер удаленных данных: "
                + (UniversalCleaner.sysSize / 1048576 > 1024 ? UniversalCleaner.sysSize / 1073741824
                + " ГБ" : UniversalCleaner.sysSize / 1048576 + " МБ") + Environment.NewLine);
        }

        #endregion

        #endregion

        #region Побочные формы

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

        #region Autorun Форма

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

        #endregion

        #endregion

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\DevLog.txt"))
            {
                Process.Start(@"C:\DevLog.txt");
            }
            else
            {
                Notify.ShowNotify("Файл не существует", Resources.Close);
            }
        }


    }
}