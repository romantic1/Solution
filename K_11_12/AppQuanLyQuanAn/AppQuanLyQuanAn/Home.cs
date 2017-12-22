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
    public partial class Home : Form
    {
       SqlConnection conn;
        public Home()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string TenNhanVienTruyenSang = "";
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Nhan_Vien Where ID_NV = '" + txt_TaiKhoan.Text + "' AND Password_NV = '" + txt_MatKhau.Text + "'", conn);
            da.Fill(dt);
            if(txt_TaiKhoan.Text.Length == 0 || txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Xin Vui Lòng Nhập Đủ Thông Tin!");
            }
            else if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng Nhập Thành Công!", "Thông Báo");      
                Home_Login frmHL = new Home_Login(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), TenNhanVienTruyenSang.ToString(), dt.Rows[0][8].ToString());
                //TenNhanVienTruyenSang = dt.Rows[0]["Ten_NV"].ToString();
                //frmHL = new Home_Login(TenNhanVienTruyenSang.ToString());
                this.Hide();
                frmHL.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại!.Vui Lòng Kiểm Tra Lại!", "Thông Báo");
            }
            conn.Close();
        }

        //Zoome
        private void button17_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        //Min
        private void button2_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }
    }
}
