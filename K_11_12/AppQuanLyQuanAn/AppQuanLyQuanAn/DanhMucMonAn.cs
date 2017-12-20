using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
