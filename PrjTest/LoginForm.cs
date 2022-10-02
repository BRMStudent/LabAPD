using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PrjTest {
    public partial class LoginForm : MetroForm {
        public LoginForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            OwnerForm ownerForm = new OwnerForm();
            ownerForm.Visible = true;
            this.Visible = false;
        }
    }
}
