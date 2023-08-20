namespace QuanLySieuThi
{
    partial class main1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main1));
            this.label6 = new System.Windows.Forms.Label();
            this.lbform = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qunLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(0, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1110, 10);
            this.label6.TabIndex = 37;
            // 
            // lbform
            // 
            this.lbform.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbform.BackColor = System.Drawing.Color.Transparent;
            this.lbform.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.lbform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbform.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbform.Location = new System.Drawing.Point(40, 56);
            this.lbform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbform.Name = "lbform";
            this.lbform.Size = new System.Drawing.Size(926, 64);
            this.lbform.TabIndex = 36;
            this.lbform.Text = "Quản Lý Siêu Thị MiNi";
            this.lbform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbform.Click += new System.EventHandler(this.lbform_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 30;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 30;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpHệThốngToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.quanly,
            this.qunLyNhanVienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 30);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngNhậpHệThốngToolStripMenuItem
            // 
            this.đăngNhậpHệThốngToolStripMenuItem.Name = "đăngNhậpHệThốngToolStripMenuItem";
            this.đăngNhậpHệThốngToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.đăngNhậpHệThốngToolStripMenuItem.Text = "Đăng Nhập Hệ thống";
            this.đăngNhậpHệThốngToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpHệThốngToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quanly
            // 
            this.quanly.Name = "quanly";
            this.quanly.Size = new System.Drawing.Size(75, 24);
            this.quanly.Text = "Quản Lý";
            this.quanly.Click += new System.EventHandler(this.quanLyToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(49, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 449);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // qunLyNhanVienToolStripMenuItem
            // 
            this.qunLyNhanVienToolStripMenuItem.Name = "qunLyNhanVienToolStripMenuItem";
            this.qunLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.qunLyNhanVienToolStripMenuItem.Text = "QuanLyNhanVien";
            this.qunLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.qunLyNhanVienToolStripMenuItem_Click);
            // 
            // main1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1110, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbform);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý siêu thị";
            this.Load += new System.EventHandler(this.main1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbform;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanly;
        private System.Windows.Forms.ToolStripMenuItem qunLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}