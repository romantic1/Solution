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
    public partial class NhanVien : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public NhanVien()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (txt_CMND.Text == "") 
            {
                MessageBox.Show("Xin Hãy Nhập Đủ Thông Tin Cần Thiết!","Thông Báo");
            }
            else
            {
                int count = 0;
                count = dgv_HienThiDanhSachNhanVien.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgv_HienThiDanhSachNhanVien.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                {
                    txt_MaNhanVien.Text = "NV0" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    txt_MaNhanVien.Text = "NV" + (chuoi2 + 1).ToString();
                }
                conn.Open();
                string SqlInsert = "Insert into Nhan_Vien values('" + txt_MaNhanVien.Text + "','" + txt_TaiKhoan.Text + "','" + txt_MatKhau.Text + "',N'" + txt_TenNhanVien.Text + "','" + txt_CMND.Text + "','" + txt_SoDienThoai.Text + "',N'" + cbb_TenChiNhanh.Text + "',N'" + cbb_CaLam.Text + "',N'" + cbb_BoPhan.Text + "',N'" + txt_DanhGia.Text + "','" + Time_NgayBatDauLam.Text + "','" + txt_Luong.Text + "')";
                SqlCommand cmd = new SqlCommand(SqlInsert, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Add Successful", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Add fail", "Thông báo");
                }

                HienThiNhanVien();
                txt_MaNhanVien.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenNhanVien.Text = txt_CMND.Text = txt_SoDienThoai.Text = cbb_TenChiNhanh.Text = cbb_CaLam.Text = cbb_BoPhan.Text = txt_DanhGia.Text = Time_NgayBatDauLam.Text = txt_Luong.Text = "";
                conn.Close();
            } 
        }     

        void HienThiNhanVien()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Nhan_Vien", conn);
            da.Fill(dt);
            dgv_HienThiDanhSachNhanVien.DataSource = dt;
            dgv_HienThiDanhSachNhanVien.RowHeadersVisible = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlDelete = "Delete Nhan_Vien Where Ma_NV = '" + txt_MaNhanVien.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }
            HienThiNhanVien();
            txt_MaNhanVien.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenNhanVien.Text = txt_CMND.Text = txt_SoDienThoai.Text = cbb_TenChiNhanh.Text = cbb_CaLam.Text = cbb_BoPhan.Text = txt_DanhGia.Text  = Time_NgayBatDauLam.Text = txt_Luong.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        private void dgv_HienThiDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgv_HienThiDanhSachNhanVien.Rows[index];

            txt_MaNhanVien.Text = row.Cells[0].Value.ToString();
            txt_TaiKhoan.Text = row.Cells[1].Value.ToString();
            txt_MatKhau.Text = row.Cells[2].Value.ToString();
            txt_TenNhanVien.Text = row.Cells[3].Value.ToString();
            txt_CMND.Text = row.Cells[4].Value.ToString();
            txt_SoDienThoai.Text = row.Cells[5].Value.ToString();
            cbb_TenChiNhanh.Text = row.Cells[6].Value.ToString();
            cbb_CaLam.Text = row.Cells[7].Value.ToString();
            cbb_BoPhan.Text = row.Cells[8].Value.ToString();
            txt_DanhGia.Text = row.Cells[9].Value.ToString();
            Time_NgayBatDauLam.Text = row.Cells[10].Value.ToString();
            txt_Luong.Text = row.Cells[11].Value.ToString();
            btn_ThemMoi.Visible = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiNhanVien();
            txt_MaNhanVien.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenNhanVien.Text = txt_CMND.Text = txt_SoDienThoai.Text = cbb_TenChiNhanh.Text = cbb_CaLam.Text = cbb_BoPhan.Text = txt_DanhGia.Text  = Time_NgayBatDauLam.Text = txt_Luong.Text = "";
            btn_ThemMoi.Visible = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlUpdate = "Update Nhan_Vien set ID_NV = N'" + txt_TaiKhoan.Text + "',Password_NV = '" + txt_MatKhau.Text + "',Ten_NV = N'" + txt_TenNhanVien.Text + "',CMND = '" + txt_CMND.Text + "',Ten_CN = N'" + cbb_TenChiNhanh.Text + "',CaLam = N'" + cbb_CaLam.Text + "',BoPhan = N'" + cbb_BoPhan.Text + "',DanhGia = N'" + txt_DanhGia.Text + "',NgayBatDauLam = '" + Time_NgayBatDauLam.Text + "',Luong = '" + txt_Luong.Text + "' Where Ma_NV = '" + txt_MaNhanVien.Text + "'";
            cmd = new SqlCommand(SqlUpdate, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update fail", "Thông báo");
            }
            HienThiNhanVien();
            txt_MaNhanVien.Text = txt_TaiKhoan.Text = txt_MatKhau.Text = txt_TenNhanVien.Text = txt_CMND.Text = txt_SoDienThoai.Text = cbb_TenChiNhanh.Text = cbb_CaLam.Text = cbb_BoPhan.Text = txt_DanhGia.Text = Time_NgayBatDauLam.Text = txt_Luong.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
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

        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
            Combobox();
            ComboboxSearchChiNhanh();
        }

        private void txt_SearchNhanVien_TextChanged(object sender, EventArgs e)
        {
            (dgv_HienThiDanhSachNhanVien.DataSource as DataTable).DefaultView.RowFilter = string.Format("ID_NV LIKE '%{0}%'", txt_SearchNhanVien.Text); 
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            (dgv_HienThiDanhSachNhanVien.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_CN LIKE '%{0}%'", cbb_SearchTenChiNhanh.Text); 
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

        private void btn_Max_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }
    }
}
