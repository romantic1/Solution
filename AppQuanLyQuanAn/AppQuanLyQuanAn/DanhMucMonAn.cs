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
            danhmuc.DataSource = kn.LayBang("select Ten_DM,Ma_DM from Danh_Muc_Chinh");
            danhmuc.DisplayMember = "Ten_DM";
            danhmuc.ValueMember = "Ma_DM";

            

        }

        private void danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            monan.DataSource = kn.LayBang("select Ma_MA,Ten_MA,Gia_MA,GhiChu from Mon_An where Ma_DM='" + danhmuc.SelectedValue.ToString() + "'");
        }
        string them;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void danhmuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn1 = new SqlConnection(@"Data Source=HOME\SQLEXPRESS;Initial Catalog=QLQUANAN;Integrated Security=True");
                kn1.Open();
                them = "insert into Danh_Muc_chinh values('',N'" + tendanhm.Text + "')";
                if (them == null)
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
                SqlCommand comthem = new SqlCommand(them, kn1);
                comthem.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công");
                DanhMucMonAn_Load(sender, e);
                madanhm.Clear();
                tendanhm.Clear();

            }
            catch
            {
                MessageBox.Show("Thêm Không Thành Công");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=HOME\SQLEXPRESS;Initial Catalog=QLQUANAN;Integrated Security=True");
                kn.Close();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SqlConnection kn1 = new SqlConnection(@"Data Source=HOME\SQLEXPRESS;Initial Catalog=QLQUANAN;Integrated Security=True");
            kn1.Open();
            them = "insert into Mon_An values('',N'" + tenmona.Text.ToString() + "','" + giamona.Text.ToString() + "','" + danhmuc.SelectedValue.ToString() + "',N'" + ghichu.Text.ToString() + "')";

            if (them == null)
            {
                MessageBox.Show("Thêm Không Thành Công");
            }
            SqlCommand comthem = new SqlCommand(them, kn1);
            comthem.ExecuteNonQuery();
            MessageBox.Show("Thêm Thành Công");
            DanhMucMonAn_Load(sender, e);
            mamona.Clear();
            tenmona.Clear();
            giamona.Clear();
            ghichu.Clear();
        }
    }
    
}
