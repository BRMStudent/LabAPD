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
        }

        private void buttonCustomerReset_Click(object sender, EventArgs e) {
            textCustomerFirstName.Text = string.Empty;
            textCustomerLastName.Text = string.Empty;
            textCustomerPhone.Text = string.Empty;
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString();
            var product = context.Productxes.Where(p => p.ProductId.ToString().Equals(id)).First();
            textBoxProductId.Text = product.ProductId.ToString();
            textBoxProductName.Text = product.Name;
            textBoxProductDescription.Text = product.Description;
            textBoxPrice.Text = product.UnitPrice.ToString();
            pictureBoxProduct.Image = LoadImage(product.Image);
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

        private void ClearAll() {
            productList.Clear();
            totalPrice = 0;
            labelTotalPrice.Text = totalPrice.ToString();
            productxBindingSource.DataSource = null;
            textCustomerFirstName.Text = string.Empty;
            textCustomerLastName.Text = string.Empty;
            textCustomerPhone.Text = string.Empty;
            clearDescription();
        }

        private void clearDescription() {
            textBoxProductId.Text = string.Empty;
            textBoxProductName.Text = string.Empty;
            textBoxProductDescription.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            pictureBoxProduct.Image = null;
        }

        private void buttonScanQRCode_Click_1(object sender, EventArgs e) {
            ScanCamForm scanCam = new ScanCamForm(productxBindingSource, productList, labelTotalPrice, this);
            scanCam.Show();
        }

        private void buttonRemoveItem_Click_1(object sender, EventArgs e) {
            try {
                int id = int.Parse(dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString());

                foreach (DataGridViewRow item in dataGridViewProduct.SelectedRows) {
                    dataGridViewProduct.Rows.RemoveAt(item.Index);
                }
                int newTotal = 0;
                foreach (Productx p in productList) {
                    newTotal += p.UnitPrice;
                }
                totalPrice = newTotal;
                labelTotalPrice.Text = totalPrice.ToString();
                productxBindingSource.DataSource = productList;

                clearDescription();


            } catch { }
        }

        private void iconButton1_Click_1(object sender, EventArgs e) {
            productList.Clear();
            totalPrice = 0;
            labelTotalPrice.Text = totalPrice.ToString();
            productxBindingSource.DataSource = null;
            clearDescription();
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
    }
}
