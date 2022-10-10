using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD.Forms.CRUD {
    public partial class ManageEmpForm : Form {

        ProjectEntities1 context = new ProjectEntities1();
        BindingSource empBindingSource;
        string title;
        int empId;
        public ManageEmpForm(string title, BindingSource empBindingSource) {
            InitializeComponent();
            this.Text = title;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.title = title;
            this.empBindingSource = empBindingSource;
        }

        public ManageEmpForm(string title, int id, BindingSource empBindingSource) {
            InitializeComponent();
            this.Text = title;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.empId = id;
            this.title = title;
            this.empBindingSource = empBindingSource;

            Employeex employee = context.Employeexes.Where(emp => emp.Id.Equals(id)).First();
            textFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxUsername.Text = employee.Username;
            textBoxPassword.Text = employee.Password;
            comboBoxStatus.Text = employee.Status;
            guna2PictureBox1.Image = LoadImage(employee.Image);
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void buttonConfirm_Click(object sender, EventArgs e) {
            if (title.Equals("Add Employee")) {
                Employeex employee = new Employeex {
                    FirstName = textFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    Status = comboBoxStatus.Text
                };

                context.Employeexes.Add(employee);
                await context.SaveChangesAsync();
                empBindingSource.DataSource = context.Employeexes.ToList();
                this.Close();
            } else if (title.Equals("Edit Employee")) {

                Employeex employeex = context.Employeexes.Where(emp => emp.Id.Equals(empId)).First();
                employeex.FirstName = textFirstName.Text;
                employeex.LastName = textBoxLastName.Text;
                employeex.Username = textBoxUsername.Text;
                employeex.Password = textBoxPassword.Text;
                employeex.Status = comboBoxStatus.Text;

                await context.SaveChangesAsync();
                empBindingSource.DataSource = context.Employeexes.ToList();
                this.Close();
            }
        }

        private void guna2PictureBox1_MouseDoubleClick(object sender, MouseEventArgs e) {

        }

        private Image LoadImage(string url) {
            if (url != null) {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                myHttpWebRequest.UserAgent = "Chrome/105.0.0.0";
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                Stream streamResponse = myHttpWebResponse.GetResponseStream();
                Bitmap bmp = new Bitmap(streamResponse);
                streamResponse.Dispose();
                return bmp;
            } else {
                return null;
            }
        }
    }
}
