﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0401_Shop_Application {
    public partial class Form1 : Form {
        APD65_63011212041Entities context = new APD65_63011212041Entities();
        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e) {
            customerBindingSource.DataSource = context.Customers.ToList();
            productBindingSource.DataSource = context.Products.ToList();

            var suppliers = context.Suppliers.OrderBy((s) => s.CompanyName)
                .Select((s) => new { s.Id, s.CompanyName });

            foreach (var supplier in suppliers) {
                comboBoxSupplier.Items.Add(new ComboBoxItem(supplier.Id.ToString(), supplier.CompanyName));
            }
        }

        private void ButtonAddCustomer_Click(object sender, EventArgs e) {
            Customer customer = new Customer();
            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.City = textBoxCity.Text;
            customer.Country = textBoxCountry.Text;
            customer.Phone = textBoxPhone.Text;

            context.Customers.Add(customer);
            int change = context.SaveChanges();
            refresh();
            MessageBox.Show("Change " + change + " records");
        }

        private void refresh() {
            customerBindingSource.DataSource = context.Customers.ToList();
            productBindingSource.DataSource = context.Products.ToList();

            var suppliers = context.Suppliers.OrderBy((s) => s.CompanyName)
                .Select((s) => new { s.Id, s.CompanyName });

            foreach (var supplier in suppliers) {
                comboBoxSupplier.Items.Add(new ComboBoxItem(supplier.Id.ToString(), supplier.CompanyName));
            }
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e) {
            customerBindingSource.AddNew();
        }

        private void ButtonSave_Click(object sender, EventArgs e) {
            customerBindingSource.EndEdit();
            int change = context.SaveChanges();
            MessageBox.Show("Change " + change + " records");
            refresh();
        }

        private void ButtonDelete_Click(object sender, EventArgs e) {
            int id = int.Parse(textBoxCustomerID.Text);
            var customer = context.Customers.Find(id);
            var toDelete = context.Customers.Where((c) => c.Id == id).First();

            context.Customers.Remove(customer);

            int change = context.SaveChanges();
            refresh();
            MessageBox.Show("Change " + change + " records");
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e) {
            int id = int.Parse(dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString());

            var product = context.Products.Where((c) => c.Id == id).First();
            //var product = context.Products.Find(id);

            textBoxProductID.Text = product.Id.ToString();
            textBoxProductName.Text = product.ProductName;
            textBoxUnitPrice.Text = product.UnitPrice.ToString();
            textBoxPackage.Text = product.Package;
            textBoxDiscount.Text = product.IsDiscontinued.ToString();
            comboBoxSupplier.Text = product.Supplier.CompanyName;
        }

        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e) {
            Console.WriteLine(((ComboBoxItem)(comboBoxSupplier.SelectedItem)).Value);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e) {
            Product product = new Product();

            product.ProductName = textBoxProductName.Text;
            product.UnitPrice = decimal.Parse(textBoxUnitPrice.Text);
            product.Package = textBoxPackage.Text;
            product.IsDiscontinued = bool.Parse(textBoxDiscount.Text);
            product.SupplierId = int.Parse(((ComboBoxItem)comboBoxSupplier.SelectedItem).Value);

            context.Products.Add(product);
            int change = context.SaveChanges();
            refresh();
        }
    }

    internal class ComboBoxItem {
        public string Value { get; set; } // Supplier ID
        public string Text { get; set; } // Supplier CompanyName
        public ComboBoxItem(string value, string text) {
            Value = value;
            Text = text;
        }

        public override string ToString() { 
            return Text;
        }
    }
}
