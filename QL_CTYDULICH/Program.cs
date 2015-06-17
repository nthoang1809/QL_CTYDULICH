using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QL_CTYDULICH.F_ListFORM;
using QL_CTYDULICH.F_UpdateFORM;

namespace QL_CTYDULICH
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
            Application.Run(new F_DSPHUONGTIEN());
        }
    }
}
