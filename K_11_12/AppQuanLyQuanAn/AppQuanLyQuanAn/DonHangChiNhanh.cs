﻿using System;
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
    public partial class DonHangChiNhanh : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public DonHangChiNhanh()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void DonHangChiNhanh_Load(object sender, EventArgs e)
        {
            ComboboxMaKhachHang();
            ComboboxTenChiNhanh();
            ComboboxNhanVien();
            ComboboxSearchChiNhanh();
            HienThiDonHangChiNhanh();
        }

        void HienThiDonHangChiNhanh()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Don_Hang_Chi_Nhanh", conn);
            da.Fill(dt);
            dgv_HienThiDanhSachDonHangChiNhanh.DataSource = dt;
            dgv_HienThiDanhSachDonHangChiNhanh.RowHeadersVisible = false;
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgv_HienThiDanhSachDonHangChiNhanh.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgv_HienThiDanhSachDonHangChiNhanh.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 4)));
            if (chuoi2 + 1 < 10)
            {
                txt_MaDonHang.Text = "DHCN0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaDonHang.Text = "DHCN" + (chuoi2 + 1).ToString();
            }
            conn.Open();
            if (txt_TenDonHang.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin!");
            }
            else 
            {
                string SqlInsert = "Insert into Don_Hang_Chi_Nhanh values('" + txt_MaDonHang.Text + "',N'" + txt_TenDonHang.Text + "','" + cbb_MaKhachHang.Text + "',N'" + cbb_TenChiNhanh.Text + "',N'" + cbb_TrangThai.Text + "',N'" + cbb_KhuyenMai.Text + "',N'" + cbb_NhanVien.Text + "','" + Time_ThoiGian.Text + "','" + txt_TongTien.Text + "')";
                cmd = new SqlCommand(SqlInsert, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Add Successful", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Add fail", "Thông báo");
                }
                HienThiDonHangChiNhanh();
                txt_MaDonHang.Text = txt_TenDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = cbb_TrangThai.Text = cbb_KhuyenMai.Text = cbb_NhanVien.Text = Time_ThoiGian.Text = txt_TongTien.Text = "";
                btn_ThemMoi.Visible = true;
            }
            conn.Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            HienThiDonHangChiNhanh();
            txt_MaDonHang.Text = txt_TenDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = cbb_TrangThai.Text = cbb_KhuyenMai.Text = cbb_NhanVien.Text = Time_ThoiGian.Text = txt_TongTien.Text = "";
            btn_ThemMoi.Visible = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlUpdate = "Update Don_Hang_Chi_Nhanh set Ten_DH = N'" + txt_TenDonHang.Text + "',Ma_KH = '" + cbb_MaKhachHang.Text + "',Ten_CN = N'" + cbb_TenChiNhanh.Text + "',TrangThai = N'" + cbb_TrangThai.Text + "',KhuyenMai = N'" + cbb_KhuyenMai.Text + "',NhanVien = N'" + cbb_NhanVien.Text + "',ThoiGian = '" + Time_ThoiGian.Text + "',TongTien = '" + txt_TongTien.Text + "' Where Ma_DHCN = '" + txt_MaDonHang.Text + "'";
            cmd = new SqlCommand(SqlUpdate, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update fail", "Thông báo");
            }
            HienThiDonHangChiNhanh();
            txt_MaDonHang.Text = txt_TenDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = cbb_TrangThai.Text = cbb_KhuyenMai.Text = cbb_NhanVien.Text = Time_ThoiGian.Text = txt_TongTien.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlDelete = "Delete Don_Hang_Chi_Nhanh Where Ma_DHCN = '" + txt_MaDonHang.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }
            HienThiDonHangChiNhanh();
            txt_MaDonHang.Text = txt_TenDonHang.Text = cbb_MaKhachHang.Text = cbb_TenChiNhanh.Text = cbb_TrangThai.Text = cbb_KhuyenMai.Text = cbb_NhanVien.Text = Time_ThoiGian.Text = txt_TongTien.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        private void dgv_HienThiDanhSachDonHangChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgv_HienThiDanhSachDonHangChiNhanh.Rows[index];

            txt_MaDonHang.Text = row.Cells[0].Value.ToString();
            txt_TenDonHang.Text = row.Cells[1].Value.ToString();
            cbb_MaKhachHang.Text = row.Cells[2].Value.ToString();
            cbb_TenChiNhanh.Text = row.Cells[3].Value.ToString();
            cbb_TrangThai.Text = row.Cells[4].Value.ToString();
            cbb_KhuyenMai.Text = row.Cells[5].Value.ToString();
            cbb_NhanVien.Text = row.Cells[6].Value.ToString();
            Time_ThoiGian.Text = row.Cells[7].Value.ToString();
            txt_TongTien.Text = row.Cells[8].Value.ToString();
            btn_ThemMoi.Visible = false;
        }

        void ComboboxMaKhachHang()
        {
            cmd = new SqlCommand("Select Ma_KH from Khach_Hang", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Khach_Hang");
            cbb_MaKhachHang.DataSource = ds.Tables[0];
            cbb_MaKhachHang.DisplayMember = "Ma_KH";
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

        void ComboboxNhanVien()
        {
            cmd = new SqlCommand("Select Ma_NV from Nhan_Vien", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nhan_Vien");
            cbb_NhanVien.DataSource = ds.Tables[0];
            cbb_NhanVien.DisplayMember = "Ma_NV";
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            (dgv_HienThiDanhSachDonHangChiNhanh.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_CN LIKE '%{0}%'", cbb_SearchTenChiNhanh.Text);
        }

        private void txt_SearchDonHangChiNhanh_TextChanged(object sender, EventArgs e)
        {
            (dgv_HienThiDanhSachDonHangChiNhanh.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_DH LIKE '%{0}%'", txt_SearchDonHangChiNhanh.Text);
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
