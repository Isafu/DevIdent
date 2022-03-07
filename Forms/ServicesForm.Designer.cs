
namespace DevIdent.Forms
{
    partial class ServicesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            this.ServiceBox = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenServicesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWithServicesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWithServiceMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceSettingsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AutoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoDelayedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceInfoLb = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.WorkWithServiceMenu.SuspendLayout();
            this.ServiceSettingsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceBox
            // 
            this.ServiceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.ServiceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceBox.ContextMenuStrip = this.MainMenu;
            this.ServiceBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ServiceBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceBox.ForeColor = System.Drawing.Color.White;
            this.ServiceBox.ItemHeight = 15;
            this.ServiceBox.Location = new System.Drawing.Point(10, 1);
            this.ServiceBox.Margin = new System.Windows.Forms.Padding(5);
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(490, 252);
            this.ServiceBox.TabIndex = 0;
            this.ServiceBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ServiceBox_DrawItem);
            this.ServiceBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ServiceBox_MeasureItem);
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenServicesMenuItem,
            this.WorkWithServicesMenuItem});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainMenu.Name = "MenuStrip";
            this.MainMenu.ShowImageMargin = false;
            this.MainMenu.Size = new System.Drawing.Size(205, 52);
            // 
            // OpenServicesMenuItem
            // 
            this.OpenServicesMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.OpenServicesMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenServicesMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.OpenServicesMenuItem.ForeColor = System.Drawing.Color.White;
            this.OpenServicesMenuItem.Name = "OpenServicesMenuItem";
            this.OpenServicesMenuItem.Size = new System.Drawing.Size(204, 24);
            this.OpenServicesMenuItem.Text = "Открыть службы";
            this.OpenServicesMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OpenServicesMenuItem.Click += new System.EventHandler(this.OpenServicesMenuItem_Click);
            // 
            // WorkWithServicesMenuItem
            // 
            this.WorkWithServicesMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.WorkWithServicesMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WorkWithServicesMenuItem.DropDown = this.WorkWithServiceMenu;
            this.WorkWithServicesMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.WorkWithServicesMenuItem.ForeColor = System.Drawing.Color.White;
            this.WorkWithServicesMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.WorkWithServicesMenuItem.Name = "WorkWithServicesMenuItem";
            this.WorkWithServicesMenuItem.Size = new System.Drawing.Size(204, 24);
            this.WorkWithServicesMenuItem.Text = "Работа со службой";
            this.WorkWithServicesMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkWithServicesMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.WorkWithServicesMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // WorkWithServiceMenu
            // 
            this.WorkWithServiceMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.WorkWithServiceMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkWithServiceMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.WorkWithServiceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunMenuItem,
            this.StopMenuItem,
            this.RestartMenuItem,
            this.SettingsMenuItem});
            this.WorkWithServiceMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.WorkWithServiceMenu.Name = "MenuStrip";
            this.WorkWithServiceMenu.ShowImageMargin = false;
            this.WorkWithServiceMenu.Size = new System.Drawing.Size(234, 100);
            // 
            // RunMenuItem
            // 
            this.RunMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.RunMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RunMenuItem.ForeColor = System.Drawing.Color.White;
            this.RunMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RunMenuItem.Name = "RunMenuItem";
            this.RunMenuItem.Size = new System.Drawing.Size(233, 24);
            this.RunMenuItem.Text = "Запусить службу";
            this.RunMenuItem.Click += new System.EventHandler(this.RunMenuItem_Click);
            // 
            // StopMenuItem
            // 
            this.StopMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.StopMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StopMenuItem.ForeColor = System.Drawing.Color.White;
            this.StopMenuItem.Name = "StopMenuItem";
            this.StopMenuItem.Size = new System.Drawing.Size(233, 24);
            this.StopMenuItem.Text = "Остановить службу";
            this.StopMenuItem.Click += new System.EventHandler(this.StopMenuItem_Click);
            // 
            // RestartMenuItem
            // 
            this.RestartMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.RestartMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RestartMenuItem.ForeColor = System.Drawing.Color.White;
            this.RestartMenuItem.Name = "RestartMenuItem";
            this.RestartMenuItem.Size = new System.Drawing.Size(233, 24);
            this.RestartMenuItem.Text = "Перезапустить службу";
            this.RestartMenuItem.Click += new System.EventHandler(this.RestartMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.SettingsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsMenuItem.DropDown = this.ServiceSettingsMenu;
            this.SettingsMenuItem.ForeColor = System.Drawing.Color.White;
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(233, 24);
            this.SettingsMenuItem.Text = "Настройка запуска";
            this.SettingsMenuItem.ToolTipText = "Для опытных пользователей";
            // 
            // ServiceSettingsMenu
            // 
            this.ServiceSettingsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ServiceSettingsMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceSettingsMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.ServiceSettingsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoMenuItem,
            this.AutoDelayedMenuItem,
            this.ManualMenuItem,
            this.OffMenuItem});
            this.ServiceSettingsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ServiceSettingsMenu.Name = "MenuStrip";
            this.ServiceSettingsMenu.OwnerItem = this.SettingsMenuItem;
            this.ServiceSettingsMenu.ShowImageMargin = false;
            this.ServiceSettingsMenu.Size = new System.Drawing.Size(351, 100);
            // 
            // AutoMenuItem
            // 
            this.AutoMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.AutoMenuItem.ForeColor = System.Drawing.Color.White;
            this.AutoMenuItem.Name = "AutoMenuItem";
            this.AutoMenuItem.Size = new System.Drawing.Size(350, 24);
            this.AutoMenuItem.Text = "Автоматически";
            this.AutoMenuItem.Click += new System.EventHandler(this.AutoMenuItem_Click);
            // 
            // AutoDelayedMenuItem
            // 
            this.AutoDelayedMenuItem.ForeColor = System.Drawing.Color.White;
            this.AutoDelayedMenuItem.Name = "AutoDelayedMenuItem";
            this.AutoDelayedMenuItem.Size = new System.Drawing.Size(350, 24);
            this.AutoDelayedMenuItem.Text = "Автоматически (отложенный запуск)";
            this.AutoDelayedMenuItem.Click += new System.EventHandler(this.AutoDelayedMenuItem_Click);
            // 
            // ManualMenuItem
            // 
            this.ManualMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ManualMenuItem.ForeColor = System.Drawing.Color.White;
            this.ManualMenuItem.Name = "ManualMenuItem";
            this.ManualMenuItem.Size = new System.Drawing.Size(350, 24);
            this.ManualMenuItem.Text = "Вручную";
            this.ManualMenuItem.Click += new System.EventHandler(this.ManualMenuItem_Click);
            // 
            // OffMenuItem
            // 
            this.OffMenuItem.ForeColor = System.Drawing.Color.White;
            this.OffMenuItem.Name = "OffMenuItem";
            this.OffMenuItem.Size = new System.Drawing.Size(350, 24);
            this.OffMenuItem.Text = "Отключена";
            this.OffMenuItem.Click += new System.EventHandler(this.OffMenuItem_Click);
            // 
            // CloseBth
            // 
            this.CloseBth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBth.Image = global::DevIdent.Properties.Resources.Close;
            this.CloseBth.Location = new System.Drawing.Point(465, 0);
            this.CloseBth.Name = "CloseBth";
            this.CloseBth.Size = new System.Drawing.Size(35, 30);
            this.CloseBth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBth.TabIndex = 5;
            this.CloseBth.TabStop = false;
            this.CloseBth.Click += new System.EventHandler(this.CloseBth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Службы Windows";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.MenuPanel.Controls.Add(this.ServiceInfoLb);
            this.MenuPanel.Location = new System.Drawing.Point(500, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(300, 285);
            this.MenuPanel.TabIndex = 7;
            // 
            // ServiceInfoLb
            // 
            this.ServiceInfoLb.AutoSize = true;
            this.ServiceInfoLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceInfoLb.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceInfoLb.ForeColor = System.Drawing.Color.White;
            this.ServiceInfoLb.Location = new System.Drawing.Point(3, 0);
            this.ServiceInfoLb.Name = "ServiceInfoLb";
            this.ServiceInfoLb.Size = new System.Drawing.Size(0, 15);
            this.ServiceInfoLb.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.ContentPanel.Controls.Add(this.ServiceBox);
            this.ContentPanel.Location = new System.Drawing.Point(0, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(500, 255);
            this.ContentPanel.TabIndex = 8;
            // 
            // SearchBox
            // 
            this.SearchBox.AccessibleDescription = "";
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(0, 5);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBox.MinimumSize = new System.Drawing.Size(160, 25);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(160, 19);
            this.SearchBox.TabIndex = 10;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(305, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 30);
            this.panel2.TabIndex = 9;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBth);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServicesForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Службы";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServicesForm_MouseDown);
            this.MainMenu.ResumeLayout(false);
            this.WorkWithServiceMenu.ResumeLayout(false);
            this.ServiceSettingsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ServiceBox;
        private System.Windows.Forms.PictureBox CloseBth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel;
        private System.Windows.Forms.Label ServiceInfoLb;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenServicesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkWithServicesMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip WorkWithServiceMenu;
        private System.Windows.Forms.ToolStripMenuItem RunMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ContextMenuStrip ServiceSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem AutoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManualMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoDelayedMenuItem;
    }
}