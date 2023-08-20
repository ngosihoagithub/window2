using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLySieuThi.TaiKhoan
{
    public partial class frmTaiKhoan : Form
    {
        private string chuoi;

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string uername = txt_tk.Text.Trim();
            string password = txt_mk.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string date = datecreate.Text.Trim();


            string role = cbbRole.SelectedIndex.ToString();
            if (txt_tk.Text == "" || txt_mk.Text == "" || fullname == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin! Vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string select = "select count(*) from taikhoan where username='" + txt_tk.Text + "'";
                    string them1 = "insert into taikhoan Values ('" + uername + "','" + password + "','" + fullname + "','" + date + "','" + role + "')";
                    chuoiketnoi.Them(select, txt_tk.Text.Trim(), txt_mk.Text.Trim(), them1, dta1);
                    chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                    dta1.Columns[0].HeaderText = "Tài khoản";
                    dta1.Columns[1].HeaderText = "Mật khẩu";
                    dta1.Columns[2].HeaderText = "Họ và tên";
                    dta1.Columns[3].HeaderText = "Ngày tạo";
                    dta1.Columns[4].HeaderText = "Quyền";
                    txt_tk.Clear();
                    txt_mk.Clear();
                    txtFullname.Clear();
                    cbbRole.SelectedIndex = 0;


                    txt_tk.Focus();
                    btn_them.Enabled = true;
                    btn_xoa.Enabled = false;
                    btn_sua.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại! Vui lòng nhập lại", "Error", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_tk.Clear();
            txt_mk.Clear();
            txtFullname.Clear();
            cbbRole.SelectedIndex = 0;
            txt_tk.Focus();
            txt_tk.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string username = txt_tk.Text.Trim();
            string password = txt_mk.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string date = datecreate.Text.Trim();
            string role = cbbRole.SelectedIndex.ToString();

            string sql = "Update taikhoan set password ='" + password + "', fullname='" + fullname + "', isAdmin='" + role +
                "' where username = '" + txt_tk.Text + "'";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);

            dta1.Columns[0].HeaderText = "Tài khoản";
            dta1.Columns[1].HeaderText = "Mật khẩu";
            dta1.Columns[2].HeaderText = "Họ và tên";
            dta1.Columns[3].HeaderText = "Ngày tạo";
            dta1.Columns[4].HeaderText = "Quyền";
            txt_tk.Clear();
            txt_mk.Clear();
            txtFullname.Clear();
            txt_tk.Focus();
            txt_tk.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from taikhoan  where username = '" + txt_tk.Text.Trim() + "'";
            chuoiketnoi.Execute(sql);
            // MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Tài khoản";
            dta1.Columns[1].HeaderText = "Mật khẩu";
            dta1.Columns[2].HeaderText = "Họ và tên";
            dta1.Columns[3].HeaderText = "Ngày tạo";
            dta1.Columns[4].HeaderText = "Quyền";
            txt_tk.Clear();
            txt_mk.Clear();
            txtFullname.Clear();
            txt_tk.Focus();
            txt_tk.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            string duongdan = "";
            string tenfile = "TaiKhoanAdmin";
            XuatExecl.exportecxel(dta1, duongdan, tenfile);
            MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
            MessageBox.Show("Duong dan file dc luu :" + duongdan + MessageBoxButtons.OK);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void dta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
