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
<<<<<<< HEAD:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/Home.cs
 
=======
        void dangnhap()
        {
            if(bophan == "0")
            {
                btChiNhanh.Enabled = true;
                btQuanLy.Enabled = false;
                btTongDai.Enabled = false;
            }
            if (bophan == "1")
            {
                btQuanLy.Enabled = true;
                btTongDai.Enabled = false;
                btChiNhanh.Enabled = false;
            }
            if (bophan == "2")
            {
                btTongDai.Enabled = true;
                btQuanLy.Enabled = false;
                btChiNhanh.Enabled = false;
            }                     
            
        }
        
>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/Form1.cs
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
            Home_Load_1(sender, e);

            dangXuatControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/Home.cs

        private void LoginControl_OnLoggedIn(object sender, EventArgs e)
        {
            DangNhapControl uc = new DangNhapControl();          
            Home_Load_1(sender, e);
        }
        private void Home_Load_1(object sender, EventArgs e)
        {
   
=======
        public void Home_Load_1(object sender, EventArgs e)
        {
            dangnhap();
                                               
>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/Form1.cs
        }

        private void homeControl2_Load(object sender, EventArgs e)
        {
            Home_Load_1(sender, e);
        }

<<<<<<< HEAD:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/Home.cs
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
=======
      

        
>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/Form1.cs
    }
}
