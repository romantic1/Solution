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

        void HienThiMonAn()
        {
            string SqlSelect = "Select * from MON_AN";
            cmd = new SqlCommand(SqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHienThiDanhSachMonAn.DataSource = dt;            
        }

        void HienThiDanhSachMonAn()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Mon_An",conn);
            da.Fill(dt);
            dgvHienThiDanhSachMonAn.DataSource = dt;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Text)
            {
                case "Bò":
                    string SqlSelect = "SELECT * FROM DANH_MUC Where Ma_DM = 'DM1'";
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgvHienThiDanhSachMonAn.DataSource = dt;
                    break;
                case "Gà":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM2'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgvHienThiDanhSachMonAn.DataSource = dt;
                    break;
                case "Heo":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM3'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgvHienThiDanhSachMonAn.DataSource = dt;
                    break;
                case "Dê":
                   SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM4'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgvHienThiDanhSachMonAn.DataSource = dt;
                    break;
               case "Cá":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM5'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgvHienThiDanhSachMonAn.DataSource = dt;
                    break;
                case "Bạch tuộc":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM6'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgvHienThiDanhSachMonAn.DataSource = dt;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SqlSelect = "Select * from MON_AN";
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvHienThiDanhSachMonAn.DataSource = dt;     
        }

        private void ThemMoiCNQL_Click(object sender, EventArgs e)
        {
            ThemChiNhanh frmTCN = new ThemChiNhanh();
            frmTCN.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            CapNhatChiNhanh frmCNCN = new CapNhatChiNhanh();
            frmCNCN.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            XoaChiNhanh frmXCN = new XoaChiNhanh();
            frmXCN.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThemMonAn frmTMA = new ThemMonAn();
            frmTMA.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CapNhatMonAn frmCNMA = new CapNhatMonAn();
            frmCNMA.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            XoaMonAn frmXMA = new XoaMonAn();
            frmXMA.ShowDialog();
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
            //DataTable dt = new DataTable("Chi_Nhanh");
            //DataView dv = new DataView(dt);
            //dv.RowFilter = string.Format("Ten_CN like '%{0}%'", txt_Search.Text);
            (dgv_HienThiThongTinCN.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_CN LIKE '%{0}%'", txt_Search.Text);
            //dgv_HienThiThongTinCN.DataSource = dv;
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            (dgvHienThiDanhSachMonAn.DataSource as DataTable).DefaultView.RowFilter = string.Format("Ten_MA LIKE '%{0}%'", txt_SearchMonAn.Text);
        }
    }
}
