using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;

namespace NetTools.UserControls.Network
{
    public partial class UCWhoIs : UserControl
    {
        // Constructor
        public UCWhoIs()
        {
            InitializeComponent();
        }

        #region Methods
        private string GetHTTPRequest(string ipAddress)
        {
            string URL = $"https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey=at_aVzDK57jaecAL81LDLNTpFpZobX4B&domainName={ipAddress}";
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
            if (xDoc.SelectSingleNode("//ErrorMessage") != null)
                return false;
            return true;
        }
        #endregion

        #region User interaction
        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (textIPAddress.Text != string.Empty)
            {
                string xmlRespone = GetHTTPRequest(textIPAddress.Text);
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(xmlRespone);
                richTextInfomation.Clear();
                try
                {
                    if (CheckQueryReponse(xDoc))
                    {
                        richTextInfomation.Text = xDoc.SelectSingleNode("./WhoisRecord[1]/rawText[1]").InnerText;

                    }
                    else
                    {
                        string errorCode = $"Error code: {xDoc.SelectSingleNode("//errorCode").InnerText}";
                        string msg = $"Message: {xDoc.SelectSingleNode("//msg").InnerText}";
                        richTextInfomation.Text += errorCode;
                        richTextInfomation.Text += "\n";
                        richTextInfomation.Text += msg;
                    }
                }
                catch (Exception ex)
                {
                    richTextInfomation.Text = ex.Message;
                }
            }
        }
        #endregion
    }
}
