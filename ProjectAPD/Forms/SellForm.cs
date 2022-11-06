using ProjectAPD.Forms.dialog;
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

namespace ProjectAPD.Forms {
    public partial class SellForm : Form {

        ProjectEntities1 context = new ProjectEntities1();
        List<Productx> productList = new List<Productx>();
        
        int totalPrice;

        public SellForm() {
            InitializeComponent();
            totalPrice = 0;
            productxBindingSource.DataSource = productList;
            comboSetBindingSource.DataSource = context.ComboSets.ToList();
        }

        private void buttonCustomerReset_Click(object sender, EventArgs e) {
            textCustomerFirstName.Text = string.Empty;
            textCustomerLastName.Text = string.Empty;
            textCustomerPhone.Text = string.Empty;
        }

        private void ClearAll() {
            productList.Clear();
            totalPrice = 0;
            labelTotalPrice.Text = totalPrice.ToString();
            productxBindingSource.DataSource = null;
            textCustomerFirstName.Text = string.Empty;
            textCustomerLastName.Text = string.Empty;
            textCustomerPhone.Text = string.Empty;
        }

        private void buttonScanQRCode_Click_1(object sender, EventArgs e) {

            FormCollection fc = Application.OpenForms;
            bool camOpening = false;
            foreach (Form frm in fc) {
                if (frm.Name == "ScanCamForm") {
                    camOpening = true;
                    frm.Close();
                    break;
                }
            }
            if (camOpening == false) {
                ScanCamForm scanCam = new ScanCamForm(productxBindingSource, productList, labelTotalPrice, this);
                scanCam.Show();
            }
        }

        bool c = false;
        private void buttonRemoveItem_Click_1(object sender, EventArgs e) {
            try {

                foreach (DataGridViewRow item in dataGridViewProduct.SelectedRows) {
                    dataGridViewProduct.Rows.RemoveAt(item.Index);
                }

                foreach (var p in productList) {
                    Console.WriteLine(p.Name);
                }

                if (c) {
                    int newTotal = 0;
                    foreach (Productx p in productList) {
                        newTotal += p.UnitPrice;
                    }
                    totalPrice = newTotal;
                    labelTotalPrice.Text = totalPrice.ToString();
                }
                productxBindingSource.DataSource = productList;
                c = true;

                dataGridViewProduct.Rows[0].Selected = true;

            } catch { }
        }

        private void iconButton1_Click_1(object sender, EventArgs e) {
            productList.Clear();
            totalPrice = 0;
            labelTotalPrice.Text = totalPrice.ToString();
            productxBindingSource.DataSource = null;
        }

        private void buttonCheckout_Click_1(object sender, EventArgs e) {
            try {
                if (!(textCustomerFirstName.Text.Equals(string.Empty) || textCustomerLastName.Text.Equals(string.Empty) || textCustomerPhone.Text.Equals(string.Empty))) {
                    if (productList.Count > 0) {
                        Customerx customer = new Customerx {
                            FirstName = textCustomerFirstName.Text,
                            LastName = textCustomerLastName.Text,
                            Phone = textCustomerPhone.Text
                        };

                        context.Customerxes.Add(customer);
                        context.SaveChanges();

                        int cusId = context.Customerxes.Max(x => x.Id);

                        Billx bill = new Billx {
                            Date = DateTime.Now.Date,
                            Time = DateTime.Now.TimeOfDay,
                            CustomerId = cusId,
                            TotalPrice = int.Parse(labelTotalPrice.Text)
                        };

                        context.Billxes.Add(bill);
                        context.SaveChanges();

                        int bill_Id = context.Billxes.Max(b => b.Id);

                        foreach (Productx product in productList) {
                            Itemx item = new Itemx {
                                Bill_Id = bill_Id,
                                ProductID = product.Id,
                                Price = product.UnitPrice
                            };
                            context.Itemxes.Add(item);
                            context.SaveChanges();
                        }
                        ClearAll();
                        MessageBox.Show("บันทึกสำเร็จ");
                    } else {
                        ClearAll();
                        MessageBox.Show("ไม่มีรายการสินค้า");
                    }
                } else {
                    MessageBox.Show("กรอกข้อมูลให้ครับถ้วน");
                }

            } catch (Exception ex) {
                MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void dataGridViewComboSet_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int id = int.Parse(dataGridViewComboSet.SelectedRows[0].Cells[0].Value.ToString());
            var set = context.ComboSets.Where(s => s.Id.Equals(id)).First();

            var setItems = context.ComboSetItems.Where(si => si.ComboSetId.Equals(set.Id)).ToList();
            
            foreach (var si in setItems) {
                var product = context.Productxes.Where(p => p.Id.Equals(si.ProductId)).First();
                productList.Add(product);
            }

            totalPrice += set.SetPrice;
            
            labelTotalPrice.Text = totalPrice.ToString();
            productxBindingSource.DataSource = new List<Productx>(productList);
            foreach (var p in productList) { 
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("\n");
            c = false;
        }

    }
}
