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
    public partial class XoaChiNhanh : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public XoaChiNhanh()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void btn_XoaChiNhanh_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlDelete = "Delete Chi_Nhanh Where Ma_CN = '" + cbb_MaChiNhanh.Text + "'";
            cmd = new SqlCommand(SqlDelete, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Delete Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Delete fail", "Thông báo");
            }
            Combobox();
            conn.Close();
        }

        void Combobox()
        {
            cmd = new SqlCommand("Select Ma_CN from Chi_Nhanh", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Chi_Nhanh");
            cbb_MaChiNhanh.DataSource = ds.Tables[0];
            cbb_MaChiNhanh.DisplayMember = "Ma_CN";
        }

        private void XoaChiNhanh_Load(object sender, EventArgs e)
        {
            Combobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLiChiNhanh frmCNQL = new QuanLiChiNhanh();
            this.Close();
            frmCNQL.Show();
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
