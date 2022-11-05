using AForge.Video;
using AForge.Video.DirectShow;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace ProjectAPD.Forms.dialog {
    public partial class ScanCamForm : Form {

        ProjectEntities1 context = new ProjectEntities1();
        

        FilterInfoCollection webcams;
        VideoCaptureDevice videoIn;
        BindingSource bindingSource;
        List<Productx> productList;
        Label lblTotalPrice;
        Form sellForm;




        public ScanCamForm(BindingSource bindingSource, List<Productx> productList, Label label, Form sellForm) {
            InitializeComponent();
            this.MaximizeBox = false;
            this.sellForm = sellForm;
            this.bindingSource = bindingSource;
            this.productList = productList;
            this.lblTotalPrice = label;


            webcams = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo webcam in webcams) {
                comboBoxWebCams.Items.Add(webcam.Name);
            }
            comboBoxWebCams.SelectedIndex = 1;
        }

        private void comboBoxWebCams_SelectedIndexChanged(object sender, EventArgs e) {

            if (videoIn != null && videoIn.IsRunning) {
                videoSourcePlayer1.Stop();
            }
            if (!(videoIn != null && videoIn.IsRunning)) {
                videoIn = new VideoCaptureDevice(webcams[comboBoxWebCams.SelectedIndex].MonikerString);
                videoSourcePlayer1.VideoSource = videoIn;
                videoSourcePlayer1.Start();
            }
        }

        private void ScanCamForm_FormClosing(object sender, FormClosingEventArgs e) {
            bindingSource.DataSource = productList;
            if (videoIn != null && videoIn.IsRunning) {
                videoSourcePlayer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            var capture = videoSourcePlayer1.GetCurrentVideoFrame();
            if (capture != null) {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(capture);
                if (result != null) {
                    int productId =  int.Parse(new string(result.Text.Where(c => char.IsDigit(c)).ToArray()));
                    try {
                        var product = context.Productxes.Where(p => p.ProductId.Equals(productId)).First();
                        productList.Add(product);
                        int total = 0;
                        foreach (var p in productList) {
                            total += p.UnitPrice;
                        }
                        lblTotalPrice.Text = total.ToString();
                        bindingSource.DataSource = context.Productxes.Where(p => p.ProductId.Equals(productId)).ToList();
                        bindingSource.DataSource = productList;
                        /*this.Close();*/
                    } catch (Exception ex) {
                        this.Close();
                        MessageBox.Show(sellForm, "ไม่พบสินค้า");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
