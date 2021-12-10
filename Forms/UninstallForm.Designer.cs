
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UninstallBox = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.УдалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.УдалитьИзРеестраStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗаписьВРеестреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.РасположениеНаДискеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СформироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.UninstallBox);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 255);
            this.panel1.TabIndex = 9;
            // 
            // UninstallBox
            // 
            this.UninstallBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.UninstallBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UninstallBox.ContextMenuStrip = this.MenuStrip;
            this.UninstallBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UninstallBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UninstallBox.ForeColor = System.Drawing.Color.White;
            this.UninstallBox.ItemHeight = 15;
            this.UninstallBox.Location = new System.Drawing.Point(10, 1);
            this.UninstallBox.Name = "UninstallBox";
            this.UninstallBox.Size = new System.Drawing.Size(490, 252);
            this.UninstallBox.TabIndex = 1;
            this.UninstallBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.UninstallBox_DrawItem);
            this.UninstallBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.UninstallBox_MeasureItem);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.УдалитьToolStripMenuItem,
            this.УдалитьИзРеестраStripMenuItem1,
            this.ЗаписьВРеестреToolStripMenuItem,
            this.РасположениеНаДискеToolStripMenuItem,
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem,
            this.СформироватьToolStripMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(293, 170);
            // 
            // УдалитьToolStripMenuItem
            // 
            this.УдалитьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.УдалитьToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.УдалитьToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.УдалитьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.УдалитьToolStripMenuItem.Name = "УдалитьToolStripMenuItem";
            this.УдалитьToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.УдалитьToolStripMenuItem.Text = "Удалить";
            this.УдалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // УдалитьИзРеестраStripMenuItem1
            // 
            this.УдалитьИзРеестраStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.УдалитьИзРеестраStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.УдалитьИзРеестраStripMenuItem1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.УдалитьИзРеестраStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.УдалитьИзРеестраStripMenuItem1.Name = "УдалитьИзРеестраStripMenuItem1";
            this.УдалитьИзРеестраStripMenuItem1.Size = new System.Drawing.Size(292, 24);
            this.УдалитьИзРеестраStripMenuItem1.Text = "Удалить запись в реестре";
            this.УдалитьИзРеестраStripMenuItem1.Click += new System.EventHandler(this.удалитьИзРеестраStripMenuItem1_Click);
            // 
            // ЗаписьВРеестреToolStripMenuItem
            // 
            this.ЗаписьВРеестреToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ЗаписьВРеестреToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ЗаписьВРеестреToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.ЗаписьВРеестреToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ЗаписьВРеестреToolStripMenuItem.Name = "ЗаписьВРеестреToolStripMenuItem";
            this.ЗаписьВРеестреToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.ЗаписьВРеестреToolStripMenuItem.Text = "Запись в реестре";
            this.ЗаписьВРеестреToolStripMenuItem.Click += new System.EventHandler(this.записьВРеестреToolStripMenuItem_Click);
            // 
            // РасположениеНаДискеToolStripMenuItem
            // 
            this.РасположениеНаДискеToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.РасположениеНаДискеToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.РасположениеНаДискеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.РасположениеНаДискеToolStripMenuItem.Name = "РасположениеНаДискеToolStripMenuItem";
            this.РасположениеНаДискеToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.РасположениеНаДискеToolStripMenuItem.Text = "Расположение на диске";
            this.РасположениеНаДискеToolStripMenuItem.Click += new System.EventHandler(this.расположениеНаДискеToolStripMenuItem_Click);
            // 
            // ЧтоЭтоЗаПрограммаToolStripMenuItem
            // 
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.Name = "ЧтоЭтоЗаПрограммаToolStripMenuItem";
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.Text = "Что это за программа?";
            this.ЧтоЭтоЗаПрограммаToolStripMenuItem.Click += new System.EventHandler(this.чтоЭтоЗаПрограммаToolStripMenuItem_Click);
            // 
            // СформироватьToolStripMenuItem
            // 
            this.СформироватьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.СформироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФайлToolStripMenuItem,
            this.HTMLToolStripMenuItem});
            this.СформироватьToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.СформироватьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.СформироватьToolStripMenuItem.Name = "СформироватьToolStripMenuItem";
            this.СформироватьToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.СформироватьToolStripMenuItem.Text = "Сформировать";
            // 
            // ФайлToolStripMenuItem
            // 
            this.ФайлToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ФайлToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ФайлToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem";
            this.ФайлToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ФайлToolStripMenuItem.Text = "Файл";
            this.ФайлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // HTMLToolStripMenuItem
            // 
            this.HTMLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.HTMLToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem";
            this.HTMLToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.HTMLToolStripMenuItem.Text = "HTML";
            this.HTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // CloseBth
            // 
            this.CloseBth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBth.Image = ((System.Drawing.Image)(resources.GetObject("CloseBth.Image")));
            this.CloseBth.Location = new System.Drawing.Point(465, 0);
            this.CloseBth.Name = "CloseBth";
            this.CloseBth.Size = new System.Drawing.Size(35, 30);
            this.CloseBth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBth.TabIndex = 10;
            this.CloseBth.TabStop = false;
            this.CloseBth.Click += new System.EventHandler(this.CloseBth_Click);
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
            // UninstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(500, 285);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CloseBth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UninstallForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uninstall";
            this.Load += new System.EventHandler(this.UninstallForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UninstallForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseBth;
        private System.Windows.Forms.ListBox UninstallBox;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem УдалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЗаписьВРеестреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem РасположениеНаДискеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЧтоЭтоЗаПрограммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СформироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem УдалитьИзРеестраStripMenuItem1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Panel panel2;
    }
}