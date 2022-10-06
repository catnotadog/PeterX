using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace PeterX
{
    public partial class Form2 : Form
    {
        bool morepeters;
        public Form2([Optional]bool peters)
        {
            morepeters = peters;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            if (morepeters)
            {
                petertimer.Start();
            }
        }

        private void okpeter_Click(object sender, EventArgs e)
        {
            if (morepeters)
            { 
                Thread peteralertthread1 = new Thread(new ThreadStart(Program.peteralertstrigger));
                peteralertthread1.Start();
                Thread peteralertthread2 = new Thread(new ThreadStart(Program.peteralertstrigger));
                peteralertthread2.Start();
                Thread peteralertthread3 = new Thread(new ThreadStart(Program.peteralertstrigger));
                peteralertthread3.Start();
                Thread peteralertthread4 = new Thread(new ThreadStart(Program.peteralertstrigger));
                peteralertthread4.Start();
                Thread peteralertthread5 = new Thread(new ThreadStart(Program.peteralertstrigger));
                peteralertthread5.Start();
                
            }
            Close();
        }

        private void petertimer_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
