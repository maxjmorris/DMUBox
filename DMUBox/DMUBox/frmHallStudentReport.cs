﻿using System;
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
    public partial class frmHallStudentReport : Form
    {
        public frmHallStudentReport()
        {
            InitializeComponent();
        }

        private void frmHallStudentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DMUBoxDataSet.sproc_HallStudents' table. You can move, or remove it, as needed.
            this.sproc_HallStudentsTableAdapter.Fill(this.DMUBoxDataSet.sproc_HallStudents);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}
