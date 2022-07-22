using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0204_MDI_Form {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form form in fc) {
                if (form.Name == "Form2") { 
                    FormFound = true;
                    form.Focus();
                    break;
                }
            }
            if (!FormFound) { 
                Form2 form2 = new Form2();
                form2.MdiParent = this;
                form2.Visible = true;
            }

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e) {
            FormCollection fc = Application.OpenForms;
            bool FormFound = false;
            foreach (Form form in fc) {
                if (form.Name == "Form3") {
                    FormFound = true;
                    form.Focus();
                    break;
                }
            }
            if (!FormFound) {
                Form3 form3 = new Form3();
                form3.MdiParent = this;
                form3.Visible = true;
            }
            
        }
    }
}
