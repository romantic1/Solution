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
        string a;
        public event EventHandler OnLoggedIn;
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0T7B1M9\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
        public DangNhapControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void DangNhapControl_Load(object sender, EventArgs e)
        {

        }
        private void dangnhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select BoPhan from Nhan_Vien where ID_NV ='" + txtdangnhap.Text + "' and Password_NV ='" + txtmatkhau.Text + "' ";



            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable kq = new DataTable();
            da.Fill(kq);

            if (kq.Rows.Count > 0)
            {
                a = kq.Rows[0]["BoPhan"].ToString();
                cmd.ExecuteNonQuery();            
                Home f = new Home();               
                f.bophan = a;
               
                
            }
            else
            {
                MessageBox.Show("Sai mã đăng nhập hoặc mật khẩu", "Thông Báo");
            }
            conn.Close();
            if(OnLoggedIn !=null) 
            OnLoggedIn(this, null);
            
        }

        
    }
}
