﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0202_Container {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == 0) {
                tabControl1.SelectTab(tabPage1);
            } else if (comboBox1.SelectedIndex == 1) {
                tabControl1.SelectTab(tabPage2);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
