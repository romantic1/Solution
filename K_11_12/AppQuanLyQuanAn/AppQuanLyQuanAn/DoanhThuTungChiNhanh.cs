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
    public partial class DoanhThuTungChiNhanh : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public DoanhThuTungChiNhanh()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            (dgv_DoanhThuTungChiNhanh.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_CN LIKE '%{0}%'", cbb_TenChiNhanh.Text);
            conn.Open();
            string SqlInsert = "Insert into DoanhThuTungChiNhanh values(N'" + cbb_TenChiNhanh.Text + "',(Select sum(TongTien) from Don_Hang_Chi_Nhanh Where Ten_CN = N'" + cbb_TenChiNhanh.Text + "'))";
            SqlCommand cmd = new SqlCommand(SqlInsert, conn);
            cmd.ExecuteNonQuery();   
            conn.Close();
            TextBoxDoanhThu();
        }

        private void DoanhThuTungChiNhanh_Load(object sender, EventArgs e)
        {
            ComboboxSearchChiNhanh();
            HienThiDoanhThuChiNhanh();          
        }

        void ComboboxSearchChiNhanh()
        {
            cmd = new SqlCommand("Select Ten_CN from Chi_Nhanh", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Chi_Nhanh");
            cbb_TenChiNhanh.DataSource = ds.Tables[0];
            cbb_TenChiNhanh.DisplayMember = "Ten_CN";
        }

        void HienThiDoanhThuChiNhanh()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ma_DHCN,Ten_DH,Ten_CN,TongTien from Don_Hang_Chi_Nhanh", conn);
            da.Fill(dt);
            dgv_DoanhThuTungChiNhanh.DataSource = dt;
            dgv_DoanhThuTungChiNhanh.RowHeadersVisible = false;
        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            HienThiDoanhThuChiNhanh();
            txt_TongTien.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void TextBoxDoanhThu()
        {
            conn.Open();
            cmd = new SqlCommand("Select TongTien from DoanhThuTungChiNhanh", conn);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                txt_TongTien.Text = (da["TongTien"].ToString());
            }
            conn.Close();
        }

        void TinhTongDoanhThuChiNhanh()
        {
            conn.Open();
            string SqlInsert = "Insert into DoanhThuTungChiNhanh values((Select Ten_CN from Don_Hang_Chi_Nhanh),(Select sum(TongTien) from Don_Hang_Chi_Nhanh Where Ten_CN = Ten_CN))";
            SqlCommand cmd = new SqlCommand(SqlInsert, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
