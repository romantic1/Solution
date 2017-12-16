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
    public partial class ChiTietChiNhanh : UserControl
    {
        public ChiTietChiNhanh()
        {
            InitializeComponent();
        }

        private void ChiNhanhControl_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            NhanVien frmNV = new NhanVien();
            frmNV.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            KhachHang frmKH = new KhachHang();
            frmKH.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DonHangChiNhanh frmDHCN = new DonHangChiNhanh();
            frmDHCN.Show();
        }
    }
}
