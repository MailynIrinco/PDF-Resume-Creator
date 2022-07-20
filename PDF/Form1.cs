using System.Collections.Generic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;

namespace PDF
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public int Age { get; private set; }
        public DateTime DateToday { get; private set; }
        public int Weight { get; private set; }
        public string Religion { get; private set; }
        public string FatherName { get; private set; }

        public string MotherName { get; private set; }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readbtn_Click(object sender, EventArgs e)
        {
          Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("Create.pdf", FileMode.Create));
            doc.Open(); 
            Paragraph paragraph = new Paragraph(txtbox.Text);
            doc.Add(paragraph);
            doc.Close();

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(txtbox.Text));
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                }
            }

        }

        private void writebtn_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            {

                Name = "Mailyn";
                Age = 20;
                DateToday = DateTime.Now;
                Height = 160;
                Weight = 55;
                Religion = "Catholic";
                FatherName = "Manuel I.";
                MotherName = "Brenda I.";

            };
            string result = JsonConvert.SerializeObject(class1);
            //File.WriteAllText(@"C:\Users\irinc\OneDrive\Documents", result);
            txtbox.Text = result;

        }
    }
}