using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTools.UserControls.Network
{
    public partial class UCPing : UserControl
    {
        int timeout = 3000;     /* 3000ms or 3 second */
        int max_ttl = 30;       /* max number of servers allowed to be found */
        const int bufferSize = 32;

        public UCPing()
        {
            InitializeComponent();
        }

        #region Methods
        /* Verify domain */
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
        /* Write text to listview */
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
        private void PingProcess(string hostname)
        {
            long max_time = -1;
            long min_time = timeout;    // 3000ms
            long average_time = 0;
            int packet_sent = 0;
            int packet_received = 0;
            Stopwatch eachTime = new Stopwatch();
            Stopwatch totalTime = new Stopwatch();
            byte[] buffer = new byte[bufferSize];
            Ping pinger = new Ping();

            Task.Factory.StartNew(() =>
            {
                WriteListBox($"--------------------------------------------------------------");
                WriteListBox($">> Started ICMP Pinging on {hostname}");
                WriteListBox($"Pingng {hostname} with {bufferSize} bytes of data: ");
                totalTime.Start();
                for (int ttl = 1; ttl <= 4; ttl++)
                {
                    eachTime.Start();
                    PingOptions options = new PingOptions(max_ttl, true);
                    PingReply reply = null;
                    try
                    {
                        reply = pinger.Send(hostname, timeout, buffer, options);
                        packet_sent += 1;
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
                            long time = eachTime.ElapsedMilliseconds;
                            WriteListBox($"Reply from {reply.Address} Time: {time} ms");
                            eachTime.Stop();
                            min_time = (time < min_time ? time:min_time);
                            max_time = (time > max_time ? time:max_time);
                            packet_received += 1;
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
                }
                average_time = totalTime.ElapsedMilliseconds / 4;
                WriteListBox("");
                WriteListBox($"Ping statistics for {hostname}:");
                WriteListBox($"\tPackets: Sent = {packet_sent}, Received = {packet_received}, Lost = {packet_sent - packet_received},");
                WriteListBox("Approximate round trip times in milli-seconds:");
                WriteListBox($"\tMinimum = {min_time}ms, Maximum = {max_time}ms, Average = {average_time}ms");
            });
        }
        #endregion
  
        /* Click-button event */
        private void buttonGo_Click(object sender, EventArgs e)
        {
            string hostname = VerifyDomain(textDomain.Text);
            PingProcess(hostname);
        }
        /* Clear listview */
        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listboxPingInfo.Items.Clear();
        }
        /* Enter-button event */
        private void textDomain_KeyDown(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(textDomain.Text))
                return;
            if (e.KeyCode == Keys.Enter)
                buttonGo_Click(sender, e);
        }
    }
}
