namespace DevIdent.Forms
{
    partial class AutorunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorunForm));
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PathItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableDisableItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.AutorunList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBth
            // 
            this.CloseBth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBth.Image = global::DevIdent.Properties.Resources.Close;
            this.CloseBth.Location = new System.Drawing.Point(465, 0);
            this.CloseBth.Name = "CloseBth";
            this.CloseBth.Size = new System.Drawing.Size(35, 30);
            this.CloseBth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBth.TabIndex = 11;
            this.CloseBth.TabStop = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PathItem,
            this.EnableDisableItem});
            this.MenuStrip.Name = "menuStrip";
            this.MenuStrip.ShowImageMargin = false;
            this.MenuStrip.Size = new System.Drawing.Size(234, 52);
            // 
            // PathItem
            // 
            this.PathItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PathItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PathItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathItem.ForeColor = System.Drawing.Color.White;
            this.PathItem.Name = "PathItem";
            this.PathItem.Size = new System.Drawing.Size(233, 24);
            this.PathItem.Text = "Путь";
            this.PathItem.Click += new System.EventHandler(this.PathItem_Click);
            // 
            // EnableDisableItem
            // 
            this.EnableDisableItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnableDisableItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EnableDisableItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnableDisableItem.ForeColor = System.Drawing.Color.White;
            this.EnableDisableItem.Name = "EnableDisableItem";
            this.EnableDisableItem.Size = new System.Drawing.Size(233, 24);
            this.EnableDisableItem.Text = "Включить / отключить";
            this.EnableDisableItem.Click += new System.EventHandler(this.EnableDisableItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Автозапуск";
            // 
            // AutorunList
            // 
            this.AutorunList.AutoArrange = false;
            this.AutorunList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.AutorunList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutorunList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.AutorunList.ContextMenuStrip = this.MenuStrip;
            this.AutorunList.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorunList.ForeColor = System.Drawing.Color.White;
            this.AutorunList.FullRowSelect = true;
            this.AutorunList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AutorunList.HideSelection = false;
            this.AutorunList.Location = new System.Drawing.Point(0, 30);
            this.AutorunList.Margin = new System.Windows.Forms.Padding(5);
            this.AutorunList.MultiSelect = false;
            this.AutorunList.Name = "AutorunList";
            this.AutorunList.ShowGroups = false;
            this.AutorunList.Size = new System.Drawing.Size(500, 255);
            this.AutorunList.TabIndex = 0;
            this.AutorunList.UseCompatibleStateImageBehavior = false;
            this.AutorunList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Программа";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Расположение";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Запущена?";
            this.columnHeader3.Width = 85;
            // 
            // AutorunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 285);
            this.Controls.Add(this.AutorunList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBth);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutorunForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автозапуск";
            this.Load += new System.EventHandler(this.AutorunForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutorunForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBth;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PathItem;
        private System.Windows.Forms.ToolStripMenuItem EnableDisableItem;
        private System.Windows.Forms.ListView AutorunList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}