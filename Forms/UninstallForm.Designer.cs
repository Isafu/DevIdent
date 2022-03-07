
namespace DevIdent.Forms
{
    partial class UninstallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UninstallForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.UninstallBox = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFromRegistyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistyPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrivePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateInfoFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.ContentPanel.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.FileMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Удаление программ";
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.ContentPanel.Controls.Add(this.UninstallBox);
            this.ContentPanel.ForeColor = System.Drawing.Color.White;
            this.ContentPanel.Location = new System.Drawing.Point(0, 30);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(500, 255);
            this.ContentPanel.TabIndex = 9;
            // 
            // UninstallBox
            // 
            this.UninstallBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.UninstallBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UninstallBox.ContextMenuStrip = this.MainMenu;
            this.UninstallBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UninstallBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UninstallBox.ForeColor = System.Drawing.Color.White;
            this.UninstallBox.ItemHeight = 100;
            this.UninstallBox.Location = new System.Drawing.Point(10, 0);
            this.UninstallBox.Margin = new System.Windows.Forms.Padding(5);
            this.UninstallBox.Name = "UninstallBox";
            this.UninstallBox.Size = new System.Drawing.Size(490, 252);
            this.UninstallBox.TabIndex = 1;
            this.UninstallBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.UninstallBox_DrawItem);
            this.UninstallBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.UninstallBox_MeasureItem);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.DeleteFromRegistyStripMenuItem,
            this.RegistyPathToolStripMenuItem,
            this.DrivePathToolStripMenuItem,
            this.SearchInGoogleToolStripMenuItem,
            this.CreateInfoFileToolStripMenuItem});
            this.MainMenu.Name = "MenuStrip";
            this.MainMenu.ShowImageMargin = false;
            this.MainMenu.Size = new System.Drawing.Size(268, 148);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.DeleteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // DeleteFromRegistyStripMenuItem
            // 
            this.DeleteFromRegistyStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.DeleteFromRegistyStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteFromRegistyStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteFromRegistyStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DeleteFromRegistyStripMenuItem.Name = "DeleteFromRegistyStripMenuItem";
            this.DeleteFromRegistyStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.DeleteFromRegistyStripMenuItem.Text = "Удалить запись в реестре";
            this.DeleteFromRegistyStripMenuItem.Click += new System.EventHandler(this.DeleteFromRegistryStripMenuItem_Click);
            // 
            // RegistyPathToolStripMenuItem
            // 
            this.RegistyPathToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.RegistyPathToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RegistyPathToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.RegistyPathToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RegistyPathToolStripMenuItem.Name = "RegistyPathToolStripMenuItem";
            this.RegistyPathToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.RegistyPathToolStripMenuItem.Text = "Запись в реестре";
            this.RegistyPathToolStripMenuItem.Click += new System.EventHandler(this.SearchInRegistryToolStripMenuItem_Click);
            // 
            // DrivePathToolStripMenuItem
            // 
            this.DrivePathToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.DrivePathToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.DrivePathToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DrivePathToolStripMenuItem.Name = "DrivePathToolStripMenuItem";
            this.DrivePathToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.DrivePathToolStripMenuItem.Text = "Расположение на диске";
            this.DrivePathToolStripMenuItem.Click += new System.EventHandler(this.SearchOnDiskToolStripMenuItem_Click);
            // 
            // SearchInGoogleToolStripMenuItem
            // 
            this.SearchInGoogleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.SearchInGoogleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchInGoogleToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.SearchInGoogleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SearchInGoogleToolStripMenuItem.Name = "SearchInGoogleToolStripMenuItem";
            this.SearchInGoogleToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.SearchInGoogleToolStripMenuItem.Text = "Что это за программа?";
            this.SearchInGoogleToolStripMenuItem.Click += new System.EventHandler(this.SearchInChromeToolStripMenuItem_Click);
            // 
            // CreateInfoFileToolStripMenuItem
            // 
            this.CreateInfoFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.CreateInfoFileToolStripMenuItem.DropDown = this.FileMenu;
            this.CreateInfoFileToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.CreateInfoFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CreateInfoFileToolStripMenuItem.Name = "CreateInfoFileToolStripMenuItem";
            this.CreateInfoFileToolStripMenuItem.Size = new System.Drawing.Size(267, 24);
            this.CreateInfoFileToolStripMenuItem.Text = "Сформировать";
            // 
            // FileMenu
            // 
            this.FileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.FileMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtFileMenuItem,
            this.HTMLMenuItem});
            this.FileMenu.Name = "MenuStrip";
            this.FileMenu.OwnerItem = this.CreateInfoFileToolStripMenuItem;
            this.FileMenu.ShowImageMargin = false;
            this.FileMenu.Size = new System.Drawing.Size(90, 52);
            // 
            // TxtFileMenuItem
            // 
            this.TxtFileMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.TxtFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TxtFileMenuItem.ForeColor = System.Drawing.Color.White;
            this.TxtFileMenuItem.Name = "TxtFileMenuItem";
            this.TxtFileMenuItem.Size = new System.Drawing.Size(89, 24);
            this.TxtFileMenuItem.Text = "Файл";
            this.TxtFileMenuItem.Click += new System.EventHandler(this.TxtFileMenuItem_Click);
            // 
            // HTMLMenuItem
            // 
            this.HTMLMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.HTMLMenuItem.ForeColor = System.Drawing.Color.White;
            this.HTMLMenuItem.Name = "HTMLMenuItem";
            this.HTMLMenuItem.Size = new System.Drawing.Size(89, 24);
            this.HTMLMenuItem.Text = "HTML";
            this.HTMLMenuItem.Click += new System.EventHandler(this.HTMLMenuItem_Click);
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
            this.panel2.TabIndex = 11;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.RefreshBtn.Image = global::DevIdent.Properties.Resources.Refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(269, 0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(35, 30);
            this.RefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.TabStop = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CloseBth
            // 
            this.CloseBth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBth.Image = global::DevIdent.Properties.Resources.Close;
            this.CloseBth.Location = new System.Drawing.Point(465, 0);
            this.CloseBth.Name = "CloseBth";
            this.CloseBth.Size = new System.Drawing.Size(35, 30);
            this.CloseBth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBth.TabIndex = 10;
            this.CloseBth.TabStop = false;
            this.CloseBth.Click += new System.EventHandler(this.CloseBth_Click);
            // 
            // UninstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(500, 285);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CloseBth);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UninstallForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление программ";
            this.Load += new System.EventHandler(this.UninstallForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UninstallForm_MouseDown);
            this.ContentPanel.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.FileMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox CloseBth;
        private System.Windows.Forms.ListBox UninstallBox;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistyPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DrivePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchInGoogleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateInfoFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFromRegistyStripMenuItem;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox RefreshBtn;
        private System.Windows.Forms.ContextMenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem TxtFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HTMLMenuItem;
    }
}