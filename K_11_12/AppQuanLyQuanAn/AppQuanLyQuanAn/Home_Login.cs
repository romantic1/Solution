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
    public partial class Home_Login : Form
    {
        public Home_Login()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            quanLyControl1.BringToFront();
        }

        private void btChiNhanh_Click(object sender, EventArgs e)
        {
            chiTietChiNhanh1.BringToFront();
        }

        private void btTongDai_Click(object sender, EventArgs e)
        {
            tongDaiControl1.BringToFront();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            manHinhChinh1.BringToFront();
        }
    }
}
