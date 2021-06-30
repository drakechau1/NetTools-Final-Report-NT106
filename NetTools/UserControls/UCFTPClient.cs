using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string currentDirectory = "/"; /* / is the root directory path */

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
            listviewFileInformation.Columns.Add("Name", 250);
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
            listviewFileInformation.Clear();
            textCurrentDirectory.ResetText();
            /* --- */
            panelDesktop.Enabled = false;
            panelQuickConnect.Visible = true;
        }
        private bool IsFolder(string folder)
        {
            if (System.IO.Path.GetExtension(folder) == string.Empty)
                return true;
            return false;
        }
        private void ListviewAddItem(ListViewItem listviewItem)
        {
            listviewFileInformation.Items.Add(listviewItem);
        }
        private void SetCurrentDirectory(string directory)
        {
            textCurrentDirectory.Text = directory;
            currentDirectory = directory;
        }
        #endregion

        #region FTP Functions
        private void RefreshFileBrowser(string directory)
        {
            Console.WriteLine(ftp.IsDirectoryExist(directory));
            /* Clear the Listview */
            listviewFileInformation.Items.Clear();

            /* Total size of current directory */
            long totalSize = 0;
            foreach (var item in ftp.ListDirectory(directory))
            {
                string fileName = Path.GetFileNameWithoutExtension(item);
                string fileExtension = Path.GetExtension(item);
                string fileSize = ftp.FileSize(item);
                string fileModifiedDay = ftp.DateTimestamp(item);
                totalSize += long.Parse(fileSize);

                /* Create Listview Item */
                ListViewItem listviewItem = new ListViewItem(new string[] { fileName, fileModifiedDay, fileExtension, fileSize });
                /* Create Listview Item */
                ListviewAddItem(listviewItem);
            }
            /* Set current directory */
            SetCurrentDirectory(directory);
        }
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
            /* Get all files of the root directory */
            RefreshFileBrowser("/");
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            ftp.Disconnect();
            ActivateDisconnected();
        }
        private void buttonGo_Click(object sender, EventArgs e)
        {
            currentDirectory = textCurrentDirectory.Text;
            RefreshFileBrowser(currentDirectory);
        }
        #endregion

        #region Enter events
        private void textCurrentDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && currentDirectory != textCurrentDirectory.Text)
            {
                this.buttonGo_Click(sender, e);
            }
        }
        #endregion

        private void listviewFileInformation_DoubleClick(object sender, EventArgs e)
        {
            string fileName = listviewFileInformation.SelectedItems[0].Text;
            if (!String.IsNullOrEmpty(listviewFileInformation.SelectedItems[0].SubItems[2].Text))
                return;
            if (currentDirectory.Last() == '/')
                SetCurrentDirectory(currentDirectory + fileName);
            else
                SetCurrentDirectory(currentDirectory + "/" + fileName);

            RefreshFileBrowser(currentDirectory);
        }
    }
}
