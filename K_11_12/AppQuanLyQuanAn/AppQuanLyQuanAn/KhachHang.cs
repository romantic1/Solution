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
    public partial class KhachHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public KhachHang()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgv_HienThiDanhSachKhachHang.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgv_HienThiDanhSachKhachHang.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txt_MaKhachHang.Text = "KH0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaKhachHang.Text = "KH" + (chuoi2 + 1).ToString();
            }
            conn.Open();
            string SqlInsert = "Insert into Khach_Hang values('" + txt_MaKhachHang.Text + "','" + txt_TaiKhoan.Text + "','" + txt_MatKhau.Text + "',N'" + txt_TenKhachHang.Text + "',N'" + cbb_TenChiNhanh.Text + "',N'" + Time_NgaySinh.Text + "',N'" + txt_DiaChi.Text + "','" + txt_SoDienThoai.Text + "')";
            cmd = new SqlCommand(SqlInsert, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Add Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Add fail", "Thông báo");
            }
            HienThiKhachHang();
            txt_MaKhachHang.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenKhachHang.Text = cbb_TenChiNhanh.Text = Time_NgaySinh.Text = txt_DiaChi.Text = txt_SoDienThoai.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        void HienThiKhachHang()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Khach_Hang", conn);
            da.Fill(dt);
            dgv_HienThiDanhSachKhachHang.DataSource = dt;
            dgv_HienThiDanhSachKhachHang.RowHeadersVisible = false;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
            ComboboxSearchChiNhanh();
            Combobox();
        }

        private void dgv_HienThiDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgv_HienThiDanhSachKhachHang.Rows[index];

            txt_MaKhachHang.Text = row.Cells[0].Value.ToString();
            txt_TaiKhoan.Text = row.Cells[1].Value.ToString();
            txt_MatKhau.Text = row.Cells[2].Value.ToString();
            txt_TenKhachHang.Text = row.Cells[3].Value.ToString();
            cbb_TenChiNhanh.Text = row.Cells[4].Value.ToString();
            Time_NgaySinh.Text = row.Cells[5].Value.ToString();
            txt_DiaChi.Text = row.Cells[6].Value.ToString();
            txt_SoDienThoai.Text = row.Cells[7].Value.ToString();
            btn_ThemMoi.Visible = false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlUpdate = "Update Khach_Hang set ID_KH = N'" + txt_TaiKhoan.Text + "',Password_KH = '" + txt_MatKhau.Text + "',Ten_KH = N'" + txt_TenKhachHang.Text + "',Ten_CN = N'"+ cbb_TenChiNhanh.Text +"',NgaySinh_KH = N'" + Time_NgaySinh.Text + "',DiaChi_KH = N'" + txt_DiaChi.Text + "',SoDienThoai_KH = '" + txt_SoDienThoai.Text + "' Where Ma_KH = '" + txt_MaKhachHang.Text + "'";
            cmd = new SqlCommand(SqlUpdate, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update fail", "Thông báo");
            }
            HienThiKhachHang();
            txt_MaKhachHang.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenKhachHang.Text = cbb_TenChiNhanh.Text = Time_NgaySinh.Text = txt_DiaChi.Text = txt_SoDienThoai.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlDelete = "Delete Khach_Hang Where Ma_KH = '" + txt_MaKhachHang.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }
            HienThiKhachHang();
            txt_MaKhachHang.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenKhachHang.Text = cbb_TenChiNhanh.Text = Time_NgaySinh.Text = txt_DiaChi.Text = txt_SoDienThoai.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiKhachHang();
            txt_MaKhachHang.Text = txt_MaKhachHang.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenKhachHang.Text = Time_NgaySinh.Text = txt_DiaChi.Text = txt_SoDienThoai.Text = "";
            btn_ThemMoi.Visible = true;
        }

        private void txt_SearchKhachHang_TextChanged(object sender, EventArgs e)
        {
            (dgv_HienThiDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID_KH LIKE '%{0}%'", txt_SearchKhachHang.Text); 
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            (dgv_HienThiDanhSachKhachHang.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_CN LIKE '%{0}%'", cbb_SearchTenChiNhanh.Text); 
        }

        void ComboboxSearchChiNhanh()
        {
            cmd = new SqlCommand("Select Ten_CN from Chi_Nhanh", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Chi_Nhanh");
            cbb_SearchTenChiNhanh.DataSource = ds.Tables[0];
            cbb_SearchTenChiNhanh.DisplayMember = "Ten_CN";
        }

        void Combobox()
        {
            cmd = new SqlCommand("Select Ten_CN from Chi_Nhanh", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Chi_Nhanh");
            cbb_TenChiNhanh.DataSource = ds.Tables[0];
            cbb_TenChiNhanh.DisplayMember = "Ten_CN";
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
