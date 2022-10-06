
namespace PeterX
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.buttonattach = new System.Windows.Forms.Button();
            this.buttonex = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.peter = new System.Windows.Forms.Button();
            this.petericon = new System.Windows.Forms.NotifyIcon(this.components);
            this.peteralert = new System.Windows.Forms.ErrorProvider(this.components);
            this.petersbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peteralert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "sex";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(314, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 5;
            // 
            // buttonattach
            // 
            this.buttonattach.Location = new System.Drawing.Point(317, 138);
            this.buttonattach.Name = "buttonattach";
            this.buttonattach.Size = new System.Drawing.Size(75, 23);
            this.buttonattach.TabIndex = 6;
            this.buttonattach.Text = "atach!11";
            this.buttonattach.UseVisualStyleBackColor = true;
            this.buttonattach.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // buttonex
            // 
            this.buttonex.Location = new System.Drawing.Point(207, 138);
            this.buttonex.Name = "buttonex";
            this.buttonex.Size = new System.Drawing.Size(75, 23);
            this.buttonex.TabIndex = 7;
            this.buttonex.Text = "execute!111!!";
            this.buttonex.UseVisualStyleBackColor = true;
            this.buttonex.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(147, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // peter
            // 
            this.peter.Location = new System.Drawing.Point(12, 41);
            this.peter.Name = "peter";
            this.peter.Size = new System.Drawing.Size(102, 24);
            this.peter.TabIndex = 9;
            this.peter.Text = "peter";
            this.peter.UseVisualStyleBackColor = true;
            this.peter.Click += new System.EventHandler(this.peter_Click);
            // 
            // petericon
            // 
            this.petericon.Icon = ((System.Drawing.Icon)(resources.GetObject("petericon.Icon")));
            this.petericon.Text = "peter";
            this.petericon.Visible = true;
            // 
            // peteralert
            // 
            this.peteralert.ContainerControl = this;
            this.peteralert.Icon = ((System.Drawing.Icon)(resources.GetObject("peteralert.Icon")));
            // 
            // petersbutton
            // 
            this.petersbutton.Location = new System.Drawing.Point(12, 71);
            this.petersbutton.Name = "petersbutton";
            this.petersbutton.Size = new System.Drawing.Size(102, 24);
            this.petersbutton.TabIndex = 10;
            this.petersbutton.Text = "peters";
            this.petersbutton.UseVisualStyleBackColor = true;
            this.petersbutton.Click += new System.EventHandler(this.petersbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 180);
            this.Controls.Add(this.petersbutton);
            this.Controls.Add(this.peter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonex);
            this.Controls.Add(this.buttonattach);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Peter x";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peteralert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonattach;
        private System.Windows.Forms.Button buttonex;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button peter;
        private System.Windows.Forms.NotifyIcon petericon;
        private System.Windows.Forms.ErrorProvider peteralert;
        private System.Windows.Forms.Button petersbutton;
    }
}

