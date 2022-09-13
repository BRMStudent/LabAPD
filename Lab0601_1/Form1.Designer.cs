namespace Lab0601_1 {
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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBoxQrCode = new AForge.Controls.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveQRCode = new System.Windows.Forms.Button();
            this.buttonBarCodeGen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonQRCode = new System.Windows.Forms.RadioButton();
            this.radioButtonBarCode = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQrCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(12, 12);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(413, 356);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(413, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBoxQrCode
            // 
            this.pictureBoxQrCode.BackColor = System.Drawing.Color.White;
            this.pictureBoxQrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQrCode.Image = null;
            this.pictureBoxQrCode.Location = new System.Drawing.Point(431, 12);
            this.pictureBoxQrCode.Name = "pictureBoxQrCode";
            this.pictureBoxQrCode.Size = new System.Drawing.Size(227, 227);
            this.pictureBoxQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQrCode.TabIndex = 3;
            this.pictureBoxQrCode.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveQRCode);
            this.groupBox1.Controls.Add(this.buttonBarCodeGen);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButtonQRCode);
            this.groupBox1.Controls.Add(this.radioButtonBarCode);
            this.groupBox1.Location = new System.Drawing.Point(431, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barcode and QRCode";
            // 
            // buttonSaveQRCode
            // 
            this.buttonSaveQRCode.Location = new System.Drawing.Point(124, 105);
            this.buttonSaveQRCode.Name = "buttonSaveQRCode";
            this.buttonSaveQRCode.Size = new System.Drawing.Size(86, 31);
            this.buttonSaveQRCode.TabIndex = 3;
            this.buttonSaveQRCode.Text = "Save";
            this.buttonSaveQRCode.UseVisualStyleBackColor = true;
            this.buttonSaveQRCode.Click += new System.EventHandler(this.buttonSaveQRCode_Click);
            // 
            // buttonBarCodeGen
            // 
            this.buttonBarCodeGen.Location = new System.Drawing.Point(124, 70);
            this.buttonBarCodeGen.Name = "buttonBarCodeGen";
            this.buttonBarCodeGen.Size = new System.Drawing.Size(86, 31);
            this.buttonBarCodeGen.TabIndex = 2;
            this.buttonBarCodeGen.Text = "Generate";
            this.buttonBarCodeGen.UseVisualStyleBackColor = true;
            this.buttonBarCodeGen.Click += new System.EventHandler(this.buttonBarCodeGen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 1;
            // 
            // radioButtonQRCode
            // 
            this.radioButtonQRCode.AutoSize = true;
            this.radioButtonQRCode.Location = new System.Drawing.Point(10, 110);
            this.radioButtonQRCode.Name = "radioButtonQRCode";
            this.radioButtonQRCode.Size = new System.Drawing.Size(81, 20);
            this.radioButtonQRCode.TabIndex = 0;
            this.radioButtonQRCode.TabStop = true;
            this.radioButtonQRCode.Text = "QRCode";
            this.radioButtonQRCode.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarCode
            // 
            this.radioButtonBarCode.AutoSize = true;
            this.radioButtonBarCode.Location = new System.Drawing.Point(10, 70);
            this.radioButtonBarCode.Name = "radioButtonBarCode";
            this.radioButtonBarCode.Size = new System.Drawing.Size(80, 20);
            this.radioButtonBarCode.TabIndex = 0;
            this.radioButtonBarCode.TabStop = true;
            this.radioButtonBarCode.Text = "Barcode";
            this.radioButtonBarCode.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(664, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 388);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 409);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxQrCode);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQrCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private AForge.Controls.PictureBox pictureBoxQrCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveQRCode;
        private System.Windows.Forms.Button buttonBarCodeGen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonQRCode;
        private System.Windows.Forms.RadioButton radioButtonBarCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

