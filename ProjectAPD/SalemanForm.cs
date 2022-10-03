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

    public partial class SalemanForm : Form {
        LoginForm loginForm;
        public SalemanForm(LoginForm loginForm) {
            this.loginForm = loginForm;
            InitializeComponent();
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

        private void closeBox_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            loginForm.Visible = true;
            this.Close();
        }
    }
}
