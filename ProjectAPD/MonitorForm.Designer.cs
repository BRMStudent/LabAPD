﻿namespace ProjectAPD {
    partial class MonitorForm {
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
            this.titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.container = new Guna.UI2.WinForms.Guna2Panel();
            this.mngProductsButton = new FontAwesome.Sharp.IconButton();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.profilePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.titleBar.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
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
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Kanit Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.Color.White;
            this.lblTag.Location = new System.Drawing.Point(136, 30);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(123, 44);
            this.lblTag.TabIndex = 1;
            this.lblTag.Text = "Monitor";
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
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 758);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1370, 10);
            this.guna2Panel3.TabIndex = 7;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.menuPanel.Controls.Add(this.mngProductsButton);
            this.menuPanel.Controls.Add(this.logoutButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 100);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(144, 658);
            this.menuPanel.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(1360, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(10, 658);
            this.guna2Panel2.TabIndex = 9;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(144, 100);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1216, 658);
            this.container.TabIndex = 10;
            // 
            // mngProductsButton
            // 
            this.mngProductsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mngProductsButton.FlatAppearance.BorderSize = 0;
            this.mngProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mngProductsButton.Font = new System.Drawing.Font("Kanit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngProductsButton.ForeColor = System.Drawing.Color.White;
            this.mngProductsButton.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.mngProductsButton.IconColor = System.Drawing.Color.White;
            this.mngProductsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mngProductsButton.Location = new System.Drawing.Point(0, 0);
            this.mngProductsButton.Name = "mngProductsButton";
            this.mngProductsButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mngProductsButton.Size = new System.Drawing.Size(144, 115);
            this.mngProductsButton.TabIndex = 2;
            this.mngProductsButton.Text = "จัดการคลังสินค้า";
            this.mngProductsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mngProductsButton.UseVisualStyleBackColor = true;
            this.mngProductsButton.Click += new System.EventHandler(this.mngProductsButton_Click);
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
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 768);
            this.Controls.Add(this.container);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MornitorForm";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblTag;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private FontAwesome.Sharp.IconButton mngProductsButton;
        private FontAwesome.Sharp.IconButton logoutButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel container;
    }
}