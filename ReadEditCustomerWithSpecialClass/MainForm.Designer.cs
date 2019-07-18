namespace ReadEditCustomerWithSpecialClass
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilterByContactTypeButton = new System.Windows.Forms.Button();
            this.ContactTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SaveAllChangesButton = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitleColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.StreetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EditContactColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CompanyLikeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.CompanyNameConditiontoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindCustomer = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilterByContactTypeButton);
            this.panel1.Controls.Add(this.ContactTypeComboBox);
            this.panel1.Controls.Add(this.SaveAllChangesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 60);
            this.panel1.TabIndex = 0;
            // 
            // FilterByContactTypeButton
            // 
            this.FilterByContactTypeButton.Location = new System.Drawing.Point(908, 15);
            this.FilterByContactTypeButton.Name = "FilterByContactTypeButton";
            this.FilterByContactTypeButton.Size = new System.Drawing.Size(154, 23);
            this.FilterByContactTypeButton.TabIndex = 4;
            this.FilterByContactTypeButton.Text = "Filter by contact type";
            this.FilterByContactTypeButton.UseVisualStyleBackColor = true;
            this.FilterByContactTypeButton.Click += new System.EventHandler(this.FilterByContactTypeButton_Click);
            // 
            // ContactTypeComboBox
            // 
            this.ContactTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContactTypeComboBox.FormattingEnabled = true;
            this.ContactTypeComboBox.Location = new System.Drawing.Point(729, 15);
            this.ContactTypeComboBox.Name = "ContactTypeComboBox";
            this.ContactTypeComboBox.Size = new System.Drawing.Size(173, 21);
            this.ContactTypeComboBox.TabIndex = 3;
            // 
            // SaveAllChangesButton
            // 
            this.SaveAllChangesButton.Location = new System.Drawing.Point(12, 15);
            this.SaveAllChangesButton.Name = "SaveAllChangesButton";
            this.SaveAllChangesButton.Size = new System.Drawing.Size(154, 23);
            this.SaveAllChangesButton.TabIndex = 1;
            this.SaveAllChangesButton.Text = "Save all changes";
            this.SaveAllChangesButton.UseVisualStyleBackColor = true;
            this.SaveAllChangesButton.Click += new System.EventHandler(this.SaveAllChangesButton_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyNameColumn,
            this.FirstNameColumn,
            this.LastNameColumn,
            this.ContactTitleColumn,
            this.StreetColumn,
            this.CityColumn,
            this.PostalCodeColumn,
            this.CountyNameColumn,
            this.EditContactColumn});
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 25);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(1074, 365);
            this.gridView.TabIndex = 1;
            this.gridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.gridView_CurrentCellDirtyStateChanged);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            this.CompanyNameColumn.HeaderText = "Company";
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.ToolTipText = "Customer name";
            // 
            // FirstNameColumn
            // 
            this.FirstNameColumn.DataPropertyName = "FirstName";
            this.FirstNameColumn.HeaderText = "First";
            this.FirstNameColumn.Name = "FirstNameColumn";
            this.FirstNameColumn.ReadOnly = true;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.DataPropertyName = "LastName";
            this.LastNameColumn.HeaderText = "Last";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.ReadOnly = true;
            // 
            // ContactTitleColumn
            // 
            this.ContactTitleColumn.HeaderText = "Title";
            this.ContactTitleColumn.Name = "ContactTitleColumn";
            this.ContactTitleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ContactTitleColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ContactTitleColumn.Width = 150;
            // 
            // StreetColumn
            // 
            this.StreetColumn.DataPropertyName = "Address";
            this.StreetColumn.HeaderText = "Street";
            this.StreetColumn.Name = "StreetColumn";
            // 
            // CityColumn
            // 
            this.CityColumn.DataPropertyName = "City";
            this.CityColumn.HeaderText = "City";
            this.CityColumn.Name = "CityColumn";
            // 
            // PostalCodeColumn
            // 
            this.PostalCodeColumn.DataPropertyName = "PostalCode";
            this.PostalCodeColumn.HeaderText = "Postal";
            this.PostalCodeColumn.Name = "PostalCodeColumn";
            // 
            // CountyNameColumn
            // 
            this.CountyNameColumn.HeaderText = "Country";
            this.CountyNameColumn.Name = "CountyNameColumn";
            this.CountyNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CountyNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EditContactColumn
            // 
            this.EditContactColumn.HeaderText = "";
            this.EditContactColumn.Name = "EditContactColumn";
            this.EditContactColumn.Text = "";
            this.EditContactColumn.ToolTipText = "Edit contact";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewCustomer,
            this.bindingNavigatorDeleteCustomer,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.CompanyLikeToolStripTextBox,
            this.CompanyNameConditiontoolStripComboBox,
            this.toolStripButtonFindCustomer});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1074, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CompanyLikeToolStripTextBox
            // 
            this.CompanyLikeToolStripTextBox.Name = "CompanyLikeToolStripTextBox";
            this.CompanyLikeToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            this.CompanyLikeToolStripTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyLikeToolStripTextBox_KeyDown);
            // 
            // CompanyNameConditiontoolStripComboBox
            // 
            this.CompanyNameConditiontoolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyNameConditiontoolStripComboBox.Items.AddRange(new object[] {
            "Starts with",
            "Contains",
            "Ends with"});
            this.CompanyNameConditiontoolStripComboBox.Name = "CompanyNameConditiontoolStripComboBox";
            this.CompanyNameConditiontoolStripComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Company";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorAddNewCustomer
            // 
            this.bindingNavigatorAddNewCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewCustomer.Image")));
            this.bindingNavigatorAddNewCustomer.Name = "bindingNavigatorAddNewCustomer";
            this.bindingNavigatorAddNewCustomer.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewCustomer.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewCustomer.Text = "Add new";
            this.bindingNavigatorAddNewCustomer.Click += new System.EventHandler(this.bindingNavigatorAddNewCustomer_Click);
            // 
            // bindingNavigatorDeleteCustomer
            // 
            this.bindingNavigatorDeleteCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteCustomer.Image")));
            this.bindingNavigatorDeleteCustomer.Name = "bindingNavigatorDeleteCustomer";
            this.bindingNavigatorDeleteCustomer.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteCustomer.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteCustomer.Text = "Delete";
            this.bindingNavigatorDeleteCustomer.Click += new System.EventHandler(this.bindingNavigatorDeleteCustomer_Click);
            // 
            // toolStripButtonFindCustomer
            // 
            this.toolStripButtonFindCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindCustomer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindCustomer.Image")));
            this.toolStripButtonFindCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFindCustomer.Name = "toolStripButtonFindCustomer";
            this.toolStripButtonFindCustomer.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindCustomer.Text = "toolStripButton1";
            this.toolStripButtonFindCustomer.Click += new System.EventHandler(this.toolStripButtonFindCustomer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button SaveAllChangesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ContactTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCodeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CountyNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditContactColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewCustomer;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteCustomer;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindCustomer;
        private System.Windows.Forms.ComboBox ContactTypeComboBox;
        private System.Windows.Forms.Button FilterByContactTypeButton;
        private System.Windows.Forms.ToolStripTextBox CompanyLikeToolStripTextBox;
        private System.Windows.Forms.ToolStripComboBox CompanyNameConditiontoolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

