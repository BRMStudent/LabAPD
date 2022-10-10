using ProjectAPD.Forms.CRUD;
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
    public partial class CustomerForm : Form {
        ProjectEntities1 context = new ProjectEntities1();
        ManageCustomerForm mCusForm;
        public CustomerForm() {
            InitializeComponent();
            customerxBindingSource.DataSource = context.Customerxes.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            textBoxSearch.Text = string.Empty;
            mCusForm = new ManageCustomerForm("Add Customer", customerxBindingSource);
            mCusForm.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            try {
                int id = int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                mCusForm = new ManageCustomerForm("Edit Customer", id, customerxBindingSource);
                mCusForm.ShowDialog();
                textBoxSearch.Text = string.Empty;
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }


        }

        private async void buttonDelete_Click(object sender, EventArgs e) {
            try {
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var result = context.Customerxes.Where(c => c.Id.ToString() == id).First();
                context.Customerxes.Remove(result);
                await context.SaveChangesAsync();
                textBoxSearch.Text = string.Empty;
                customerxBindingSource.DataSource = context.Customerxes.ToList();
            } catch (Exception exp){
                Console.WriteLine(exp.Message);
            }
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e) {
            customerxBindingSource.DataSource = context.Customerxes.Where(c => (c.FirstName + " " + c.LastName).Contains(textBoxSearch.Text)).ToList();
        }
    }
}
