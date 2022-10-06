using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PeterX
{
    public partial class synxpath : Form
    {
        public synxpath()
        {
            InitializeComponent();
        }

        private void nopeter_Click(object sender, EventArgs e)
        {
            if(syndir.TextLength >= 0)
            {
                string[] path = { syndir.Text, "notfirstlaunch" };
                System.IO.File.WriteAllLines("syndir.txt", path);
                Close();
            }
            
            Thread peteralertthread = new Thread(new ThreadStart(Program.peteralerttrigger));
            peteralertthread.Start();
            Close();
        }

        private void synxpath_Click(object sender, EventArgs e)
        {

        }

        private void synxpath_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("syndir.txt"))
            {
                System.IO.File.Create("syndir.txt");
                string[] firstwrite = { "placeholder", "firstlaunch" };
                File.WriteAllLines("syndir.txt", firstwrite);
                
            }

        }
    }
}
