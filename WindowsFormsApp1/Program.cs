using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;
using System.IO;

namespace PeterX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       public static string[] syndir;
        [STAThread]
        
        static void Main(string[] Args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(!File.Exists("syndir.txt"))
            {
                Application.Run(new synxpath());
            }
            else if(File.ReadAllLines("syndir.txt")[1] == "firstlaunch")
            {
                Application.Run(new synxpath());
            }
            syndir = File.ReadAllLines("syndir.txt");
            if (syndir[1] == "notfirstlaunch")
            {
                Application.Run(new Form1());
            }
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
