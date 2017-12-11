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
    public partial class ChiNhanhQL : Form
    {
        DataTable dt = new DataTable();
        SqlConnection conn;
        SqlCommand cmd;
        public delegate void SendMessage(string Message);
        public SendMessage Sender;

        public ChiNhanhQL()
        {
            InitializeComponent();
            String Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
            
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiNhanhQL_Load(object sender, EventArgs e)
        {
            HienThiThongTinCN();
            HienThiDanhSachMonAn();
        }

        void HienThiThongTinCN()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Chi_Nhanh", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_HienThiThongTinCN.DataSource = dt;
        }

        //void HienThiMonAn()
        //{
        //    string SqlSelect = "Select * from MON_AN";
        //    cmd = new SqlCommand(SqlSelect, conn);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(dr);
        //    dgvHienThiDanhSachMonAn.DataSource = dt;            
        //}

        void HienThiDanhSachMonAn()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Mon_An",conn);
            da.Fill(dt);
            dgvHienThiDanhSachMonAn.DataSource = dt;
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (dgvHienThiDanhSachMonAn.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_DM LIKE '%{0}%'",  cbb_DanhMucMonAn.SelectedItem.ToString());        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SqlSelect = "Select * from MON_AN";
            cmd = new SqlCommand(SqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHienThiDanhSachMonAn.DataSource = dt;     
        }

        private void ThemMoiCNQL_Click(object sender, EventArgs e)
        {
            ThemChiNhanh frmTCN = new ThemChiNhanh();
            frmTCN.ShowDialog();
            HienThiThongTinCN();
            HienThiDanhSachMonAn();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            CapNhatChiNhanh frmCNCN = new CapNhatChiNhanh();
            frmCNCN.ShowDialog();
            HienThiThongTinCN();
            HienThiDanhSachMonAn();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            XoaChiNhanh frmXCN = new XoaChiNhanh();
            frmXCN.ShowDialog();
            HienThiThongTinCN();
            HienThiDanhSachMonAn();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThemMonAn frmTMA = new ThemMonAn();
            frmTMA.ShowDialog();
            HienThiThongTinCN();
            HienThiDanhSachMonAn();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CapNhatMonAn frmCNMA = new CapNhatMonAn();
            frmCNMA.ShowDialog();
            HienThiThongTinCN();
            HienThiDanhSachMonAn();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            XoaMonAn frmXMA = new XoaMonAn();
            frmXMA.ShowDialog();
            HienThiThongTinCN();
            HienThiDanhSachMonAn();
        }

        private void dgv_HienThiThongTinCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgv_HienThiThongTinCN.Rows[indexRow];

            txt_MaChiNhanh.Text = row.Cells[0].Value.ToString();
            txt_TenChiNhanh.Text = row.Cells[1].Value.ToString();
            txt_SoDienThoai.Text = row.Cells[2].Value.ToString();
            txt_DiaChi.Text = row.Cells[3].Value.ToString();
            cbb_TinhThanh.Text = row.Cells[4].Value.ToString();
            cbb_TinhTrang.Text = row.Cells[5].Value.ToString();
            Time_NgayThanhLap.Text = row.Cells[6].Value.ToString();
            txt_MaMonAn.Text = row.Cells[7].Value.ToString();
            txt_SoBan.Text = row.Cells[8].Value.ToString();
        }

        private void RefeshDM_Click(object sender, EventArgs e)
        {
            HienThiThongTinCN();
            HienThiDanhSachMonAn();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        { 
            (dgv_HienThiThongTinCN.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_CN LIKE '%{0}%'", txt_Search.Text); 
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            (dgvHienThiDanhSachMonAn.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_MA LIKE '%{0}%'", txt_SearchMonAn.Text);
        }

        private void HeaderPanelDM_Paint(object sender, PaintEventArgs e)
        {

        }

        //void ComboboxMonAn()
        //{
        //    cmd = new SqlCommand("Select Ten_DM from Mon_An", conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds, "Mon_An");
        //    cbb_DanhMucMonAn.DataSource = ds.Tables[0];
        //    cbb_DanhMucMonAn.DisplayMember = "Ten_DM";
        //}
    }
}
