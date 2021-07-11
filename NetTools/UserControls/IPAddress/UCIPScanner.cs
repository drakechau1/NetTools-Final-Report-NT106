using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTools.UserControls.IPAddress
{
    public partial class UCIPScanner : UserControl
    {
        // source: https://foxlearn.com/windows-forms/how-to-scan-ip-address-in-a-network-using-csharp-507.html

        private bool isbreak = false;

        public UCIPScanner()
        {
            InitializeComponent();
            /* Init listview */
            InitListview();
        }

        void InitListview()
        {
            /* Create columns */
            listviewInfor.Columns.Add("IP Address", 200);
            listviewInfor.Columns.Add("Host name", 200);
            listviewInfor.Columns.Add("Status", 200);
            /* Set listview-view */
            listviewInfor.View = View.Details;
        }

        void IPScanning()
        {
            string subnet = textIPSubnet.Text;
            listviewInfor.Items.Clear();

            Task.Factory.StartNew(new Action(() =>
            {
                isbreak = false;
                for (int i = 2; i < 255; i++)
                {
                    if (isbreak) break;
                    string ip = $"{subnet}.{i}";
                    Ping ping = new Ping();
                    PingReply reply = ping.Send(ip, 100);
                    if (reply.Status == IPStatus.Success)
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {
                            try
                            {
                                System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse(ip);
                                IPHostEntry host = Dns.GetHostEntry(ipaddress);
                                listviewInfor.Items.Add(new ListViewItem(new String[] { ip, host.HostName, "Up" }));
                            }
                            catch
                            {
                                Console.WriteLine($"Couldn't retrieve hostname from {ip}");
                            }
                            progressBar.Value += 1;
                            labelStatus.ForeColor = Color.Blue;
                            labelStatus.Text = $"Scanning: {ip}";
                            if (progressBar.Value == 253)
                                labelStatus.Text = "Finished";
                        }));
                    }
                    else
                    {
                        progressBar.BeginInvoke(new Action(() =>
                        {
                            progressBar.Value += 1;
                            labelStatus.ForeColor = Color.DarkGray;
                            labelStatus.Text = $"Scanning: {ip}";
                            if (progressBar.Value == 253)
                                labelStatus.Text = "Finished";
                        }));
                    }
                }
            }));
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textIPSubnet.Text))
                return;
            IPScanning();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {

        }

        private void textIPSubnet_KeyDown(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(textIPSubnet.Text))
                return;
            if (e.KeyCode == Keys.Enter)
                buttonScan_Click(sender, e);
        }
    }
}
