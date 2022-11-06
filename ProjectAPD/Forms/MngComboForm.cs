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
    public partial class MngComboForm : Form {
        ProjectEntities1 context = new ProjectEntities1();
        List<Productx> productList = new List<Productx>();

        int total = 0;
        bool c = false;

        List<string> typeNames = new List<string> {
            "ทั้งหมด",
            "ซีพียู คอมพิวเตอร์",
            "เมนบอร์ด",
            "การ์ดแสดงผล",
            "แรมสำหรับคอมพิวเตอร์",
            "เคสและเพาเวอร์ซัพพลาย",
            "เครื่องอ่านและบันทึกแผ่นซีดี",
            "การ์ดเสียง",
            "เครื่องอ่านเม็มโมรี่การ์ด",
            "Single Board Computer",
            "Combo Set",
            "Bundle Pack",
        };

        List<string> typeIds = new List<string> {
            "0","43", "46", "51", "53", "54", "55", "56", "57", "1433", "1617", "1616"
        };

        public MngComboForm() {
            InitializeComponent();
            productxBindingSource.DataSource = context.Productxes.ToList();
            ComboboxAddItem(typeIds, typeNames);
            comboBoxType.SelectedIndex = 0;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
            textBoxSearch.Text = String.Empty;
            string typeid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;

            if (!typeid.Equals("0")) {
                productxBindingSource.DataSource = context.Productxes.Where(p => p.TypeId.ToString() == typeid).ToList();
            } else {
                productxBindingSource.DataSource = context.Productxes.ToList();
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) {
            productxBindingSource.DataSource = context.Productxes.Where(p => p.Name.Contains(textBoxSearch.Text) || p.ProductId.ToString().Contains(textBoxSearch.Text)).ToList();
        }

        

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
            var product = context.Productxes.Where(p => p.ProductId.ToString().Equals(id)).First();
            productList.Add(product);

            int total = 0;
            foreach (var p in productList) {
                total += p.UnitPrice;//(p.UnitPrice)-(int)(p.UnitPrice * 0.1);
            }
            label2.Text = total.ToString();
            productxBindingSource1.DataSource = new List<Productx>(productList);

            dataGridViewProductSet.Rows[0].Selected = true;
            c = false;
        }

        private void ComboboxAddItem(List<string> typeIds, List<string> typeNames) {
            List<ComboboxItem> items = new List<ComboboxItem>();

            for (int i = 0; i < typeIds.Count; i++) {
                items.Add(new ComboboxItem {
                    Text = typeNames[i],
                    Value = typeIds[i]
                });
            }

            foreach (var item in items) {
                comboBoxType.Items.Add(item);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e) {
            if (productList.Count > 1) {
                List<string> names = new List<string>();

                int price = 0;

                foreach (var p in productList) {
                    price += (p.UnitPrice) - (int)(p.UnitPrice * 0.1);
                }

                foreach (var item in productList) {
                    names.Add(item.Name);
                }

                string comboSetName = "ComboSet " + string.Join(" + ", names);

                ComboSet comboSet = new ComboSet {
                    Name = comboSetName,
                    SetPrice = int.Parse(label2.Text)
                };

                context.ComboSets.Add(comboSet);
                context.SaveChanges();

                int comboSetId = context.ComboSets.Max(b => b.Id);

                foreach (Productx product in productList) {
                    ComboSetItem item = new ComboSetItem {
                        ComboSetId = comboSetId,
                        ProductId = product.Id
                    };
                    context.ComboSetItems.Add(item);
                    context.SaveChanges();
                }
                ClearAll();
                MessageBox.Show("บันทึกสำเร็จ");
            } else {
                MessageBox.Show("ต้องมีสินค้ามากว่า 1 ชิ้น");
            }
            c = false;
        }

        private void ClearAll() {
            productList.Clear();
            label2.Text = 0.ToString();
            productxBindingSource1.DataSource = null;

            
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e) {
            try {
                int index = dataGridViewProductSet.CurrentRow.Index;
                dataGridViewProductSet.Rows.Remove(dataGridViewProductSet.CurrentRow);
                if (c) {
                    int newTotal = 0;
                    foreach (Productx p in productList) {
                        newTotal += p.UnitPrice;
                    }
                    total = newTotal;
                    label2.Text = total.ToString();
                }
                
                productxBindingSource1.DataSource = productList;
                c = true;

            } catch { }
        }

        private void iconButton1_Click(object sender, EventArgs e) {
            productList.Clear();
            productxBindingSource1.DataSource = null;
            total = 0;
            label2.Text = total.ToString();
        }
    }
}
