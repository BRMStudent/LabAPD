using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0303_Registration {
    public partial class Form1 : Form {
        RegistrationEntities context = new RegistrationEntities();
        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void refresh() {
            registerBindingSource.DataSource = context.Registers
                .Where((r) => r.student_id == comboBox1.Text)
                .Select((r) => new {
                    r.subject_id,
                    r.Subject.subject_name,
                    r.Subject.subject_credit
                })
                .ToList();
        }

        private void Form1_Load(object sender, EventArgs e) {
            studentBindingSource.DataSource =  context.Students.ToList();
            subjectBindingSource.DataSource = context.Subjects.ToList();
            refresh();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            refresh();
        }

        

        private void RemoveButton_Click(object sender, EventArgs e) {
            string student_id = comboBox1.Text;
            string subject_id = dataGridViewRegistration.SelectedRows[0].Cells[0].Value.ToString();

            var toDelete = context.Registers.Where((r) => r.student_id == student_id && r.subject_id == subject_id);
            context.Registers.RemoveRange(toDelete);
            int change = context.SaveChanges();
            refresh();
            /*MessageBox.Show("Change: " + change + " records");*/
        }

        private void EnrollButton_Click(object sender, EventArgs e) {
            string student_id = comboBox1.Text;
            string subject_id = dataGridViewSubject.SelectedRows[0].Cells[0].Value.ToString();
            /*string subject_id = dataGridViewSubject.SelectedRows[0].DataBoundItem.ToString();*/

            Register register = new Register();
            register.student_id = student_id;
            register.subject_id = subject_id;

            context.Registers.Add(register);
            int change = context.SaveChanges();
            refresh();
            /*MessageBox.Show("Change: " + change + " records");*/
        }
    }
}
