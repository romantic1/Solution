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
    public partial class XacNhanDHDT : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
        public XacNhanDHDT()
        {
            InitializeComponent();
        }
        void hiendonhang()
        {
            HienThiDanhSachDonHangTongDai.DataSource = kn.LayBang("select * from Don_Hang_Tong_Dai where  TrangThai != N''");
        }

        private void XacNhanDHDT_Load_1(object sender, EventArgs e)
        {
            hiendonhang();
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {


            string id = HienThiDanhSachDonHangTongDai.CurrentRow.Cells[0].Value.ToString();
            kn.ThayDoiDL("UPDATE Don_Hang_Tong_Dai SET TrangThai= N'Đã Xác Nhận'where Ma_DHTD = '" + id.ToString() + "'");

            XacNhanDHDT_Load_1(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            HienThiDanhSachDonHangTongDai.DataSource = kn.LayBang("select * from Don_Hang_Tong_Dai where TrangThai = N'" + SearchTenChiNhanh.Text.ToString() + "'");
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            XacNhanDHDT_Load_1(sender, e);
        }
    }
}
