using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanAn
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            // Doi qua Slide cua Quan Ly khi click vao quan ly
            quanLyControl1.BringToFront();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            // Doi qua Sile cua Home khi click vao man hinh chinh
            homeControl1.BringToFront();
        }

        private void btChiNhanh_Click(object sender, EventArgs e)
        {
            // Doi qua Slide cua Chi Nhanh khi click vao chi nhanh
            chiNhanhControl1.BringToFront();
            
        }

        private void btTongDai_Click(object sender, EventArgs e)
        {
            // Doi qua Slide cua Tong Dai khi click vao tong dai
            tongDaiControl1.BringToFront();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            // Doi qua Slide cua Dang Nhap khi click vao dang xuat
            dangXuatControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
