namespace DMUBox
{
    partial class frmStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            this.dMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblStudentTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager();
            this.tblStudentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblStudentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentNoTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.foreNameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNoTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblHallTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tblOrderTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblOrderTableAdapter();
            this.tblOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studentNoLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            foreNameLabel = new System.Windows.Forms.Label();
            familyNameLabel = new System.Windows.Forms.Label();
            hallNoLabel = new System.Windows.Forms.Label();
            apartmentNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingNavigator)).BeginInit();
            this.tblStudentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNoLabel
            // 
            studentNoLabel.AutoSize = true;
            studentNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            studentNoLabel.Location = new System.Drawing.Point(51, 88);
            studentNoLabel.Name = "studentNoLabel";
            studentNoLabel.Size = new System.Drawing.Size(86, 18);
            studentNoLabel.TabIndex = 1;
            studentNoLabel.Text = "Student No:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(51, 129);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 18);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // foreNameLabel
            // 
            foreNameLabel.AutoSize = true;
            foreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            foreNameLabel.Location = new System.Drawing.Point(51, 174);
            foreNameLabel.Name = "foreNameLabel";
            foreNameLabel.Size = new System.Drawing.Size(87, 18);
            foreNameLabel.TabIndex = 5;
            foreNameLabel.Text = "Fore Name:";
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            familyNameLabel.Location = new System.Drawing.Point(51, 220);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new System.Drawing.Size(99, 18);
            familyNameLabel.TabIndex = 7;
            familyNameLabel.Text = "Family Name:";
            // 
            // hallNoLabel
            // 
            hallNoLabel.AutoSize = true;
            hallNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hallNoLabel.Location = new System.Drawing.Point(51, 268);
            hallNoLabel.Name = "hallNoLabel";
            hallNoLabel.Size = new System.Drawing.Size(37, 18);
            hallNoLabel.TabIndex = 9;
            hallNoLabel.Text = "Hall:";
            // 
            // apartmentNoLabel
            // 
            apartmentNoLabel.AutoSize = true;
            apartmentNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apartmentNoLabel.Location = new System.Drawing.Point(51, 310);
            apartmentNoLabel.Name = "apartmentNoLabel";
            apartmentNoLabel.Size = new System.Drawing.Size(103, 18);
            apartmentNoLabel.TabIndex = 11;
            apartmentNoLabel.Text = "Apartment No:";
            // 
            // dMUBoxDataSet
            // 
            this.dMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.dMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            this.tblStudentBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBoxTableAdapter = null;
            this.tableAdapterManager.tblHallTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblStudentTableAdapter = this.tblStudentTableAdapter;
            this.tableAdapterManager.UpdateOrder = DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblStudentBindingNavigator
            // 
            this.tblStudentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblStudentBindingNavigator.BindingSource = this.tblStudentBindingSource;
            this.tblStudentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblStudentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblStudentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblStudentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblStudentBindingNavigatorSaveItem});
            this.tblStudentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblStudentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblStudentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblStudentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblStudentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblStudentBindingNavigator.Name = "tblStudentBindingNavigator";
            this.tblStudentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblStudentBindingNavigator.Size = new System.Drawing.Size(843, 27);
            this.tblStudentBindingNavigator.TabIndex = 0;
            this.tblStudentBindingNavigator.Text = "bindingNavigator1";
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
            // tblStudentBindingNavigatorSaveItem
            // 
            this.tblStudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblStudentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblStudentBindingNavigatorSaveItem.Image")));
            this.tblStudentBindingNavigatorSaveItem.Name = "tblStudentBindingNavigatorSaveItem";
            this.tblStudentBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tblStudentBindingNavigatorSaveItem.Text = "Save Data";
            this.tblStudentBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblStudentBindingNavigatorSaveItem_Click);
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "StudentNo", true));
            this.studentNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNoTextBox.Location = new System.Drawing.Point(169, 85);
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(119, 24);
            this.studentNoTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(169, 126);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(119, 24);
            this.titleTextBox.TabIndex = 4;
            // 
            // foreNameTextBox
            // 
            this.foreNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "ForeName", true));
            this.foreNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreNameTextBox.Location = new System.Drawing.Point(169, 171);
            this.foreNameTextBox.Name = "foreNameTextBox";
            this.foreNameTextBox.Size = new System.Drawing.Size(119, 24);
            this.foreNameTextBox.TabIndex = 6;
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "FamilyName", true));
            this.familyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyNameTextBox.Location = new System.Drawing.Point(169, 217);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(119, 24);
            this.familyNameTextBox.TabIndex = 8;
            // 
            // apartmentNoTextBox
            // 
            this.apartmentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "ApartmentNo", true));
            this.apartmentNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentNoTextBox.Location = new System.Drawing.Point(169, 307);
            this.apartmentNoTextBox.Name = "apartmentNoTextBox";
            this.apartmentNoTextBox.Size = new System.Drawing.Size(119, 24);
            this.apartmentNoTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStudentBindingSource, "HallNo", true));
            this.comboBox1.DataSource = this.tblHallBindingSource;
            this.comboBox1.DisplayMember = "HallName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "HallNo";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(678, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblOrderTableAdapter
            // 
            this.tblOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderBindingSource1
            // 
            this.tblOrderBindingSource1.DataMember = "FK_tblOrder_tblStudent";
            this.tblOrderBindingSource1.DataSource = this.tblStudentBindingSource;
            // 
            // tblOrderDataGridView
            // 
            this.tblOrderDataGridView.AutoGenerateColumns = false;
            this.tblOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblOrderDataGridView.DataSource = this.tblOrderBindingSource1;
            this.tblOrderDataGridView.Location = new System.Drawing.Point(356, 88);
            this.tblOrderDataGridView.Name = "tblOrderDataGridView";
            this.tblOrderDataGridView.RowTemplate.Height = 24;
            this.tblOrderDataGridView.Size = new System.Drawing.Size(445, 220);
            this.tblOrderDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "StudentNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DeliveryDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DeliveryDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 470);
            this.Controls.Add(this.tblOrderDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(studentNoLabel);
            this.Controls.Add(this.studentNoTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(foreNameLabel);
            this.Controls.Add(this.foreNameTextBox);
            this.Controls.Add(familyNameLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(hallNoLabel);
            this.Controls.Add(apartmentNoLabel);
            this.Controls.Add(this.apartmentNoTextBox);
            this.Controls.Add(this.tblStudentBindingNavigator);
            this.Name = "frmStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingNavigator)).EndInit();
            this.tblStudentBindingNavigator.ResumeLayout(false);
            this.tblStudentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMUBoxDataSet dMUBoxDataSet;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DMUBoxDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
        private DMUBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblStudentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblStudentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentNoTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox foreNameTextBox;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox apartmentNoTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tblHallBindingSource;
        private DMUBoxDataSetTableAdapters.tblHallTableAdapter tblHallTableAdapter;
        private System.Windows.Forms.Button button1;
        private DMUBoxDataSetTableAdapters.tblOrderTableAdapter tblOrderTableAdapter;
        private System.Windows.Forms.BindingSource tblOrderBindingSource1;
        private System.Windows.Forms.DataGridView tblOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}