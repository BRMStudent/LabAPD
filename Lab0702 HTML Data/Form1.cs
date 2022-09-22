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

namespace Lab0702_HTML_Data {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string url = "https://www.jib.co.th/web/product/readProduct/" + textBox1.Text;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            var html = doc.DocumentNode.Descendants("meta");

            var title = html.Where(m => m.GetAttributeValue("property", "") == "og:title").First();
            textBox2.Text = title.GetAttributeValue("content", "");

            var description = html.Where(m => m.GetAttributeValue("property", "") == "og:description").First();
            textBox3.Text = description.GetAttributeValue("content", "");

            var image = html.Where(m => m.GetAttributeValue("property", "") == "og:image").First();

            //pictureBox1.Load(image.GetAttributeValue("content", ""));

            string ImageURl = image.GetAttributeValue("content", "");
            Console.WriteLine(ImageURl);
            //pictureBox1.Load(ImageURl);
            pictureBox1.Image = LoadImage(image.GetAttributeValue("content", ""));

            var priceblock = doc.DocumentNode.Descendants("div");
            var price = priceblock.Where(p => p.GetAttributeValue("class", "") ==
                "col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center price_block").First().InnerText;
            price = new string(price.Where(c => char.IsDigit(c)).ToArray());
            textBox4.Text = price;
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

        private void button2_Click(object sender, EventArgs e) {
            string url = "https://www.jib.co.th/web/product/readProduct/" + textBox1.Text;
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            HtmlNode titleNode = doc.DocumentNode
                .SelectSingleNode("//meta[@property=\"og:title\"]");
            textBox2.Text = titleNode.Attributes["content"].Value;

            HtmlNode descriptionNode = doc.DocumentNode
              .SelectSingleNode("//meta[@property=\"og:description\"]");
            textBox3.Text = descriptionNode.Attributes["content"].Value;

            HtmlNode imageNode = doc.DocumentNode
              .SelectSingleNode("//meta[@property=\"og:image\"]");
            pictureBox1.Image = LoadImage(imageNode.GetAttributeValue("content", ""));

            HtmlNode priceNode = doc.DocumentNode
                .SelectSingleNode("//div[@class=" +
               "\"col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center price_block\"]");
            String price = priceNode.InnerText;
            price = new string(price.Where(c => char.IsDigit(c)).ToArray());
            textBox4.Text = price;
        }
    }
}
