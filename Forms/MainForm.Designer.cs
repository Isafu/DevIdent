
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
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
            this.SensorBtn = new System.Windows.Forms.PictureBox();
            this.TurnBtn = new System.Windows.Forms.PictureBox();
            this.mainNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ОчисткаStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.БраузерыStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SensorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SensorBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).BeginInit();
            this.menuStrip.SuspendLayout();
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
            // CloseBth
            // 
            this.CloseBth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBth.Image = ((System.Drawing.Image)(resources.GetObject("CloseBth.Image")));
            this.CloseBth.Location = new System.Drawing.Point(615, 0);
            this.CloseBth.Name = "CloseBth";
            this.CloseBth.Size = new System.Drawing.Size(35, 30);
            this.CloseBth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBth.TabIndex = 4;
            this.CloseBth.TabStop = false;
            this.CloseBth.Click += new System.EventHandler(this.CloseBth_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
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
            // UninstallBtn
            // 
            this.UninstallBtn.AutoSize = true;
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
            this.InfoLb12.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb12.Location = new System.Drawing.Point(10, 340);
            this.InfoLb12.Name = "InfoLb12";
            this.InfoLb12.Size = new System.Drawing.Size(0, 15);
            this.InfoLb12.TabIndex = 13;
            // 
            // InfoLb11
            // 
            this.InfoLb11.AutoSize = true;
            this.InfoLb11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb11.Location = new System.Drawing.Point(10, 310);
            this.InfoLb11.Name = "InfoLb11";
            this.InfoLb11.Size = new System.Drawing.Size(0, 15);
            this.InfoLb11.TabIndex = 12;
            // 
            // InfoLb10
            // 
            this.InfoLb10.AutoSize = true;
            this.InfoLb10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb10.Location = new System.Drawing.Point(10, 280);
            this.InfoLb10.Name = "InfoLb10";
            this.InfoLb10.Size = new System.Drawing.Size(0, 15);
            this.InfoLb10.TabIndex = 11;
            // 
            // InfoLb9
            // 
            this.InfoLb9.AutoSize = true;
            this.InfoLb9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb9.Location = new System.Drawing.Point(10, 250);
            this.InfoLb9.Name = "InfoLb9";
            this.InfoLb9.Size = new System.Drawing.Size(0, 15);
            this.InfoLb9.TabIndex = 10;
            // 
            // InfoLb1
            // 
            this.InfoLb1.AutoSize = true;
            this.InfoLb1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb1.Location = new System.Drawing.Point(10, 10);
            this.InfoLb1.Name = "InfoLb1";
            this.InfoLb1.Size = new System.Drawing.Size(0, 15);
            this.InfoLb1.TabIndex = 0;
            // 
            // InfoLb2
            // 
            this.InfoLb2.AutoSize = true;
            this.InfoLb2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb2.Location = new System.Drawing.Point(10, 40);
            this.InfoLb2.Name = "InfoLb2";
            this.InfoLb2.Size = new System.Drawing.Size(0, 15);
            this.InfoLb2.TabIndex = 6;
            // 
            // InfoLb3
            // 
            this.InfoLb3.AutoSize = true;
            this.InfoLb3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb3.Location = new System.Drawing.Point(10, 70);
            this.InfoLb3.Name = "InfoLb3";
            this.InfoLb3.Size = new System.Drawing.Size(0, 15);
            this.InfoLb3.TabIndex = 2;
            // 
            // InfoLb4
            // 
            this.InfoLb4.AutoSize = true;
            this.InfoLb4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb4.Location = new System.Drawing.Point(10, 100);
            this.InfoLb4.Name = "InfoLb4";
            this.InfoLb4.Size = new System.Drawing.Size(0, 15);
            this.InfoLb4.TabIndex = 7;
            // 
            // InfoLb5
            // 
            this.InfoLb5.AutoSize = true;
            this.InfoLb5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb5.Location = new System.Drawing.Point(10, 130);
            this.InfoLb5.Name = "InfoLb5";
            this.InfoLb5.Size = new System.Drawing.Size(0, 15);
            this.InfoLb5.TabIndex = 4;
            // 
            // InfoLb6
            // 
            this.InfoLb6.AutoSize = true;
            this.InfoLb6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb6.Location = new System.Drawing.Point(10, 160);
            this.InfoLb6.Name = "InfoLb6";
            this.InfoLb6.Size = new System.Drawing.Size(0, 15);
            this.InfoLb6.TabIndex = 5;
            // 
            // InfoLb7
            // 
            this.InfoLb7.AutoSize = true;
            this.InfoLb7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb7.Location = new System.Drawing.Point(10, 190);
            this.InfoLb7.Name = "InfoLb7";
            this.InfoLb7.Size = new System.Drawing.Size(0, 15);
            this.InfoLb7.TabIndex = 8;
            // 
            // InfoLb8
            // 
            this.InfoLb8.AutoSize = true;
            this.InfoLb8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLb8.Location = new System.Drawing.Point(10, 220);
            this.InfoLb8.Name = "InfoLb8";
            this.InfoLb8.Size = new System.Drawing.Size(0, 15);
            this.InfoLb8.TabIndex = 9;
            // 
            // SensorBtn
            // 
            this.SensorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.SensorBtn.Image = global::DevIdent.Properties.Resources.SensorIcon1;
            this.SensorBtn.Location = new System.Drawing.Point(545, 0);
            this.SensorBtn.Name = "SensorBtn";
            this.SensorBtn.Size = new System.Drawing.Size(35, 30);
            this.SensorBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SensorBtn.TabIndex = 8;
            this.SensorBtn.TabStop = false;
            this.SensorBtn.Click += new System.EventHandler(this.SensorBtn_Click);
            // 
            // TurnBtn
            // 
            this.TurnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.TurnBtn.Image = ((System.Drawing.Image)(resources.GetObject("TurnBtn.Image")));
            this.TurnBtn.Location = new System.Drawing.Point(580, 0);
            this.TurnBtn.Name = "TurnBtn";
            this.TurnBtn.Size = new System.Drawing.Size(35, 30);
            this.TurnBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnBtn.TabIndex = 14;
            this.TurnBtn.TabStop = false;
            this.TurnBtn.Click += new System.EventHandler(this.TurnBtn_Click);
            // 
            // mainNotify
            // 
            this.mainNotify.ContextMenuStrip = this.menuStrip;
            this.mainNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotify.Icon")));
            this.mainNotify.Text = "Информация о ПК";
            this.mainNotify.DoubleClick += new System.EventHandler(this.mainNotify_DoubleClick);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОчисткаStripMenuItem1,
            this.БраузерыStripMenuItem1,
            this.SensorItem,
            this.ExitItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.ShowImageMargin = false;
            this.menuStrip.Size = new System.Drawing.Size(207, 100);
            // 
            // ОчисткаStripMenuItem1
            // 
            this.ОчисткаStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ОчисткаStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ОчисткаStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.ОчисткаStripMenuItem1.Name = "ОчисткаStripMenuItem1";
            this.ОчисткаStripMenuItem1.Size = new System.Drawing.Size(206, 24);
            this.ОчисткаStripMenuItem1.Text = "Очистка системы";
            this.ОчисткаStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ОчисткаStripMenuItem1.Click += new System.EventHandler(this.ОчисткаStripMenuItem1_Click);
            // 
            // БраузерыStripMenuItem1
            // 
            this.БраузерыStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.БраузерыStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.БраузерыStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.БраузерыStripMenuItem1.Name = "БраузерыStripMenuItem1";
            this.БраузерыStripMenuItem1.Size = new System.Drawing.Size(206, 24);
            this.БраузерыStripMenuItem1.Text = "Очистка браузеров";
            this.БраузерыStripMenuItem1.Click += new System.EventHandler(this.БраузерыStripMenuItem1_Click);
            // 
            // SensorItem
            // 
            this.SensorItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SensorItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SensorItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SensorItem.ForeColor = System.Drawing.Color.White;
            this.SensorItem.Name = "SensorItem";
            this.SensorItem.Size = new System.Drawing.Size(206, 24);
            this.SensorItem.Text = "Датчики";
            this.SensorItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ExitItem
            // 
            this.ExitItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitItem.ForeColor = System.Drawing.Color.White;
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(206, 24);
            this.ExitItem.Text = "Закрыть";
            this.ExitItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.ControlBox = false;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevIdent";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SensorBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).EndInit();
            this.menuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem SensorItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        public System.Windows.Forms.NotifyIcon mainNotify;
        public System.Windows.Forms.Label ServicesBtn;
        public System.Windows.Forms.Label SysClearBtn;
        public System.Windows.Forms.Label UninstallBtn;
        private System.Windows.Forms.ToolStripMenuItem ОчисткаStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem БраузерыStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
    }
}

