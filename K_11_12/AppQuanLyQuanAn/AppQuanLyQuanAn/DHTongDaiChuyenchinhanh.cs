using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanAn
{
    public partial class DHTongDaiChuyenchinhanh : Form
    {
        public DHTongDaiChuyenchinhanh()
        {
            InitializeComponent();
        }
        void hiendonhang()
        {
            HienThiDanhSachDonHangTongDai.DataSource = kn.LayBang("select * from Don_Hang_Tong_Dai where TrangThai != N'Chưa Xác Nhận' and TrangThai != N''");
        }
        private void DHTongDaiChuyenchinhanh_Load(object sender, EventArgs e)
        {
            hiendonhang();
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            HienThiDanhSachDonHangTongDai.DataSource = kn.LayBang("select * from Don_Hang_Tong_Dai where TrangThai = N'" + SearchTenChiNhanh.Text.ToString() + "'");
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            string id = HienThiDanhSachDonHangTongDai.CurrentRow.Cells[0].Value.ToString();
            kn.ThayDoiDL("UPDATE Don_Hang_Tong_Dai SET TrangThai= N'" + cbxacnhan.Text.ToString() + "'where Ma_DHTD = '" + id.ToString() + "'");

            DHTongDaiChuyenchinhanh_Load(sender, e);
        }
    }
}
