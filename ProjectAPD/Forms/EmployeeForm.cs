using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD.Forms {
    public partial class EmployeeForm : Form {
        ProjectEntities context = new ProjectEntities();
        public EmployeeForm() {
            InitializeComponent();
            employeexBindingSource.DataSource = context.Employeexes.ToList();
        }

        private void iconButton2_Click(object sender, EventArgs e) {

        }

        private void buttonEdit_Click(object sender, EventArgs e) {

        }
    }
}
