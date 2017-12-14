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
    public partial class BaoCaoThongKe : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public BaoCaoThongKe()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            ComboboxTenChiNhanh();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        void ComboboxTenChiNhanh()
        {
            cmd = new SqlCommand("Select Ten_CN from Chi_Nhanh", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Chi_Nhanh");
            //cbb_TenChiNhanh.DataSource = ds.Tables[0];
            //cbb_TenChiNhanh.DisplayMember = "Ten_CN";
        }
    }
}
