namespace DMUBox
{
    partial class frmBox
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
            System.Windows.Forms.Label boxNoLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBox));
            this.dMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.tblBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBoxTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblBoxTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager();
            this.tblBoxBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblBoxBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.boxNoTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.lblDmuBoxScheme = new System.Windows.Forms.Label();
            this.lblBoxDetails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            boxNoLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoxBindingNavigator)).BeginInit();
            this.tblBoxBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxNoLabel
            // 
            boxNoLabel.AutoSize = true;
            boxNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            boxNoLabel.Location = new System.Drawing.Point(45, 160);
            boxNoLabel.Name = "boxNoLabel";
            boxNoLabel.Size = new System.Drawing.Size(69, 20);
            boxNoLabel.TabIndex = 1;
            boxNoLabel.Text = "Box No:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(14, 222);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(100, 20);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(56, 283);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(53, 20);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Price:";
            // 
            // dMUBoxDataSet
            // 
            this.dMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.dMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBoxBindingSource
            // 
            this.tblBoxBindingSource.DataMember = "tblBox";
            this.tblBoxBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // tblBoxTableAdapter
            // 
            this.tblBoxTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBoxTableAdapter = this.tblBoxTableAdapter;
            this.tableAdapterManager.tblHallTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblStudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblBoxBindingNavigator
            // 
            this.tblBoxBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblBoxBindingNavigator.BindingSource = this.tblBoxBindingSource;
            this.tblBoxBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblBoxBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblBoxBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblBoxBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblBoxBindingNavigatorSaveItem});
            this.tblBoxBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblBoxBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblBoxBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblBoxBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblBoxBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblBoxBindingNavigator.Name = "tblBoxBindingNavigator";
            this.tblBoxBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblBoxBindingNavigator.Size = new System.Drawing.Size(439, 27);
            this.tblBoxBindingNavigator.TabIndex = 0;
            this.tblBoxBindingNavigator.Text = "bindingNavigator1";
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
            // tblBoxBindingNavigatorSaveItem
            // 
            this.tblBoxBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblBoxBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblBoxBindingNavigatorSaveItem.Image")));
            this.tblBoxBindingNavigatorSaveItem.Name = "tblBoxBindingNavigatorSaveItem";
            this.tblBoxBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tblBoxBindingNavigatorSaveItem.Text = "Save Data";
            this.tblBoxBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblBoxBindingNavigatorSaveItem_Click);
            // 
            // boxNoTextBox
            // 
            this.boxNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBoxBindingSource, "BoxNo", true));
            this.boxNoTextBox.Location = new System.Drawing.Point(131, 160);
            this.boxNoTextBox.Name = "boxNoTextBox";
            this.boxNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.boxNoTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBoxBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(131, 220);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(141, 22);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBoxBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.priceTextBox.Location = new System.Drawing.Point(131, 281);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 6;
            // 
            // lblDmuBoxScheme
            // 
            this.lblDmuBoxScheme.AutoSize = true;
            this.lblDmuBoxScheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmuBoxScheme.ForeColor = System.Drawing.Color.Maroon;
            this.lblDmuBoxScheme.Location = new System.Drawing.Point(19, 41);
            this.lblDmuBoxScheme.Name = "lblDmuBoxScheme";
            this.lblDmuBoxScheme.Size = new System.Drawing.Size(258, 36);
            this.lblDmuBoxScheme.TabIndex = 8;
            this.lblDmuBoxScheme.Text = "DMU Box Scheme";
            this.lblDmuBoxScheme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBoxDetails
            // 
            this.lblBoxDetails.AutoSize = true;
            this.lblBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxDetails.ForeColor = System.Drawing.Color.Maroon;
            this.lblBoxDetails.Location = new System.Drawing.Point(51, 101);
            this.lblBoxDetails.Name = "lblBoxDetails";
            this.lblBoxDetails.Size = new System.Drawing.Size(110, 25);
            this.lblBoxDetails.TabIndex = 9;
            this.lblBoxDetails.Text = "Box Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DMUBox.Properties.Resources.rsz_1rsz_1dmu_logo;
            this.pictureBox1.Location = new System.Drawing.Point(334, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 154);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 291);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 337);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBoxDetails);
            this.Controls.Add(this.lblDmuBoxScheme);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(boxNoLabel);
            this.Controls.Add(this.boxNoTextBox);
            this.Controls.Add(this.tblBoxBindingNavigator);
            this.Name = "frmBox";
            this.Text = "Box";
            this.Load += new System.EventHandler(this.frmBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoxBindingNavigator)).EndInit();
            this.tblBoxBindingNavigator.ResumeLayout(false);
            this.tblBoxBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMUBoxDataSet dMUBoxDataSet;
        private System.Windows.Forms.BindingSource tblBoxBindingSource;
        private DMUBoxDataSetTableAdapters.tblBoxTableAdapter tblBoxTableAdapter;
        private DMUBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblBoxBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblBoxBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox boxNoTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label lblDmuBoxScheme;
        private System.Windows.Forms.Label lblBoxDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}