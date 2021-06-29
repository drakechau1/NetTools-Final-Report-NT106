
namespace NetTools.UserControls
{
    partial class UCFTPClient
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelQuickConnect = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonQuickConnect = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.listviewFileInformation = new System.Windows.Forms.ListView();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboxDirectory = new System.Windows.Forms.ComboBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.panelQuickConnect.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuickConnect
            // 
            this.panelQuickConnect.Controls.Add(this.buttonQuickConnect);
            this.panelQuickConnect.Controls.Add(this.label3);
            this.panelQuickConnect.Controls.Add(this.label2);
            this.panelQuickConnect.Controls.Add(this.textPassword);
            this.panelQuickConnect.Controls.Add(this.textUsername);
            this.panelQuickConnect.Controls.Add(this.label1);
            this.panelQuickConnect.Controls.Add(this.textHost);
            this.panelQuickConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuickConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelQuickConnect.Location = new System.Drawing.Point(0, 0);
            this.panelQuickConnect.Name = "panelQuickConnect";
            this.panelQuickConnect.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelQuickConnect.Size = new System.Drawing.Size(980, 70);
            this.panelQuickConnect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // textHost
            // 
            this.textHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHost.Location = new System.Drawing.Point(101, 27);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(216, 27);
            this.textHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(415, 27);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(152, 27);
            this.textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(662, 27);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(125, 27);
            this.textPassword.TabIndex = 1;
            // 
            // buttonQuickConnect
            // 
            this.buttonQuickConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuickConnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonQuickConnect.FlatAppearance.BorderSize = 0;
            this.buttonQuickConnect.Location = new System.Drawing.Point(793, 22);
            this.buttonQuickConnect.Name = "buttonQuickConnect";
            this.buttonQuickConnect.Size = new System.Drawing.Size(134, 37);
            this.buttonQuickConnect.TabIndex = 3;
            this.buttonQuickConnect.Text = "QuickConnect";
            this.buttonQuickConnect.UseVisualStyleBackColor = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.listviewFileInformation);
            this.panelDesktop.Controls.Add(this.panelControls);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panelDesktop.Size = new System.Drawing.Size(980, 760);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.comboxDirectory);
            this.panelControls.Controls.Add(this.buttonDisconnect);
            this.panelControls.Controls.Add(this.buttonRefresh);
            this.panelControls.Controls.Add(this.buttonDownload);
            this.panelControls.Controls.Add(this.buttonUpload);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(50, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(880, 100);
            this.panelControls.TabIndex = 0;
            // 
            // listviewFileInformation
            // 
            this.listviewFileInformation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listviewFileInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewFileInformation.HideSelection = false;
            this.listviewFileInformation.Location = new System.Drawing.Point(50, 100);
            this.listviewFileInformation.Name = "listviewFileInformation";
            this.listviewFileInformation.Size = new System.Drawing.Size(880, 630);
            this.listviewFileInformation.TabIndex = 1;
            this.listviewFileInformation.UseCompatibleStateImageBehavior = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(46, 7);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(96, 37);
            this.buttonUpload.TabIndex = 0;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.Location = new System.Drawing.Point(148, 7);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(123, 37);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(277, 7);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 37);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // comboxDirectory
            // 
            this.comboxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxDirectory.FormattingEnabled = true;
            this.comboxDirectory.Location = new System.Drawing.Point(46, 50);
            this.comboxDirectory.Name = "comboxDirectory";
            this.comboxDirectory.Size = new System.Drawing.Size(788, 24);
            this.comboxDirectory.TabIndex = 1;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(686, 7);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(148, 37);
            this.buttonDisconnect.TabIndex = 0;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // UCFTPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelQuickConnect);
            this.Name = "UCFTPClient";
            this.Size = new System.Drawing.Size(980, 830);
            this.panelQuickConnect.ResumeLayout(false);
            this.panelQuickConnect.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuickConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonQuickConnect;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.ListView listviewFileInformation;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.ComboBox comboxDirectory;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}
