using System.Windows.Forms;

namespace ComputerDIY {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWebEx = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductDetail = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInsertData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonGetAllPage = new System.Windows.Forms.Button();
            this.textBoxCountPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageShoppingCart = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageWebEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWebEx);
            this.tabControl1.Controls.Add(this.tabPageShoppingCart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Kanit", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 778);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageWebEx
            // 
            this.tabPageWebEx.Controls.Add(this.pictureBox1);
            this.tabPageWebEx.Controls.Add(this.textBoxPrice);
            this.tabPageWebEx.Controls.Add(this.textBoxProductDetail);
            this.tabPageWebEx.Controls.Add(this.textBoxProductName);
            this.tabPageWebEx.Controls.Add(this.textBoxProductId);
            this.tabPageWebEx.Controls.Add(this.label7);
            this.tabPageWebEx.Controls.Add(this.label6);
            this.tabPageWebEx.Controls.Add(this.label5);
            this.tabPageWebEx.Controls.Add(this.label4);
            this.tabPageWebEx.Controls.Add(this.buttonInsertData);
            this.tabPageWebEx.Controls.Add(this.label3);
            this.tabPageWebEx.Controls.Add(this.comboBoxType);
            this.tabPageWebEx.Controls.Add(this.listView1);
            this.tabPageWebEx.Controls.Add(this.buttonGetAllPage);
            this.tabPageWebEx.Controls.Add(this.textBoxCountPage);
            this.tabPageWebEx.Controls.Add(this.label2);
            this.tabPageWebEx.Controls.Add(this.buttonGo);
            this.tabPageWebEx.Controls.Add(this.textBoxURL);
            this.tabPageWebEx.Controls.Add(this.label1);
            this.tabPageWebEx.Location = new System.Drawing.Point(4, 36);
            this.tabPageWebEx.Name = "tabPageWebEx";
            this.tabPageWebEx.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWebEx.Size = new System.Drawing.Size(1254, 738);
            this.tabPageWebEx.TabIndex = 0;
            this.tabPageWebEx.Text = "WebExtraction";
            this.tabPageWebEx.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(939, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(939, 383);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(290, 33);
            this.textBoxPrice.TabIndex = 14;
            // 
            // textBoxProductDetail
            // 
            this.textBoxProductDetail.Font = new System.Drawing.Font("Kanit", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductDetail.Location = new System.Drawing.Point(939, 264);
            this.textBoxProductDetail.Multiline = true;
            this.textBoxProductDetail.Name = "textBoxProductDetail";
            this.textBoxProductDetail.ReadOnly = true;
            this.textBoxProductDetail.Size = new System.Drawing.Size(290, 83);
            this.textBoxProductDetail.TabIndex = 13;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(939, 194);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(290, 30);
            this.textBoxProductName.TabIndex = 12;
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(939, 120);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.ReadOnly = true;
            this.textBoxProductId.Size = new System.Drawing.Size(290, 33);
            this.textBoxProductId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(934, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "ราคา";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(934, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "รายละเอียดสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(934, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "ชื่อสินสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "รหัสสินค้า";
            // 
            // buttonInsertData
            // 
            this.buttonInsertData.Location = new System.Drawing.Point(27, 654);
            this.buttonInsertData.Name = "buttonInsertData";
            this.buttonInsertData.Size = new System.Drawing.Size(884, 72);
            this.buttonInsertData.TabIndex = 9;
            this.buttonInsertData.Text = "เพิ่มข้อมูลเข้าฐานข้อมูล";
            this.buttonInsertData.UseVisualStyleBackColor = true;
            this.buttonInsertData.Click += new System.EventHandler(this.buttonInsertData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "ประเภท";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(665, 71);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(246, 35);
            this.comboBoxType.TabIndex = 7;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductId,
            this.ProductName});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(884, 528);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // ProductId
            // 
            this.ProductId.Text = "รหัสสินค้า";
            this.ProductId.Width = 100;
            // 
            // ProductName
            // 
            this.ProductName.Text = "ชื่อสินค้า";
            this.ProductName.Width = 700;
            // 
            // buttonGetAllPage
            // 
            this.buttonGetAllPage.Location = new System.Drawing.Point(271, 71);
            this.buttonGetAllPage.Name = "buttonGetAllPage";
            this.buttonGetAllPage.Size = new System.Drawing.Size(152, 39);
            this.buttonGetAllPage.TabIndex = 5;
            this.buttonGetAllPage.Text = "ดึงข้อมูลทุกหน้า";
            this.buttonGetAllPage.UseVisualStyleBackColor = true;
            this.buttonGetAllPage.Click += new System.EventHandler(this.buttonGetAllPage_Click);
            // 
            // textBoxCountPage
            // 
            this.textBoxCountPage.Location = new System.Drawing.Point(163, 73);
            this.textBoxCountPage.Name = "textBoxCountPage";
            this.textBoxCountPage.ReadOnly = true;
            this.textBoxCountPage.Size = new System.Drawing.Size(100, 33);
            this.textBoxCountPage.TabIndex = 4;
            this.textBoxCountPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "จำนวนหน้าทั้งหมด";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(1122, 22);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(107, 39);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(70, 25);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(1046, 33);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
            this.textBoxURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURL_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // tabPageShoppingCart
            // 
            this.tabPageShoppingCart.Location = new System.Drawing.Point(4, 36);
            this.tabPageShoppingCart.Name = "tabPageShoppingCart";
            this.tabPageShoppingCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShoppingCart.Size = new System.Drawing.Size(1254, 738);
            this.tabPageShoppingCart.TabIndex = 1;
            this.tabPageShoppingCart.Text = "Shopping Cart";
            this.tabPageShoppingCart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 778);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer DIY";
            this.tabControl1.ResumeLayout(false);
            this.tabPageWebEx.ResumeLayout(false);
            this.tabPageWebEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWebEx;
        private System.Windows.Forms.TabPage tabPageShoppingCart;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonGetAllPage;
        private System.Windows.Forms.TextBox textBoxCountPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsertData;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProductDetail;
        private TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProsductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ColumnHeader ProductId;
        private ColumnHeader ProductName;
    }
}

