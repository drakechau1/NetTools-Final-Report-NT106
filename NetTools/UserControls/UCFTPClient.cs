using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetTools.Libraries;

namespace NetTools.UserControls
{
    public partial class UCFTPClient : UserControl
    {
        private FTP ftp;

        /* Constructor */
        public UCFTPClient()
        {
            InitializeComponent();
            /* Begin */
            textHost.Text = "ftp://127.0.0.1/";
            textUsername.Text = "user1";
            textPassword.Text = "user1";

            ActivateDisconnected();
        }

        #region Methods
        private void ActivateConnected()
        {
            /* Create listview-columns */
            listviewFileInformation.Columns.Add("Name", 300);
            listviewFileInformation.Columns.Add("Date modified", 200);
            listviewFileInformation.Columns.Add("Type", 100);
            listviewFileInformation.Columns.Add("Size", 100);
            listviewFileInformation.View = View.Details;

            /* --- */
            panelDesktop.Enabled = true;
            panelQuickConnect.Visible = false;
        }

        private void ActivateDisconnected()
        {
            /* Reset text */
            comboxDirectory.ResetText();
            listviewFileInformation.Clear();

            /* --- */
            panelDesktop.Enabled = false;
            panelQuickConnect.Visible = true;
        }
        #endregion

        #region FTP Functions

        #endregion

        #region Button
        private void buttonQuickConnect_Click(object sender, EventArgs e)
        {
            ftp = new FTP(textHost.Text, textUsername.Text, textPassword.Text);
            /* FTP Connection Unsuccess */
            if (!ftp.Connect())
            {
                MessageBox.Show("Fail connection", "Error");
                return;
            }
            /* FTP Connection Success */
            ActivateConnected();
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            ftp.Disconnect();
            ActivateDisconnected();
        }
        #endregion
    }
}
