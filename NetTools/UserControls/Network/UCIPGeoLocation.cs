using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace NetTools.UserControls.Network
{
    public partial class UCIPGeoLocation : UserControl
    {
        // Constructor
        public UCIPGeoLocation()
        {
            InitializeComponent();
        }

        #region Methods
        private string GetHTTPRequest(string ipAddress)
        {
            string URL = $"http://ip-api.com/xml/{ipAddress}?fields=status,message,continent,continentCode,country,countryCode,region,regionName,city,district,zip,lat,lon,timezone,offset,currency,isp,org,as,asname,reverse,mobile,proxy,hosting,query";
            WebRequest webRequest = WebRequest.Create(URL);
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string httpResponse = streamReader.ReadToEnd();
            stream.Close();
            webResponse.Close();
            return httpResponse;
        }

        private bool CheckQueryReponse(XmlDocument xDoc)
        {
            if (xDoc.SelectSingleNode("//message") != null)
                return false;
            return true;
        }

        private List<string> GetIpGeoLocationInfo(XmlDocument xDoc)
        {
            List<string> ipInfo = new List<string>();
            foreach (XmlNode node in xDoc.DocumentElement)
            {
                ipInfo.Add(node.InnerText);
            }
            return ipInfo;
        }
        #endregion

        #region Events from user
        private void UCIPGeoLocation_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewGeoLocationInfo.Items.Count; i++)
            {
                listViewGeoLocationInfo.Items[i].SubItems.Add(string.Empty);
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string URL = textIPAddress.Text;
            string xmlQuery = GetHTTPRequest(URL);

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xmlQuery);

            if (CheckQueryReponse(xDoc))
            {
                // Add info to listview
                List<string> ipInfo = GetIpGeoLocationInfo(xDoc);
                for (int i = 0; i < listViewGeoLocationInfo.Items.Count; i++)
                {
                    listViewGeoLocationInfo.Items[i].SubItems[1].Text = ipInfo[i];
                }
            }
            else
            {
                listViewGeoLocationInfo.Items[0].SubItems[1].Text = "Country Unable to resolve IP address, test stopped.";
            }
        }
        #endregion
    }
}
