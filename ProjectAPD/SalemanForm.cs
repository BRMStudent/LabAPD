using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD {
    public partial class SalemanForm : Form {
        public SalemanForm() {
            InitializeComponent();
        }

        private void SalemanForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
