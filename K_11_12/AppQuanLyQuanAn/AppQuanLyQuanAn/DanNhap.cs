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
    public partial class DanNhap : Form
    {   
        string a;
       
        static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0T7B1M9\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
        
        public DanNhap()
        {
            InitializeComponent();
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
                this.Hide();
                a = kq.Rows[0]["BoPhan"].ToString();
                cmd.ExecuteNonQuery();
                Home f = new Home();
                f.bophan = a;
                f.ShowDialog();
                this.Close();



            }
            else
            {
                MessageBox.Show("Sai mã đăng nhập hoặc mật khẩu", "Thông Báo");
            }
            conn.Close();
        }

        private void DanNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
