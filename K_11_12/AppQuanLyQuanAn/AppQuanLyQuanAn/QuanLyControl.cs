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
            ChiNhanhQL frChiNhanh = new ChiNhanhQL();
            frChiNhanh.Show();
        }
    }
}
