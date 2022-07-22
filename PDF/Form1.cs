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
        public DateTime DateOfBirth { get; private set; }
        public int Weight { get; private set; }
        public string Religion { get; private set; }
        public string FatherName { get; private set; }

        public string MotherName { get; private set; }
        public string ElementarySchool { get; private set; }

        public string JuniorHS { get; set; }

        public string SeniorHS { get; set; }

        public string College { get; set; }

        public string First { get; set; }   

        public string Second { get; set; }      

        public string Third { get; set; }   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readbtn_Click(object sender, EventArgs e)
        {
          Document doc = new Document(iTextSharp.text.PageSize.A4);
            //PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("Create.pdf", FileMode.Create));
            //doc.Open(); 
            //Paragraph paragraph = new Paragraph(txtbox.Text);
            //doc.Add(paragraph);
            //doc.Close();
            //MessageBox.Show("PDF file created successfully!");

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
                        //doc.Add()
                        doc.Close();

                    }
                    catch (Exception ex)
                    {
                        
                        //throw;
                    }
                }
            }

        }

        private void writebtn_Click(object sender, EventArgs e)
        {
            Class1 basicinfo = new Class1();
            {
               
                Name = "Mailyn";
                Age = 20;
                DateOfBirth = new DateTime(2002, 11, 3);
                Height = 160;
                Weight = 55;
                Religion = "Catholic";
                FatherName = "Manuel I.";
                MotherName = "Brenda I.";

                //Educational Background
                ElementarySchool = "Commonwealth Elementary School";
                JuniorHS = "North Fairview High School";
                SeniorHS = "Juan Sumulong High School";
                College = "Polytechnic University of the Philippines";

                //Personal Skills
                First = "Responsible";
                Second = "Flexible & Dependable";
                Third = "Organization Skills";
                    
            };
            string result = JsonConvert.SerializeObject(basicinfo);
            txtbox.Text = result;

        }
    }
}