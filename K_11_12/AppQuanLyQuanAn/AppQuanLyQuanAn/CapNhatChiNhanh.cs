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
    public partial class CapNhatChiNhanh : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public CapNhatChiNhanh()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void OffThaoTacCNQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiNhanhQL frChonMenuUpdate = new ChiNhanhQL();
            this.Close();
            frChonMenuUpdate.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlUpdate = "Update Chi_Nhanh set Ten_CN = N'" + txt_TenChiNhanh.Text + "',SoDienThoai_CN = '" + txt_DienThoai.Text + "',DiaChi_CN = N'" + txt_DiaChi.Text + "',TinhThanh = N'" + cbb_TinhThanh.Text + "',TinhTrang = N'" + cbb_TinhTrang.Text + "',NgayThanhLap = '" + dateTimePicker1.Text + "',MaMonAn = '" + txt_MaMonAn.Text + "',SoBan = '" + txt_SoBan.Text + "' Where Ma_CN = '" + txt_MaChiNhanh.Text + "'";
            cmd = new SqlCommand(SqlUpdate, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update fail", "Thông báo");
            }
            HienThiChiNhanh();
            //txt_MaMonAn.Text = txt_TenMonAn.Text = txt_Gia.Text = txt_GhiChu.Text = "";
            conn.Close();
        }

        void HienThiChiNhanh()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Chi_Nhanh", conn);
            da.Fill(dt);
            dgv_CapNhatChiNhanh.DataSource = dt;
        }

        private void CapNhatChiNhanh_Load_1(object sender, EventArgs e)
        {
            HienThiChiNhanh();
        }

        private void dgv_CapNhatChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int indexRow = e.RowIndex;
           DataGridViewRow row = dgv_CapNhatChiNhanh.Rows[indexRow];

           txt_MaChiNhanh.Text = row.Cells[0].Value.ToString();
           txt_TenChiNhanh.Text = row.Cells[1].Value.ToString();
           txt_DienThoai.Text = row.Cells[2].Value.ToString();
           txt_DiaChi.Text = row.Cells[3].Value.ToString();
           cbb_TinhThanh.Text = row.Cells[4].Value.ToString();
           cbb_TinhTrang.Text = row.Cells[5].Value.ToString();
           txt_MaMonAn.Text = row.Cells[6].Value.ToString();
           txt_SoBan.Text = row.Cells[7].Value.ToString();
        }
    }
}
