
namespace PeterX
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.peterlabel = new System.Windows.Forms.Label();
            this.okpeter = new System.Windows.Forms.Button();
            this.petertimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // peterlabel
            // 
            this.peterlabel.AutoSize = true;
            this.peterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peterlabel.Location = new System.Drawing.Point(165, 32);
            this.peterlabel.Name = "peterlabel";
            this.peterlabel.Size = new System.Drawing.Size(74, 17);
            this.peterlabel.TabIndex = 1;
            this.peterlabel.Text = "Peter alert";
            // 
            // okpeter
            // 
            this.okpeter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okpeter.Location = new System.Drawing.Point(177, 100);
            this.okpeter.Name = "okpeter";
            this.okpeter.Size = new System.Drawing.Size(52, 30);
            this.okpeter.TabIndex = 2;
            this.okpeter.Text = "Ok";
            this.okpeter.UseVisualStyleBackColor = true;
            this.okpeter.Click += new System.EventHandler(this.okpeter_Click);
            // 
            // petertimer
            // 
            this.petertimer.Enabled = true;
            this.petertimer.Interval = 3000;
            this.petertimer.Tick += new System.EventHandler(this.petertimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 155);
            this.ControlBox = false;
            this.Controls.Add(this.okpeter);
            this.Controls.Add(this.peterlabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Peter alert";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label peterlabel;
        private System.Windows.Forms.Button okpeter;
        private System.Windows.Forms.Timer petertimer;
    }
}