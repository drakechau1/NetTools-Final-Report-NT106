using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace NetTools.UserControls.IPAddress
{
    public partial class UCMyIP : UserControl
    {
        /* Get Local IP Address */
        private string GetLocalIPAddress()
        {
            string ipInformation = string.Empty;
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                ipInformation += $"IPv6 Address. . . . . . . . . . . . . . . : {host.AddressList[2]}" +
                    $"\nTemporary IPv6 Address. . . . . . : {host.AddressList[1]}" +
                    $"\nLink-local IPv6 Address . . . . . . .: {host.AddressList[0]}" +
                    $"\nIPv4 Address. . . . . . . . . . . . . . . : {host.AddressList[3]}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return ipInformation;
        }
        /* Get Network Interfaces */
        private string GetTypeAndAddress()
        {
            string infor = string.Empty;
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            infor += $"Interface information for {computerProperties.HostName}\n{computerProperties.DomainName}";
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                infor += "\n" + adapter.Description;

                infor += "\n" + String.Empty.PadLeft(adapter.Description.Length, '=');
                infor += $"\n    Interface type. . . . . . . . . . . . . . : {adapter.NetworkInterfaceType}";
                infor += $"\n    Physical Address . . . . . . . . . . . : {adapter.GetPhysicalAddress().ToString()}";
                infor += $"\n    Is receive only. . . . . . . . . . . . . . : {adapter.IsReceiveOnly}";
                infor += $"\n    Multicast. . . . . . . . . . . . . . . . . . : {adapter.SupportsMulticast}";
                infor += "\n";
            }
            return infor;
        }
        /* Show Richtext */
        private void DisplayInformation()
        {
            richMyIP.Text = null;
            richMyIP.Text = GetLocalIPAddress();
            richMyIP.Text += "\n\n";
            richMyIP.Text += GetTypeAndAddress();
        }

        public UCMyIP()
        {
            InitializeComponent();
            DisplayInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayInformation();
        }
    }
}
