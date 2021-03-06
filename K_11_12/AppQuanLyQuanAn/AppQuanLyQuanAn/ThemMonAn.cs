﻿using System;
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
    public partial class ThemMonAn : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ThemMonAn()
        {
            InitializeComponent();
            string Sqlconnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(Sqlconnection);
        }

        private void btn_ThemMonAn_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dgv_ThemMonAn.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dgv_ThemMonAn.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
            if (chuoi2 + 1 < 10)
            {
                txt_MaMonAn.Text = "MA0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                txt_MaMonAn.Text = "MA" + (chuoi2 + 1).ToString();
            }
            conn.Open();
            if (txt_TenMonAn.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin!");
            }
            else
            {
                string SqlInsert = "Insert into Mon_An values('" + txt_MaMonAn.Text + "',N'" + txt_TenMonAn.Text + "','" + txt_Gia.Text + "',N'" + txt_GhiChu.Text + "',N'" + cbb_TenDanhMuc.Text + "')";
                cmd = new SqlCommand(SqlInsert, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Add Successful", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Add fail", "Thông báo");
                }
                HienThiMonAn();
                txt_MaMonAn.Text = txt_TenMonAn.Text = txt_Gia.Text = txt_GhiChu.Text = cbb_TenDanhMuc.Text = "";
            }
            conn.Close();
        }

        private void OffThaoTacCNQL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ComboboxDanhMuc()
        {
            cmd = new SqlCommand("Select Ten_DM from Mon_An", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Mon_An");
            cbb_TenDanhMuc.DataSource = ds.Tables[0];
            cbb_TenDanhMuc.DisplayMember = "Ten_DM";
        }

        private void ThemMonAn_Load(object sender, EventArgs e)
        {
            HienThiMonAn();
            ComboboxDanhMuc();
        }

        void HienThiMonAn()
        {
            cmd = new SqlCommand("Select * from Mon_An", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_ThemMonAn.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            this.Close();
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
