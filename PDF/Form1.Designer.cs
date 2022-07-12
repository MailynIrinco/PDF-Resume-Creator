namespace PDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.writebtn = new System.Windows.Forms.Button();
            this.readbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writebtn
            // 
            this.writebtn.Location = new System.Drawing.Point(134, 58);
            this.writebtn.Name = "writebtn";
            this.writebtn.Size = new System.Drawing.Size(94, 29);
            this.writebtn.TabIndex = 0;
            this.writebtn.Text = "Write";
            this.writebtn.UseVisualStyleBackColor = true;
            // 
            // readbtn
            // 
            this.readbtn.Location = new System.Drawing.Point(134, 379);
            this.readbtn.Name = "readbtn";
            this.readbtn.Size = new System.Drawing.Size(94, 29);
            this.readbtn.TabIndex = 1;
            this.readbtn.Text = "Read";
            this.readbtn.UseVisualStyleBackColor = true;
            this.readbtn.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 479);
            this.Controls.Add(this.readbtn);
            this.Controls.Add(this.writebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button writebtn;
        private Button readbtn;
    }
}