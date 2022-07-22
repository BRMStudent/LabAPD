namespace Lab0303_Registration {
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStudentFullname = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRegistration = new System.Windows.Forms.DataGridView();
            this.subjectidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.subjectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.EnrollButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Image";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentBindingSource;
            this.comboBox1.DisplayMember = "student_id";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Lab0303_Registration.Student);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxStudentImage);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxStudentFullname);
            this.groupBox1.Controls.Add(this.textBoxStudentID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 297);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student info";
            // 
            // pictureBoxStudentImage
            // 
            this.pictureBoxStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStudentImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.studentBindingSource, "student_image", true));
            this.pictureBoxStudentImage.Location = new System.Drawing.Point(6, 62);
            this.pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            this.pictureBoxStudentImage.Size = new System.Drawing.Size(194, 229);
            this.pictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudentImage.TabIndex = 12;
            this.pictureBoxStudentImage.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "student_birthday", true));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(206, 212);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(238, 26);
            this.dateTimePicker.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student Fullname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student ID";
            // 
            // textBoxStudentFullname
            // 
            this.textBoxStudentFullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_fullname", true));
            this.textBoxStudentFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentFullname.Location = new System.Drawing.Point(206, 151);
            this.textBoxStudentFullname.Multiline = true;
            this.textBoxStudentFullname.Name = "textBoxStudentFullname";
            this.textBoxStudentFullname.Size = new System.Drawing.Size(238, 30);
            this.textBoxStudentFullname.TabIndex = 3;
            this.textBoxStudentFullname.WordWrap = false;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_id", true));
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentID.Location = new System.Drawing.Point(206, 85);
            this.textBoxStudentID.Multiline = true;
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(238, 30);
            this.textBoxStudentID.TabIndex = 3;
            this.textBoxStudentID.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewRegistration);
            this.groupBox3.Controls.Add(this.RemoveButton);
            this.groupBox3.Controls.Add(this.RefreshButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(469, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 494);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registration";
            // 
            // dataGridViewRegistration
            // 
            this.dataGridViewRegistration.AllowUserToAddRows = false;
            this.dataGridViewRegistration.AllowUserToDeleteRows = false;
            this.dataGridViewRegistration.AutoGenerateColumns = false;
            this.dataGridViewRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectidDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.Subject});
            this.dataGridViewRegistration.DataSource = this.registerBindingSource;
            this.dataGridViewRegistration.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewRegistration.Name = "dataGridViewRegistration";
            this.dataGridViewRegistration.ReadOnly = true;
            this.dataGridViewRegistration.RowHeadersVisible = false;
            this.dataGridViewRegistration.RowHeadersWidth = 51;
            this.dataGridViewRegistration.RowTemplate.Height = 24;
            this.dataGridViewRegistration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegistration.Size = new System.Drawing.Size(539, 417);
            this.dataGridViewRegistration.TabIndex = 9;
            // 
            // subjectidDataGridViewTextBoxColumn1
            // 
            this.subjectidDataGridViewTextBoxColumn1.DataPropertyName = "subject_id";
            this.subjectidDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.subjectidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.subjectidDataGridViewTextBoxColumn1.Name = "subjectidDataGridViewTextBoxColumn1";
            this.subjectidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subjectidDataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "subject_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 248;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "subject_credit";
            this.Subject.HeaderText = "Credit";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 73;
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataSource = typeof(Lab0303_Registration.Register);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Location = new System.Drawing.Point(397, 448);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(148, 40);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.Location = new System.Drawing.Point(6, 448);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(148, 40);
            this.RefreshButton.TabIndex = 8;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewSubject);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 343);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 294);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Subject";
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.AllowUserToAddRows = false;
            this.dataGridViewSubject.AllowUserToDeleteRows = false;
            this.dataGridViewSubject.AutoGenerateColumns = false;
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectidDataGridViewTextBoxColumn,
            this.subjectnameDataGridViewTextBoxColumn});
            this.dataGridViewSubject.DataSource = this.subjectBindingSource;
            this.dataGridViewSubject.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.ReadOnly = true;
            this.dataGridViewSubject.RowHeadersVisible = false;
            this.dataGridViewSubject.RowHeadersWidth = 51;
            this.dataGridViewSubject.RowTemplate.Height = 24;
            this.dataGridViewSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubject.Size = new System.Drawing.Size(434, 263);
            this.dataGridViewSubject.TabIndex = 0;
            // 
            // subjectidDataGridViewTextBoxColumn
            // 
            this.subjectidDataGridViewTextBoxColumn.DataPropertyName = "subject_id";
            this.subjectidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.subjectidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectidDataGridViewTextBoxColumn.Name = "subjectidDataGridViewTextBoxColumn";
            this.subjectidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectidDataGridViewTextBoxColumn.Width = 75;
            // 
            // subjectnameDataGridViewTextBoxColumn
            // 
            this.subjectnameDataGridViewTextBoxColumn.DataPropertyName = "subject_name";
            this.subjectnameDataGridViewTextBoxColumn.HeaderText = "Subject Name";
            this.subjectnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectnameDataGridViewTextBoxColumn.Name = "subjectnameDataGridViewTextBoxColumn";
            this.subjectnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectnameDataGridViewTextBoxColumn.Width = 248;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(Lab0303_Registration.Subject);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Student ID";
            // 
            // EnrollButton
            // 
            this.EnrollButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnrollButton.Location = new System.Drawing.Point(475, 597);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(545, 40);
            this.EnrollButton.TabIndex = 8;
            this.EnrollButton.Text = "Enroll";
            this.EnrollButton.UseVisualStyleBackColor = true;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 649);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.EnrollButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab0303 Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStudentFullname;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxStudentImage;
        private System.Windows.Forms.DataGridView dataGridViewRegistration;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
    }
}

