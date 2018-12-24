namespace DMUBox
{
    partial class frmFindStudent
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
            System.Windows.Forms.Label studentNoLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label foreNameLabel;
            System.Windows.Forms.Label familyNameLabel;
            System.Windows.Forms.Label hallNoLabel;
            System.Windows.Forms.Label apartmentNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindStudent));
            this.btnClose = new System.Windows.Forms.Button();
            this.dMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.sproc_tblStudent_FilterByStudentNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sproc_tblStudent_FilterByStudentNoTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.sproc_tblStudent_FilterByStudentNoTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentNoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentNoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studentNoTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.foreNameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.hallNoTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNoTextBox = new System.Windows.Forms.TextBox();
            this.tblHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblHallTableAdapter();
            studentNoLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            foreNameLabel = new System.Windows.Forms.Label();
            familyNameLabel = new System.Windows.Forms.Label();
            hallNoLabel = new System.Windows.Forms.Label();
            apartmentNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingNavigator)).BeginInit();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNoLabel
            // 
            studentNoLabel.AutoSize = true;
            studentNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentNoLabel.Location = new System.Drawing.Point(131, 96);
            studentNoLabel.Name = "studentNoLabel";
            studentNoLabel.Size = new System.Drawing.Size(97, 20);
            studentNoLabel.TabIndex = 3;
            studentNoLabel.Text = "Student No:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(175, 136);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(46, 20);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "Title:";
            // 
            // foreNameLabel
            // 
            foreNameLabel.AutoSize = true;
            foreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foreNameLabel.Location = new System.Drawing.Point(132, 184);
            foreNameLabel.Name = "foreNameLabel";
            foreNameLabel.Size = new System.Drawing.Size(97, 20);
            foreNameLabel.TabIndex = 7;
            foreNameLabel.Text = "Fore Name:";
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            familyNameLabel.Location = new System.Drawing.Point(121, 235);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new System.Drawing.Size(112, 20);
            familyNameLabel.TabIndex = 9;
            familyNameLabel.Text = "Family Name:";
            // 
            // hallNoLabel
            // 
            hallNoLabel.AutoSize = true;
            hallNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hallNoLabel.Location = new System.Drawing.Point(156, 285);
            hallNoLabel.Name = "hallNoLabel";
            hallNoLabel.Size = new System.Drawing.Size(70, 20);
            hallNoLabel.TabIndex = 11;
            hallNoLabel.Text = "Hall No:";
            // 
            // apartmentNoLabel
            // 
            apartmentNoLabel.AutoSize = true;
            apartmentNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apartmentNoLabel.Location = new System.Drawing.Point(115, 326);
            apartmentNoLabel.Name = "apartmentNoLabel";
            apartmentNoLabel.Size = new System.Drawing.Size(117, 20);
            apartmentNoLabel.TabIndex = 13;
            apartmentNoLabel.Text = "Apartment No:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(473, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dMUBoxDataSet
            // 
            this.dMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.dMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sproc_tblStudent_FilterByStudentNoBindingSource
            // 
            this.sproc_tblStudent_FilterByStudentNoBindingSource.DataMember = "sproc_tblStudent_FilterByStudentNo";
            this.sproc_tblStudent_FilterByStudentNoBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // sproc_tblStudent_FilterByStudentNoTableAdapter
            // 
            this.sproc_tblStudent_FilterByStudentNoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblBoxTableAdapter = null;
            this.tableAdapterManager.tblHallTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblStudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sproc_tblStudent_FilterByStudentNoBindingNavigator
            // 
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.BindingSource = this.sproc_tblStudent_FilterByStudentNoBindingSource;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem});
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Name = "sproc_tblStudent_FilterByStudentNoBindingNavigator";
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Size = new System.Drawing.Size(560, 27);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.TabIndex = 1;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem
            // 
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Enabled = false;
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Image")));
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Name = "sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem";
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentNoToolStripLabel,
            this.studentNoToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(560, 27);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // studentNoToolStripLabel
            // 
            this.studentNoToolStripLabel.Name = "studentNoToolStripLabel";
            this.studentNoToolStripLabel.Size = new System.Drawing.Size(83, 24);
            this.studentNoToolStripLabel.Text = "StudentNo:";
            // 
            // studentNoToolStripTextBox
            // 
            this.studentNoToolStripTextBox.Name = "studentNoToolStripTextBox";
            this.studentNoToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "StudentNo", true));
            this.studentNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNoTextBox.Location = new System.Drawing.Point(250, 93);
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(100, 27);
            this.studentNoTextBox.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(250, 133);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 27);
            this.titleTextBox.TabIndex = 6;
            // 
            // foreNameTextBox
            // 
            this.foreNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "ForeName", true));
            this.foreNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreNameTextBox.Location = new System.Drawing.Point(250, 181);
            this.foreNameTextBox.Name = "foreNameTextBox";
            this.foreNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.foreNameTextBox.TabIndex = 8;
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "FamilyName", true));
            this.familyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyNameTextBox.Location = new System.Drawing.Point(250, 232);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.familyNameTextBox.TabIndex = 10;
            // 
            // hallNoTextBox
            // 
            this.hallNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "HallNo", true));
            this.hallNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hallNoTextBox.Location = new System.Drawing.Point(250, 282);
            this.hallNoTextBox.Name = "hallNoTextBox";
            this.hallNoTextBox.Size = new System.Drawing.Size(100, 27);
            this.hallNoTextBox.TabIndex = 12;
            // 
            // apartmentNoTextBox
            // 
            this.apartmentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sproc_tblStudent_FilterByStudentNoBindingSource, "ApartmentNo", true));
            this.apartmentNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentNoTextBox.Location = new System.Drawing.Point(250, 323);
            this.apartmentNoTextBox.Name = "apartmentNoTextBox";
            this.apartmentNoTextBox.Size = new System.Drawing.Size(100, 27);
            this.apartmentNoTextBox.TabIndex = 14;
            // 
            // tblHallBindingSource
            // 
            this.tblHallBindingSource.DataMember = "tblHall";
            this.tblHallBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // tblHallTableAdapter
            // 
            this.tblHallTableAdapter.ClearBeforeFill = true;
            // 
            // frmFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 446);
            this.Controls.Add(apartmentNoLabel);
            this.Controls.Add(this.apartmentNoTextBox);
            this.Controls.Add(hallNoLabel);
            this.Controls.Add(this.hallNoTextBox);
            this.Controls.Add(familyNameLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(foreNameLabel);
            this.Controls.Add(this.foreNameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(studentNoLabel);
            this.Controls.Add(this.studentNoTextBox);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sproc_tblStudent_FilterByStudentNoBindingNavigator);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFindStudent";
            this.Text = "Find Student";
            this.Load += new System.EventHandler(this.frmFindStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_tblStudent_FilterByStudentNoBindingNavigator)).EndInit();
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.ResumeLayout(false);
            this.sproc_tblStudent_FilterByStudentNoBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private DMUBoxDataSet dMUBoxDataSet;
        private System.Windows.Forms.BindingSource sproc_tblStudent_FilterByStudentNoBindingSource;
        private DMUBoxDataSetTableAdapters.sproc_tblStudent_FilterByStudentNoTableAdapter sproc_tblStudent_FilterByStudentNoTableAdapter;
        private DMUBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sproc_tblStudent_FilterByStudentNoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sproc_tblStudent_FilterByStudentNoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel studentNoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentNoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox studentNoTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox foreNameTextBox;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox hallNoTextBox;
        private System.Windows.Forms.TextBox apartmentNoTextBox;
        private System.Windows.Forms.BindingSource tblHallBindingSource;
        private DMUBoxDataSetTableAdapters.tblHallTableAdapter tblHallTableAdapter;
    }
}