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
    public partial class frmThongTinDonHang : Form
    {
        private readonly string chuoi;

        public frmThongTinDonHang()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from chitietdonhang where maphieuxuat= '" + txt_matdonhang.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, db1);
            clear();
        }

        private void clear()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TongTien_Click(object sender, EventArgs e)
        {
            string duongdan = "";
            DateTime nagy = DateTime.Now;
            string tim = nagy.ToString();
            string randomNameFile = tim.Replace(" ", "_").Replace("/", "-").Replace(":", "-");
            XuatExecl.exportecxelchitietdonhang(db1, duongdan, randomNameFile);
            MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
            //MessageBox.Show("Duong dan file dc luu :" + duongdan + MessageBoxButtons.OK);
        }

        private void frmThongTinDonHang_Load(object sender, EventArgs e)
        {

        }

        private void lb_Tile_Click(object sender, EventArgs e)
        {

        }
    }
}
