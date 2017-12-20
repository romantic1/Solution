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

            Application.Run(new DanhMucMonAn());
            //Application.Run(new Home_Login());
=======
            Application.Run(new Home());
>>>>>>> 8a5c68ec27d4aa2d22f56f01e1b4cbfd4a29c980
        }
    }
}
