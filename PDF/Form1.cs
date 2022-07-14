using System.Collections.Generic;
using Newtonsoft.Json;

namespace PDF
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void writebtn_Click(object sender, EventArgs e)
        {
           Class1 info = new Class1();
            {
                Name = "Mailyn J. Irinco";
                //Age = 20;
                //Address = "Kenedaa";
            }

            string JsonOutput = JsonConvert.SerializeObject(info);
            txtbox.Text = JsonOutput;
        }
    }
}