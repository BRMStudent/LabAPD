using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab0302_Data_Binding {
    public partial class Form1 : Form {

        StudentBindingEntities context = new StudentBindingEntities();

        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void FillButton_Click(object sender, EventArgs e) {
            studentBindingSource.DataSource =  context.Students.ToList();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            pictureBox1.Image = null;
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            studentBindingSource.EndEdit();
            int change = context.SaveChanges();
            MessageBox.Show("Change: " + change + " records");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

    }
}
