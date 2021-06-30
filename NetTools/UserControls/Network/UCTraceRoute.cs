using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace NetTools.UserControls.Network
{
    public partial class UCTraceRoute : UserControl
    {
        public UCTraceRoute()
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
                TraceRoute.Items.Add(text);
            }));
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            /* Check empty text box */
            if (txtHostname.Text == string.Empty)
                return;

            string hostname = GetIPAddress(txtHostname.Text);
            int timeout = 3000;     /* 3000ms or 3 second */
            int max_ttl = 30;       /* max number of servers allowed to be found */
            int current_ttl = 0;    /* used for tracking how many servers have been found */
            const int bufferSize = 32;
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            byte[] buffer = new byte[bufferSize];
            //new Random.NextBytes(buffer);
            Ping pinger = new Ping();
            Task.Factory.StartNew(() =>
            {
                WriteListBox($">> Started ICMP TraceRoute on {hostname}");
                for (int ttl = 1; ttl <= max_ttl; ttl++)
                {
                    current_ttl++;
                    s1.Start();
                    s2.Start();
                    PingOptions options = new PingOptions(ttl, true);
                    PingReply reply = null;
                    try
                    {
                        reply = pinger.Send(hostname, timeout, buffer, options);
                    }
                    catch
                    {
                        WriteListBox("Error");
                        break;  //the rest of the code relies on the reply not being so...
                    }
                    if (reply != null)//don't need this but anyway...
                    {
                        if (reply.Status == IPStatus.Success)
                        {
                            //the ICMP packet has reached the destination (the hostname)
                            WriteListBox($"---------------------------------------------------------------------------------------------------------------");
                            WriteListBox($"Successful Traceroute to {hostname} Time: {s1.ElapsedMilliseconds} ms - Total time: {s2.ElapsedMilliseconds} ms");
                            WriteListBox($"---------------------------------------------------------------------------------------------------------------");
                            s1.Stop();
                            s2.Stop();
                        }
                        else if (reply.Status == IPStatus.TtlExpired)
                        {
                            //address found after yours on the way to the destination
                            WriteListBox($"[{ttl}] - Route: {reply.Address} - Time: {s1.ElapsedMilliseconds} ms - Total time: {s2.ElapsedMilliseconds} ms");
                            continue;//continue to the other bits to find more servers
                        }
                        else if (reply.Status == IPStatus.TimedOut)
                        {
                            /*this would occour if it takes too long for the server to reply or 
                             if a server has the ICMP port closed (quite common for this).*/
                            WriteListBox($"----------------------------------");
                            WriteListBox($"Timeout on {hostname}. Continuing.");
                            WriteListBox($"----------------------------------");
                            continue;
                        }
                    }
                    break;
                }
            });
        }
        private void TraceRoute_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(Cursor.Position);
            }
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            TraceRoute.Items.Clear();
        }

        private void txtHostname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
