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
    public partial class ProductDetailForm : Form {
        public ProductDetailForm(int productId, string productName, int productPrice, string productDescription, string productImage) {
            InitializeComponent();
            
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            
            textBoxProductId.Text = productId.ToString();
            textBoxProductName.Text = productName;
            textboxDescription.Text = productDescription;
            textBoxPrice.Text = productPrice.ToString();
            guna2PictureBox1.Image = LoadImage(productImage);
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

        private void ProductDetailForm_Deactivate(object sender, EventArgs e) {
            this.Close();
        }
    }
}
