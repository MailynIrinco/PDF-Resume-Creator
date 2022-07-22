using System.Collections.Generic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;

namespace PDF
{
    public partial class createPDFile : Form
    {
        
        public createPDFile()
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
                        doc.Add(new iTextSharp.text.Paragraph("MAILYN J. IRINCO"));
                        doc.Add(new iTextSharp.text.Paragraph("Vancouver, Canada"));
                        doc.Add(new iTextSharp.text.Paragraph("mamamoo@gmail.com | 9366-1200-454"));
                        doc.Add(new iTextSharp.text.Paragraph("--------------------------------------------------------------------------------------------------------------------------"));
                        doc.Add(new iTextSharp.text.Paragraph("Objective:"));
                        doc.Add(new iTextSharp.text.Paragraph("     Implement expertise and experience in computer engineering for managing software and hardware computer systems as a Computer Engineer."));
                        doc.Add(new iTextSharp.text.Paragraph("--------------------------------------------------------------------------------------------------------------------------"));
                        doc.Add(new iTextSharp.text.Paragraph("Education:"));
                        doc.Add(new iTextSharp.text.Paragraph("     Bachelor of Science Major in Computer Engineering"));
                        doc.Add(new iTextSharp.text.Paragraph("     University of British Columbia (UBC)"));
                        doc.Add(new iTextSharp.text.Paragraph("     2015 - 2020"));
                        doc.Add(new iTextSharp.text.Paragraph("--------------------------------------------------------------------------------------------------------------------------"));
                        doc.Add(new iTextSharp.text.Paragraph("Experience:"));
                        doc.Add(new iTextSharp.text.Paragraph("     Computer System Analyst"));
                        doc.Add(new iTextSharp.text.Paragraph("          - Provide comprehensive system-level support of multi-user patient management system, including installation (hardware and software), configuration and maintenance."));
                        doc.Add(new iTextSharp.text.Paragraph("          - Perform (PMS) user account management: including add/delete, and modifies access security permissions."));
                        doc.Add(new iTextSharp.text.Paragraph("          - Gather project requirements, design, maintain, and provide technical support for clinical and business applications."));
                        doc.Add(new iTextSharp.text.Paragraph("  "));
                        doc.Add(new iTextSharp.text.Paragraph("     Office Manager"));
                        doc.Add(new iTextSharp.text.Paragraph("          - Organize office operations and procedures."));
                        doc.Add(new iTextSharp.text.Paragraph("          - Ensire security, integrity and confidentiality of data's."));
                        doc.Add(new iTextSharp.text.Paragraph("          - Making operational reports and schedules to ensure efficiency."));
                        doc.Add(new iTextSharp.text.Paragraph("--------------------------------------------------------------------------------------------------------------------------"));
                        doc.Add(new iTextSharp.text.Paragraph("Personal Skills:"));
                        doc.Add(new iTextSharp.text.Paragraph("  - Management Skills"));
                        doc.Add(new iTextSharp.text.Paragraph("  - Flexible and Dependable"));
                        doc.Add(new iTextSharp.text.Paragraph("  - Interpersonal and Communication Skills"));
                        doc.Add(new iTextSharp.text.Paragraph("  - Basic computer Skills"));
                        doc.Add(new iTextSharp.text.Paragraph("  - Programming Skills (Python, C#, HTML)"));
                        doc.Add(new iTextSharp.text.Paragraph("  "));
                        doc.Add(new iTextSharp.text.Paragraph("  "));
                        doc.Add(new iTextSharp.text.Paragraph("--------------------------------------------------------------------------------------------------------------------------"));
                        doc.Add(new iTextSharp.text.Paragraph("Languages:"));
                        doc.Add(new iTextSharp.text.Paragraph("    Filipino"));
                        doc.Add(new iTextSharp.text.Paragraph("    English"));
                        doc.Add(new iTextSharp.text.Paragraph("    Spanish"));
                        doc.Add(new iTextSharp.text.Paragraph("  "));
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
            //txtbox.Text = result;

        }
    }
}