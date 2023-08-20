namespace QuanLySieuThi
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Chọn ảnh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "3x4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(595, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Yellow;
            this.btClose.Location = new System.Drawing.Point(686, 418);
            this.btClose.Margin = new System.Windows.Forms.Padding(2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(88, 24);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Brown;
            this.btDelete.Location = new System.Drawing.Point(502, 418);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 26);
            this.btDelete.TabIndex = 25;
            this.btDelete.Text = "Xóa ";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btAddNew.Location = new System.Drawing.Point(410, 418);
            this.btAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(88, 26);
            this.btAddNew.TabIndex = 24;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = false;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(92, 335);
            this.ckGender.Margin = new System.Windows.Forms.Padding(2);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(58, 20);
            this.ckGender.TabIndex = 23;
            this.ckGender.Text = "Nam";
            this.ckGender.UseVisualStyleBackColor = true;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(78, 309);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(134, 22);
            this.tbAge.TabIndex = 22;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(75, 282);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(307, 22);
            this.tbName.TabIndex = 21;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(78, 256);
            this.tbId.Margin = new System.Windows.Forms.Padding(2);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(130, 22);
            this.tbId.TabIndex = 20;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ảnh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính (Nam)";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tuổi";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 247;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tuổi";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvEmployee.Location = new System.Drawing.Point(43, 31);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.Height = 33;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(839, 208);
            this.dgvEmployee.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(528, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 99);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}

