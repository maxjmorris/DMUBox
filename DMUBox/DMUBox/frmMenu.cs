using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMUBox
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBoxes_Click(object sender, EventArgs e)
        {
           // create an instance of frmBox
           frmBox myBoxForm = new frmBox();
            //display the form
            myBoxForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creat an instance of frmFindStudent
            frmFindStudent myFindStudentForm = new frmFindStudent();
            //display the form
            myFindStudentForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            //create an instance of frmStudents
            frmStudents myStudentsForm = new frmStudents();
            //display the form
            myStudentsForm.Show();

        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            //create an instance of frmStudentReport
            frmStudentReport myStudentReportForm = new frmStudentReport();
            //dispay form
            myStudentReportForm.Show();
        }

        private void btnHallStudentReport_Click(object sender, EventArgs e)
        {
            //create an instance of frmHallStudentReport
            frmHallStudentReport myHallStudentReportForm = new frmHallStudentReport();
            //display the form
            myHallStudentReportForm.Show();
        }
    }
}
