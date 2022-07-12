using Newtonsoft.Json;

namespace PDF
{
    public partial class Form1 : Form
    {
        private readonly string _path = @"C:\Users\irinc\OneDrive\Documents";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_path)) 
                {
                    jsonFromFile = reader.ReadToEnd();  
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}