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
    public partial class DonHangTongDaiCN : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
        public DonHangTongDaiCN()
        {
            InitializeComponent();
        }
        void hiendonhang()
        {
            dgv_HienThiDanhSachDonHangTongDai.DataSource = kn.LayBang("select * from Don_Hang_Tong_Dai where TrangThai != ''");
        }
        void tongtien()
        {
            conn.Open();
            string sql = "select mh.Ma_MA,mh.Ten_MA,mh.Gia,mh.GhiChu from Mon_An mh,Chi_Tiet_Don_Hang_DT ctdhdt where mh.Ma_MA = ctdhdt.Ma_MA  and ctdhdt.Ma_DHTD='" + lm1.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable lm = new DataTable();
            da.Fill(lm);
            int tongdonhang = 0, a;
            if (lm.Rows.Count > 0)
            {
                for (int i = 0; i < lm.Rows.Count; i++)
                {
                    a = Convert.ToInt32(lm.Rows[i]["Gia"]);
                    tongdonhang = tongdonhang + a;
                }

            }
            txt_TongTien.Text = tongdonhang.ToString();
            conn.Close();
        }
        void hienchinhanh()
        {
            cbb_TenChiNhanh.DataSource = kn.LayBang("select Ten_CN from Chi_Nhanh");
            cbb_TenChiNhanh.DisplayMember = "Ten_CN";
            cbb_TenChiNhanh.ValueMember = "Ten_CN";
        }
        void laymaDH()
        {
            conn.Open();
            string sql = "select * from Don_Hang_Tong_Dai ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable lm = new DataTable();
            da.Fill(lm);
            c = lm.Rows.Count - 1;
            lm1 = Convert.ToInt32(lm.Rows[c]["Ma_DHTD"]);
            T = lm1 + 1;
            conn.Close();
        }
        int c, lm1, T;
        private void DonHangTongDai_Load(object sender, EventArgs e)
        {
            hiendonhang();
            laymaDH();
            tongtien();
            hienchinhanh();
            cbb_SearchTenChiNhanh_SelectedIndexChanged(sender, e);
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            kn.ThayDoiDL("UPDATE Don_Hang_Tong_Dai SET Ten_DH = N'" + txt_TenDonHang.Text.ToString() + "',sdtKH = '" + txt_sdtKH.Text.ToString() + "',dcKH = N'" + txt_dcKH.Text.ToString() + "',Ten_CN = N'" + cbb_TenChiNhanh.SelectedValue.ToString() + "',TrangThai = N'" + cbb_TrangThai.Text.ToString() + "',KhuyenMai = N'" + cbb_KhuyenMai.Text.ToString() + "',ThoiGian = '" + Time_ThoiGian.Text.ToString() + "',TongTien = '" + txt_TongTien.Text.ToString() + "' where Ma_DHTD = '" + lm1.ToString() + "'");
            kn.ThayDoiDL("Insert into Don_Hang_Tong_Dai values('','','','','','','','')");
            DonHangTongDai_Load(sender, e);
            txt_dcKH.Text = "";
            txt_sdtKH.Text = "";
            txt_TenDonHang.Text = "";
            cbb_KhuyenMai.Text = "";
            cbb_TenChiNhanh.Text = "";
            cbb_TrangThai.Text = "";
        }




        private void btn_Xoa_Click(object sender, EventArgs e)
        {


            string id = dgv_HienThiDanhSachDonHangTongDai.CurrentRow.Cells[0].Value.ToString();

            kn.ThayDoiDL("delete from Don_Hang_Tong_Dai  where Ma_DHTD = '" + id.ToString() + "'");

            DonHangTongDai_Load(sender, e);
        }
        private void timkh_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select * from Khach_Hang where SoDienThoai_KH = '" + txt_sdtKH.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable lm = new DataTable();
            da.Fill(lm);
            if (lm.Rows.Count > 0)
            {
                txt_dcKH.Text = lm.Rows[0]["DiaChi_KH"].ToString();
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy", "Thông Báo");
            }
            conn.Close();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            DonHangTongDai_Load(sender, e);
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            themmonantongdai f = new themmonantongdai();
            f.MaDHDT = lm1.ToString();
            f.ShowDialog();
            DonHangTongDai_Load(sender, e);
        }

        private void txt_SearchDonHanTongDai_TextChanged(object sender, EventArgs e)
        {
            (dgv_HienThiDanhSachDonHangTongDai.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_DH LIKE '%{0}%'", txt_SearchDonHanTongDai);
        }

        private void cbb_SearchTenChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_SearchTenChiNhanh.DataSource = kn.LayBang("select Ten_CN from Chi_Nhanh");
            cbb_SearchTenChiNhanh.DisplayMember = "Ten_CN";
            cbb_SearchTenChiNhanh.ValueMember = "Ten_CN";
        }
        private void cbb_TenChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            dgv_HienThiDanhSachDonHangTongDai.DataSource = kn.LayBang("select * from DON_HANG_TONG_DAI where Ten_CN= N'" + cbb_SearchTenChiNhanh.SelectedValue.ToString() + "'");
        }

        private void gbSearchCNQL_Enter(object sender, EventArgs e)
        {

        }




    }

}
