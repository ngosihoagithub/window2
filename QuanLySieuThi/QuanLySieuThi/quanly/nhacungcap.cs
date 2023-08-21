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
    public partial class nhacungcap : Form
    {
        private string chuoi;

        public string Chuoi { get => chuoi; set => chuoi = value; }

        public nhacungcap()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (txt_tennv.Text == "" || txt_diachi.Text == "" || txt_sdt.Text == "" || txt_congno.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into nhacungcap values(N'" + txt_tennv.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "','" + txt_congno.Text + "' )";
                chuoiketnoi.them_dl(sql1, dta1);
                chuoiketnoi.Chuoiketnoi(Chuoi, dta1);
                clear();
            }
        }

        private void clear()
        {
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update nhacungcap set tenncc = N'" + txt_tennv.Text + "',diachi = N'" + txt_diachi.Text + "',sdt = '" + txt_sdt.Text + "',congno = '" + txt_congno.Text + "' Where mancc = '" + txt_manv.Text + "' ";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(Chuoi, dta1);
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from nhacungcap where mancc= '" + txt_manv.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(Chuoi, dta1);
            clear();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            string duongdan = "";
            string tenfile = "QuanLyNhaCungCap";
            XuatExecl.exportecxel(dta1, duongdan, tenfile);
            MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
            MessageBox.Show("Duong dan file dc luu :" + duongdan + MessageBoxButtons.OK);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {

        }
    }
}
