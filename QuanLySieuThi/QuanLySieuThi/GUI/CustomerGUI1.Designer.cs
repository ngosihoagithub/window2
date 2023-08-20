namespace QuanLySieuThi.GUI
{
    partial class CustomerGUI1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGUI1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.id_area});
            this.dataGridView1.Location = new System.Drawing.Point(87, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(905, 326);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // id
            // 
            this.id.FillWeight = 200F;
            this.id.HeaderText = "Mã";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 250;
            // 
            // name
            // 
            this.name.FillWeight = 350F;
            this.name.HeaderText = "Tên";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 350;
            // 
            // id_area
            // 
            this.id_area.FillWeight = 200F;
            this.id_area.HeaderText = "Khu vực";
            this.id_area.MinimumWidth = 6;
            this.id_area.Name = "id_area";
            this.id_area.Width = 250;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(163, 499);
            this.cbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(160, 24);
            this.cbArea.TabIndex = 32;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btExit.Location = new System.Drawing.Point(975, 536);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 28);
            this.btExit.TabIndex = 31;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.btEdit.Location = new System.Drawing.Point(827, 536);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(100, 28);
            this.btEdit.TabIndex = 30;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Location = new System.Drawing.Point(670, 536);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 28);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.IndianRed;
            this.btNew.Location = new System.Drawing.Point(507, 536);
            this.btNew.Margin = new System.Windows.Forms.Padding(4);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(100, 28);
            this.btNew.TabIndex = 28;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 503);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Khu vực";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(156, 447);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(288, 22);
            this.tbName.TabIndex = 26;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(156, 402);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(195, 22);
            this.tbId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CustomerGUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1163, 615);
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
            this.Name = "CustomerGUI1";
            this.Text = "CustomerGUI1";
            this.Load += new System.EventHandler(this.CustomerGUI1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_area;
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
    }
}