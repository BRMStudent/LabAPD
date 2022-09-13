namespace LAB0601_Simple_DLL {
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
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPi = new System.Windows.Forms.TextBox();
            this.textBoxradius = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.Location = new System.Drawing.Point(30, 180);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(116, 35);
            this.buttonSayHello.TabIndex = 0;
            this.buttonSayHello.Text = "SayHello";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(104, 21);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(69, 22);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(188, 21);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(69, 22);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(283, 21);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(69, 22);
            this.textBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add";
            // 
            // textBoxPi
            // 
            this.textBoxPi.Location = new System.Drawing.Point(104, 98);
            this.textBoxPi.Name = "textBoxPi";
            this.textBoxPi.ReadOnly = true;
            this.textBoxPi.Size = new System.Drawing.Size(69, 22);
            this.textBoxPi.TabIndex = 5;
            // 
            // textBoxradius
            // 
            this.textBoxradius.Location = new System.Drawing.Point(188, 98);
            this.textBoxradius.Name = "textBoxradius";
            this.textBoxradius.Size = new System.Drawing.Size(69, 22);
            this.textBoxradius.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(283, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Circle Area";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxradius);
            this.Controls.Add(this.textBoxPi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonSayHello);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB0601 Simple DLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSayHello;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPi;
        private System.Windows.Forms.TextBox textBoxradius;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}

