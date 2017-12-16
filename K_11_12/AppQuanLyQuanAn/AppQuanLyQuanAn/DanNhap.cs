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
<<<<<<< HEAD:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DangNhapControl.cs
    public partial class DangNhapControl : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        public DangNhapControl()
=======
    public partial class DanNhap : Form
    {   
        string a;
       
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0T7B1M9\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
        
        public DanNhap()
>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DanNhap.cs
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

<<<<<<< HEAD:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DangNhapControl.cs
        public static string ID_USER = "";

=======
>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DanNhap.cs
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
<<<<<<< HEAD:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DangNhapControl.cs
                Home_Login frmHL = new Home_Login();
                this.Hide();
                frmHL.Show();
=======
                this.Hide();
                a = kq.Rows[0]["BoPhan"].ToString();
                cmd.ExecuteNonQuery();
                Home f = new Home();
                f.bophan = a;
                f.ShowDialog();
                this.Close();



>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DanNhap.cs
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
            conn.Close();
        }

<<<<<<< HEAD:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DangNhapControl.cs

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
=======
        private void DanNhap_Load(object sender, EventArgs e)
        {

>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e:K_11_12/AppQuanLyQuanAn/AppQuanLyQuanAn/DanNhap.cs
        }
    }
}
