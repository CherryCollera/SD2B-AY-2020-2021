namespace Activity9
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booktitletext = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.DataGridView();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookrecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book3DataSet1 = new Activity9.book3DataSet1();
            this.bookrecordsTableAdapter = new Activity9.book3DataSet1TableAdapters.bookrecordsTableAdapter();
            this.bindingnavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.addRecords = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.book3DataSet2 = new Activity9.book3DataSet2();
            this.bookrecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookrecordsTableAdapter1 = new Activity9.book3DataSet2TableAdapters.bookrecordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingnavigator)).BeginInit();
            this.bindingnavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description: ";
            // 
            // booktitletext
            // 
            this.booktitletext.Location = new System.Drawing.Point(146, 44);
            this.booktitletext.Name = "booktitletext";
            this.booktitletext.Size = new System.Drawing.Size(349, 22);
            this.booktitletext.TabIndex = 2;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(146, 93);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(349, 22);
            this.DescriptionText.TabIndex = 3;
            // 
            // Data
            // 
            this.Data.AutoGenerateColumns = false;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.Data.DataSource = this.bookrecordsBindingSource1;
            this.Data.Location = new System.Drawing.Point(65, 180);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 24;
            this.Data.Size = new System.Drawing.Size(667, 187);
            this.Data.TabIndex = 4;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // bookrecordsBindingSource
            // 
            this.bookrecordsBindingSource.DataMember = "bookrecords";
            this.bookrecordsBindingSource.DataSource = this.book3DataSet1;
            // 
            // book3DataSet1
            // 
            this.book3DataSet1.DataSetName = "book3DataSet1";
            this.book3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrecordsTableAdapter
            // 
            this.bookrecordsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingnavigator
            // 
            this.bindingnavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingnavigator.BindingSource = this.bookrecordsBindingSource1;
            this.bindingnavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingnavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingnavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingnavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingnavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingnavigator.Location = new System.Drawing.Point(209, 390);
            this.bindingnavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingnavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingnavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingnavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingnavigator.Name = "bindingnavigator";
            this.bindingnavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingnavigator.Size = new System.Drawing.Size(310, 27);
            this.bindingnavigator.TabIndex = 5;
            this.bindingnavigator.Text = "bindingNavigator1";
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
            // addRecords
            // 
            this.addRecords.Location = new System.Drawing.Point(595, 27);
            this.addRecords.Name = "addRecords";
            this.addRecords.Size = new System.Drawing.Size(137, 52);
            this.addRecords.TabIndex = 6;
            this.addRecords.Text = "Add Records";
            this.addRecords.UseVisualStyleBackColor = true;
            this.addRecords.Click += new System.EventHandler(this.addRecords_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(595, 93);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(137, 52);
            this.Show.TabIndex = 7;
            this.Show.Text = "Show All";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // book3DataSet2
            // 
            this.book3DataSet2.DataSetName = "book3DataSet2";
            this.book3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrecordsBindingSource1
            // 
            this.bookrecordsBindingSource1.DataMember = "bookrecords";
            this.bookrecordsBindingSource1.DataSource = this.book3DataSet2;
            // 
            // bookrecordsTableAdapter1
            // 
            this.bookrecordsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.addRecords);
            this.Controls.Add(this.bindingnavigator);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.booktitletext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingnavigator)).EndInit();
            this.bindingnavigator.ResumeLayout(false);
            this.bindingnavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book3DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrecordsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox booktitletext;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.DataGridView Data;
        private book3DataSet1 book3DataSet1;
        private System.Windows.Forms.BindingSource bookrecordsBindingSource;
        private book3DataSet1TableAdapters.bookrecordsTableAdapter bookrecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingnavigator;
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
        private System.Windows.Forms.Button addRecords;
        private System.Windows.Forms.Button Show;
        private book3DataSet2 book3DataSet2;
        private System.Windows.Forms.BindingSource bookrecordsBindingSource1;
        private book3DataSet2TableAdapters.bookrecordsTableAdapter bookrecordsTableAdapter1;
    }
}

