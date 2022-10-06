using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace PeterX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public static void peteralerttrigger()
        {
            Application.Run(new Form2());
        }
        public static void peteralertstrigger()
        {
            Application.Run(new Form2(true));
        }

    }
}
