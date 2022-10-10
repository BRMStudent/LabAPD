using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD {
    public partial class LoginForm : Form {

        bool passwordHide = true;
        ProjectEntities1 context = new ProjectEntities1();
        List<string> status = new List<string>() { 
            "owner",
            "saleman",
            "monitor"
        };


        public LoginForm() {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            this.ActiveControl = textBoxUsername;
        }

        // DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titleBar_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelHidePassword_Click(object sender, EventArgs e) {
            passwordHide = !passwordHide;
            if (passwordHide) {
                labelHidePassword.Text = "แสดงรหัสผ่าน";
                textBoxPassword.PasswordChar = '*';
            } else {
                labelHidePassword.Text = "ซ่อนรหัสผ่าน";
                textBoxPassword.PasswordChar = '\0';
            }
            
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            var usernames = context.Employeexes.Select(emp => emp.Username).ToList();
            var passwords = context.Employeexes.Select(emp => emp.Password).ToList();

            if (usernames.Contains(textBoxUsername.Text)) {
                if (passwords.Contains(textBoxPassword.Text)) {
                    var user = context.Employeexes.Where(emp => emp.Username == textBoxUsername.Text).First();
                    if (user != null) {
                        if (user.Status.ToLower().Equals(status[0].ToLower())) {
                            OwnerForm ownerForm = new OwnerForm(this, user);
                            ownerForm.Visible = true;
                        } else if (user.Status.ToLower().Equals(status[1].ToLower())) {
                            SalemanForm salemanForm = new SalemanForm(this, user);
                            salemanForm.Visible = true;
                        } else if (user.Status.ToLower().Equals(status[2].ToLower())) {
                            MonitorForm mornitorForm = new MonitorForm(this, user);
                            mornitorForm.Visible = true;
                        }
                        this.Hide();
                    }
                } else {
                    MessageBox.Show("กรอกรหัสผ่านให้ถูกต้อง", "ข้อมูลไม่ถูกต้อง");
                }
            } else { 
                MessageBox.Show("กรอกชื่อผู้ใช้ให้ถูกต้อง", "ข้อมูลไม่ถูกต้อง");
            }
        }
    }
}
