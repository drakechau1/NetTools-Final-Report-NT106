using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetTools.Libraries
{
    class FTP
    {
        private string host, user, pass;
        bool isConnected = false;

        public FTP(string host = null, string user = null, string pass = null)
        {
            this.host = host;
            this.user = user;
            this.pass = pass;
        }

        public bool Connect()
        {
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(host);
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                isConnected = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isConnected = false;
            }
            return isConnected;
        }
        public void Disconnect()
        {
            if (!isConnected)
                return;
            this.host = null;
            this.user = null;
            this.pass = null;
            Console.WriteLine("FTP was disconnected");
        }
    }
}
