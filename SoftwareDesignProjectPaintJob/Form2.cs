﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesignProjectPaintJob
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           private System.IO.Stream streamToPrint;
        string streamType;
        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC  
            int nXDest, // x-coord of destination upper-left corner  
            int nYDest, // y-coord of destination upper-left corner  
            int nWidth, // width of destination rectangle  
            int nHeight, // height of destination rectangle  
            IntPtr hdcSrc, // handle to source DC  
            int nXSrc, // x-coordinate of source upper-left corner  
            int nYSrc, // y-coordinate of source upper-left corner  
            System.Int32 dwRop // raster operation code  
        );

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(this.streamToPrint);
                int x = e.MarginBounds.X;
                int y = e.MarginBounds.Y;
                int width = image.Width;
                int height = image.Height;
                if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
                {
                    width = e.MarginBounds.Width;
                    height = image.Height * e.MarginBounds.Width / image.Width;
                }
                else
                {
                    height = e.MarginBounds.Height;
                    width = image.Width * e.MarginBounds.Height / image.Height;
                }
                System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
                e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
            }

            public void StartPrint(Stream streamToPrint, string streamType)
            {
                this.printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                this.streamToPrint = streamToPrint;
                this.streamType = streamType;
                System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
                PrintDialog1.AllowSomePages = true;
                PrintDialog1.ShowHelp = true;
                PrintDialog1.Document = printDocument1;
                DialogResult result = PrintDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                    //docToPrint.Print();  
                }
                Graphics g1 = this.CreateGraphics();
            Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            MyImage.Save(@"c:\PrintPage.jpg", ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(@"c:\PrintPage.jpg", FileMode.Open, FileAccess.Read);
            StartPrint(fileStream, "Image");
            fileStream.Close();
            if (System.IO.File.Exists(@"c:\PrintPage.jpg"))
            {
                System.IO.File.Delete(@"c:\PrintPage.jpg");
            }
        }
    }
}
