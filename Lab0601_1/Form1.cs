using AForge.Video.DirectShow;
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
using ZXing.QrCode;

namespace Lab0601_1 {
    public partial class Form1 : Form {
        FilterInfoCollection webcams;
        VideoCaptureDevice videoIn;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            webcams = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo webcam in webcams) { 
                comboBox1.Items.Add(webcam.Name);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            videoIn = new VideoCaptureDevice(webcams[comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = videoIn;
            videoSourcePlayer1.Start();
        }

        private void buttonBarCodeGen_Click(object sender, EventArgs e) {
            QrCodeEncodingOptions option = new QrCodeEncodingOptions();
            option.CharacterSet = "UTF-8";
            option.Width = 400;
            option.Height = 400;

            BarcodeWriter writer = new BarcodeWriter();
            if (radioButtonBarCode.Checked) {
                writer.Format = BarcodeFormat.CODE_39;
            } else if (radioButtonQRCode.Checked) {
                writer.Format = BarcodeFormat.QR_CODE;
            }
            var result = writer.Write(textBox1.Text);
            pictureBoxQrCode.Image = result;

        }

        private void buttonSaveQRCode_Click(object sender, EventArgs e) {
            pictureBoxQrCode.Image.Save("Code.jpg");
        }

        private void timer1_Tick(object sender, EventArgs e) {
            var capture = videoSourcePlayer1.GetCurrentVideoFrame();
            if (capture != null) {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(capture);
                if (result != null) { 
                    listBox1.Items.Insert(0, result.Text + " " + result.BarcodeFormat.ToString());
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (videoIn != null && videoIn.IsRunning) {
                videoSourcePlayer1.Stop();
            }
        }
    }
}
