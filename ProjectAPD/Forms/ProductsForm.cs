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
    public partial class ProductsForm : Form {
        ProjectEntities1 context = new ProjectEntities1();

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

        public ProductsForm() {
            InitializeComponent();
            productxBindingSource.DataSource = context.Productxes.ToList();
            ComboboxAddItem(typeIds, typeNames);
            comboBoxType.SelectedIndex = 0;
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

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
            string typeid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;
            if (!typeid.Equals("0")) {
                productxBindingSource.DataSource = context.Productxes.Where(p => p.TypeId.ToString() == typeid).ToList();
            } else {
                productxBindingSource.DataSource = context.Productxes.ToList();
            }
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id = dataGridViewProduct.SelectedRows[0].Cells[0].Value.ToString();

            Productx product = context.Productxes.Where((c) => c.ProductId.ToString() == id).First();

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

        private void textBoxSearch_TextChanged(object sender, EventArgs e) {
            comboBoxType.SelectedIndex = 0;
            productxBindingSource.DataSource = context.Productxes.Where(p => p.Name.Contains(textBoxSearch.Text) || p.ProductId.ToString().Contains(textBoxSearch.Text)).ToList();
        }
    }
}
