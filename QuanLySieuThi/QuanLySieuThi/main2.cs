using QuanLySieuThi.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class main2 : Form
    {
        public main2()
        {
            InitializeComponent();
        }

        private void ql_nhanvien_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }

        private void ql_ncc_Click(object sender, EventArgs e)
        {
            quanly.nhacungcap a = new quanly.nhacungcap();
            a.Show();
        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanly.frmThongTinDonHang ql = new quanly.frmThongTinDonHang();
            ql.Show();
        }

        private void mn_hethong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                main1 a = new main1();
                a.Show();
                this.Hide();
            }
        }

        private void mn_banhang_Click(object sender, EventArgs e)
        {
            banhang.banhang a = new banhang.banhang();
            a.lb_quyen.Text = lb_quyen.Text;
            a.Show();
        }

        private void mn_quanly_Click(object sender, EventArgs e)
        {

        }
    }
}
