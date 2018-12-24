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
    public partial class frmFindStudent : Form
    {
        public frmFindStudent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sproc_tblStudent_FilterByStudentNoTableAdapter.Fill(this.dMUBoxDataSet.sproc_tblStudent_FilterByStudentNo, studentNoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frmFindStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblHall' table. You can move, or remove it, as needed.
            this.tblHallTableAdapter.Fill(this.dMUBoxDataSet.tblHall);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
