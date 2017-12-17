using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppQuanLyQuanAn
{
    public partial class ManHinhChinh : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ManHinhChinh()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=DESKTOP-CSFRQ67\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        void HienThiThongTin()
        {
            string SqlSelect = "Select Ten_NV,ID_NV,BoPhan,NgaySinh,DiaChi,CaLam from Nhan_Vien";
            cmd = new SqlCommand(SqlSelect, conn);
        }
    }
}
