namespace PDF
{
    partial class createPDFile
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
            this.pdfbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdfbutton
            // 
            this.pdfbutton.BackColor = System.Drawing.Color.AliceBlue;
            this.pdfbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pdfbutton.ForeColor = System.Drawing.Color.Black;
            this.pdfbutton.Location = new System.Drawing.Point(75, 72);
            this.pdfbutton.Name = "pdfbutton";
            this.pdfbutton.Size = new System.Drawing.Size(185, 47);
            this.pdfbutton.TabIndex = 1;
            this.pdfbutton.Text = "Create PDF File";
            this.pdfbutton.UseVisualStyleBackColor = false;
            this.pdfbutton.Click += new System.EventHandler(this.readbtn_Click);
            // 
            // createPDFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 209);
            this.Controls.Add(this.pdfbutton);
            this.Name = "createPDFile";
            this.Text = "Generate Resume in PDF ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button pdfbutton;
    }
}