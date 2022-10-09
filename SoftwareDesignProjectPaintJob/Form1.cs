using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
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

            txtItemSF.Text = Convert.ToString(itemSF);
            txtRoomName.Text = itemNameList.Text;

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
        private void btnApiValue_Click(object sender, EventArgs e)
        {
            static void whoAmI_API()
            {
                // Specify the Dataverse environment name to connect with.
                string resource = "https://org35646656.api.crm.dynamics.com";

                // Azure Active Directory app registration shared by all Power Apps samples.
                // For your custom apps, you will need to register them with Azure AD yourself.
                // See https://learn.microsoft.com/powerapps/developer/data-platform/walkthrough-register-app-azure-active-directory
                var clientId = "51f81489-12ee-4a9e-aaae-a2591f45987d";
                var redirectUri = "app://58145B91-0C36-4500-8554-080854F2AC97";

                #region Authentication
                var authBuilder = PublicClientApplicationBuilder.Create(clientId)
                                 .WithAuthority(AadAuthorityAudience.AzureAdMultipleOrgs)
                                 .WithRedirectUri(redirectUri)
                                 .Build();
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

                    txtApiValue.Text = userId.ToString();
                }
                else
                {
                    txtApiValue.Text = ToString("Web API call failed");
                    CotxtApiValue.Text = ToString("Reason: " + response.ReasonPhrase);
                }
                #endregion Web API call
            }
            private void txtApiReturnID_TextChanged(object sender, EventArgs e)
        {
        
        }

        
    }
}