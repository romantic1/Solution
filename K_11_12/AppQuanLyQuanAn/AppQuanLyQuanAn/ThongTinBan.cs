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
    public partial class ThongTinBan : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ThongTinBan()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void ThongTinBan_Load(object sender, EventArgs e)
        {
            HienThiThongTinBan();
            ComboboxTinhTrangBan();
            ComboboxMaKhachHang();
            ComboboxSearchChiNhanh();
            ComboboxTenChiNhanh();
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgv_ThongTinBan.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgv_ThongTinBan.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 1)));
            if (chuoi2 + 1 < 10)
            {
                txt_MaBan.Text = "B0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaBan.Text = "B" + (chuoi2 + 1).ToString();
            }
            conn.Open();
            string SqlInsert = "Insert into ThongTinBan values('" + txt_MaBan.Text + "',N'" + cbb_LoaiBan.Text + "','" + txt_SoLuongNguoi.Text + "',N'" + cbb_TenChiNhanh.Text + "',N'" + cbb_TinhTrangBan.Text + "','" + cbb_MaKhachHang.Text + "')";
            cmd = new SqlCommand(SqlInsert, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Add Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Add fail", "Thông báo");
            }
            HienThiThongTinBan();
            txt_MaBan.Text = cbb_LoaiBan.Text = txt_SoLuongNguoi.Text = cbb_TinhTrangBan.Text = cbb_TenChiNhanh.Text = cbb_MaKhachHang.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        void HienThiThongTinBan()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ThongTinBan", conn);
            da.Fill(dt);
            dgv_ThongTinBan.DataSource = dt;
            dgv_ThongTinBan.RowHeadersVisible = false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaBan.Text = cbb_LoaiBan.Text = txt_SoLuongNguoi.Text = cbb_TinhTrangBan.Text = cbb_TenChiNhanh.Text = cbb_MaKhachHang.Text = "";
            HienThiThongTinBan();
            btn_ThemMoi.Visible = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlUpdate = "Update ThongTinBan set LoaiBan = N'" + cbb_LoaiBan.Text + "',SoLuongNguoi = '" + txt_SoLuongNguoi.Text + "',TinhTrangBan = N'" + cbb_TenChiNhanh.Text + "',Ten_CN = N'" + cbb_TinhTrangBan.Text + "',MaKhachHang = '" +cbb_MaKhachHang.Text + "' Where Ma_Ban = '" + txt_MaBan.Text + "'";
            cmd = new SqlCommand(SqlUpdate, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update fail", "Thông báo");
            }
            HienThiThongTinBan();
            txt_MaBan.Text = cbb_LoaiBan.Text = txt_SoLuongNguoi.Text = cbb_TinhTrangBan.Text = cbb_TenChiNhanh.Text = cbb_MaKhachHang.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        private void dgv_ThongTinBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgv_ThongTinBan.Rows[index];

            txt_MaBan.Text = row.Cells[0].Value.ToString();
            cbb_LoaiBan.Text = row.Cells[1].Value.ToString();
            txt_SoLuongNguoi.Text = row.Cells[2].Value.ToString();
            cbb_TinhTrangBan.Text = row.Cells[4].Value.ToString();
            cbb_TenChiNhanh.Text = row.Cells[3].Value.ToString();
            cbb_MaKhachHang.Text = row.Cells[5].Value.ToString();
            btn_ThemMoi.Visible = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlDelete = "Delete ThongTinBan Where Ma_Ban = '" + txt_MaBan.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }
            HienThiThongTinBan();
            txt_MaBan.Text = cbb_LoaiBan.Text = txt_SoLuongNguoi.Text = cbb_TinhTrangBan.Text = cbb_TenChiNhanh.Text = cbb_MaKhachHang.Text = "";
            btn_ThemMoi.Visible = true;
            conn.Close();
        }

        private void txt_SearchDonHanTongDai_TextChanged(object sender, EventArgs e)
        {
            (dgv_ThongTinBan.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ma_Ban LIKE '%{0}%'", txt_Search.Text); 
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            (dgv_ThongTinBan.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_CN LIKE '%{0}%'", cbb_SearchTenChiNhanh.Text); 
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

        void ComboboxTinhTrangBan()
        {
            cmd = new SqlCommand("Select TinhTrangBan from ThongTinBan", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ThongTinBan");
            cbb_TinhTrangBan.DataSource = ds.Tables[0];
            cbb_TinhTrangBan.DisplayMember = "TinhTrangBan";
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

        void ComboboxMaKhachHang()
        {
            cmd = new SqlCommand("Select Ma_KH from Khach_Hang", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Khach_Hang");
            cbb_MaKhachHang.DataSource = ds.Tables[0];
            cbb_MaKhachHang.DisplayMember = "Ma_KH";
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
