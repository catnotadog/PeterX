
namespace PeterX
{
    partial class synxpath
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
            this.syndir = new System.Windows.Forms.TextBox();
            this.enterpathtext = new System.Windows.Forms.Label();
            this.nopeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syndir
            // 
            this.syndir.Location = new System.Drawing.Point(70, 35);
            this.syndir.Name = "syndir";
            this.syndir.Size = new System.Drawing.Size(239, 20);
            this.syndir.TabIndex = 0;
            // 
            // enterpathtext
            // 
            this.enterpathtext.AutoSize = true;
            this.enterpathtext.Location = new System.Drawing.Point(100, 9);
            this.enterpathtext.Name = "enterpathtext";
            this.enterpathtext.Size = new System.Drawing.Size(174, 13);
            this.enterpathtext.TabIndex = 1;
            this.enterpathtext.Text = "enter SynX path or peter will kill you";
            // 
            // nopeter
            // 
            this.nopeter.Location = new System.Drawing.Point(150, 69);
            this.nopeter.Name = "nopeter";
            this.nopeter.Size = new System.Drawing.Size(82, 29);
            this.nopeter.TabIndex = 2;
            this.nopeter.Text = "Please no";
            this.nopeter.UseVisualStyleBackColor = true;
            this.nopeter.Click += new System.EventHandler(this.nopeter_Click);
            // 
            // synxpath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 110);
            this.Controls.Add(this.nopeter);
            this.Controls.Add(this.enterpathtext);
            this.Controls.Add(this.syndir);
            this.Name = "synxpath";
            this.Text = "synxpath";
            this.Load += new System.EventHandler(this.synxpath_Load);
            this.Click += new System.EventHandler(this.synxpath_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox syndir;
        private System.Windows.Forms.Label enterpathtext;
        private System.Windows.Forms.Button nopeter;
    }
}