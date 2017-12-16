using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AppQuanLyQuanAn
{
    public partial class DangNhapControl : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public DangNhapControl()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        public static string ID_USER = "";

        private void dangnhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            //string SqlSelect = "Select Count(*) From Nhan_Vien where ID_NV = @TaiKhoan and Password_NV = @MatKhau";
            //cmd = new SqlCommand(SqlSelect, conn);
            //cmd.Parameters.Add(new SqlParameter("@TaiKhoan", txt_TaiKhoan.Text));
            //cmd.Parameters.Add(new SqlParameter("@MatKhau", txt_MatKhau.Text));
            //int x = (int)cmd.ExecuteScalar();
            //if (x == 1)
            //{
            //    MessageBox.Show("Đăng Nhập Thành Công!", "Thông báo");    
               
            //    Home_Login frmHL = new Home_Login();
            //    this.Hide();
            //    frmHL.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Đăng Nhâp Thất Bại!", "Thông báo");
            //}

            ID_USER = getID(txt_TaiKhoan.Text, txt_MatKhau.Text);
            if (ID_USER != "")
            {
                Home_Login frmHL = new Home_Login();
                this.Hide();
                frmHL.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
            conn.Close();
        }


        private string getID(string TaiKhoan, string MatKhau)
        {
            string id = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Nhan_Vien WHERE ID_NV =  '" + TaiKhoan + "'  AND Password_NV = '" + MatKhau + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["Ma_NV"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                conn.Close();
            }
            return id;
        }
    }
}
