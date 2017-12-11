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
    public partial class CapNhatMonAn : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public CapNhatMonAn()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void OffThaoTacCNQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CapNhatMonAn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlUpdate = "Update Mon_An set Ten_MA = N'" + txt_TenMonAn.Text + "',Gia = '" + txt_Gia.Text + "',GhiChu = N'" + txt_GhiChu.Text + "',Ten_DM = N'" + txt_TenDanhMuc.Text + "' Where Ma_MA = '" + txt_MaMonAn.Text + "'";
            cmd = new SqlCommand(SqlUpdate, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Update Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update fail", "Thông báo");
            }
            HienThiMonAn();
            txt_MaMonAn.Text = txt_TenMonAn.Text = txt_Gia.Text = txt_GhiChu.Text = txt_TenDanhMuc.Text = "";
            conn.Close();
        }

        void HienThiMonAn()
        {
            cmd = new SqlCommand("Select * from Mon_An", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_CapNhatMonAn.DataSource = dt;
        }

        private void CapNhatMonAn_Load(object sender, EventArgs e)
        {
            HienThiMonAn();
        }

        

        private void dgv_CapNhatMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgv_CapNhatMonAn.Rows[indexRow];

            txt_MaMonAn.Text = row.Cells[0].Value.ToString();
            txt_TenMonAn.Text = row.Cells[1].Value.ToString();
            txt_Gia.Text = row.Cells[2].Value.ToString();
            txt_GhiChu.Text = row.Cells[3].Value.ToString();
            txt_TenDanhMuc.Text = row.Cells[4].Value.ToString();
        }
    }
}
