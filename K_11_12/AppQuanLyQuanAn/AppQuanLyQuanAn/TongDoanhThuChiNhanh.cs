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
    public partial class TongDoanhThu_QuanLi : Form
    {
        SqlConnection conn;
        public TongDoanhThu_QuanLi()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void HienThiDoanhThuChiNhanh()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from DoanhThuTungChiNhanh", conn);
            da.Fill(dt);
            dgv_DoanhThuTongChiNhanh.DataSource = dt;
            dgv_DoanhThuTongChiNhanh.RowHeadersVisible = false;
        }

        private void TongThuNhap_QuanLi_Load(object sender, EventArgs e)
        {
            HienThiDoanhThuChiNhanh();
            InsertDoanhThuTungChiNhanh();
            TongTienChiNhanh();
        }

        void InsertDoanhThuTungChiNhanh()
        {
            conn.Open();
            String SqlSelect = "Select Ten_CN,Sum(TongTien) AS DoanhThuChiNhanh from Don_Hang_Chi_Nhanh Group by Ten_CN";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(SqlSelect,conn);
            da.Fill(ds);
            dgv_DoanhThuTongChiNhanh.DataSource = ds.Tables[0];
            dgv_DoanhThuTongChiNhanh.Refresh();
            conn.Close();
        }
        public static DataTable docDuLieu(String sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,"Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
            adapter.Fill(dt);
            return dt;
        }

        public int Tong;
        void TongTienChiNhanh()
        {
            DataTable dt = docDuLieu("Select Ten_CN,Sum(TongTien) from Don_Hang_Chi_Nhanh Group by Ten_CN");
            foreach (DataRow row in dt.Rows)
            {
                Tong += int.Parse(row[1].ToString());
                txt_TongTien.Text = Tong.ToString();
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
    }
}
