using NBarCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeGen
{
    public partial class Main : Form
    {
        public static string path = Environment.CurrentDirectory;

        public Main()
        {
            InitializeComponent();
        }

        private void btnBarcodeGen_Click(object sender, EventArgs e)
        {
            GenBarcode();
            AppendTextToBarrcode();
            PrintImage();
        }

        private static void AppendTextToBarrcode()
        {
            var bmp = Bitmap.FromFile(path + @"\barcode.jpg");
            var newImage = new Bitmap(bmp.Width + 300, bmp.Height);
            
            var gr = Graphics.FromImage(newImage);
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gr.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            gr.DrawImageUnscaled(bmp, 0, 0);
            gr.DrawString("this is the added text1", new Font("Tahoma", 10), Brushes.Black, new RectangleF(bmp.Width, 0, bmp.Width + 300, 50));
            gr.DrawString("this is the added text2", new Font("Tahoma", 10), Brushes.Black, new RectangleF(bmp.Width, 15, bmp.Width + 300, 50));
            gr.DrawString("this is the added text3", new Font("Tahoma", 10), Brushes.Black, new RectangleF(bmp.Width, 30, bmp.Width + 300, 50));

            newImage.Save(path + @"\barcodeandtext.jpg");
            newImage.Dispose();
            bmp.Dispose();
        }

        private static void GenBarcode()
        {
            var number = "123456";

            string[] jpegList = Directory.GetFiles(path, "*.jpg");
            foreach (string f in jpegList)
            {
                File.Delete(f);
            }

            BarCodeSettings settings = new BarCodeSettings();
            settings.Type = BarCodeType.Code128;
            settings.Data = number.ToString();
            settings.BarHeight = 20;
            BarCodeGenerator generator = new BarCodeGenerator(settings);
            Bitmap b = new Bitmap(generator.GenerateImage());
            b.RotateFlip(RotateFlipType.Rotate90FlipNone);
            b.Save(path + @"\barcode.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            b.Dispose();
        }

        private void PrintImage()
        {
            PrintDocument pd = new PrintDocument();

            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.OriginAtMargins = false;
            pd.DefaultPageSettings.Landscape = true;

            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);


            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();

            //pd.Print();
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            var image = Bitmap.FromFile(path + @"\barcodeandtext.jpg");
            e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            image.Dispose();
        }
    }
}
