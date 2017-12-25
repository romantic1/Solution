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
    public partial class themmonantongdai : Form
    {
        static SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
        public string MaDHDT
        {
            get;
            set;
        }
        public themmonantongdai()
        {
            InitializeComponent();
        }
        void HienDanhMuc()
        {
            danhmuc.DataSource = kn.LayBang("select * from Danh_Muc");
            danhmuc.DisplayMember = "Ten_DM";
            danhmuc.ValueMember = "Ma_DM";
        }
        void HienMonAnchon()
        {
            dataGridViewmachon.DataSource = kn.LayBang("select ctdhdt.id,mh.Ma_MA,mh.Ten_MA,mh.Gia,mh.GhiChu from Mon_An mh,Chi_Tiet_Don_Hang_DT ctdhdt where mh.Ma_MA = ctdhdt.Ma_MA  and ctdhdt.Ma_DHTD='" + MaDHDT.ToString() + "'");
        }
        private void danhmuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridViewmonan.DataSource = kn.LayBang("select mh.Ma_MA,mh.Ten_MA,mh.Gia,mh.GhiChu from Mon_An mh,Chi_Tiet_Danh_Muc ctdm where mh.Ma_MA = ctdm.Ma_MA  and ctdm.Ma_DM='" + danhmuc.SelectedValue.ToString() + "'");
        }

        private void themmonantongdai_Load_1(object sender, EventArgs e)
        {

            HienDanhMuc();
            HienMonAnchon();

        }


        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            string id = dataGridViewmonan.CurrentRow.Cells[0].Value.ToString();
            kn.ThayDoiDL("insert into Chi_Tiet_Don_Hang_DT values('" + MaDHDT.ToString() + "','" + id.ToString() + "')");
            themmonantongdai_Load_1(sender, e);
        }

        private void HeaderPanelDM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Offthemmonan_Click_1(object sender, EventArgs e)
        {
            DonHangTongDaiCN f = new DonHangTongDaiCN();

            this.Close();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            themmonantongdai_Load_1(sender, e);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            string id = dataGridViewmachon.CurrentRow.Cells[0].Value.ToString();

            string delete = "delete from Chi_Tiet_Don_Hang_DT where id = '" + id.ToString() + "'";
            SqlCommand deletecmd = new SqlCommand(delete, conn);
            deletecmd.CommandType = CommandType.Text;
            deletecmd.ExecuteNonQuery();
            conn.Close();
            themmonantongdai_Load_1(sender, e);
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {

        }

      
    


      

       

       


    }
}
