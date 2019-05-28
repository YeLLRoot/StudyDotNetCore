using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var qg = new QRCoder.QRCodeGenerator();
            var myData = qg.CreateQrCode(TxtCode.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(myData);
            PicQRCode.Image = code.GetGraphic(50);
        }
        //利用 .NET Framework 自带的 PrintDocument 调用打印机。
        private void PrintBarCode()
        {
            var pd = new PrintDialog();
            var doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var bm = new Bitmap(PicQRCode.Width, PicQRCode.Height);
            PicQRCode.DrawToBitmap(bm, new Rectangle(0, 0, PicQRCode.Width, PicQRCode.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PrintBarCode();
        }
    }
}
