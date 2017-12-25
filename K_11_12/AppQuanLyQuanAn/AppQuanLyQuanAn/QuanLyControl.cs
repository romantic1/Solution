using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanAn
{
    public partial class QuanLyControl : UserControl
    {
        public QuanLyControl()
        {
            InitializeComponent();
        }

        private void btDanhMucQL_Click(object sender, EventArgs e)
        {
            DanhMucMonAn frDanhMuc = new DanhMucMonAn();            
            frDanhMuc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLiChiNhanh frChiNhanh = new QuanLiChiNhanh();
            frChiNhanh.Show();
        }

        private void btKhachHangQL_Click(object sender, EventArgs e)
        {
            KhachHang frmKH = new KhachHang();
            frmKH.Show();
        }

        private void btNhanVienQL_Click(object sender, EventArgs e)
        {
            NhanVien frmNV = new NhanVien();
            frmNV.Show();
        }

        private void btBaoCaoQL_Click(object sender, EventArgs e)
        {
            TongDoanhThu_QuanLi frmTTN_QL = new TongDoanhThu_QuanLi();
            frmTTN_QL.Show();
        }

        private void btBieuDoQL_Click(object sender, EventArgs e)
        {
            BieuDo frmBD = new BieuDo();
            frmBD.Show();
        }
    }
}
