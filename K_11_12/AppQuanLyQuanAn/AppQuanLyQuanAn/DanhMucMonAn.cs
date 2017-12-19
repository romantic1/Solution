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
    public partial class DanhMucMonAn : Form
    {
        //Hien thi
        public DanhMucMonAn()
        {
            InitializeComponent();
        }

        Provider kn = new Provider();
        int index;
        

        

        private void btnResetManHinh_Click(object sender, EventArgs e)
        {

            LoadDanhSachMonAn();
            LoadlbDanhMucMonAn();
            txtMaMA.Clear();
            txtMaDM.Clear();
            txtTenMA.Clear();
            txtTenDM.Clear();
            txtTimKiemMA.Clear();
            txtTimKiemDM.Clear();
            txtGia.Clear();
            txtGhiChu.Clear();

        }

        private void LoadDanhSachMonAn()
        {


            kn.Connect();
            string sql = "select * from Mon_An ";
            //--Cach 1
            //SqlCommand cmd = new SqlCommand(sql, kn.Connection);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgvDanhSachMonAn.DataSource = dt;

            //--Cach 2
            dgvDanhSachMonAn.DataSource = kn.Select(CommandType.Text, sql);

            kn.Disconnect();
        }

        private void LoadlbDanhMucMonAn()
        {

            kn.Connect();

            string sql = "select * from Danh_Muc";
            lbDanhMucMonAn.DataSource = kn.Select(CommandType.Text, sql);
            lbDanhMucMonAn.DisplayMember = "Tên Danh Mục";
            lbDanhMucMonAn.ValueMember = "Ten_DM"; // Them cot Loai Mon An

            kn.Disconnect();
        }

        private void DanhMucMonAn_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonAn();
            LoadlbDanhMucMonAn();
        }

        private void dgvDanhSachMonAn_Click(object sender, EventArgs e)
        {
            index = dgvDanhSachMonAn.CurrentRow.Index;
            txtMaMA.Text = dgvDanhSachMonAn.Rows[index].Cells[0].Value.ToString();
            txtTenMA.Text = dgvDanhSachMonAn.Rows[index].Cells[1].Value.ToString();
            txtGia.Text = dgvDanhSachMonAn.Rows[index].Cells[2].Value.ToString();
            cbDanhMuc.Text = dgvDanhSachMonAn.Rows[index].Cells[3].Value.ToString();
            txtGhiChu.Text = dgvDanhSachMonAn.Rows[index].Cells[4].Value.ToString();
        }


        //Cac phim chuc nang

        //Mon An
        private void btnTimKiemMA_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqlTimKiem = "select * from Mon_An where Ma_MA LIKE  '" + txtTimKiemMA.Text + "'";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqlTimKiem, kn.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDanhSachMonAn.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            kn.Disconnect();
        }

        private void btnThemMA_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqladd = " insert into Mon_An values (@Ma_MA, @Ten_MA, @Gia, @DanhMuc, @GhiChu)";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqladd, kn.Connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Ma_MA", txtMaMA.Text));
                cmd.Parameters.Add(new SqlParameter("Ten_MA", txtTenMA.Text));
                cmd.Parameters.Add(new SqlParameter("Gia", float.Parse(txtGia.Text)));
                cmd.Parameters.Add(new SqlParameter("DanhMuc", cbDanhMuc.Text));
                cmd.Parameters.Add(new SqlParameter("GhiChu", txtGhiChu.Text));

                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            LoadDanhSachMonAn();

            kn.Disconnect();
        }

        private void btnCapNhatMA_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqledit = " update Mon_An SET Ma_MA = @Ma_MA, Ten_MA = @Ten_MA, Gia = @Gia, DanhMuc = @DanhMuc, GhiChu = @GhiChu where Ma_MA = @Ma_MA ";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqledit, kn.Connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Ma_MA", txtMaMA.Text));
                cmd.Parameters.Add(new SqlParameter("Ten_MA", txtTenMA.Text));
                cmd.Parameters.Add(new SqlParameter("Gia", float.Parse(txtGia.Text)));
                cmd.Parameters.Add(new SqlParameter("DanhMuc", cbDanhMuc.Text));
                cmd.Parameters.Add(new SqlParameter("GhiChu", txtGhiChu.Text));

                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            LoadDanhSachMonAn();

            kn.Disconnect();

        }

        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqldelete = "delete from Mon_An where Ma_MA = @Ma_MA ";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqldelete, kn.Connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Ma_MA", txtMaMA.Text));
                cmd.Parameters.Add(new SqlParameter("Ten_MA", txtTenMA.Text));
                cmd.Parameters.Add(new SqlParameter("Gia", float.Parse(txtGia.Text)));
                cmd.Parameters.Add(new SqlParameter("GhiChu", txtGhiChu.Text));

                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            LoadDanhSachMonAn();

            kn.Disconnect();
        }


        //Danh Muc
        private void btnTimKiemDM_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqlTimKiem = "select * from Danh_Muc where Ma_DM LIKE  '" + txtTimKiemDM.Text + "'";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqlTimKiem, kn.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lbDanhMucMonAn.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            kn.Disconnect();
        }

   

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            //kn.Connect();

            //string sqladd = " insert into Danh_Muc values ( @MaDM, @TenDM, @MaCN)";
            //try
            //{
            //    SqlCommand cmd;
            //    cmd = new SqlCommand(sqladd, kn.Connection);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.Add(new SqlParameter("MaDM", txtMaMA.Text));
            //    cmd.Parameters.Add(new SqlParameter("TenDM", txtTenMA.Text));
            //    cmd.Parameters.Add(new SqlParameter("MaCN", ""));

            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException ex)
            //{
            //    throw ex;
            //}
            //LoadlbDanhMucMonAn();

            //kn.Disconnect();
        }

        private void btnCapNhatDM_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqldelete = "delete from Danh_Muc where Ma_DM = @MaDM ";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqldelete, kn.Connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("MaDM", txtMaDM.Text));
                cmd.Parameters.Add(new SqlParameter("TenDM", txtTenDM.Text));
               

                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            LoadlbDanhMucMonAn();

            kn.Disconnect();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
