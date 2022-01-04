
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.InfoLb12 = new System.Windows.Forms.Label();
            this.InfoLb11 = new System.Windows.Forms.Label();
            this.InfoLb10 = new System.Windows.Forms.Label();
            this.InfoLb9 = new System.Windows.Forms.Label();
            this.InfoLb1 = new System.Windows.Forms.Label();
            this.InfoLb2 = new System.Windows.Forms.Label();
            this.InfoLb3 = new System.Windows.Forms.Label();
            this.InfoLb4 = new System.Windows.Forms.Label();
            this.InfoLb5 = new System.Windows.Forms.Label();
            this.InfoLb6 = new System.Windows.Forms.Label();
            this.InfoLb7 = new System.Windows.Forms.Label();
            this.InfoLb8 = new System.Windows.Forms.Label();
            this.colorEditor1 = new Cyotek.Windows.Forms.ColorEditor();
            this.SetTheme = new System.Windows.Forms.Label();
            this.SetDefaultTheme = new System.Windows.Forms.Label();
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TurnBtn = new System.Windows.Forms.PictureBox();
            this.SensorBtn = new System.Windows.Forms.PictureBox();
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InvPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.ThemePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // AutorunBtn
            // 
            this.AutorunBtn.AutoSize = true;
            this.AutorunBtn.BackColor = System.Drawing.Color.Transparent;
            this.AutorunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutorunBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorunBtn.ForeColor = System.Drawing.Color.White;
            this.AutorunBtn.Location = new System.Drawing.Point(10, 340);
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
            this.UninstallBtn.Location = new System.Drawing.Point(10, 310);
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
            this.ServicesBtn.Location = new System.Drawing.Point(10, 220);
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
            this.SysClearBtn.Location = new System.Drawing.Point(10, 250);
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
            this.BrowserBtn.Location = new System.Drawing.Point(10, 280);
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
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.ContentPanel.Controls.Add(this.InfoLb12);
            this.ContentPanel.Controls.Add(this.InfoLb11);
            this.ContentPanel.Controls.Add(this.InfoLb10);
            this.ContentPanel.Controls.Add(this.InfoLb9);
            this.ContentPanel.Controls.Add(this.InfoLb1);
            this.ContentPanel.Controls.Add(this.InfoLb2);
            this.ContentPanel.Controls.Add(this.InfoLb3);
            this.ContentPanel.Controls.Add(this.InfoLb4);
            this.ContentPanel.Controls.Add(this.InfoLb5);
            this.ContentPanel.Controls.Add(this.InfoLb6);
            this.ContentPanel.Controls.Add(this.InfoLb7);
            this.ContentPanel.Controls.Add(this.InfoLb8);
            this.ContentPanel.Location = new System.Drawing.Point(175, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(475, 470);
            this.ContentPanel.TabIndex = 7;
            // 
            // InfoLb12
            // 
            this.InfoLb12.AutoSize = true;
            this.InfoLb12.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb12.Location = new System.Drawing.Point(10, 340);
            this.InfoLb12.Name = "InfoLb12";
            this.InfoLb12.Size = new System.Drawing.Size(0, 15);
            this.InfoLb12.TabIndex = 13;
            // 
            // InfoLb11
            // 
            this.InfoLb11.AutoSize = true;
            this.InfoLb11.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb11.Location = new System.Drawing.Point(10, 310);
            this.InfoLb11.Name = "InfoLb11";
            this.InfoLb11.Size = new System.Drawing.Size(0, 15);
            this.InfoLb11.TabIndex = 12;
            // 
            // InfoLb10
            // 
            this.InfoLb10.AutoSize = true;
            this.InfoLb10.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb10.Location = new System.Drawing.Point(10, 280);
            this.InfoLb10.Name = "InfoLb10";
            this.InfoLb10.Size = new System.Drawing.Size(0, 15);
            this.InfoLb10.TabIndex = 11;
            // 
            // InfoLb9
            // 
            this.InfoLb9.AutoSize = true;
            this.InfoLb9.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb9.Location = new System.Drawing.Point(10, 250);
            this.InfoLb9.Name = "InfoLb9";
            this.InfoLb9.Size = new System.Drawing.Size(0, 15);
            this.InfoLb9.TabIndex = 10;
            // 
            // InfoLb1
            // 
            this.InfoLb1.AutoSize = true;
            this.InfoLb1.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb1.Location = new System.Drawing.Point(10, 10);
            this.InfoLb1.Name = "InfoLb1";
            this.InfoLb1.Size = new System.Drawing.Size(0, 15);
            this.InfoLb1.TabIndex = 0;
            // 
            // InfoLb2
            // 
            this.InfoLb2.AutoSize = true;
            this.InfoLb2.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb2.Location = new System.Drawing.Point(10, 40);
            this.InfoLb2.Name = "InfoLb2";
            this.InfoLb2.Size = new System.Drawing.Size(0, 15);
            this.InfoLb2.TabIndex = 6;
            // 
            // InfoLb3
            // 
            this.InfoLb3.AutoSize = true;
            this.InfoLb3.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb3.Location = new System.Drawing.Point(10, 70);
            this.InfoLb3.Name = "InfoLb3";
            this.InfoLb3.Size = new System.Drawing.Size(0, 15);
            this.InfoLb3.TabIndex = 2;
            // 
            // InfoLb4
            // 
            this.InfoLb4.AutoSize = true;
            this.InfoLb4.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb4.Location = new System.Drawing.Point(10, 100);
            this.InfoLb4.Name = "InfoLb4";
            this.InfoLb4.Size = new System.Drawing.Size(0, 15);
            this.InfoLb4.TabIndex = 7;
            // 
            // InfoLb5
            // 
            this.InfoLb5.AutoSize = true;
            this.InfoLb5.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb5.Location = new System.Drawing.Point(10, 130);
            this.InfoLb5.Name = "InfoLb5";
            this.InfoLb5.Size = new System.Drawing.Size(0, 15);
            this.InfoLb5.TabIndex = 4;
            // 
            // InfoLb6
            // 
            this.InfoLb6.AutoSize = true;
            this.InfoLb6.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb6.Location = new System.Drawing.Point(10, 160);
            this.InfoLb6.Name = "InfoLb6";
            this.InfoLb6.Size = new System.Drawing.Size(0, 15);
            this.InfoLb6.TabIndex = 5;
            // 
            // InfoLb7
            // 
            this.InfoLb7.AutoSize = true;
            this.InfoLb7.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb7.Location = new System.Drawing.Point(10, 190);
            this.InfoLb7.Name = "InfoLb7";
            this.InfoLb7.Size = new System.Drawing.Size(0, 15);
            this.InfoLb7.TabIndex = 8;
            // 
            // InfoLb8
            // 
            this.InfoLb8.AutoSize = true;
            this.InfoLb8.BackColor = System.Drawing.Color.Transparent;
            this.InfoLb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoLb8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb8.Location = new System.Drawing.Point(10, 220);
            this.InfoLb8.Name = "InfoLb8";
            this.InfoLb8.Size = new System.Drawing.Size(0, 15);
            this.InfoLb8.TabIndex = 9;
            // 
            // colorEditor1
            // 
            this.colorEditor1.Color = System.Drawing.Color.Empty;
            this.colorEditor1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorEditor1.Location = new System.Drawing.Point(5, 5);
            this.colorEditor1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorEditor1.Name = "colorEditor1";
            this.colorEditor1.Size = new System.Drawing.Size(288, 132);
            this.colorEditor1.TabIndex = 16;
            // 
            // SetTheme
            // 
            this.SetTheme.AutoSize = true;
            this.SetTheme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetTheme.Location = new System.Drawing.Point(5, 145);
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
            this.SetDefaultTheme.Location = new System.Drawing.Point(5, 175);
            this.SetDefaultTheme.Name = "SetDefaultTheme";
            this.SetDefaultTheme.Size = new System.Drawing.Size(261, 19);
            this.SetDefaultTheme.TabIndex = 17;
            this.SetDefaultTheme.Text = "Вернуться к стандартной теме";
            this.SetDefaultTheme.Click += new System.EventHandler(this.SetDefaultTheme_Click);
            // 
            // ThemePanel
            // 
            this.ThemePanel.Controls.Add(this.colorEditor1);
            this.ThemePanel.Controls.Add(this.SetDefaultTheme);
            this.ThemePanel.Controls.Add(this.SetTheme);
            this.ThemePanel.Location = new System.Drawing.Point(650, 0);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(305, 205);
            this.ThemePanel.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.pictureBox1.Image = global::DevIdent.Properties.Resources.Paint;
            this.pictureBox1.Location = new System.Drawing.Point(510, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // SensorBtn
            // 
            this.SensorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.SensorBtn.Image = ((System.Drawing.Image)(resources.GetObject("SensorBtn.Image")));
            this.SensorBtn.Location = new System.Drawing.Point(545, 0);
            this.SensorBtn.Name = "SensorBtn";
            this.SensorBtn.Size = new System.Drawing.Size(35, 30);
            this.SensorBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SensorBtn.TabIndex = 8;
            this.SensorBtn.TabStop = false;
            this.SensorBtn.Click += new System.EventHandler(this.SensorBtn_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.pictureBox2.Image = global::DevIdent.Properties.Resources.Back;
            this.pictureBox2.Location = new System.Drawing.Point(650, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // InvPanel
            // 
            this.InvPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.InvPanel.Location = new System.Drawing.Point(650, 235);
            this.InvPanel.Name = "InvPanel";
            this.InvPanel.Size = new System.Drawing.Size(302, 265);
            this.InvPanel.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.ControlBox = false;
            this.Controls.Add(this.InvPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ThemePanel);
            this.Controls.Add(this.TurnBtn);
            this.Controls.Add(this.SensorBtn);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CloseBth);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevIdent";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(150)))), ((int)(((byte)(120)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ThemePanel.ResumeLayout(false);
            this.ThemePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox CloseBth;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label SysInfoBtn;
        private System.Windows.Forms.Label CPUInfoBtn;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label InfoLb1;
        private System.Windows.Forms.Label InfoLb2;
        private System.Windows.Forms.Label InfoLb3;
        private System.Windows.Forms.Label InfoLb4;
        private System.Windows.Forms.Label InfoLb5;
        private System.Windows.Forms.Label InfoLb6;
        private System.Windows.Forms.Label InfoLb7;
        private System.Windows.Forms.Label InfoLb8;
        private System.Windows.Forms.Label VideoInfoBtn;
        private System.Windows.Forms.Label RAMInfoBtn;
        private System.Windows.Forms.PictureBox SensorBtn;
        private System.Windows.Forms.Label InfoLb9;
        private System.Windows.Forms.Label MotherBoardBtn;
        private System.Windows.Forms.Label BiosBtn;
        private System.Windows.Forms.Label DiskInfoBtn;
        private System.Windows.Forms.Label BrowserBtn;
        private System.Windows.Forms.Label InfoLb12;
        private System.Windows.Forms.Label InfoLb11;
        private System.Windows.Forms.Label InfoLb10;
        private System.Windows.Forms.PictureBox TurnBtn;
        public System.Windows.Forms.Label ServicesBtn;
        public System.Windows.Forms.Label SysClearBtn;
        public System.Windows.Forms.Label UninstallBtn;
        public System.Windows.Forms.Label AutorunBtn;
        private Cyotek.Windows.Forms.ColorEditor colorEditor1;
        private System.Windows.Forms.Label SetTheme;
        private System.Windows.Forms.Label SetDefaultTheme;
        private System.Windows.Forms.Panel ThemePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel InvPanel;
    }
}

