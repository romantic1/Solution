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
    public partial class TaoDonHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public TaoDonHang()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void TaoDonHang_Load(object sender, EventArgs e)
        {
            ComboboxTenChiNhanh();
            ComboboxTenKhachHang();
            HienThiDonHang();
        }

        void HienThiDonHang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Don_Hang", conn);
            da.Fill(dt);
            dgv_HienThiDanhSachDonHang.DataSource = dt;
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgv_HienThiDanhSachDonHang.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgv_HienThiDanhSachDonHang.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txt_MaDonHang.Text = "DH0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaDonHang.Text = "DH" + (chuoi2 + 1).ToString();
            }
            conn.Open();
            string SqlInsert = "Insert into Don_Hang values('" + txt_MaDonHang.Text + "','" + cbb_MaKhachHang.Text + "','" + cbb_TenChiNhanh.Text + "',N'" + txt_SoLuong.Text + "','" + Time_NgayDat.Text + "','" + Time_NgayGiao.Text + "','" + cbb_KhuyenMai.Text + "',N'" + txt_PhiShip.Text + "',N'" + cbb_TrangThai.Text + "')";
            cmd = new SqlCommand(SqlInsert, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Add Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Add fail", "Thông báo");
            }
            HienThiDonHang();
            txt_MaDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = txt_SoLuong.Text = Time_NgayDat.Text = Time_NgayGiao.Text = cbb_KhuyenMai.Text = txt_PhiShip.Text = cbb_TrangThai.Text = "";
            conn.Close();
        }

        void ComboboxTenChiNhanh()
        {
            cmd = new SqlCommand("Select Ten_CN from Chi_Nhanh", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Chi_Nhanh");
            cbb_TenChiNhanh.DataSource = ds.Tables[0];
            cbb_TenChiNhanh.DisplayMember = "Ten_CN";
        }

        void ComboboxTenKhachHang()
        {
            cmd = new SqlCommand("Select Ma_KH from Khach_Hang", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Khach_Hang");
            cbb_MaKhachHang.DataSource = ds.Tables[0];
            cbb_MaKhachHang.DisplayMember = "Ma_KH";
        }

        private void dgv_HienThiDanhSachDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgv_HienThiDanhSachDonHang.Rows[index];

            txt_MaDonHang.Text = row.Cells[0].Value.ToString();
            cbb_MaKhachHang.Text = row.Cells[1].Value.ToString();
            cbb_TenChiNhanh.Text = row.Cells[2].Value.ToString();
            txt_SoLuong.Text = row.Cells[3].Value.ToString();
            Time_NgayDat.Text = row.Cells[4].Value.ToString();
            Time_NgayGiao.Text = row.Cells[5].Value.ToString();
            cbb_KhuyenMai.Text = row.Cells[6].Value.ToString();
            txt_PhiShip.Text = row.Cells[7].Value.ToString();
            cbb_TrangThai.Text = row.Cells[8].Value.ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlUpdate = "Update Don_Hang set Ma_KH = '" + cbb_MaKhachHang.Text + "',Ma_CN = N'" + cbb_TenChiNhanh.Text + "',SoLuong = '" + txt_SoLuong.Text + "',NgayDat = '" + Time_NgayDat.Text + "',NgayGiao = '" + Time_NgayGiao.Text + "',KhuyenMai = N'" + cbb_KhuyenMai.Text + "',PhiShip = '" + txt_PhiShip.Text + "',TrangThai_DH = N'" + cbb_TrangThai.Text + "' Where Ma_DH = '" + txt_MaDonHang.Text + "'";
            cmd = new SqlCommand(SqlUpdate, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update fail", "Thông báo");
            }
            HienThiDonHang();
            txt_MaDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = txt_SoLuong.Text = Time_NgayDat.Text = Time_NgayGiao.Text = cbb_KhuyenMai.Text = txt_PhiShip.Text = cbb_TrangThai.Text = "";
            conn.Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = txt_SoLuong.Text = Time_NgayDat.Text = Time_NgayGiao.Text = cbb_KhuyenMai.Text = txt_PhiShip.Text = cbb_TrangThai.Text = "";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlDelete = "Delete Don_Hang Where Ma_DH = '" + txt_MaDonHang.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }
            HienThiDonHang();
            txt_MaDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = txt_SoLuong.Text = Time_NgayDat.Text = Time_NgayGiao.Text = cbb_KhuyenMai.Text = txt_PhiShip.Text = cbb_TrangThai.Text = "";
            conn.Close();
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
