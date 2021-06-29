using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NetTools.UserControls.IPAddress
{
    public partial class UCWhoIs : UserControl
    {
        XmlDocument xDoc;

        public UCWhoIs()
        {
            InitializeComponent();
            comboxFields.SelectedItem = comboxFields.Items[0];
        }

        #region Methods
        private void ResetRichText()
        {
            richTextInformation.Clear();
        }
        private void SetRichText(string text)
        {
            ResetRichText();
            richTextInformation.Text = text;
        }
        private string VerifyDomain(string url)
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
        private string GetHTTPRequest(string domain)
        {
            /* Verified domain */
            domain = VerifyDomain(domain);
            /* Get api */
            string URL = $"https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey=at_aVzDK57jaecAL81LDLNTpFpZobX4B&domainName={domain}";
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
        private string CheckQueryReponse(XmlDocument xDoc)
        {
            if (xDoc.SelectSingleNode("//errorCode") != null)
            {
                string errorCode = $"Error code: {xDoc.SelectSingleNode("//errorCode").InnerText}";
                string msg = $"Message: {xDoc.SelectSingleNode("//msg").InnerText}";
                return errorCode + "\n" + msg;
            }
            if (xDoc.SelectSingleNode("//dataError") != null)
            {
                return xDoc.SelectSingleNode("//dataError").InnerText;
            }
            return null;
        }
        #endregion

        #region Detail information
        private string GetRegistrant(XmlDocument xDoc)
        {
            try
            {
                string info = xDoc.SelectSingleNode("//registrant/rawText").InnerText;
                return info;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string GetAdministrativeContact(XmlDocument xDoc)
        {
            try
            {
                string info = xDoc.SelectSingleNode("//administrativeContact/rawText").InnerText;
                return info;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string GetTechnicalContact(XmlDocument xDoc)
        {
            try
            {
                string info = xDoc.SelectSingleNode("//technicalContact/rawText").InnerText;
                return info;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string GetRecordUpdate(XmlDocument xDoc)
        {
            try
            {
                string createdDate = xDoc.SelectSingleNode("//audit/createdDate").InnerText;
                string updatedDate = xDoc.SelectSingleNode("//audit/updatedDate").InnerText;
                return $"Created date: {createdDate}\nUpdated date: {updatedDate}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string GetNameServers(XmlDocument xDoc)
        {
            try
            {
                string info = xDoc.SelectSingleNode("//nameServers/rawText").InnerText;
                return $"Host names:\n{info}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string GetRegistryData(XmlDocument xDoc)
        {
            try
            {
                string info = null;
                info = $"Created date: {xDoc.SelectSingleNode("//registryData/createdDate").InnerText}" +
                    $"\nUpdated date: {xDoc.SelectSingleNode("//registryData/updatedDate").InnerText}" +
                    $"\nExpires date: {xDoc.SelectSingleNode("//registryData/expiresDate").InnerText}" +
                    $"\nParsed domain name: {xDoc.SelectSingleNode("//registryData/domainName").InnerText}" +
                    $"\n\nHost names \n{xDoc.SelectSingleNode("//registryData/nameServers/rawText").InnerText}" +
                    $"\nDomain EPP status codes by ICANN list: {xDoc.SelectSingleNode("//registryData/status").InnerText}" +
                    $"\n\nRecord update dates: " +
                    $"\nCreated date: {xDoc.SelectSingleNode("//registryData/audit/createdDate").InnerText}" +
                    $"\nUpdated date: {xDoc.SelectSingleNode("//registryData/audit/updatedDate").InnerText}" +
                    $"";
                return info;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        private string GetWhoIsInformation(XmlDocument xDoc)
        {
            if (xDoc == null)
                return null;
            string error = CheckQueryReponse(xDoc);
            if (error != null)
                return error;

            string whoIsInformation = null;
            whoIsInformation = $"*** RECORD UPDATE DATES *** \n{GetRecordUpdate(xDoc)}" +
                $"\n\n*** REGISTRANT *** \n{GetRegistrant(xDoc)}" +
                $"\n\n *** ADMINISTRATIVE CONTACT *** \n{GetAdministrativeContact(xDoc)}" +
                $"\n\n *** TECHNICAL CONTACT *** \n{GetTechnicalContact(xDoc)}" +
                $"\n\n *** NAME SERVERS *** \n{GetNameServers(xDoc)}" +
                $"\n *** REGISTRY DATA *** \n{GetRegistryData(xDoc)}";

            return whoIsInformation;
        }
        #endregion

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (textDomain.Text != string.Empty)
            {
                string xmlRespone = GetHTTPRequest(textDomain.Text);
                xDoc = new XmlDocument();
                xDoc.LoadXml(xmlRespone);
                ResetRichText();
                /* Call  comboxFields_SelectedIndexChanged() event*/
                this.comboxFields_SelectedIndexChanged(sender, e);
            }
        }

        private void textDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.buttonGo_Click(sender, e);
        }

        private void comboxFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboxFields.SelectedIndex)
            {
                /*
                    0: All
                    1: Registrant
                    2: Administrative Contact
                    3: Technical Contact
                    4: Record update dates
                    5: Name Servers
                    6: Registry Data
                 */
                case 0:
                    SetRichText(GetWhoIsInformation(xDoc));
                    break;
                case 1:
                    SetRichText(GetRegistrant(xDoc));
                    break;
                case 2:
                    SetRichText(GetAdministrativeContact(xDoc));
                    break;
                case 3:
                    SetRichText(GetTechnicalContact(xDoc));
                    break;
                case 4:
                    SetRichText(GetRecordUpdate(xDoc));
                    break;
                case 5:
                    SetRichText(GetNameServers(xDoc));
                    break;
                case 6:
                    SetRichText(GetRegistryData(xDoc));
                    break;
                default:
                    break;
            }
        }
    }
}
