namespace Lab0401_Shop_Application {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.ButtonAddNewCustomer = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonAddCustomer = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxPackage = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.tabPageSell = new System.Windows.Forms.TabPage();
            this.buttonSaveSell = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxProductIdToSell = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPageSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCustomer);
            this.tabControl.Controls.Add(this.tabPageProduct);
            this.tabControl.Controls.Add(this.tabPageSell);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(862, 529);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.BackColor = System.Drawing.Color.White;
            this.tabPageCustomer.Controls.Add(this.ButtonAddNewCustomer);
            this.tabPageCustomer.Controls.Add(this.ButtonSave);
            this.tabPageCustomer.Controls.Add(this.ButtonDelete);
            this.tabPageCustomer.Controls.Add(this.ButtonAddCustomer);
            this.tabPageCustomer.Controls.Add(this.lblPhone);
            this.tabPageCustomer.Controls.Add(this.lblCountry);
            this.tabPageCustomer.Controls.Add(this.lblCity);
            this.tabPageCustomer.Controls.Add(this.lblLastName);
            this.tabPageCustomer.Controls.Add(this.lblFirstName);
            this.tabPageCustomer.Controls.Add(this.lblID);
            this.tabPageCustomer.Controls.Add(this.textBoxPhone);
            this.tabPageCustomer.Controls.Add(this.textBoxCountry);
            this.tabPageCustomer.Controls.Add(this.textBoxCity);
            this.tabPageCustomer.Controls.Add(this.textBoxLastName);
            this.tabPageCustomer.Controls.Add(this.textBoxFirstName);
            this.tabPageCustomer.Controls.Add(this.textBoxCustomerID);
            this.tabPageCustomer.Controls.Add(this.dataGridViewCustomer);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 29);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(854, 496);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Customer";
            // 
            // ButtonAddNewCustomer
            // 
            this.ButtonAddNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNewCustomer.Location = new System.Drawing.Point(470, 448);
            this.ButtonAddNewCustomer.Name = "ButtonAddNewCustomer";
            this.ButtonAddNewCustomer.Size = new System.Drawing.Size(119, 40);
            this.ButtonAddNewCustomer.TabIndex = 27;
            this.ButtonAddNewCustomer.Text = "Add New";
            this.ButtonAddNewCustomer.UseVisualStyleBackColor = true;
            this.ButtonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Location = new System.Drawing.Point(597, 450);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(238, 40);
            this.ButtonSave.TabIndex = 24;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Location = new System.Drawing.Point(9, 449);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(238, 40);
            this.ButtonDelete.TabIndex = 25;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAddCustomer
            // 
            this.ButtonAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddCustomer.Location = new System.Drawing.Point(597, 404);
            this.ButtonAddCustomer.Name = "ButtonAddCustomer";
            this.ButtonAddCustomer.Size = new System.Drawing.Size(238, 40);
            this.ButtonAddCustomer.TabIndex = 26;
            this.ButtonAddCustomer.Text = "Add";
            this.ButtonAddCustomer.UseVisualStyleBackColor = true;
            this.ButtonAddCustomer.Click += new System.EventHandler(this.ButtonAddCustomer_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(597, 336);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 20);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // lblCountry
            // 
            this.lblCountry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(597, 270);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(67, 20);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(597, 204);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 20);
            this.lblCity.TabIndex = 20;
            this.lblCity.Text = "City";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(597, 138);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(597, 72);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(597, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "ID";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(597, 359);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(238, 30);
            this.textBoxPhone.TabIndex = 12;
            this.textBoxPhone.WordWrap = false;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Country", true));
            this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.Location = new System.Drawing.Point(597, 293);
            this.textBoxCountry.Multiline = true;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(238, 30);
            this.textBoxCountry.TabIndex = 13;
            this.textBoxCountry.WordWrap = false;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "City", true));
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(597, 228);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(238, 30);
            this.textBoxCity.TabIndex = 14;
            this.textBoxCity.WordWrap = false;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(597, 161);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(238, 30);
            this.textBoxLastName.TabIndex = 15;
            this.textBoxLastName.WordWrap = false;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(597, 95);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(238, 30);
            this.textBoxFirstName.TabIndex = 16;
            this.textBoxFirstName.WordWrap = false;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxCustomerID.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCustomerID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Id", true));
            this.textBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxCustomerID.Location = new System.Drawing.Point(597, 31);
            this.textBoxCustomerID.Multiline = true;
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(119, 30);
            this.textBoxCustomerID.TabIndex = 17;
            this.textBoxCustomerID.UseWaitCursor = true;
            this.textBoxCustomerID.WordWrap = false;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AllowUserToResizeColumns = false;
            this.dataGridViewCustomer.AllowUserToResizeRows = false;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dataGridViewCustomer.DataSource = this.customerBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersVisible = false;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(582, 436);
            this.dataGridViewCustomer.TabIndex = 11;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.BackColor = System.Drawing.Color.White;
            this.tabPageProduct.Controls.Add(this.dataGridViewProduct);
            this.tabPageProduct.Controls.Add(this.comboBoxSupplier);
            this.tabPageProduct.Controls.Add(this.buttonSaveProduct);
            this.tabPageProduct.Controls.Add(this.buttonDeleteProduct);
            this.tabPageProduct.Controls.Add(this.buttonAddProduct);
            this.tabPageProduct.Controls.Add(this.label1);
            this.tabPageProduct.Controls.Add(this.label2);
            this.tabPageProduct.Controls.Add(this.label3);
            this.tabPageProduct.Controls.Add(this.label4);
            this.tabPageProduct.Controls.Add(this.label5);
            this.tabPageProduct.Controls.Add(this.label6);
            this.tabPageProduct.Controls.Add(this.textBoxDiscount);
            this.tabPageProduct.Controls.Add(this.textBoxPackage);
            this.tabPageProduct.Controls.Add(this.textBoxUnitPrice);
            this.tabPageProduct.Controls.Add(this.textBoxProductName);
            this.tabPageProduct.Controls.Add(this.textBoxProductID);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 29);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(854, 496);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Product";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            this.dataGridViewProduct.AutoGenerateColumns = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dataGridViewProduct.DataSource = this.productBindingSource;
            this.dataGridViewProduct.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(582, 436);
            this.dataGridViewProduct.TabIndex = 44;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(595, 358);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(238, 28);
            this.comboBoxSupplier.TabIndex = 43;
            this.comboBoxSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplier_SelectedIndexChanged);
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveProduct.Location = new System.Drawing.Point(595, 449);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(238, 40);
            this.buttonSaveProduct.TabIndex = 40;
            this.buttonSaveProduct.Text = "Save";
            this.buttonSaveProduct.UseVisualStyleBackColor = true;
            this.buttonSaveProduct.Click += new System.EventHandler(this.buttonSaveProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(9, 449);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(238, 40);
            this.buttonDeleteProduct.TabIndex = 41;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddProduct.Location = new System.Drawing.Point(595, 403);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(238, 40);
            this.buttonAddProduct.TabIndex = 42;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Is Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Package";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(595, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "ID";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(595, 292);
            this.textBoxDiscount.Multiline = true;
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(238, 30);
            this.textBoxDiscount.TabIndex = 29;
            this.textBoxDiscount.WordWrap = false;
            // 
            // textBoxPackage
            // 
            this.textBoxPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPackage.Location = new System.Drawing.Point(595, 226);
            this.textBoxPackage.Multiline = true;
            this.textBoxPackage.Name = "textBoxPackage";
            this.textBoxPackage.Size = new System.Drawing.Size(238, 30);
            this.textBoxPackage.TabIndex = 30;
            this.textBoxPackage.WordWrap = false;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitPrice.Location = new System.Drawing.Point(595, 160);
            this.textBoxUnitPrice.Multiline = true;
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(238, 30);
            this.textBoxUnitPrice.TabIndex = 31;
            this.textBoxUnitPrice.WordWrap = false;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(595, 94);
            this.textBoxProductName.Multiline = true;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(238, 30);
            this.textBoxProductName.TabIndex = 32;
            this.textBoxProductName.WordWrap = false;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductID.Location = new System.Drawing.Point(595, 30);
            this.textBoxProductID.Multiline = true;
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.ReadOnly = true;
            this.textBoxProductID.Size = new System.Drawing.Size(119, 30);
            this.textBoxProductID.TabIndex = 33;
            this.textBoxProductID.WordWrap = false;
            // 
            // tabPageSell
            // 
            this.tabPageSell.BackColor = System.Drawing.Color.White;
            this.tabPageSell.Controls.Add(this.buttonSaveSell);
            this.tabPageSell.Controls.Add(this.numericUpDown1);
            this.tabPageSell.Controls.Add(this.textBoxProductIdToSell);
            this.tabPageSell.Controls.Add(this.listView1);
            this.tabPageSell.Controls.Add(this.labelTotalPrice);
            this.tabPageSell.Controls.Add(this.labelTotal);
            this.tabPageSell.Controls.Add(this.lblProductId);
            this.tabPageSell.Location = new System.Drawing.Point(4, 29);
            this.tabPageSell.Name = "tabPageSell";
            this.tabPageSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSell.Size = new System.Drawing.Size(854, 496);
            this.tabPageSell.TabIndex = 2;
            this.tabPageSell.Text = "Sell";
            // 
            // buttonSaveSell
            // 
            this.buttonSaveSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveSell.Location = new System.Drawing.Point(718, 396);
            this.buttonSaveSell.Name = "buttonSaveSell";
            this.buttonSaveSell.Size = new System.Drawing.Size(119, 40);
            this.buttonSaveSell.TabIndex = 43;
            this.buttonSaveSell.Text = "Save";
            this.buttonSaveSell.UseVisualStyleBackColor = true;
            this.buttonSaveSell.Click += new System.EventHandler(this.buttonSaveSell_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(258, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 42;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // textBoxProductIdToSell
            // 
            this.textBoxProductIdToSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductIdToSell.Location = new System.Drawing.Point(122, 19);
            this.textBoxProductIdToSell.Name = "textBoxProductIdToSell";
            this.textBoxProductIdToSell.Size = new System.Drawing.Size(119, 26);
            this.textBoxProductIdToSell.TabIndex = 41;
            this.textBoxProductIdToSell.WordWrap = false;
            this.textBoxProductIdToSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProductIdToSell_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(840, 328);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Amount";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Price";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 100;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(601, 406);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(90, 20);
            this.labelTotalPrice.TabIndex = 39;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(549, 406);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(46, 20);
            this.labelTotal.TabIndex = 39;
            this.labelTotal.Text = "Total";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(27, 22);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(89, 20);
            this.lblProductId.TabIndex = 39;
            this.lblProductId.Text = "Product ID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Lab0401_Shop_Application.Customer);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 51;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 124;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 124;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 124;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 51;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 247;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lab0401_Shop_Application.Product);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 529);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab0401 Shop Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPageSell.ResumeLayout(false);
            this.tabPageSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCustomer;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageSell;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonAddCustomer;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.TextBox textBoxPackage;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ButtonAddNewCustomer;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxProductIdToSell;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonSaveSell;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

