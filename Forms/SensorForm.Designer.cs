
namespace DevIdent.Forms
{
    partial class SensorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorForm));
            this.SensorInfoPanel = new System.Windows.Forms.Panel();
            this.SensorLb3 = new System.Windows.Forms.Label();
            this.SensorLb2 = new System.Windows.Forms.Label();
            this.SensorLb1 = new System.Windows.Forms.Label();
            this.TitleLb = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.TurnBtn = new System.Windows.Forms.PictureBox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SensorInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // SensorInfoPanel
            // 
            this.SensorInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(42)))));
            this.SensorInfoPanel.Controls.Add(this.SensorLb3);
            this.SensorInfoPanel.Controls.Add(this.SensorLb2);
            this.SensorInfoPanel.Controls.Add(this.SensorLb1);
            this.SensorInfoPanel.Location = new System.Drawing.Point(0, 30);
            this.SensorInfoPanel.Name = "SensorInfoPanel";
            this.SensorInfoPanel.Size = new System.Drawing.Size(270, 100);
            this.SensorInfoPanel.TabIndex = 0;
            // 
            // SensorLb3
            // 
            this.SensorLb3.AutoSize = true;
            this.SensorLb3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SensorLb3.ForeColor = System.Drawing.Color.White;
            this.SensorLb3.Location = new System.Drawing.Point(10, 70);
            this.SensorLb3.Name = "SensorLb3";
            this.SensorLb3.Size = new System.Drawing.Size(0, 14);
            this.SensorLb3.TabIndex = 7;
            // 
            // SensorLb2
            // 
            this.SensorLb2.AutoSize = true;
            this.SensorLb2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SensorLb2.Location = new System.Drawing.Point(10, 40);
            this.SensorLb2.Name = "SensorLb2";
            this.SensorLb2.Size = new System.Drawing.Size(0, 14);
            this.SensorLb2.TabIndex = 4;
            // 
            // SensorLb1
            // 
            this.SensorLb1.AutoSize = true;
            this.SensorLb1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SensorLb1.Location = new System.Drawing.Point(10, 10);
            this.SensorLb1.Name = "SensorLb1";
            this.SensorLb1.Size = new System.Drawing.Size(0, 14);
            this.SensorLb1.TabIndex = 3;
            // 
            // TitleLb
            // 
            this.TitleLb.AutoSize = true;
            this.TitleLb.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLb.Location = new System.Drawing.Point(15, 5);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.Size = new System.Drawing.Size(72, 19);
            this.TitleLb.TabIndex = 1;
            this.TitleLb.Text = "Датчики";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.CloseBtn.Image = global::DevIdent.Properties.Resources.CloseIcon;
            this.CloseBtn.Location = new System.Drawing.Point(235, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(35, 30);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TurnBtn
            // 
            this.TurnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.TurnBtn.Image = global::DevIdent.Properties.Resources.TurnIcon;
            this.TurnBtn.Location = new System.Drawing.Point(200, 0);
            this.TurnBtn.Name = "TurnBtn";
            this.TurnBtn.Size = new System.Drawing.Size(35, 30);
            this.TurnBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnBtn.TabIndex = 6;
            this.TurnBtn.TabStop = false;
            this.TurnBtn.Click += new System.EventHandler(this.TurnBtn_Click);   
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(270, 130);
            this.Controls.Add(this.TurnBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.TitleLb);
            this.Controls.Add(this.SensorInfoPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SensorForm";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.SensorForm_Activated);
            this.Deactivate += new System.EventHandler(this.SensorForm_Deactivate);
            this.Load += new System.EventHandler(this.SensorForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SensorForm_MouseDown);
            this.SensorInfoPanel.ResumeLayout(false);
            this.SensorInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SensorInfoPanel;
        private System.Windows.Forms.Label TitleLb;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label SensorLb1;
        private System.Windows.Forms.Label SensorLb2;
        private System.Windows.Forms.PictureBox TurnBtn;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Label SensorLb3;
        private System.Windows.Forms.Timer Timer;
    }
}