namespace ProjectAPD {
    partial class SalemanForm {
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
            this.profilePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTag = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonMngComboSet = new FontAwesome.Sharp.IconButton();
            this.buttonSell = new FontAwesome.Sharp.IconButton();
            this.buttonCustomer = new FontAwesome.Sharp.IconButton();
            this.productsButton = new FontAwesome.Sharp.IconButton();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.container = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.titleBar.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePictureBox.Image = global::ProjectAPD.Properties.Resources.user;
            this.profilePictureBox.ImageRotate = 0F;
            this.profilePictureBox.Location = new System.Drawing.Point(820, 24);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePictureBox.Size = new System.Drawing.Size(50, 50);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 3;
            this.profilePictureBox.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(879, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 32);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "label2";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1210, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(80, 50);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeBox.FillColor = System.Drawing.Color.Transparent;
            this.minimizeBox.IconColor = System.Drawing.Color.White;
            this.minimizeBox.Location = new System.Drawing.Point(1130, 0);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(80, 50);
            this.minimizeBox.TabIndex = 0;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.FillColor = System.Drawing.Color.Transparent;
            this.closeBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.closeBox.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(1290, 0);
            this.closeBox.Margin = new System.Windows.Forms.Padding(0);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(80, 50);
            this.closeBox.TabIndex = 0;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click_1);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.titleBar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.titleBar.Controls.Add(this.profilePictureBox);
            this.titleBar.Controls.Add(this.labelName);
            this.titleBar.Controls.Add(this.lblTag);
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Controls.Add(this.minimizeBox);
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1370, 100);
            this.titleBar.TabIndex = 5;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown_1);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Kanit Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.Color.White;
            this.lblTag.Location = new System.Drawing.Point(136, 30);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(137, 44);
            this.lblTag.TabIndex = 1;
            this.lblTag.Text = "Saleman";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 758);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1370, 10);
            this.guna2Panel1.TabIndex = 6;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.menuPanel.Controls.Add(this.buttonMngComboSet);
            this.menuPanel.Controls.Add(this.buttonSell);
            this.menuPanel.Controls.Add(this.buttonCustomer);
            this.menuPanel.Controls.Add(this.productsButton);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 100);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(144, 658);
            this.menuPanel.TabIndex = 7;
            // 
            // buttonMngComboSet
            // 
            this.buttonMngComboSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMngComboSet.FlatAppearance.BorderSize = 0;
            this.buttonMngComboSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMngComboSet.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMngComboSet.ForeColor = System.Drawing.Color.White;
            this.buttonMngComboSet.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.buttonMngComboSet.IconColor = System.Drawing.Color.White;
            this.buttonMngComboSet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMngComboSet.Location = new System.Drawing.Point(0, 345);
            this.buttonMngComboSet.Name = "buttonMngComboSet";
            this.buttonMngComboSet.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonMngComboSet.Size = new System.Drawing.Size(144, 115);
            this.buttonMngComboSet.TabIndex = 6;
            this.buttonMngComboSet.Text = "จัดชุดอุปกรณ์";
            this.buttonMngComboSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMngComboSet.UseVisualStyleBackColor = true;
            this.buttonMngComboSet.Click += new System.EventHandler(this.buttonMngComboSet_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSell.FlatAppearance.BorderSize = 0;
            this.buttonSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSell.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.ForeColor = System.Drawing.Color.White;
            this.buttonSell.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.buttonSell.IconColor = System.Drawing.Color.White;
            this.buttonSell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSell.Location = new System.Drawing.Point(0, 230);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonSell.Size = new System.Drawing.Size(144, 115);
            this.buttonSell.TabIndex = 5;
            this.buttonSell.Text = "ขายสินค้า";
            this.buttonSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonCustomer.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.buttonCustomer.IconColor = System.Drawing.Color.White;
            this.buttonCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCustomer.Location = new System.Drawing.Point(0, 115);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.buttonCustomer.Size = new System.Drawing.Size(144, 115);
            this.buttonCustomer.TabIndex = 4;
            this.buttonCustomer.Text = "ข้อมูลลูกค้า";
            this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // productsButton
            // 
            this.productsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.Color.White;
            this.productsButton.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.productsButton.IconColor = System.Drawing.Color.White;
            this.productsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.productsButton.Location = new System.Drawing.Point(0, 0);
            this.productsButton.Name = "productsButton";
            this.productsButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.productsButton.Size = new System.Drawing.Size(144, 115);
            this.productsButton.TabIndex = 2;
            this.productsButton.Text = "คลังสินค้า";
            this.productsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.logoutButton.IconColor = System.Drawing.Color.White;
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutButton.IconSize = 40;
            this.logoutButton.Location = new System.Drawing.Point(0, 543);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.logoutButton.Size = new System.Drawing.Size(144, 115);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "ออกจากระบบ";
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(1360, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(10, 658);
            this.guna2Panel2.TabIndex = 8;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(144, 100);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1216, 658);
            this.container.TabIndex = 9;
            // 
            // SalemanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 768);
            this.Controls.Add(this.container);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalemanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalemanForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePictureBox;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private System.Windows.Forms.Label lblTag;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private FontAwesome.Sharp.IconButton buttonCustomer;
        private FontAwesome.Sharp.IconButton productsButton;
        private FontAwesome.Sharp.IconButton logoutButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel container;
        private FontAwesome.Sharp.IconButton buttonSell;
        private FontAwesome.Sharp.IconButton buttonMngComboSet;
    }
}