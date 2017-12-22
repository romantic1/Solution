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
    public partial class ThemChiNhanh : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public ThemChiNhanh()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void OffThaoTacCNQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLiChiNhanh frmQLCT = new QuanLiChiNhanh();
            this.Close();
            frmQLCT.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgv_ThemChiNhanh.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgv_ThemChiNhanh.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txt_MaChiNhanh.Text = "CN0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaChiNhanh.Text = "CN" + (chuoi2 + 1).ToString();
            }
            conn.Open();
            string SqlInsert = "Insert into Chi_Nhanh values('" + txt_MaChiNhanh.Text + "',N'" + txt_TenChiNhanh.Text + "','" + txt_SoDienThoai.Text + "',N'" + txt_DiaChi.Text + "',N'" + cbb_TinhThanh.Text + "',N'" + cbb_TinhTrang.Text + "','" + dateTimePicker1.Text + "','" + txt_MaMonAn.Text + "','" + txt_SoBan.Text + "')";
            cmd = new SqlCommand(SqlInsert, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Add Successful", "Thông báo");
            }
            else
            {
                MessageBox.Show("Add fail", "Thông báo");
            }
            HienThiChiNhanh();
            txt_MaChiNhanh.Text = txt_TenChiNhanh.Text = txt_DiaChi.Text = cbb_TinhThanh.Text = cbb_TinhTrang.Text = txt_SoBan.Text = txt_MaMonAn.Text = txt_SoDienThoai.Text = "";
            conn.Close();
        }

        void HienThiChiNhanh()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Chi_Nhanh",conn);
            da.Fill(dt);
            dgv_ThemChiNhanh.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            HienThiChiNhanh();
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
