using HtmlAgilityPack;
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
    public partial class MngProductForm : Form {
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

        string typeid;
        public MngProductForm() {
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
            textBoxSearch.Text = string.Empty;
            typeid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;
            if (!typeid.Equals("0")) {
                productxBindingSource.DataSource = context.Productxes.Where(p => p.TypeId.ToString() == typeid).ToList();
            } else {
                productxBindingSource.DataSource = context.Productxes.ToList();
            }
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            string id = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Productx product = context.Productxes.Where((c) => c.ProductId.ToString() == id).First();


            ProductDetailForm productDetail = new ProductDetailForm(
                product.ProductId, 
                product.Name, 
                product.UnitPrice, 
                product.Description, 
                product.Image
            );
            productDetail.ShowDialog();

        }

        private async void buttonAdd_Click(object sender, EventArgs e) {

            string productName;
            int productPrice;
            string productDescription;
            string productImage;
            int productType;

            try {
                string url = "https://www.jib.co.th/web/product/readProduct/" + textBoxAddProduct.Text;
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                HtmlNode titleNode = doc.DocumentNode
                    .SelectSingleNode("//meta[@property=\"og:title\"]");
                productName = titleNode.Attributes["content"].Value;

                HtmlNode descriptionNode = doc.DocumentNode
                  .SelectSingleNode("//meta[@property=\"og:description\"]");
                productDescription = descriptionNode.Attributes["content"].Value;

                HtmlNode imageNode = doc.DocumentNode
                  .SelectSingleNode("//meta[@property=\"og:image\"]");
                productImage = imageNode.GetAttributeValue("content", "");

                HtmlNode priceNode = doc.DocumentNode
                    .SelectSingleNode("//div[@class=" +
                   "\"col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center price_block\"]");
                string price = priceNode.InnerText;
                price = new string(price.Where(c => char.IsDigit(c)).ToArray());
                productPrice = int.Parse(price);

                List<string> pType = new List<string>();
                foreach (var ptype in doc.DocumentNode.SelectNodes("//div[@class=" + "\"step_nav\"]//a")) {
                    Console.WriteLine(ptype.GetAttributeValue("href", ""));
                    pType.Add(ptype.GetAttributeValue("href", ""));
                }

                string str = pType[2];
                string[] bits = str.Split('/');
                string subStr = bits[bits.Length - 1];
                productType = int.Parse(subStr);

                var ids = context.Productxes.Select(x => x.ProductId).ToList();
                int change = 0;
                if (!ids.Contains(int.Parse(textBoxAddProduct.Text))) {
                    Productx product = new Productx {
                        ProductId = int.Parse(textBoxAddProduct.Text),
                        Name = productName,
                        UnitPrice = productPrice,
                        Description = productDescription,
                        Image = productImage,
                        TypeId = productType
                    };
                    context.Productxes.Add(product);
                    change = await context.SaveChangesAsync();
                    textBoxAddProduct.Text = string.Empty;
                    textBoxSearch.Text = string.Empty;
                }
                MessageBox.Show("สินค้าถูกเพิ่ม " + change + " รายการ");
            } catch(Exception ex){
                textBoxSearch.Text = string.Empty;
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("สินค้าหมด");
            }

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

        private async void buttonDelete_Click(object sender, EventArgs e) {
            try {
                int id = int.Parse(guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var result = context.Productxes.Where(p => p.ProductId.Equals(id)).First();
                context.Productxes.Remove(result);
                await context.SaveChangesAsync();
                textBoxSearch.Text = string.Empty;
                productxBindingSource.DataSource = context.Productxes.ToList();
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }
        }

    }
}
