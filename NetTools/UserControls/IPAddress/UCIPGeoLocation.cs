using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace NetTools.UserControls.IPAddress
{
    public partial class UCIPGeoLocation : UserControl
    {
        public UCIPGeoLocation()
        {
            InitializeComponent();
        }

        #region Methods
        private string GetIPAddress(string url)
        {
            /* Check url is valid? */
            if (!url.Contains("http"))
                return url;
            try
            {
                Uri myUri = new Uri(url);
                string host = myUri.Host;
                return host;
            }
            catch
            {
                return url;
            }
        }
        private string GetHTTPRequest(string ipAddress)
        {
            string URL = $"http://ip-api.com/xml/{GetIPAddress(textDomain.Text)}?fields=status,message,continent,continentCode,country,countryCode,region,regionName,city,district,zip,lat,lon,timezone,offset,currency,isp,org,as,asname,reverse,mobile,proxy,hosting,query";
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
        private void GetIpGeoLocationInfo(XmlDocument xDoc)
        {
            XmlElement xmlNodeList = xDoc.DocumentElement;
            foreach (XmlNode element in xmlNodeList)
            {
                Console.WriteLine("{0}:{1}", element.Name, element.InnerText);
                ListViewItem item = new ListViewItem(new string[] { element.Name, element.InnerText });
                listViewGeoLocationInfo.Items.Add(item);
            }
        }
        private void ResetListview()
        {
            listViewGeoLocationInfo.Items.Clear(); 
        }
        #endregion

        private void UCIPGeoLocation_Load(object sender, EventArgs e)
        {
            /* Initialize listview */
            listViewGeoLocationInfo.Columns.Add("Field", 200);
            listViewGeoLocationInfo.Columns.Add("Value", listViewGeoLocationInfo.Width - 300);
            listViewGeoLocationInfo.View = View.Details;
        }
        private void buttonGo_Click(object sender, EventArgs e)
        {
            string URL = textDomain.Text;
            ResetListview();

            string xmlQuery = GetHTTPRequest(URL);
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xmlQuery);

            if (!CheckQueryReponse(xDoc))
            {
                /* Error response*/
                ListViewItem item = new ListViewItem(new string[] { null, "Country Unable to resolve IP address, test stopped." });
                listViewGeoLocationInfo.Items.Add(item);
                return;
            }
            /* Success response */
            GetIpGeoLocationInfo(xDoc);
        }
    }
}
