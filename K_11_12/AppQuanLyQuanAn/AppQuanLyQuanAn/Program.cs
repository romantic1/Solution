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
            Application.Run(new Home());
            //Application.Run(new KhachHang());
=======

           // Application.Run(new KhachHang());

            Application.Run(new Home());

>>>>>>> 7036469285d3b9807dee665a177926f979014bb9
        }
    }
}
