using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerDIY {
    public partial class Form1 : Form {
        List<string> id = new List<string>();
        List<string> promoNames = new List<string>();
        List<string> priceTotal = new List<string>();
        List<string> descriptions = new List<string>();
        List<string> images = new List<string>();
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
        string typeid = "";

        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            textBoxURL.Text = "https://www.jib.co.th/web/product/product_list/2/" + typeid;
            
            ComboboxAddItem(typeIds, typeNames);
            comboBoxType.SelectedIndex = 0;

            //ReadData(textBoxURL.Text);
        }

        private void buttonGo_Click(object sender, EventArgs e) {
            textBoxCountPage.Clear();
            ClearData();
            ResetDetail();
            string url = textBoxURL.Text;
            ReadData(url);
            AddData();
            buttonInsertData.Enabled = false;
        }

        private void textBoxURL_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                ClearData();
                ResetDetail();
                string url = textBoxURL.Text;
                ReadData(url);
                AddData();
                this.ActiveControl = null;
            }
        }

        private void listView1_Click(object sender, EventArgs e) {
            textBoxProductId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBoxProductName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxPrice.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxProductDetail.Text = listView1.SelectedItems[0].SubItems[3].Text;
            pictureBox1.Image = LoadImage(listView1.SelectedItems[0].SubItems[4].Text);
        }

        private void buttonGetAllPage_Click(object sender, EventArgs e) {
            ClearData();
            ResetDetail();
            string url = textBoxURL.Text;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            List<string> countPages = new List<string>();
            foreach (var countPageNode in doc.DocumentNode.SelectNodes("//div[@class=" + "\"col-md-6 col-sm-6 pad-0\"]//span")) {
                countPages.Add(countPageNode.InnerText.ToString());
            }

            string countPage = countPages[1];
            textBoxCountPage.Text = countPage;

            for (int i = 0; i < int.Parse(countPage); i++) {
                ReadData(url + "/" + i * 100);
            }
            AddData();
            string tid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;
            if (!tid.Equals("0")) {
                buttonInsertData.Enabled = true;
            }
        }

        private void ReadData(string url) {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            try {

                foreach (var ids in doc.DocumentNode.SelectNodes("//div[@data-id]")) {
                    if (!id.Contains(ids.GetAttributeValue("data-id", ""))) {
                        id.Add(ids.GetAttributeValue("data-id", ""));
                    }
                }

                foreach (var name in doc.DocumentNode.SelectNodes("//span[@class=" + "\"promo_name\"]")) {
                    promoNames.Add(name.InnerText.ToString());
                }

                foreach (var price in doc.DocumentNode.SelectNodes("//p[@class=" + "\"price_total\"]")) {
                    priceTotal.Add(price.InnerText.ToString());
                }

                foreach (var description in doc.DocumentNode.SelectNodes("//div[@class=" + "\"row description\"]")) {
                    descriptions.Add(description.InnerText.ToString());
                }

                foreach (var image in doc.DocumentNode.SelectNodes("//img[@class=" + "\"img-responsive imgpspecial\"]")) {
                    images.Add("https://www.jib.co.th" + image.GetAttributeValue("src", ""));
                }
            } catch (NullReferenceException e) {
                MessageBox.Show("สินค้าหมด");
                Console.WriteLine(e.Message);
            }
        }

        private void AddData() {
            for (int i = 0; i < promoNames.Count(); i++) {
                id[i] = new string(id[i].Where(c => char.IsDigit(c)).ToArray());
                priceTotal[i] = new string(priceTotal[i].Where(c => char.IsDigit(c)).ToArray());

                string[] items = new string[] {
                    id[i],
                    promoNames[i],
                    priceTotal[i],
                    descriptions[i],
                    images[i]
                };
                listView1.Items.Add(new ListViewItem(items));
            }
        }

        private void buttonInsertData_Click(object sender, EventArgs e) {
            buttonInsertData.Enabled = false;
            ResetDetail();
            ProductxEntitie context = new ProductxEntitie();

            int productId;
            string productName;
            int productPrice;
            string productDescription;
            string productImage;
            int pTypeId;
            int records = 0;

            List<int> productList = context.Productxes.Select(x => x.ProductId).ToList();

            foreach (ListViewItem item in listView1.Items) {

                productId = int.Parse(item.SubItems[0].Text);
                productName = item.SubItems[1].Text;
                productPrice = int.Parse(item.SubItems[2].Text);
                productDescription = item.SubItems[3].Text;
                productImage = item.SubItems[4].Text;
                pTypeId = int.Parse(((ComboboxItem)(comboBoxType.SelectedItem)).Value);

                if (!productList.Contains(productId)) {
                    records++;
                    Productx product = new Productx {
                        ProductId = productId,
                        Name = productName,
                        UnitPrice = productPrice,
                        Description = productDescription,
                        Image = productImage,
                        TypeId = pTypeId
                    };

                    context.Productxes.Add(product);
                    context.SaveChanges();
                }
            }
            MessageBox.Show("สินค้าถูกเพิ่ม " + records + " รายการ", "เรียบร้อย");
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
            textBoxCountPage.Clear();
            ResetDetail();
            buttonInsertData.Enabled = false;
            typeid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;
            if (!typeid.Equals("0")) {
                textBoxURL.Text = "https://www.jib.co.th/web/product/product_list/2/" + typeid;
            } else {
                textBoxURL.Text = "https://www.jib.co.th/web/product/product_list/1/42";
            }
            ClearData();
            ReadData(textBoxURL.Text);
            AddData();
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e) {
            string str = textBoxURL.Text;
            string[] bits = str.Split('/');
            string subStr = bits[bits.Length - 1];

            if (typeIds.Contains(subStr)) {
                int index = typeIds.IndexOf(subStr);
                comboBoxType.SelectedIndex = index;
            } else if (textBoxURL.Text.Equals("https://www.jib.co.th/web/product/product_list/1/42")) {
                comboBoxType.SelectedIndex = 0;
            } else {
                listView1.Items.Clear();
            }
        }

        private void ComboboxAddItem(List<string> typeIds, List<string> typeNames) {
            List<ComboboxItem> items = new List<ComboboxItem>();

            for (int i = 0; i < 12; i++) {
                items.Add(new ComboboxItem {
                    Text = typeNames[i],
                    Value = typeIds[i]
                });
            }

            foreach (var item in items) {
                comboBoxType.Items.Add(item);
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

        private void ResetDetail() {
            textBoxProductId.Clear();
            textBoxProductName.Clear();
            textBoxPrice.Clear();
            textBoxProductDetail.Clear();
            pictureBox1.Image = null;
        }

        private void ClearData() {
            id.Clear();
            promoNames.Clear();
            priceTotal.Clear();
            descriptions.Clear();
            images.Clear();
            listView1.Items.Clear();
        }

    }
}

public class ComboboxItem {
    public string Text { get; set; }
    public string Value { get; set; }

    public override string ToString() {
        return Text;
    }
}
