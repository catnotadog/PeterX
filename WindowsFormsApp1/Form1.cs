using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;
using System.Threading;


namespace PeterX
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public SxLibWinForms sxlib;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
timer1.Start();
            
            this.sxlib = SxLib.InitializeWinForms(this, Program.syndir[0]);
            sxlib.AttachEvent += Sxlib_AttachEvent;
            sxlib.LoadEvent += Sxlib_LoadEvent;
            sxlib.Load();
        }
        private void Sxlib_LoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            statusLabel.Text = "Presetup: " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
            if (Event == SxLibBase.SynLoadEvents.READY)
            {
                sxlib.ScriptHub();
            }
        }

        private void Sxlib_AttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {
            statusLabel.Text = "Injection: " + Event.ToString().Replace("_", " ").ToLower().First().ToString().ToUpper() + Event.ToString().Replace("_", " ").ToLower().Substring(1) + ".";
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!(progressBar1.Value == progressBar1.Maximum))
            {
                int sex = rnd.Next(1, 2);
                if(progressBar1.Value + sex >= progressBar1.Maximum)
                {
                    sex--;
                }
                progressBar1.Value = progressBar1.Value + rnd.Next(1, 2);
                progressBar1.Refresh();
            }
            else
            {
                progressBar1.Value = 0;
                progressBar1.Refresh();
            }
            
            label2.Text = progressBar1.Value.ToString() + "%";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void attachButton_Click(object sender, EventArgs e)
        {
            sxlib.Attach();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            sxlib.Execute(richTextBox1.Text);
        }

        private void peter_Click(object sender, EventArgs e)
        {
            peteralert.SetError(peter, "peter alert");
            Thread peteralertthread = new Thread(new ThreadStart(Program.peteralerttrigger));
            peteralertthread.Start();
            
        }

        private void petersbutton_Click(object sender, EventArgs e)
        {
            peteralert.SetError(petersbutton, "peter alert");
            peteralert.SetError(buttonex, "peter alert");
            peteralert.SetError(buttonattach, "peter alert");
            peteralert.SetError(label1, "peter alert");
            peteralert.SetError(label2, "peter alert");
            peteralert.SetError(progressBar1, "peter alert");
            peteralert.SetError(peter, "peter alert");
            peteralert.SetError(richTextBox1, "peter alert");
            peteralert.SetError(statusLabel, "peter alert");
            Thread peteralertthread = new Thread(new ThreadStart(Program.peteralertstrigger));
            peteralertthread.Start();
        }
    }
}
