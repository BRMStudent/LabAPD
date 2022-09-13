using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleDLL;
using ClassLibrary1;
using New_Library;

namespace LAB0601_Simple_DLL {
    public partial class Form1 : Form {
        Simple simple = new Simple();
        Shape shape = new Shape();

        public Form1() {
            InitializeComponent();
            textBoxPi.Text = 3.14.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            Simple simple = new Simple();
            string str = simple.SayHello("Baramee");
            Console.WriteLine(str);
            
        }

        private void button1_Click_1(object sender, EventArgs e) {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int sum = simple.sum(a, b);
            textBoxResult.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            
            double radius = double.Parse(textBoxradius.Text);
            double circleArea = shape.circle(radius);
            textBox3.Text = circleArea.ToString();
        }
    }
}
