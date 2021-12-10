
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
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenServicesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWithServicesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуситьСлужбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьСлужбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приостановитьСлужбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезапуститьСлужбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseBth = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ServiceInfoLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).BeginInit();
            this.flowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceBox
            // 
            this.ServiceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.ServiceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceBox.ContextMenuStrip = this.MenuStrip;
            this.ServiceBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ServiceBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiceBox.ForeColor = System.Drawing.Color.White;
            this.ServiceBox.ItemHeight = 15;
            this.ServiceBox.Location = new System.Drawing.Point(10, 1);
            this.ServiceBox.Name = "ServiceBox";
            this.ServiceBox.Size = new System.Drawing.Size(490, 252);
            this.ServiceBox.TabIndex = 0;
            this.ServiceBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.ServiceBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenServicesMenuItem,
            this.WorkWithServicesMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(230, 52);
            // 
            // OpenServicesMenuItem
            // 
            this.OpenServicesMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.OpenServicesMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenServicesMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.OpenServicesMenuItem.ForeColor = System.Drawing.Color.White;
            this.OpenServicesMenuItem.Name = "OpenServicesMenuItem";
            this.OpenServicesMenuItem.Size = new System.Drawing.Size(229, 24);
            this.OpenServicesMenuItem.Text = "Открыть службы";
            this.OpenServicesMenuItem.Click += new System.EventHandler(this.OpenServicesMenuItem_Click);
            // 
            // WorkWithServicesMenuItem
            // 
            this.WorkWithServicesMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.WorkWithServicesMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WorkWithServicesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуситьСлужбуToolStripMenuItem,
            this.остановитьСлужбуToolStripMenuItem,
            this.приостановитьСлужбуToolStripMenuItem,
            this.перезапуститьСлужбуToolStripMenuItem});
            this.WorkWithServicesMenuItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.WorkWithServicesMenuItem.ForeColor = System.Drawing.Color.White;
            this.WorkWithServicesMenuItem.Name = "WorkWithServicesMenuItem";
            this.WorkWithServicesMenuItem.Size = new System.Drawing.Size(229, 24);
            this.WorkWithServicesMenuItem.Text = "Работа со службой";
            // 
            // запуситьСлужбуToolStripMenuItem
            // 
            this.запуситьСлужбуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.запуситьСлужбуToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.запуситьСлужбуToolStripMenuItem.Name = "запуситьСлужбуToolStripMenuItem";
            this.запуситьСлужбуToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.запуситьСлужбуToolStripMenuItem.Text = "Запусить службу";
            this.запуситьСлужбуToolStripMenuItem.Click += new System.EventHandler(this.запуситьСлужбуToolStripMenuItem_Click);
            // 
            // остановитьСлужбуToolStripMenuItem
            // 
            this.остановитьСлужбуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.остановитьСлужбуToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.остановитьСлужбуToolStripMenuItem.Name = "остановитьСлужбуToolStripMenuItem";
            this.остановитьСлужбуToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.остановитьСлужбуToolStripMenuItem.Text = "Остановить службу";
            this.остановитьСлужбуToolStripMenuItem.Click += new System.EventHandler(this.остановитьСлужбуToolStripMenuItem_Click);
            // 
            // приостановитьСлужбуToolStripMenuItem
            // 
            this.приостановитьСлужбуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.приостановитьСлужбуToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.приостановитьСлужбуToolStripMenuItem.Name = "приостановитьСлужбуToolStripMenuItem";
            this.приостановитьСлужбуToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.приостановитьСлужбуToolStripMenuItem.Text = "Приостановить службу";
            this.приостановитьСлужбуToolStripMenuItem.Click += new System.EventHandler(this.приостановитьСлужбуToolStripMenuItem_Click);
            // 
            // перезапуститьСлужбуToolStripMenuItem
            // 
            this.перезапуститьСлужбуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.перезапуститьСлужбуToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.перезапуститьСлужбуToolStripMenuItem.Name = "перезапуститьСлужбуToolStripMenuItem";
            this.перезапуститьСлужбуToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.перезапуститьСлужбуToolStripMenuItem.Text = "Перезапустить службу";
            this.перезапуститьСлужбуToolStripMenuItem.Click += new System.EventHandler(this.перезапуститьСлужбуToolStripMenuItem_Click);
            // 
            // CloseBth
            // 
            this.CloseBth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBth.Image = ((System.Drawing.Image)(resources.GetObject("CloseBth.Image")));
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
            // flowPanel
            // 
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.flowPanel.Controls.Add(this.ServiceInfoLb);
            this.flowPanel.Location = new System.Drawing.Point(500, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(300, 285);
            this.flowPanel.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.ServiceBox);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 255);
            this.panel1.TabIndex = 8;
            // 
            // SearchBox
            // 
            this.SearchBox.AccessibleDescription = "";
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(0, 5);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.SearchBox.MinimumSize = new System.Drawing.Size(160, 25);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(160, 25);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowPanel);
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
            this.Text = "Services";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServicesForm_MouseDown);
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBth)).EndInit();
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ServiceBox;
        private System.Windows.Forms.PictureBox CloseBth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Label ServiceInfoLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenServicesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WorkWithServicesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьСлужбуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приостановитьСлужбуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перезапуститьСлужбуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуситьСлужбуToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
    }
}