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
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void XoaMonAn_Load(object sender, EventArgs e)
        {
            ComboboxMonAn();
        }

        private void btn_XoaMonAn_Click(object sender, EventArgs e)
        {
            conn.Open();
            //string SqlDelete = "Delete Mon_An Where Ten_MA = '" + cbb_TenMonAn.Text + "'";
            //cmd = new SqlCommand(SqlDelete, conn);
            //if (cmd.ExecuteNonQuery() == 1)
            //{
            //    MessageBox.Show("Delete Successful", "Thông báo");
            //}
            //else
            //{
            //    MessageBox.Show("Delete fail", "Thông báo");
            //}
            //ComboboxMonAn();
            string SqlDelete = "Delete Mon_An Where Ten_MA = '" + cbb_TenMonAn.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }
            conn.Close();
        }

        void ComboboxMonAn()
        {
            cmd = new SqlCommand("Select Ten_MA from Mon_An", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Mon_An");
            cbb_TenMonAn.DataSource = ds.Tables[0];
            cbb_TenMonAn.DisplayMember = "Ten_MA";
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiNhanhQL frmCNQL = new ChiNhanhQL();
            this.Close();
            frmCNQL.Show();
        }
    }
}
