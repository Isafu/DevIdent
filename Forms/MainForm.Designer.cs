
namespace DevIdent.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.WinSettinsBtn = new System.Windows.Forms.Label();
            this.NetworkBtn = new System.Windows.Forms.Label();
            this.AutorunBtn = new System.Windows.Forms.Label();
            this.UninstallBtn = new System.Windows.Forms.Label();
            this.ServicesBtn = new System.Windows.Forms.Label();
            this.SysClearBtn = new System.Windows.Forms.Label();
            this.BrowserBtn = new System.Windows.Forms.Label();
            this.DiskInfoBtn = new System.Windows.Forms.Label();
            this.BiosBtn = new System.Windows.Forms.Label();
            this.MotherBoardBtn = new System.Windows.Forms.Label();
            this.RAMInfoBtn = new System.Windows.Forms.Label();
            this.VideoInfoBtn = new System.Windows.Forms.Label();
            this.CPUInfoBtn = new System.Windows.Forms.Label();
            this.SysInfoBtn = new System.Windows.Forms.Label();
            this.SetTheme = new System.Windows.Forms.Label();
            this.SetDefaultTheme = new System.Windows.Forms.Label();
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.ColorEditor = new Cyotek.Windows.Forms.ColorEditor();
            this.CurrentOpacityValueLb = new System.Windows.Forms.Label();
            this.CurrentOpacityLb = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.CurrentColorBtn = new System.Windows.Forms.Button();
            this.CurrentColorLb = new System.Windows.Forms.Label();
            this.OpenThemeEditorBtn = new System.Windows.Forms.PictureBox();
            this.TurnBtn = new System.Windows.Forms.PictureBox();
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.CloseThemeEditorBtn = new System.Windows.Forms.PictureBox();
            this.LogBtn = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LogEnabled = new System.Windows.Forms.CheckBox();
            this.InformationBtn = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.ThemePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenThemeEditorBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseThemeEditorBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(10, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(81, 19);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "DevIdent";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.MenuPanel.Controls.Add(this.WinSettinsBtn);
            this.MenuPanel.Controls.Add(this.NetworkBtn);
            this.MenuPanel.Controls.Add(this.AutorunBtn);
            this.MenuPanel.Controls.Add(this.UninstallBtn);
            this.MenuPanel.Controls.Add(this.ServicesBtn);
            this.MenuPanel.Controls.Add(this.SysClearBtn);
            this.MenuPanel.Controls.Add(this.BrowserBtn);
            this.MenuPanel.Controls.Add(this.DiskInfoBtn);
            this.MenuPanel.Controls.Add(this.BiosBtn);
            this.MenuPanel.Controls.Add(this.MotherBoardBtn);
            this.MenuPanel.Controls.Add(this.RAMInfoBtn);
            this.MenuPanel.Controls.Add(this.VideoInfoBtn);
            this.MenuPanel.Controls.Add(this.CPUInfoBtn);
            this.MenuPanel.Controls.Add(this.SysInfoBtn);
            this.MenuPanel.Location = new System.Drawing.Point(0, 30);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(175, 470);
            this.MenuPanel.TabIndex = 6;
            // 
            // WinSettinsBtn
            // 
            this.WinSettinsBtn.AutoSize = true;
            this.WinSettinsBtn.BackColor = System.Drawing.Color.Transparent;
            this.WinSettinsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WinSettinsBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinSettinsBtn.ForeColor = System.Drawing.Color.White;
            this.WinSettinsBtn.Location = new System.Drawing.Point(10, 400);
            this.WinSettinsBtn.Name = "WinSettinsBtn";
            this.WinSettinsBtn.Size = new System.Drawing.Size(162, 19);
            this.WinSettinsBtn.TabIndex = 19;
            this.WinSettinsBtn.Text = "Настройка Windows";
            this.WinSettinsBtn.Click += new System.EventHandler(this.WinSettingsBtn_Click);
            // 
            // NetworkBtn
            // 
            this.NetworkBtn.AutoSize = true;
            this.NetworkBtn.BackColor = System.Drawing.Color.Transparent;
            this.NetworkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetworkBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NetworkBtn.ForeColor = System.Drawing.Color.White;
            this.NetworkBtn.Location = new System.Drawing.Point(10, 220);
            this.NetworkBtn.Name = "NetworkBtn";
            this.NetworkBtn.Size = new System.Drawing.Size(45, 19);
            this.NetworkBtn.TabIndex = 18;
            this.NetworkBtn.Text = "Сеть";
            this.NetworkBtn.Click += new System.EventHandler(this.NetworkBtn_Click);
            // 
            // AutorunBtn
            // 
            this.AutorunBtn.AutoSize = true;
            this.AutorunBtn.BackColor = System.Drawing.Color.Transparent;
            this.AutorunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutorunBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorunBtn.ForeColor = System.Drawing.Color.White;
            this.AutorunBtn.Location = new System.Drawing.Point(10, 370);
            this.AutorunBtn.Name = "AutorunBtn";
            this.AutorunBtn.Size = new System.Drawing.Size(99, 19);
            this.AutorunBtn.TabIndex = 17;
            this.AutorunBtn.Text = "Автозапуск";
            this.AutorunBtn.Click += new System.EventHandler(this.AutorunBtn_Click);
            // 
            // UninstallBtn
            // 
            this.UninstallBtn.AutoSize = true;
            this.UninstallBtn.BackColor = System.Drawing.Color.Transparent;
            this.UninstallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UninstallBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UninstallBtn.ForeColor = System.Drawing.Color.White;
            this.UninstallBtn.Location = new System.Drawing.Point(10, 340);
            this.UninstallBtn.Name = "UninstallBtn";
            this.UninstallBtn.Size = new System.Drawing.Size(108, 19);
            this.UninstallBtn.TabIndex = 16;
            this.UninstallBtn.Text = "Удаление ПО";
            this.UninstallBtn.Click += new System.EventHandler(this.UninstallBtn_Click);
            // 
            // ServicesBtn
            // 
            this.ServicesBtn.AutoSize = true;
            this.ServicesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ServicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesBtn.ForeColor = System.Drawing.Color.White;
            this.ServicesBtn.Location = new System.Drawing.Point(10, 250);
            this.ServicesBtn.Name = "ServicesBtn";
            this.ServicesBtn.Size = new System.Drawing.Size(63, 19);
            this.ServicesBtn.TabIndex = 15;
            this.ServicesBtn.Text = "Службы";
            this.ServicesBtn.Click += new System.EventHandler(this.ServicesLb_Click);
            // 
            // SysClearBtn
            // 
            this.SysClearBtn.AutoSize = true;
            this.SysClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.SysClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SysClearBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SysClearBtn.ForeColor = System.Drawing.Color.White;
            this.SysClearBtn.Location = new System.Drawing.Point(10, 280);
            this.SysClearBtn.Name = "SysClearBtn";
            this.SysClearBtn.Size = new System.Drawing.Size(144, 19);
            this.SysClearBtn.TabIndex = 14;
            this.SysClearBtn.Text = "Очистка системы";
            this.SysClearBtn.Click += new System.EventHandler(this.SysClearBtn_Click);
            // 
            // BrowserBtn
            // 
            this.BrowserBtn.AutoSize = true;
            this.BrowserBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrowserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrowserBtn.ForeColor = System.Drawing.Color.White;
            this.BrowserBtn.Location = new System.Drawing.Point(10, 310);
            this.BrowserBtn.Name = "BrowserBtn";
            this.BrowserBtn.Size = new System.Drawing.Size(162, 19);
            this.BrowserBtn.TabIndex = 13;
            this.BrowserBtn.Text = "Очистка браузеров";
            this.BrowserBtn.Click += new System.EventHandler(this.BrowserBtn_Click);
            // 
            // DiskInfoBtn
            // 
            this.DiskInfoBtn.AutoSize = true;
            this.DiskInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.DiskInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiskInfoBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskInfoBtn.ForeColor = System.Drawing.Color.White;
            this.DiskInfoBtn.Location = new System.Drawing.Point(10, 190);
            this.DiskInfoBtn.Name = "DiskInfoBtn";
            this.DiskInfoBtn.Size = new System.Drawing.Size(90, 19);
            this.DiskInfoBtn.TabIndex = 12;
            this.DiskInfoBtn.Text = "Винчестер";
            this.DiskInfoBtn.Click += new System.EventHandler(this.DiskInfoBtn_Click);
            // 
            // BiosBtn
            // 
            this.BiosBtn.AutoSize = true;
            this.BiosBtn.BackColor = System.Drawing.Color.Transparent;
            this.BiosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiosBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BiosBtn.ForeColor = System.Drawing.Color.White;
            this.BiosBtn.Location = new System.Drawing.Point(10, 40);
            this.BiosBtn.Name = "BiosBtn";
            this.BiosBtn.Size = new System.Drawing.Size(45, 19);
            this.BiosBtn.TabIndex = 11;
            this.BiosBtn.Text = "БИОС";
            this.BiosBtn.Click += new System.EventHandler(this.BiosBtn_Click);
            // 
            // MotherBoardBtn
            // 
            this.MotherBoardBtn.AutoSize = true;
            this.MotherBoardBtn.BackColor = System.Drawing.Color.Transparent;
            this.MotherBoardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MotherBoardBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MotherBoardBtn.ForeColor = System.Drawing.Color.White;
            this.MotherBoardBtn.Location = new System.Drawing.Point(10, 70);
            this.MotherBoardBtn.Name = "MotherBoardBtn";
            this.MotherBoardBtn.Size = new System.Drawing.Size(144, 19);
            this.MotherBoardBtn.TabIndex = 10;
            this.MotherBoardBtn.Text = "Системная плата";
            this.MotherBoardBtn.Click += new System.EventHandler(this.MotherBoardBtn_Click);
            // 
            // RAMInfoBtn
            // 
            this.RAMInfoBtn.AutoSize = true;
            this.RAMInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.RAMInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RAMInfoBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMInfoBtn.ForeColor = System.Drawing.Color.White;
            this.RAMInfoBtn.Location = new System.Drawing.Point(10, 160);
            this.RAMInfoBtn.Name = "RAMInfoBtn";
            this.RAMInfoBtn.Size = new System.Drawing.Size(36, 19);
            this.RAMInfoBtn.TabIndex = 9;
            this.RAMInfoBtn.Text = "ОЗУ";
            this.RAMInfoBtn.Click += new System.EventHandler(this.RAMInfoLb_Click);
            // 
            // VideoInfoBtn
            // 
            this.VideoInfoBtn.AutoSize = true;
            this.VideoInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.VideoInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoInfoBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VideoInfoBtn.ForeColor = System.Drawing.Color.White;
            this.VideoInfoBtn.Location = new System.Drawing.Point(10, 130);
            this.VideoInfoBtn.Name = "VideoInfoBtn";
            this.VideoInfoBtn.Size = new System.Drawing.Size(99, 19);
            this.VideoInfoBtn.TabIndex = 8;
            this.VideoInfoBtn.Text = "Видеокарта";
            this.VideoInfoBtn.Click += new System.EventHandler(this.VideoInfoLabel_Click);
            // 
            // CPUInfoBtn
            // 
            this.CPUInfoBtn.AutoSize = true;
            this.CPUInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.CPUInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPUInfoBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUInfoBtn.ForeColor = System.Drawing.Color.White;
            this.CPUInfoBtn.Location = new System.Drawing.Point(10, 100);
            this.CPUInfoBtn.Name = "CPUInfoBtn";
            this.CPUInfoBtn.Size = new System.Drawing.Size(90, 19);
            this.CPUInfoBtn.TabIndex = 7;
            this.CPUInfoBtn.Text = "Процессор";
            this.CPUInfoBtn.Click += new System.EventHandler(this.CPUInfoLabel_Click);
            // 
            // SysInfoBtn
            // 
            this.SysInfoBtn.AutoSize = true;
            this.SysInfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.SysInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SysInfoBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SysInfoBtn.Location = new System.Drawing.Point(10, 10);
            this.SysInfoBtn.Name = "SysInfoBtn";
            this.SysInfoBtn.Size = new System.Drawing.Size(90, 19);
            this.SysInfoBtn.TabIndex = 7;
            this.SysInfoBtn.Text = "О системе";
            this.SysInfoBtn.Click += new System.EventHandler(this.SysInfoLabel_Click);
            // 
            // SetTheme
            // 
            this.SetTheme.AutoSize = true;
            this.SetTheme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetTheme.Location = new System.Drawing.Point(5, 190);
            this.SetTheme.Name = "SetTheme";
            this.SetTheme.Size = new System.Drawing.Size(90, 19);
            this.SetTheme.TabIndex = 14;
            this.SetTheme.Text = "Применить";
            this.SetTheme.Click += new System.EventHandler(this.SetTheme_Click);
            // 
            // SetDefaultTheme
            // 
            this.SetDefaultTheme.AutoSize = true;
            this.SetDefaultTheme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetDefaultTheme.Location = new System.Drawing.Point(5, 220);
            this.SetDefaultTheme.Name = "SetDefaultTheme";
            this.SetDefaultTheme.Size = new System.Drawing.Size(261, 19);
            this.SetDefaultTheme.TabIndex = 17;
            this.SetDefaultTheme.Text = "Вернуться к стандартной теме";
            this.SetDefaultTheme.Click += new System.EventHandler(this.SetDefaultTheme_Click);
            // 
            // ThemePanel
            // 
            this.ThemePanel.Controls.Add(this.ColorEditor);
            this.ThemePanel.Controls.Add(this.CurrentOpacityValueLb);
            this.ThemePanel.Controls.Add(this.CurrentOpacityLb);
            this.ThemePanel.Controls.Add(this.OpacityBar);
            this.ThemePanel.Controls.Add(this.CurrentColorBtn);
            this.ThemePanel.Controls.Add(this.CurrentColorLb);
            this.ThemePanel.Controls.Add(this.SetDefaultTheme);
            this.ThemePanel.Controls.Add(this.SetTheme);
            this.ThemePanel.Location = new System.Drawing.Point(650, 0);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(302, 269);
            this.ThemePanel.TabIndex = 18;
            // 
            // ColorEditor
            // 
            this.ColorEditor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorEditor.Location = new System.Drawing.Point(5, 5);
            this.ColorEditor.Name = "ColorEditor";
            this.ColorEditor.Size = new System.Drawing.Size(290, 104);
            this.ColorEditor.TabIndex = 25;
            this.ColorEditor.ColorChanged += new System.EventHandler(this.ColorEditor_ColorChanged);
            // 
            // CurrentOpacityValueLb
            // 
            this.CurrentOpacityValueLb.AutoSize = true;
            this.CurrentOpacityValueLb.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentOpacityValueLb.Location = new System.Drawing.Point(152, 173);
            this.CurrentOpacityValueLb.Name = "CurrentOpacityValueLb";
            this.CurrentOpacityValueLb.Size = new System.Drawing.Size(28, 15);
            this.CurrentOpacityValueLb.TabIndex = 24;
            this.CurrentOpacityValueLb.Text = "85%";
            // 
            // CurrentOpacityLb
            // 
            this.CurrentOpacityLb.AutoSize = true;
            this.CurrentOpacityLb.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentOpacityLb.Location = new System.Drawing.Point(5, 145);
            this.CurrentOpacityLb.Name = "CurrentOpacityLb";
            this.CurrentOpacityLb.Size = new System.Drawing.Size(126, 19);
            this.CurrentOpacityLb.TabIndex = 23;
            this.CurrentOpacityLb.Text = "Прозрачность:";
            // 
            // OpacityBar
            // 
            this.OpacityBar.AutoSize = false;
            this.OpacityBar.Location = new System.Drawing.Point(147, 145);
            this.OpacityBar.Maximum = 100;
            this.OpacityBar.Minimum = 85;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(155, 25);
            this.OpacityBar.SmallChange = 5;
            this.OpacityBar.TabIndex = 21;
            this.OpacityBar.TickFrequency = 5;
            this.OpacityBar.Value = 85;
            this.OpacityBar.Scroll += new System.EventHandler(this.OpacityBar_Scroll);
            // 
            // CurrentColorBtn
            // 
            this.CurrentColorBtn.Enabled = false;
            this.CurrentColorBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CurrentColorBtn.FlatAppearance.BorderSize = 2;
            this.CurrentColorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentColorBtn.Location = new System.Drawing.Point(155, 115);
            this.CurrentColorBtn.Name = "CurrentColorBtn";
            this.CurrentColorBtn.Size = new System.Drawing.Size(140, 25);
            this.CurrentColorBtn.TabIndex = 22;
            this.CurrentColorBtn.UseVisualStyleBackColor = true;
            // 
            // CurrentColorLb
            // 
            this.CurrentColorLb.AutoSize = true;
            this.CurrentColorLb.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentColorLb.Location = new System.Drawing.Point(5, 115);
            this.CurrentColorLb.Name = "CurrentColorLb";
            this.CurrentColorLb.Size = new System.Drawing.Size(144, 19);
            this.CurrentColorLb.TabIndex = 21;
            this.CurrentColorLb.Text = "Выбранный цвет:";
            // 
            // OpenThemeEditorBtn
            // 
            this.OpenThemeEditorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.OpenThemeEditorBtn.Image = global::DevIdent.Properties.Resources.Paint;
            this.OpenThemeEditorBtn.Location = new System.Drawing.Point(545, 0);
            this.OpenThemeEditorBtn.Name = "OpenThemeEditorBtn";
            this.OpenThemeEditorBtn.Size = new System.Drawing.Size(35, 30);
            this.OpenThemeEditorBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenThemeEditorBtn.TabIndex = 19;
            this.OpenThemeEditorBtn.TabStop = false;
            this.OpenThemeEditorBtn.Click += new System.EventHandler(this.OpenThemeEditorBtn_Click);
            // 
            // TurnBtn
            // 
            this.TurnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.TurnBtn.Image = global::DevIdent.Properties.Resources.Minimize;
            this.TurnBtn.Location = new System.Drawing.Point(580, 0);
            this.TurnBtn.Name = "TurnBtn";
            this.TurnBtn.Size = new System.Drawing.Size(35, 30);
            this.TurnBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnBtn.TabIndex = 14;
            this.TurnBtn.TabStop = false;
            this.TurnBtn.Click += new System.EventHandler(this.TurnBtn_Click);
            // 
            // CloseBth
            // 
            this.CloseBth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBth.Image = global::DevIdent.Properties.Resources.Close;
            this.CloseBth.Location = new System.Drawing.Point(615, 0);
            this.CloseBth.Name = "CloseBth";
            this.CloseBth.Size = new System.Drawing.Size(35, 30);
            this.CloseBth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBth.TabIndex = 4;
            this.CloseBth.TabStop = false;
            this.CloseBth.Click += new System.EventHandler(this.CloseBth_Click);
            // 
            // CloseThemeEditorBtn
            // 
            this.CloseThemeEditorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseThemeEditorBtn.Image = global::DevIdent.Properties.Resources.Back;
            this.CloseThemeEditorBtn.Location = new System.Drawing.Point(650, 470);
            this.CloseThemeEditorBtn.Name = "CloseThemeEditorBtn";
            this.CloseThemeEditorBtn.Size = new System.Drawing.Size(302, 30);
            this.CloseThemeEditorBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseThemeEditorBtn.TabIndex = 20;
            this.CloseThemeEditorBtn.TabStop = false;
            this.CloseThemeEditorBtn.Click += new System.EventHandler(this.CloseThemeEditorBtn_Click);
            // 
            // LogBtn
            // 
            this.LogBtn.AutoSize = true;
            this.LogBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogBtn.Location = new System.Drawing.Point(655, 275);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(162, 19);
            this.LogBtn.TabIndex = 21;
            this.LogBtn.Text = "Открыть .log файл";
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.ContentPanel.Location = new System.Drawing.Point(175, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(475, 470);
            this.ContentPanel.TabIndex = 7;
            // 
            // LogEnabled
            // 
            this.LogEnabled.AutoSize = true;
            this.LogEnabled.Font = new System.Drawing.Font("Consolas", 12F);
            this.LogEnabled.Location = new System.Drawing.Point(659, 305);
            this.LogEnabled.Name = "LogEnabled";
            this.LogEnabled.Size = new System.Drawing.Size(217, 23);
            this.LogEnabled.TabIndex = 22;
            this.LogEnabled.Text = "Включить логирование?";
            this.LogEnabled.UseVisualStyleBackColor = true;
            // 
            // InformationBtn
            // 
            this.InformationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.InformationBtn.Image = global::DevIdent.Properties.Resources.Question;
            this.InformationBtn.Location = new System.Drawing.Point(510, 0);
            this.InformationBtn.Name = "InformationBtn";
            this.InformationBtn.Size = new System.Drawing.Size(35, 30);
            this.InformationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InformationBtn.TabIndex = 23;
            this.InformationBtn.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.ControlBox = false;
            this.Controls.Add(this.InformationBtn);
            this.Controls.Add(this.LogEnabled);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.CloseThemeEditorBtn);
            this.Controls.Add(this.OpenThemeEditorBtn);
            this.Controls.Add(this.ThemePanel);
            this.Controls.Add(this.TurnBtn);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CloseBth);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevIdent";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ThemePanel.ResumeLayout(false);
            this.ThemePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenThemeEditorBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseThemeEditorBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox CloseBth;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label SysInfoBtn;
        private System.Windows.Forms.Label CPUInfoBtn;
        private System.Windows.Forms.Label VideoInfoBtn;
        private System.Windows.Forms.Label RAMInfoBtn;
        private System.Windows.Forms.Label MotherBoardBtn;
        private System.Windows.Forms.Label BiosBtn;
        private System.Windows.Forms.Label DiskInfoBtn;
        private System.Windows.Forms.Label BrowserBtn;
        private System.Windows.Forms.PictureBox TurnBtn;
        public System.Windows.Forms.Label ServicesBtn;
        public System.Windows.Forms.Label SysClearBtn;
        public System.Windows.Forms.Label UninstallBtn;
        public System.Windows.Forms.Label AutorunBtn;
        private System.Windows.Forms.Label SetTheme;
        private System.Windows.Forms.Label SetDefaultTheme;
        private System.Windows.Forms.Panel ThemePanel;
        private System.Windows.Forms.PictureBox OpenThemeEditorBtn;
        private System.Windows.Forms.PictureBox CloseThemeEditorBtn;
        private System.Windows.Forms.Label CurrentColorLb;
        private System.Windows.Forms.Button CurrentColorBtn;
        private System.Windows.Forms.Label CurrentOpacityLb;
        private System.Windows.Forms.Label CurrentOpacityValueLb;
        public System.Windows.Forms.TrackBar OpacityBar;
        private Cyotek.Windows.Forms.ColorEditor ColorEditor;
        private System.Windows.Forms.Label LogBtn;
        private System.Windows.Forms.Label NetworkBtn;
        private System.Windows.Forms.Panel ContentPanel;
        public System.Windows.Forms.Label WinSettinsBtn;
        private System.Windows.Forms.CheckBox LogEnabled;
        private System.Windows.Forms.PictureBox InformationBtn;
    }
}

