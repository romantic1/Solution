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
    public partial class XoaMonAn : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public XoaMonAn()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void XoaMonAn_Load(object sender, EventArgs e)
        {
            ComboboxMonAn();
        }

        private void btn_XoaMonAn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlDelete = "Delete Mon_An Where Ma_MA = '" + cbb_MaMonAn.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }          
            ComboboxMonAn();
            conn.Close();
        }

        void ComboboxMonAn()
        {
            cmd = new SqlCommand("Select Ma_MA from Mon_An", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Mon_An");
            cbb_MaMonAn.DataSource = ds.Tables[0];
            cbb_MaMonAn.DisplayMember = "Ma_MA";
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLiChiNhanh frmCNQL = new QuanLiChiNhanh();
            this.Close();
            frmCNQL.Show();
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
