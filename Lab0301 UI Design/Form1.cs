using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0301_UI_Design {
    public partial class Form1 : Form {

        StudentProjectEntities context = new StudentProjectEntities();

        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnFillData_Click(object sender, EventArgs e) {

            // Linq Query
            // var result = from s in context.Student select s;

            // Linq Methods
            var result = context.Student;

            dataGridView1.DataSource = result.ToList();
        }

        private void btnWhere_Click(object sender, EventArgs e) {
            // Linq Query
            // var result = from a in context.Student where a.student_id == textBoxStdID1.Text select a;

            // Linq Methods
            var result = context.Student.Where((a) => a.student_id == textBoxStdIdWhere.Text);

            dataGridView1.DataSource = result.ToList();
        }

        private void btnWhereAnd_Click(object sender, EventArgs e) {
            // Linq Query
            /*
             var result = from s in context.Student 
                         where s.student_id == textBoxStdID1.Text 
                         && s.student_password == textBoxPassword.Text 
                         select s; */

            // Linq Methods
            var result = context.Student.
                    Where((s) => s.student_id == textBoxStdIdWhere.Text 
                    && s.student_password == textBoxPassword.Text);

            dataGridView1.DataSource = result.ToList();
        }

        private void btnWhereOrder_Click(object sender, EventArgs e) {
            // Linq Query
            // var result = from s in context.Student orderby s.student_fullname descending select s;

            // Linq Methods
            var result = context.Student.OrderByDescending((s) => s.student_fullname);

            dataGridView1.DataSource = result.ToList();
        }

        private void btnWhereProjection_Click(object sender, EventArgs e) {
            // Linq Query
            /*var result = from s in context.Student
                         select new { ID = s.student_id, Fullname = s.student_fullname };*/

            // Linq Methods
            var result = context.Student
                .Select((s) => new { ID = s.student_id, Fullname = s.student_fullname })
                .OrderByDescending((s) => s.ID);

            dataGridView1.DataSource = result.ToList();
        }

        private void btnCount_Click(object sender, EventArgs e) {
            // Linq Query
            /*var result = from s in context.Student
                         select s;*/

            // Linq Methods
            var result = context.Student;

            MessageBox.Show("Number of records: " + context.Student.Count());
        }

        private void btnUpdateFullname_Click(object sender, EventArgs e) {
            // Linq Query
            /*var result = from s in context.Student where s.student_id == textBoxStdIdUpdate1.Text select s;
            result.ToList().ForEach((s) => s.student_fullname = textBoxFullname1.Text);*/

            // Linq Methods
            context.Student.Where((s) => s.student_id == textBoxStdIdUpdate1.Text)
                .First().student_fullname = textBoxFullname1.Text;

            int change = context.SaveChanges();
            MessageBox.Show("Change: " + change + " records");
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            Student student = new Student();
            student.student_id = textBoxStdIdInsert.Text;
            student.student_fullname = textBoxFullname2.Text;

            context.Student.Add(student);

            int change = context.SaveChanges();
            MessageBox.Show("Change: " + change + " records");
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            // Linq Query
            // var result = from s in context.Student where s.student_id == textBoxStdIdDelete.Text select s;
            // remove 1 more
            // result.ToList().ForEach((s) => context.Student.Remove(s));
            // remove 1
            // context.Student.Remove(result.First());

            // Linq Methods
            var result = context.Student.Where((s) => s.student_id == textBoxStdIdDelete.Text);
            context.Student.Remove(result.First());

            int change = context.SaveChanges();
            MessageBox.Show("Change: " + change + " records");
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnUpdateImage_Click(object sender, EventArgs e) {
            // Linq Query
            // var result = from s in context.Student where s.student_id == textBoxStdIdUpdate2.Text select s;

            // Linq Methods
            var result = context.Student.Where((s) => s.student_id == textBoxStdIdUpdate2.Text);

            result.First().student_image = ImageToByteArray(pictureBox1.Image);

            int change = context.SaveChanges();
            MessageBox.Show("Change: " + change + " records");

        }

        private byte[] ImageToByteArray(Image image) { 
            var ms = new MemoryStream();

            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
