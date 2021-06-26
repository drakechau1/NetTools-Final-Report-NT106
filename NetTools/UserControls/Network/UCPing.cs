using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTools.UserControls.Network
{
    public partial class UCPing : UserControl
    {
        int timeout = 3000;     /* 3000ms or 3 second */
        int max_ttl = 30;       /* max number of servers allowed to be found */
        int current_ttl = 0;    /* used for tracking how many servers have been found */
        const int bufferSize = 32;

        public UCPing()
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
        private void WriteListBox(string text)
        {
            //this will make adding things to the listbox easier
            //Because I'll put the code in another thread/thing, aka using a task
            //you need to use a dispatcher to edit things in the current thread
            Invoke(new Action(() =>
            {
                listboxPingInfo.Items.Add(text);
            }));
        }
        async Task UseDelay()
        {
            await Task.Delay(1000); // wait for 1 second
        }
        private void PingProcess(string hostname)
        {
            Stopwatch eachTime = new Stopwatch();
            Stopwatch totalTime = new Stopwatch();
            byte[] buffer = new byte[bufferSize];
            //new Random.NextBytes(buffer);
            Ping pinger = new Ping();

            Task.Factory.StartNew(() =>
            {
                WriteListBox($"--------------------------------------------------------------");
                WriteListBox($">> Started ICMP Pinging on {hostname}");
                WriteListBox($"Pingng {hostname} with {bufferSize} bytes of data: ");
                totalTime.Start();
                for (int ttl = 1; ttl <= 4; ttl++)
                {
                    current_ttl++;
                    eachTime.Start();
                    PingOptions options = new PingOptions(max_ttl, true);
                    PingReply reply = null;
                    try
                    {
                        reply = pinger.Send(hostname, timeout, buffer, options);
                    }
                    catch (Exception ex)
                    {
                        WriteListBox(ex.Message);
                        break;  //the rest of the code relies on the reply not being so...
                    }

                    if (reply != null)  //don't need this but anyway...
                    {
                        if (reply.Status == IPStatus.Success)
                        {
                            WriteListBox($"Reply from {reply.Address} Time: {eachTime.ElapsedMilliseconds} ms \t TTL: {ttl}");
                            eachTime.Stop();
                        }
                        else if (reply.Status == IPStatus.TtlExpired)
                        {
                            WriteListBox($"Route: {reply.Address} - Time: {eachTime.ElapsedMilliseconds} ms - Total time: {totalTime.ElapsedMilliseconds} ms");
                        }
                        else if (reply.Status == IPStatus.TimedOut)
                        {
                            WriteListBox($"Timeout on {hostname}. Continuing.");
                        }
                    }
                    Task.Delay(1000);
                }
            });
        }
        #endregion

        #region Button       
        private void buttonGo_Click(object sender, EventArgs e)
        {
            string hostname = GetIPAddress(textDomain.Text);
            PingProcess(hostname);
        }
        #endregion

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listboxPingInfo.Items.Clear();
        }
    }
}
