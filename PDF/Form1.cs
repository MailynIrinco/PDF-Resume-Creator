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

        public string Name { get; private set; }    
        public DateTime DateToday { get; private set; }
        public int Age { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void writebtn_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            {
                DateToday = DateTime.Now;
                Name = "Mailyn";
                Age = 20;
                //Address = "Kenedaa";
            };

            string JsonOutput = JsonConvert.SerializeObject(class1);
            txtbox.Text = JsonOutput;
        }
    }
}