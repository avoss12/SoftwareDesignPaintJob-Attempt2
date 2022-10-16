using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace SoftwareDesignProjectPaintJob
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtCeilingSF_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCeilingRate_Click(object sender, EventArgs e)
        {

        }

        private void lblCeilingSF_Click(object sender, EventArgs e)
        {

        }

        private void txtCeilingRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClicktoCalculate_Click(object sender, EventArgs e)
        {
            decimal itemLength = Convert.ToDecimal(txtItemLength.Text);
            decimal itemWidthHeight = Convert.ToDecimal(txtItemWidthHeight.Text);
            decimal itemRate = Convert.ToDecimal(txtItemRate.Text);   
            decimal itemSF = itemLength * itemWidthHeight;

            decimal itemLength1 = Convert.ToDecimal(txtItemLength1.Text);
            decimal itemWidthHeight1 = Convert.ToDecimal(txtItemWidthHeight1.Text);
            decimal itemRate1 = Convert.ToDecimal(txtItemRate1.Text);
            decimal itemSF1 = itemLength1 * itemWidthHeight1;
            decimal itemEstTotal1 = itemSF1 * itemRate1;
            txtInterfaceEstimate1.Text = Convert.ToString(itemEstTotal1);

            decimal itemLength2 = Convert.ToDecimal(txtItemLength2.Text);
            decimal itemWidthHeight2 = Convert.ToDecimal(txtItemWidthHeight2.Text);
            decimal itemRate2 = Convert.ToDecimal(txtItemRate2.Text);
            decimal itemSF2 = itemLength2 * itemWidthHeight2;
            decimal itemEstTotal2 = itemSF2 * itemRate2;
            txtInterfaceEstimate2.Text = Convert.ToString(itemEstTotal2);

            decimal itemLength3 = Convert.ToDecimal(txtItemLength3.Text);
            decimal itemWidthHeight3 = Convert.ToDecimal(txtItemWidthHeight3.Text);
            decimal itemRate3 = Convert.ToDecimal(txtItemRate3.Text);
            decimal itemSF3 = itemLength3 * itemWidthHeight3;
            decimal itemEstTotal3 = itemSF3 * itemRate3;
            txtInterfaceEstimate3.Text = Convert.ToString(itemEstTotal3);

            decimal itemLength4 = Convert.ToDecimal(txtItemLength4.Text);
            decimal itemRate4 = Convert.ToDecimal(txtItemRate4.Text);
            decimal itemEstTotal4 = itemLength4 * itemRate4;
            txtInterfaceEstimate4.Text = Convert.ToString(itemEstTotal4);

            decimal itemLength5 = Convert.ToDecimal(txtItemLength5.Text);
            decimal itemRate5 = Convert.ToDecimal(txtItemRate5.Text);
            decimal itemEstTotal5 = itemLength5 * itemRate5;
            txtInterfaceEstimate5.Text = Convert.ToString(itemEstTotal5);

            txtItemSF.Text = Convert.ToString(itemSF);
            txtItemSF1.Text = Convert.ToString(itemSF1);
            txtItemSF2.Text = Convert.ToString(itemSF2);
            txtItemSF3.Text = Convert.ToString(itemSF3);
            txtRoomName.Text = itemNameList.Text;
                
            decimal estimateTotal = itemEstTotal1 + itemEstTotal2 + itemEstTotal3 + itemEstTotal4 + itemEstTotal5;
            txtEstimateTotal.Text = Convert.ToString(estimateTotal);

            Ceilings newCeiling = new Ceilings(itemNameList.Text, txtItemPaintColor.Text, itemLength, itemWidthHeight, itemSF);

            Type thisType = newCeiling.GetType();
            txtThisType.Text = thisType.Name.ToString();

            item_class obj_item_iclass = new item_class();
            obj_item_iclass.doCalc(itemLength, itemWidthHeight, itemRate);
            txtInterfaceEstimate.Text = obj_item_iclass.itemEstTotal.ToString();

        }

        private void txtCeilingEstimateTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomNameList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThisType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInterfaceEstimate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReflectionClassType_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtApiReturnID_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnAPICall_Click(object sender, EventArgs e)
        {
            //call API here and assign form value
            // Add NuGet packages NewtonSoft.Json and Microsoft.Identity.Client

                // Add new method inside of program class to leverage PowerApps which can also be used on SharePoint
                // and call Azure Active Directory to authenticate and display your user_id



                // Specify the Dataverse environment name to connect with.
                string resource = "https://org35646656.api.crm.dynamics.com";

                // Azure Active Directory app registration shared by all Power Apps samples.
                // For your custom apps, you will need to register them with Azure AD yourself.
                // See https://learn.microsoft.com/powerapps/developer/data-platform/walkthrough-register-app-azure-active-directory
                var clientId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
               // var redirectUri = "app://58145B91-0C36-4500-8554-080854F2AC97";

                #region Authentication
                var authBuilder = PublicClientApplicationBuilder.Create(clientId)
                                 .WithAuthority(AadAuthorityAudience.AzureAdMultipleOrgs)
                                 .WithDefaultRedirectUri()
                                 .Build();
            //                                 .WithRedirectUri(redirectUri)

            var scope = resource + "/.default";
                string[] scopes = { scope };

                AuthenticationResult token =
                    authBuilder.AcquireTokenInteractive(scopes).ExecuteAsync().Result;
                #endregion Authentication

                #region Client configuration

                var client = new HttpClient
                {
                    // See https://learn.microsoft.com/powerapps/developer/data-platform/webapi/compose-http-requests-handle-errors#web-api-url-and-versions
                    BaseAddress = new Uri(resource + "/api/data/v9.2/"),
                    Timeout = new TimeSpan(0, 2, 0)    // Standard two minute timeout on web service calls.
                };

                // Default headers for each Web API call.
                // See https://learn.microsoft.com/powerapps/developer/data-platform/webapi/compose-http-requests-handle-errors#http-headers
                HttpRequestHeaders headers = client.DefaultRequestHeaders;
                headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
                headers.Add("OData-MaxVersion", "4.0");
                headers.Add("OData-Version", "4.0");
                headers.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                #endregion Client configuration

                #region Web API call

                // Invoke the Web API 'WhoAmI' unbound function.
                // See https://learn.microsoft.com/powerapps/developer/data-platform/webapi/compose-http-requests-handle-errors
                // See https://learn.microsoft.com/powerapps/developer/data-platform/webapi/use-web-api-functions#unbound-functions
                var response = client.GetAsync("WhoAmI").Result;

                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON formatted service response to obtain the user ID.
                    JObject body = JObject.Parse(
                        response.Content.ReadAsStringAsync().Result);
                    Guid userId = (Guid)body["UserId"];

                    txtApiReturnID.Text = userId.ToString();

                }
                else
                {
                txtApiReturnID.Text = "Web API call failed";
                    // txtApiReturnID = ("Reason: " + response.ReasonPhrase);
                }
                #endregion Web API call


            }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemPaintColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemWidthHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtItemSF1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInterfaceEstimate1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemLength4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemLength5_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
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
        }

        private void txtItemRate1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class item_class1
    {
    }
}