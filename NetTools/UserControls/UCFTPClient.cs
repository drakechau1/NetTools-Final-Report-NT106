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
        /* Active the state-connection display */
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
        /* Active the state-disconnection display */
        private void ActivateDisconnected()
        {
            /* Reset text */
            listviewFileInformation.Clear();
            textCurrentDirectory.ResetText();
            /* --- */
            panelDesktop.Enabled = false;
            panelQuickConnect.Visible = true;
        }
        /* Check the name is a folder? */
        private bool IsFolder(string folder)
        {
            if (Path.GetExtension(folder) == string.Empty)
                return true;
            return false;
        }
        /* Add the file-information into the listview */
        private void AddListviewItem(ListViewItem listviewItem)
        {
            listviewFileInformation.Items.Add(listviewItem);
        }
        /* Store the current-directory */
        private void SetCurrentDirectory(string directory)
        {
            textCurrentDirectory.Text = directory;
            currentDirectory = directory;
        }
        /* Get the savepath from the local */
        private string GetSavePath()
        {
            string fileName = GetFullFileName();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = $"|*{Path.GetExtension(fileName)}";
            sfd.FileName = fileName;
            if (sfd.ShowDialog() == DialogResult.OK)
                return sfd.FileName;
            return null;
        }
        /* Get the open file dialog path */
        private string GetOpenFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;
            return null;
        }
        /* Get the full-path of the Listview-SelectedItem */
        private string GetFullFileName()
        {
            /* Check the item has been selected? */
            if (listviewFileInformation.SelectedItems.Count <= 0)
                return null;
            string fileName = listviewFileInformation.SelectedItems[0].Text;
            string fileExt = listviewFileInformation.SelectedItems[0].SubItems[2].Text;
            return fileName + fileExt;
        }
        #endregion

        #region FTP Functions
        /* Load the directory-information */
        private void RefreshFileBrowser(string directory)
        {
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
                AddListviewItem(listviewItem);
            }
            /* Set current directory */
            SetCurrentDirectory(directory);
        }
        /* Download a file from FTP Server */
        private void FTPDownloadFile(string remoteFile, string localFile)
        {
            try
            {
                ftp.Download(remoteFile, localFile);
                Console.WriteLine("Download file completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /* Upload a file from the local to FTP Server */
        private void FTPUploadFile(string filePath)
        {
            try
            {
                string remoteFile = currentDirectory + "/" + Path.GetFileName(filePath);
                ftp.Upload(remoteFile, filePath);
                MessageBox.Show("Upload file completed");
                RefreshFileBrowser(currentDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        /* Delete a file in the FTP Server */
        private void FTPDeleteFile(string fileName)
        {

        }
        #endregion

        #region Button
        /* Connect to FTP Server */
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
        /* Disconnect with FTP Server */
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            ftp.Disconnect();
            ActivateDisconnected();
        }
        /* Get the directory-information */
        private void buttonGo_Click(object sender, EventArgs e)
        {
            /* Check the textbox is a null or empty? */
            if (String.IsNullOrEmpty(textCurrentDirectory.Text))
                return;
            /* Check the textbox has been changed */
            if (textCurrentDirectory.Text == currentDirectory)
                return;
            /* Check the current directory is exist in the FTP Server? */
            if (!ftp.IsDirectoryExist(textCurrentDirectory.Text))
                return;

            currentDirectory = textCurrentDirectory.Text;
            RefreshFileBrowser(currentDirectory);
        }
        /* Download a file from the specific directory in FTP Server */
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (listviewFileInformation.SelectedItems.Count <= 0)
                return;
            string savePath = GetSavePath();
            if (String.IsNullOrEmpty(savePath))
                return;
            string remoteFile = currentDirectory + "/" + GetFullFileName();
            FTPDownloadFile(remoteFile, savePath);
        }
        /* Upload a file from the local to the FTP Server */
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            string localFile = GetOpenFileDialog();
            if (localFile != null)
                FTPUploadFile(localFile);
        }
        /* Refresh listview */
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshFileBrowser(currentDirectory);
        }
        #endregion

        /* Enter-textbox event */
        private void textCurrentDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonGo_Click(sender, e);
            }
        }
        /* DoubleClick_listview event */
        private void listviewFileInformation_DoubleClick(object sender, EventArgs e)
        {
            if (!IsFolder(GetFullFileName()))
                return;

            string fileName = listviewFileInformation.SelectedItems[0].Text;

            if (currentDirectory.Last() == '/')
                currentDirectory += fileName;
            else
                currentDirectory += ("/" + fileName);

            RefreshFileBrowser(currentDirectory);
        }

        #region Tool Strip Menu Item
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = GetFullFileName();
            /* Check the remoteFile is a null or empty string? */
            if (string.IsNullOrEmpty(fileName))
                return;
            string remoteFile = currentDirectory + "/" + GetFullFileName();
            /* Check the remottFile is exist in the FTP Server? */
            if (!ftp.IsDirectoryExist(remoteFile))
                return;
            /* If it is exist */
            ftp.Delete(remoteFile);
            RefreshFileBrowser(currentDirectory);
        }
        #endregion
    }
}
