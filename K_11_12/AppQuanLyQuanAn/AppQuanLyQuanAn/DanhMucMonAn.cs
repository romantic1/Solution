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
        public DanhMucMonAn()
        {
            InitializeComponent();
        }

        private void OffDanhMuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DanhMucMonAn_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonAn();
            LoadlbDanhMucMonAn();
            MaTuTangMonAn();

        }

        Provider kn = new Provider();
        int index;

//Hien Thi Man Hinh
        private void ClearScr()
        {
            
            
            txtTenMA.Clear();
            txtTenDM.Clear();
            txtTimKiemMA.Clear();
            txtTimKiemDM.Clear();
            txtGia.Clear();
            txtGhiChu.Clear();
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
        private void RefeshDM_Click(object sender, EventArgs e)
        {
            LoadDanhSachMonAn();
            LoadlbDanhMucMonAn();
            MaTuTangMonAn();
            ClearScr();
        }
        private void dgvDanhSachMA_Click(object sender, EventArgs e)
        {
            index = dgvDanhSachMA.CurrentRow.Index;
            txtMaMA.Text = dgvDanhSachMA.Rows[index].Cells[0].Value.ToString();
            txtTenMA.Text = dgvDanhSachMA.Rows[index].Cells[1].Value.ToString();
            txtGia.Text = dgvDanhSachMA.Rows[index].Cells[2].Value.ToString();
            txtGhiChu.Text = dgvDanhSachMA.Rows[index].Cells[3].Value.ToString();
            cbDanhMucMA.Text = dgvDanhSachMA.Rows[index].Cells[4].Value.ToString();
        }

        private void  LoadDanhSachMonAn()
        {
            kn.Connect();

            string sql = "select * from Mon_An ";
            dgvDanhSachMA.DataSource = kn.Select(CommandType.Text, sql);


            kn.Disconnect();
        }

        private void MaTuTangMonAn()
        {
            kn.Connect();

            string sql = "select * from Mon_An ";          
            //dgvDanhSachMA.DataSource = kn.Select(CommandType.Text, sql);
            SqlCommand cmd = new SqlCommand(sql, kn.Connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string g = "";
            if ((dt.Rows.Count <= 0))
            {               
                g = "MA01";
            }
            else
            {
                int k;
                g = "MA";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k <= 10)
                {
                    g = g + "0";
                    g = g + k.ToString();
                }
                txtMaMA.Text = g;
            }

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
        
        
//Phim Chuc Nang

        //Mon An
        private void btnThemMA_Click(object sender, EventArgs e)
        {
            kn.Connect();
            string sqladd = " insert into Mon_An values (@Ma_MA, @Ten_MA, @Gia, @GhiChu, @DanhMuc)";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqladd, kn.Connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Ma_MA", txtMaMA.Text));
                cmd.Parameters.Add(new SqlParameter("Ten_MA", txtTenMA.Text));
                cmd.Parameters.Add(new SqlParameter("Gia", float.Parse(txtGia.Text)));
                cmd.Parameters.Add(new SqlParameter("GhiChu", txtGhiChu.Text));
                cmd.Parameters.Add(new SqlParameter("DanhMuc", cbDanhMucMA.Text));
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            LoadDanhSachMonAn();
            ClearScr();
            MaTuTangMonAn();
            kn.Disconnect();
        }
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

                dgvDanhSachMA.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            kn.Disconnect();
            ClearScr();
        }
        private void btnCapNhatMA_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqledit = " update Mon_An SET Ma_MA = @Ma_MA, Ten_MA = @Ten_MA, Gia = @Gia, GhiChu = @GhiChu, Ten_DM = @DanhMuc where Ma_MA = @Ma_MA ";
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn sửa đổi thông tin món ăn?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd;
                    cmd = new SqlCommand(sqledit, kn.Connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("Ma_MA", txtMaMA.Text));
                    cmd.Parameters.Add(new SqlParameter("Ten_MA", txtTenMA.Text));
                    cmd.Parameters.Add(new SqlParameter("Gia", float.Parse(txtGia.Text)));
                    cmd.Parameters.Add(new SqlParameter("GhiChu", txtGhiChu.Text));
                    cmd.Parameters.Add(new SqlParameter("DanhMuc", cbDanhMucMA.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thành công!", "Thông Báo");
                }
                else
                {
                    return;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            LoadDanhSachMonAn();
            ClearScr();
            MaTuTangMonAn();
            kn.Disconnect();
        
        }
        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqldelete = "delete from Mon_An where Ma_MA = @Ma_MA ";
            try
            {
                if (txtMaMA.Text == "" || txtTenMA.Text == "" || txtGia.Text == "" || cbDanhMucMA.Text == "")
                {
                    MessageBox.Show("Bạn cần chọn một món ăn cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    
                    if (MessageBox.Show("Bạn thực sự muốn xóa món ăn này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SqlCommand cmd;
                        cmd = new SqlCommand(sqldelete, kn.Connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add(new SqlParameter("Ma_MA", txtMaMA.Text));
                        cmd.Parameters.Add(new SqlParameter("Ten_MA", txtTenMA.Text));
                        cmd.Parameters.Add(new SqlParameter("Gia", float.Parse(txtGia.Text)));
                        cmd.Parameters.Add(new SqlParameter("GhiChu", txtGhiChu.Text));
                        cmd.Parameters.Add(new SqlParameter("DanhMuc", cbDanhMucMA.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã Xóa!", "Thông Báo");
                    }
                    else
                    {
                        return;
                    }
                }


            }
            catch (SqlException ex)
            {
                throw ex;
            }
            LoadDanhSachMonAn();
            MaTuTangMonAn();
            ClearScr();
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
            ClearScr();
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
            ClearScr();

            kn.Disconnect();
        }  
        private void lbDanhMucMonAn_Click(object sender, EventArgs e)
        {
          
            txtMaDM.Text = "";
            txtTenDM.Text = lbDanhMucMonAn.SelectedValue.ToString();
        }
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            kn.Connect();
            string sqladd = " insert into Danh_Muc values (@Ma_DM, @Ten_DM )";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqladd, kn.Connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Ma_DM", txtMaDM.Text));
                cmd.Parameters.Add(new SqlParameter("Ten_DM", txtTenDM.Text));
                

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
             LoadlbDanhMucMonAn();

            kn.Disconnect();
        }
        private void btnCapNhatDM_Click(object sender, EventArgs e)
        {
            kn.Connect();

            string sqledit = " update Danh_Muc SET Ma_DM = @MaDM, Ten_DM = @TenDM where Ma_DM = @MaDM ";
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand(sqledit, kn.Connection);
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
    }
}
