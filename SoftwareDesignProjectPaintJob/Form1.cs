using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SoftwareDesignProjectPaintJob
{
    public partial class Form1 : Form
    {
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

            decimal itemLength2 = Convert.ToDecimal(txtItemLength2.Text);
            decimal itemWidthHeight2 = Convert.ToDecimal(txtItemWidthHeight2.Text);
            decimal itemRate2 = Convert.ToDecimal(txtItemRate2.Text);
            decimal itemSF2 = itemLength2 * itemWidthHeight2;

            txtItemSF.Text = Convert.ToString(itemSF);
            txtItemSF1.Text = Convert.ToString(itemSF1);
            txtItemSF2.Text = Convert.ToString(itemSF2);
            txtRoomName.Text = itemNameList.Text;

            decimal itemEstTotal1 = itemSF1 * itemRate1;
            txtInterfaceEstimate1.Text = Convert.ToString(itemEstTotal1);

            decimal itemEstTotal2 = itemSF2 * itemRate2;
            txtInterfaceEstimate2.Text = Convert.ToString(itemEstTotal2);

            decimal estimateTotal = itemEstTotal1 + itemEstTotal2;
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
    }

    internal class item_class1
    {
    }
}