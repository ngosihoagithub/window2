namespace QuanLySieuThi.GUI
{
    partial class CustomerGUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.id_area,
            this.gianhap,
            this.soluong,
            this.soluongco});
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 326);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // id
            // 
            this.id.FillWeight = 200F;
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.FillWeight = 350F;
            this.name.HeaderText = "Tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // id_area
            // 
            this.id_area.FillWeight = 200F;
            this.id_area.HeaderText = "Khu vực";
            this.id_area.MinimumWidth = 6;
            this.id_area.Name = "id_area";
            this.id_area.Width = 150;
            // 
            // gianhap
            // 
            this.gianhap.HeaderText = "Giá Nhập";
            this.gianhap.MinimumWidth = 6;
            this.gianhap.Name = "gianhap";
            this.gianhap.Width = 150;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng nhập";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 150;
            // 
            // soluongco
            // 
            this.soluongco.HeaderText = "Số lượng hiện có";
            this.soluongco.MinimumWidth = 6;
            this.soluongco.Name = "soluongco";
            this.soluongco.Width = 150;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(86, 534);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(160, 24);
            this.cbArea.TabIndex = 32;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(898, 571);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 28);
            this.btExit.TabIndex = 31;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(750, 571);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 28);
            this.btEdit.TabIndex = 30;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(593, 571);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 28);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(430, 571);
            this.btNew.Margin = new System.Windows.Forms.Padding(4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(100, 28);
            this.btNew.TabIndex = 28;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 538);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Khu vực";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 482);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(288, 22);
            this.tbName.TabIndex = 26;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(79, 437);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(195, 22);
            this.tbId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(923, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Giá Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Số lượng nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số lượng hiện có";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(593, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(593, 479);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(593, 532);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 22);
            this.textBox3.TabIndex = 39;
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 693);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerGUI";
            this.Text = "CustomerGUI";
            this.Load += new System.EventHandler(this.CustomerGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongco;
    }
}