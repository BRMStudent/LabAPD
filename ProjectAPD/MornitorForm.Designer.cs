namespace ProjectAPD {
    partial class MornitorForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minimizeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(211)))));
            this.titleBar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Controls.Add(this.minimizeBox);
            this.titleBar.Controls.Add(this.closeBox);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1280, 51);
            this.titleBar.TabIndex = 6;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monitor";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1190, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 31);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // minimizeBox
            // 
            this.minimizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeBox.FillColor = System.Drawing.Color.Transparent;
            this.minimizeBox.IconColor = System.Drawing.Color.White;
            this.minimizeBox.Location = new System.Drawing.Point(1145, 0);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(45, 31);
            this.minimizeBox.TabIndex = 0;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.FillColor = System.Drawing.Color.Transparent;
            this.closeBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(63)))), ((int)(((byte)(64)))));
            this.closeBox.HoverState.IconColor = System.Drawing.Color.White;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(1235, 0);
            this.closeBox.Margin = new System.Windows.Forms.Padding(0);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(45, 31);
            this.closeBox.TabIndex = 0;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1088, 663);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MornitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MornitorForm";
            this.Text = "MornitorForm";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel titleBar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox minimizeBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}