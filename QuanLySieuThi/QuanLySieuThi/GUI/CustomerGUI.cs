using QuanLySieuThi.BAL;
using QuanLySieuThi.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLySieuThi.GUI
{
    public partial class CustomerGUI : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        AreaBAL areaBAL = new AreaBAL();

        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cus.Area = (AreaBEL)cbArea.SelectedItem;
            cusBAL.NewCustomer(cus);
            dataGridView1.Rows.Add(cus.Id, cus.Name, cus.Area.Name);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Kiểm tra nếu các ô cột có giá trị (không rỗng) trong hàng được chọn
                if (!string.IsNullOrWhiteSpace(selectedRow.Cells[0].Value?.ToString()) &&
                    !string.IsNullOrWhiteSpace(selectedRow.Cells[1].Value?.ToString()) &&
                    !string.IsNullOrWhiteSpace(selectedRow.Cells[2].Value?.ToString()))
                {
                    int idx = selectedRow.Index;

                    CustomerBEL cus = new CustomerBEL();
                    cus.Id = int.Parse(selectedRow.Cells[0].Value.ToString());
                    cus.Name = selectedRow.Cells[1].Value.ToString();
                    cus.Area = (AreaBEL)cbArea.SelectedItem;
                    cusBAL.DeleteCustomer(cus);
                    dataGridView1.Rows.RemoveAt(idx);

                    MessageBox.Show("Khách hàng đã được xoá khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể xoá hàng chưa có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row != null)
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cusBAL.EditCustomer(cus);
                row.Cells[0].Value = cus.Id;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.AreaName;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            foreach (CustomerBEL cus in lstCus)
            {
                dataGridView1.Rows.Add(cus.Id, cus.Name, cus.AreaName);
            }
            List<AreaBEL> lstArea = areaBAL.ReadAreaList();
            foreach (AreaBEL area in lstArea)
            {
                cbArea.Items.Add(area);
            }
            cbArea.DisplayMember = "name";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                // Disable the TextBox to prevent editing

                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                cbArea.Text = row.Cells[2].Value.ToString();
                //tbsdt.Text = row.Cells[3].Value.ToString();
                //txtImagePath.Text = row.Cells[5].Value.ToString();
                //dateTimePicker1.Text = row.Cells[4].Value.ToString();

                ////
                //txtImagePath.Text = row.Cells[5].Value.ToString();

            }
        }
    }
}
