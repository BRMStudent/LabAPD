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
    public partial class EmployeeForm : Form {
        ProjectEntities1 context = new ProjectEntities1();
        ManageEmpForm mEmp;
        public EmployeeForm() {
            InitializeComponent();
            employeexBindingSource.DataSource = context.Employeexes.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            textBoxSearch.Text = string.Empty;
            mEmp = new ManageEmpForm("Add Employee", employeexBindingSource);
            mEmp.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            try { 
                int id = int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                mEmp = new ManageEmpForm("Edit Employee", id, employeexBindingSource);
                mEmp.ShowDialog();
                textBoxSearch.Text = string.Empty;
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e) {

            try {
                string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var result = context.Employeexes.Where(emp => emp.Id.ToString() == id).First();
                context.Employeexes.Remove(result);
                await context.SaveChangesAsync();
                textBoxSearch.Text = string.Empty;
                employeexBindingSource.DataSource = context.Employeexes.ToList();
            } catch (Exception exp) {
                Console.WriteLine(exp.Message); 
            }
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) {
            employeexBindingSource.DataSource = context.Employeexes.Where(emp => (emp.FirstName+" "+emp.LastName).Contains(textBoxSearch.Text)).ToList();
        }
    }
}
