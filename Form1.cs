using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cillo05_LabExer
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string StudentNo,Lname,Fname,Middlename,Program, Age, Gender, Birthday, Contact;

            StudentNo = txtStudentNo.Text;
            Lname = txtLastName.Text;
            Fname = txtFirstName.Text;
            Middlename = txtMidIn.Text;
            Program = txtProgram.SelectedItem.ToString();
            Age = txtAge.Text;
            Gender = txtProgram.SelectedItem.ToString();
            Contact = txtContactNo.Text;
            Birthday = dateTimePicker1.Text;


            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            StudentNo+".txt")))
            {
                outputFile.WriteLine("Student No: " + StudentNo);
                outputFile.WriteLine("FullName: " + Lname+", "+Fname+", "+Middlename+".");
                outputFile.WriteLine("Program: " + Program);
                outputFile.WriteLine("Age: " + Age);
                outputFile.WriteLine("Gender: " + Gender);
                outputFile.WriteLine("Birthday: " + Birthday);
                outputFile.WriteLine("Contact No: " + Contact);

          
            }

            MessageBox.Show("Record Saved");
  

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frm = new FrmStudentRecord();
            frm.ShowDialog();
            this.Close();
        }
    }
}
