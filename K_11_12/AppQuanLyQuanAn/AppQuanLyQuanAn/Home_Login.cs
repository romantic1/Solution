using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanAn
{
    public partial class Home_Login : Form
    {
        string TaiKhoan = "", TenNhanVien = "", MatKhau = "", BoPhan = "";
        public Home_Login()
        {
            InitializeComponent();         
        }

        public Home_Login(string TaiKhoan,string MatKhau,string TenNhanVien,string BoPhan)
        {
            InitializeComponent();
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.TenNhanVien = TenNhanVien;
            this.BoPhan = BoPhan;
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

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home frmH = new Home();
            frmH.Show();
        }

        void PhanQuyen()
        {
            if (BoPhan == "Giám Đốc")
            {
                btn_ChiNhanh.Enabled = true;
                btn_QuanLy.Enabled = true;
                btn_TongDai.Enabled = true;
            }
            else if (BoPhan == "Bán Hàng")
            {
                btn_ChiNhanh.Enabled = true;
                btn_QuanLy.Enabled = false;
                btn_TongDai.Enabled = false;
            }
            else if (BoPhan == "Tổng Đài")
            {
                btn_ChiNhanh.Enabled = false;
                btn_QuanLy.Enabled = false;
                btn_TongDai.Enabled = true;
            }
        }

        private void Home_Login_Load_1(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void btn_Zoom_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }
    }
}
