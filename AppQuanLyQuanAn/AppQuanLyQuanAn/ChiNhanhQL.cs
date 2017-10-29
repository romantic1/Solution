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
        int SelectedRow;
        DataTable dt = new DataTable();
        private SqlConnection conn;
        public ChiNhanhQL()
        {
            InitializeComponent();
        }

        private void OffChiNhanh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemMoiCNQL_Click_1(object sender, EventArgs e)
        {
            dt.Rows.Add(text1.Text, text2.Text, text3.Text, text4.Text, cb5.Text, cb6.Text, dt7.Text);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Add successful!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow update = dataGridView1.Rows[SelectedRow];
            update.Cells[0].Value = text1.Text;
            update.Cells[1].Value = text2.Text;
            update.Cells[2].Value = text3.Text;
            update.Cells[3].Value = text4.Text;
            update.Cells[4].Value = cb5.Text;
            update.Cells[5].Value = cb6.Text;
            update.Cells[6].Value = dt7.Text;
            MessageBox.Show("Update successful!");
        }

        private void ChiNhanhQL_Load(object sender, EventArgs e)
        {
            string maChiNhanh = text1.ToString();
            string tenChiNhanh = text2.ToString();
            string diaChi = text3.ToString();
            string soDienThoai = text4.ToString();
            string tinhThanh = cb5.ToString();
            string tinhTrang = cb6.ToString();

            string connection = (@"Data Source=DESKTOP-0MT2C0B\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True");
            conn = new SqlConnection(connection);
            conn.Open();
            HienThiLB();       
        }

        void HienThiMonAn()
        {
            string SqlSelect = "Select * from MON_AN";
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;            
        }

        void HienThiLB()
        {
            SqlDataAdapter dr = new SqlDataAdapter("Select * from CHI_NHANH", conn);
            dr.Fill(dt);

            listBox1.Items.Clear();
            foreach (DataRow di in dt.Rows)
            {
                listBox1.Items.Add(di["Ma_CN"].ToString());
                listBox1.Items.Add(di["Ten_CN"].ToString());
                listBox1.Items.Add(di["SoDienThoai_CN"].ToString());
                listBox1.Items.Add(di["DiaChi_CN"].ToString());
                listBox1.Items.Add(di["TinhThanh"].ToString());           
            }
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
                    dataGridView1.DataSource = dt;
                    break;
                case "Gà":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM2'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    break;
                case "Heo":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM3'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    break;
                case "Dê":
                   SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM4'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    break;
               case "Cá":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM5'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    break;
                case "Bạch tuộc":
                    SqlSelect = "SELECT * FROM [dbo].[DANH_MUC] Where Ma_DM = 'DM6'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(SelectedRow);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string SqlSelect = "Select * from CHI_NHANH";
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[SelectedRow];
            text1.Text = row.Cells[0].Value.ToString();
            text2.Text = row.Cells[1].Value.ToString();
            text3.Text = row.Cells[2].Value.ToString();
            text4.Text = row.Cells[3].Value.ToString();
            cb5.Text = row.Cells[4].Value.ToString();
            cb6.Text = row.Cells[5].Value.ToString();
            dt7.Text = row.Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SqlSelect = "Select * from MON_AN";
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;     
        }    
    }
}
