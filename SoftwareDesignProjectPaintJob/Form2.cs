using System;
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
        private Label lblReflectionClassType;
        private TextBox textBox2;
        private TextBox txtThisType;
        private TextBox txtThisType1;
        private TextBox textBox1;
        private TextBox txtThisType2;
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

        private void InitializeComponent()
        {
            this.lblReflectionClassType = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtThisType = new System.Windows.Forms.TextBox();
            this.txtThisType1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtThisType2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblReflectionClassType
            // 
            this.lblReflectionClassType.AutoSize = true;
            this.lblReflectionClassType.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReflectionClassType.Location = new System.Drawing.Point(382, 222);
            this.lblReflectionClassType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReflectionClassType.Name = "lblReflectionClassType";
            this.lblReflectionClassType.Size = new System.Drawing.Size(97, 17);
            this.lblReflectionClassType.TabIndex = 20;
            this.lblReflectionClassType.Text = "Item Selected";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(-163, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 26);
            this.textBox2.TabIndex = 75;
            this.textBox2.Text = "* Complete Colored Boxes ONLY!";
            // 
            // txtThisType
            // 
            this.txtThisType.Location = new System.Drawing.Point(918, 265);
            this.txtThisType.Margin = new System.Windows.Forms.Padding(2);
            this.txtThisType.Name = "txtThisType";
            this.txtThisType.Size = new System.Drawing.Size(106, 23);
            this.txtThisType.TabIndex = 74;
            // 
            // txtThisType1
            // 
            this.txtThisType1.Location = new System.Drawing.Point(377, 219);
            this.txtThisType1.Margin = new System.Windows.Forms.Padding(2);
            this.txtThisType1.Name = "txtThisType1";
            this.txtThisType1.Size = new System.Drawing.Size(106, 23);
            this.txtThisType1.TabIndex = 76;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 227);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 23);
            this.textBox1.TabIndex = 77;
            // 
            // txtThisType2
            // 
            this.txtThisType2.Location = new System.Drawing.Point(393, 235);
            this.txtThisType2.Margin = new System.Windows.Forms.Padding(2);
            this.txtThisType2.Name = "txtThisType2";
            this.txtThisType2.Size = new System.Drawing.Size(106, 23);
            this.txtThisType2.TabIndex = 78;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(861, 460);
            this.Controls.Add(this.txtThisType2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtThisType1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtThisType);
            this.Controls.Add(this.lblReflectionClassType);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }