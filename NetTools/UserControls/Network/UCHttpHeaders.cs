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

namespace NetTools.UserControls.Network
{
    public partial class UCHttpHeaders : UserControl
    {
        private string domain = null;
        /* Constructor */
        public UCHttpHeaders()
        {
            InitializeComponent();
        }

        #region Methods
        private bool CheckTextBox(TextBox checkBox)
        {
            return (checkBox.Text == string.Empty ? false : true);
        }
        private bool isDomain(string domain)
        {
            if (domain.Contains("http") || domain.Contains("https"))
                return false;
            return true;
        }
        private string VerifiedURL(string domain)
        {
            if (!isDomain(domain))
                return domain;
            return $"https://{domain}";
        }
        private string GetHTTPHeaders(string url)
        {
            // Reference source: https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebresponse.headers?view=net-5.0
            try
            {
                string httpHeaders = null;
                /* Creates an HttpWebRequest for the specified URL. */
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                /* Set Allow Auto Redirect */
                bool isAllowAutoRedirect = (checkboxAllowRedirects.Checked ? true : false);
                httpWebRequest.AllowAutoRedirect = isAllowAutoRedirect;
                /* Sends the HttpWebRequest and waits for response. */
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                /* Get each header and it's key associated with the response. */
                for (int i = 0; i < httpWebResponse.Headers.Count; ++i)
                    httpHeaders += $"\n{httpWebResponse.Headers.Keys[i]}: {httpWebResponse.Headers[i]}";
                httpWebResponse.Close();
                return httpHeaders;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtDomain))
            {
                domain = txtDomain.Text;
                string url = VerifiedURL(domain);
                richtextHTTPHeaders.Text = $"Site: {url.ToLower()}\r\nRetrieving Headers\r\n";
                richtextHTTPHeaders.Text += GetHTTPHeaders(url);
            }
        }
    }
}
