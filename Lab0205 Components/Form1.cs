using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0205_Components {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e) {
            if (String.IsNullOrEmpty(textBox1.Text)) {
                errorProvider1.SetError(textBox1, "this field mustn't be null");
            } else {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (progressBar1.Value >= 100) {
                progressBar1.Value = 0;
            } else {
                progressBar1.PerformStep();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            timer1.Enabled = !timer1.Enabled;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            while (true) {
                for (int i = 0; i < imageList1.Images.Count; i++) {
                    Thread.Sleep(1000);
                    pictureBox1.Image = imageList1.Images[i];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            backgroundWorker1.RunWorkerAsync();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
