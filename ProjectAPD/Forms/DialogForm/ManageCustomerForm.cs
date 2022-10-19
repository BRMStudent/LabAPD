using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAPD.Forms.CRUD {
    public partial class ManageCustomerForm : Form {
        ProjectEntities1 context = new ProjectEntities1();
        BindingSource customerBindingSource;
        string title;
        int cusId;
        public ManageCustomerForm(string title, BindingSource customerBindingSource) {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = title;
            this.title = title;
            this.customerBindingSource = customerBindingSource;
        }

        public ManageCustomerForm(string title, int id, BindingSource customerBindingSource) {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = title;
            this.cusId = id;
            this.title = title;
            this.customerBindingSource = customerBindingSource;

            Customerx customer = context.Customerxes.Where(c => c.Id.Equals(id)).First();
            textFirstName.Text = customer.FirstName;
            textBoxLastName.Text = customer.LastName;
            textBoxPhone.Text = customer.Phone;
        }

        private async void buttonConfirm_Click(object sender, EventArgs e) {

            if (title.Equals("Add Customer")) {
                Customerx customer = new Customerx {
                    FirstName = textFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Phone = textBoxPhone.Text
                };

                context.Customerxes.Add(customer);
                await context.SaveChangesAsync();
                customerBindingSource.DataSource = context.Customerxes.ToList();
                this.Close();
            } else if (title.Equals("Edit Customer")) {
                Customerx customerx = context.Customerxes.Where(c => c.Id.Equals(cusId)).First();
                customerx.FirstName = textFirstName.Text;
                customerx.LastName = textBoxLastName.Text;
                customerx.Phone = textBoxPhone.Text;

                await context.SaveChangesAsync();
                customerBindingSource.DataSource = context.Customerxes.ToList();
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
