using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using ProjectAPD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD {
    public partial class MonitorForm : Form {
        LoginForm loginForm;
        Employeex userData;


        //component
        IconButton currentButton;
        Guna2Panel selectedPanel;
        Form currentChildForm;
        public MonitorForm(LoginForm loginForm, Employeex userData) {
            InitializeComponent();
            this.loginForm = loginForm;
            this.userData = userData;
            labelName.Text = userData.FirstName + " " + userData.LastName;
            if (userData.Image != null) {
                profilePictureBox.Image = LoadImage(userData.Image);
            }
            //btn
            selectedPanel = new Guna2Panel();
            selectedPanel.Size = new Size(7, mngProductsButton.Size.Height);
            menuPanel.Controls.Add(selectedPanel);
            selectedPanel.BackColor = Color.White;

            SelectedButton(mngProductsButton);
            OpenChildForm(new MngProductForm());
        }
        private void OpenChildForm(Form childForm) {
            if (currentChildForm != null) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            container.Controls.Add(childForm);
            container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTag.Text = childForm.Text;
        }

        private void SelectedButton(object sender) {

            UnselecteButton();
            currentButton = (IconButton)sender;
            currentButton.BackColor = Color.FromArgb(42, 73, 140);

            selectedPanel.Location = new Point(0, currentButton.Location.Y);
            selectedPanel.Visible = true;
            selectedPanel.BringToFront();
        }

        private void UnselecteButton() {
            if (currentButton != null) {
                currentButton.BackColor = Color.FromArgb(25, 118, 211);
            }
        }

        // DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void titleBar_MouseDown_1(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeBox_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            loginForm.Visible = true;
            this.Close();
        }
        
        private void mngProductsButton_Click(object sender, EventArgs e) {
            SelectedButton(sender);
            OpenChildForm(new MngProductForm());
        }
        private Image LoadImage(string url) {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myHttpWebRequest.UserAgent = "Chrome/105.0.0.0";
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Stream streamResponse = myHttpWebResponse.GetResponseStream();
            Bitmap bmp = new Bitmap(streamResponse);
            streamResponse.Dispose();
            return bmp;
        }
    }
}
