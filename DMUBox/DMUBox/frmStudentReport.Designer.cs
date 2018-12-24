namespace DMUBox
{
    partial class frmStudentReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblStudentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "StudentDataSet";
            reportDataSource2.Value = this.tblStudentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DMUBox.rptStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(676, 317);
            this.reportViewer1.TabIndex = 0;
            // 
            // DMUBoxDataSet
            // 
            this.DMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.DMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            this.tblStudentBindingSource.DataSource = this.DMUBoxDataSet;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmStudentReport";
            this.Text = "Student Report";
            this.Load += new System.EventHandler(this.frmStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DMUBoxDataSet DMUBoxDataSet;
        private DMUBoxDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}