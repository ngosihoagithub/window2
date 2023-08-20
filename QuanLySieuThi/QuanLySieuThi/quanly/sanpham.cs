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

namespace QuanLySieuThi.quanly
{
    public partial class sanpham : Form
    {
        private string chuoi;

        public sanpham()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (
          txt_tensp.Text == "" ||
          txt_mancc.Text == "" ||
          txt_gianhap.Text == "" ||
          txt_giaban.Text == "" ||
          txt_solg.Text == "" ||
          txt_hsd.Text == "" ||
          txt_nsx.Text == "" ||
          txt_dvt.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into sanpham values(N'" + txt_tensp.Text + "',N'" + txt_mancc.SelectedValue + "','" + txt_gianhap.Text + "','" + txt_giaban.Text + "','" + txt_solg.Text + "','" + txt_hsd.Value + "',N'" + txt_nsx.Text + "',N'" + txt_dvt.Text + "',N'" + txtNguoiNhap.Text + "')";
                chuoiketnoi.them_dl(sql1, dta1);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                clear();
            }
        }

        private void clear()
        {
            throw new NotImplementedException();
        }

        private void bnt_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update sanpham set tensp = N'" + txt_tensp.Text + "',mancc = N'" + txt_mancc.SelectedValue + "',gianhap = '" + txt_gianhap.Text + "',giaban = '" + txt_giaban.Text + "',solg = '" + txt_solg.Text + "',hsd = '" + txt_hsd.Value + "',noisx = N'" + txt_nsx.Text + "',donvitinh = N'" + txt_dvt.Text + "',nguoinhap= N'" + txtNguoiNhap.Text + "' where masp='" + txt_masp.Text + "'";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from sanpham where masp= '" + txt_masp.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            string duongdan = "";
            String tenfile = "ThongTinSanPham";
            XuatExecl.export_phieu(dta1, duongdan, tenfile, lbl_kq.Text);
            MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void sanpham_Load(object sender, EventArgs e)
        {

        }
    }
}
