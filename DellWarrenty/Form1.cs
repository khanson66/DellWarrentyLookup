using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace DellWarrenty
{

    public partial class Form1 : Form
    {

        //private static string _clientId = "l7288658a5a9fd4617989b7537f524505f";

        // If _storedRefreshToken is null, CodeGrantFlow goes
        // through the entire process of getting the user credentials
        // and permissions. If _storedRefreshToken contains the refresh
        // token, CodeGrantFlow returns the new access and refresh tokens.

        private static string _storedRefreshToken = null;
        private static DateTime _tokenExpiration;
        public Form1()
        {
            InitializeComponent();
        }

        //This is a blocking call and needs to be fixed
        private void button1_Click(object sender, EventArgs e)
        {
                       
            var apiCall = WarrantyApiCall(serviceTagInput.Text);
            if (apiCall[0].Invalid)
            {
                MessageBox.Show(@"Invalid Service Tag", @"Error", MessageBoxButtons.OK);
            }
            else
            {
                serviceTagBox.Text = apiCall[0].ServiceTag;
                computerModelBox.Text = apiCall[0].SystemDescription;
                warrantyEndDateBox.Text = apiCall[0].Entitlements[0].EndDate.ToLocalTime().ToShortDateString();
                shipDateBox.Text = apiCall[0].Entitlements[0].StartDate.ToLocalTime().ToShortDateString();
            }

        }

        private WarrantySpec[] WarrantyApiCall(string serviceTag)
        {
            if (_storedRefreshToken == null || DateTime.Compare(_tokenExpiration, DateTime.Now) >= 0)
            {
                SetOAuthKey();
            }

            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(new HttpMethod("GET"),
                    $"https://apigtwb2c.us.dell.com/PROD/sbil/eapi/v5/asset-entitlements?servicetags={serviceTag}");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _storedRefreshToken);
                response = client.SendAsync(request).Result;
            }

            var apiResponse = response.Content.ReadAsStringAsync().Result;

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            var objectConversion = JsonConvert.DeserializeObject<WarrantySpec[]>(apiResponse, settings);
            return objectConversion;
        }

        //Generates the OAuth Key and updates the global variable

        private void SetOAuthKey()
        {
            using (var client = new HttpClient())
            {
                //check to see if OAuth Keys have been set in settings
                if (Properties.Settings.Default.clientID == null || Properties.Settings.Default.clientSecret == null)
                {
                    throw new Exception("ClientID and/or client Secrets not set up");
                }


                var request = new HttpRequestMessage(new HttpMethod("POST"),
                    "https://apigtwb2c.us.dell.com/auth/oauth/v2/token");



                var postParams = new Dictionary<string, string>()
                {
                    { "grant_type", "client_credentials" },
                    { "client_id", Properties.Settings.Default.clientID.ToString() },
                    { "client_secret", Properties.Settings.Default.clientSecret.ToString() },
                };
                request.Content = new FormUrlEncodedContent(postParams);
                var response = client.SendAsync(request).Result;
                var apiResponse = response.Content.ReadAsStringAsync().Result;
                try
                {
                    // Attempt to deserialise the reponse to the desired type, otherwise throw an expetion with the response from the api.
                    if (apiResponse != "")
                    {
                        var oauthResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(apiResponse);

                        //TODO: ADD Response value validation
                        if (oauthResponse == null) return;
                        _tokenExpiration = DateTime.Now.AddSeconds(Convert.ToDouble(oauthResponse["expires_in"]));
                        _storedRefreshToken = oauthResponse["access_token"];

                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception)
                {
                    throw new Exception($"An error ocurred while calling the OAuth API. It responded with the following message: {response.StatusCode} {response.ReasonPhrase}");
                }

            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        public class Entitlement
        {
            public string ItemNumber { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string EntitlementType { get; set; }
            public string ServiceLevelCode { get; set; }
            public string ServiceLevelDescription { get; set; }
            public int ServiceLevelGroup { get; set; }
        }

        public class WarrantySpec
        {
            public int Id { get; set; }
            public string ServiceTag { get; set; }
            public int OrderBuid { get; set; }
            public DateTime ShipDate { get; set; }
            public string ProductCode { get; set; }
            public string LocalChannel { get; set; }
            public string ProductId { get; set; }
            public string ProductLineDescription { get; set; }
            public string ProductFamily { get; set; }
            public string SystemDescription { get; set; }
            public string ProductLobDescription { get; set; }
            public string CountryCode { get; set; }
            public bool Duplicated { get; set; }
            public bool Invalid { get; set; }
            public List<Entitlement> Entitlements { get; set; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}