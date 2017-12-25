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
    public partial class TongDaiControl : UserControl
    {
        public string taikhoangnv
        {
            get;
            set;
        }
        public TongDaiControl()
        {
            InitializeComponent();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            DonHangTongDaiCN f = new DonHangTongDaiCN();
            f.ShowDialog();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            f.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            XacNhanDHDT f = new XacNhanDHDT();
            f.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DHTongDaiChuyenchinhanh f = new DHTongDaiChuyenchinhanh();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLiChiNhanh f = new QuanLiChiNhanh();
            f.ShowDialog();

        }

      


      

       
    }
}
