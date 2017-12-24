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
    public partial class BieuDo : Form
    {
        SqlConnection conn;
        public BieuDo()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BieuDo_Load(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ten_CN,COUNT(Ten_CN) AS SoLuongKhach from Khach_Hang Group by Ten_CN", conn);
            da.Fill(dt);
            BieuDoKhachHang.DataSource = dt;
            BieuDoKhachHang.ChartAreas["ChartArea1"].AxisX.Title = "";
            BieuDoKhachHang.ChartAreas["ChartArea1"].AxisX.Title = "Số Lượng Khách Hàng";

            BieuDoKhachHang.Series["Series1"].XValueMember = "Ten_CN";
            BieuDoKhachHang.Series["Series1"].YValueMembers = "SoLuongKhach";
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }
    }
}
