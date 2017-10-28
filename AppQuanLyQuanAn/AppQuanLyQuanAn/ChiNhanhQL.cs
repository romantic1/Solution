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
    public partial class ChiNhanhQL : Form
    {
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
            ThaoTacCNQL frThaoTacCNQL = new ThaoTacCNQL();

            frThaoTacCNQL.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CapNhatCNQL frCapNhatCNQL = new CapNhatCNQL();

            frCapNhatCNQL.Show();
        }
    }
}
