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

namespace ComputerDIY {
    public partial class Form1 : Form {
        List<string> id = new List<string>();
        List<string> promoNames = new List<string>();
        List<string> priceTotal = new List<string>();
        List<string> descriptions = new List<string>();
        List<string> images = new List<string>();
        string typeid = "";

        ProductEntities context = new ProductEntities();
        ProductXML product = new ProductXML();

        string idx;
        string name;
        int price;
        string description;
        string image;


        public Form1() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            textBoxURL.Text = "https://www.jib.co.th/web/product/product_list/2/"+typeid;


            List<string> typeNames = new List<string> {
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
                "43", "46", "51", "53", "54", "55", "56", "57", "1433", "1617", "1616" 
            };

            ComboboxAddItem(typeIds, typeNames);
        }

        private void buttonGo_Click(object sender, EventArgs e) {
            Go();
        }

        private void textBoxURL_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                Go();
                this.ActiveControl = null;
            }
        }

        private void listView1_Click(object sender, EventArgs e) {
            string id = listView1.SelectedItems[0].SubItems[0].Text;
            this.name = listView1.SelectedItems[0].SubItems[1].Text;
            this.price = int.Parse(listView1.SelectedItems[0].SubItems[2].Text);
            this.description = listView1.SelectedItems[0].SubItems[3].Text;
            this.image = listView1.SelectedItems[0].SubItems[4].Text;
            typeid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;
            ShowDetail(id);
            idx = id;
        }

        public void Go() {
            ClearData();
            string url = textBoxURL.Text;
            AddData(url);
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

        private void ShowDetail(string id) {
            string url = "https://www.jib.co.th/web/product/readProduct/" + id;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//meta[@property=\"og:title\"]");
            HtmlNode descriptionNode = doc.DocumentNode.SelectSingleNode("//meta[@property=\"og:description\"]");
            HtmlNode imageNode = doc.DocumentNode.SelectSingleNode("//meta[@property=\"og:image\"]");
            HtmlNode priceNode = doc.DocumentNode.SelectSingleNode("//div[@class=" +
               "\"col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center price_block\"]");

            String price = priceNode.InnerText;
            price = new string(price.Where(c => char.IsDigit(c)).ToArray());

            textBoxProductId.Text = id;
            textBoxProductName.Text = titleNode.Attributes["content"].Value;
            textBoxProductDetail.Text = descriptionNode.Attributes["content"].Value;
            pictureBox1.Image = LoadImage(imageNode.GetAttributeValue("content", ""));
            textBoxPrice.Text = price;
        }

        void AddData(string url) {
            listView1.Items.Clear();
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

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

        void MapType() { 
            Dictionary<string, string> type = new Dictionary<string, string>();
            type.Add("ซีพียู คอมพิวเตอร์", "43");
            type.Add("เมนบอร์ด", "46");
        }

        void ComboboxAddItem (List<string> typeIds, List<string>typeNames) {
            List<ComboboxItem> items = new List<ComboboxItem>();

            for (int i = 0; i < 11; i++) {
                items.Add(new ComboboxItem {
                    Text = typeNames[i],
                    Value = typeIds[i]
                });
            }

            foreach (var item in items) { 
                comboBoxType.Items.Add(item);
            }

        }

        private void buttonGetAllPage_Click(object sender, EventArgs e) {
            ClearData();

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
                AddData(url + "/" + i + "00");
            }
            
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e) {
            this.typeid = ((ComboboxItem)(comboBoxType.SelectedItem)).Value;
            textBoxURL.Text = "https://www.jib.co.th/web/product/product_list/2/" + typeid;
            Console.WriteLine(typeid);
        }

        void ClearData() {
            id.Clear();
            promoNames.Clear();
            priceTotal.Clear();
            descriptions.Clear();
            images.Clear();
        }


        void InsertDataToDB() { }
        private void buttonAddData_Click(object sender, EventArgs e) {

            int itemId;
            if (context.ProductXMLs.Max(b => (int?)b.Id) == null) itemId = 0;
            else itemId = context.ProductXMLs.Max(b => b.Id);
            product.Id = itemId+1;
            product.Name = name;
            product.Price = price;
            product.Description = description;
            product.Image = image;
            product.TypeId = int.Parse(typeid);

            context.ProductXMLs.Add(product);
            int change = context.SaveChanges();
            MessageBox.Show("Change " + change + " records");
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
