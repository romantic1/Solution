using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyQuanAn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

<<<<<<< HEAD
            //Application.Run(new QuanLiChiNhanh());
            Application.Run(new Home());
=======
           
            Application.Run(new DanNhap());
>>>>>>> 2aded26205219ec0c3eb921864fdea7c11c6d42e
        }
    }
}
