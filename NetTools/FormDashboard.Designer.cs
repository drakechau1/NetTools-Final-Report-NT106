
namespace NetTools
{
    partial class FormDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panelMisc = new System.Windows.Forms.Panel();
            this.buttonBinaryConverter = new System.Windows.Forms.Button();
            this.buttonTextConversion = new System.Windows.Forms.Button();
            this.buttonMisc = new System.Windows.Forms.Button();
            this.panelIPAddress = new System.Windows.Forms.Panel();
            this.buttonWhoIs = new System.Windows.Forms.Button();
            this.buttonIPGeoLocation = new System.Windows.Forms.Button();
            this.buttonIPSubnetCalc = new System.Windows.Forms.Button();
            this.buttonIPScanner = new System.Windows.Forms.Button();
            this.buttonMyIP = new System.Windows.Forms.Button();
            this.buttonIPAddress = new System.Windows.Forms.Button();
            this.panelNetwork = new System.Windows.Forms.Panel();
            this.buttonIPHeader = new System.Windows.Forms.Button();
            this.buttonTraceRoute = new System.Windows.Forms.Button();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonNetwork = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelWindowControl = new System.Windows.Forms.Panel();
            this.buttonMinimizeWindow = new System.Windows.Forms.Button();
            this.buttonMaximizeWindow = new System.Windows.Forms.Button();
            this.buttonExitWindow = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelMisc.SuspendLayout();
            this.panelIPAddress.SuspendLayout();
            this.panelNetwork.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelWindowControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Controls.Add(this.panelMisc);
            this.panelMenu.Controls.Add(this.buttonMisc);
            this.panelMenu.Controls.Add(this.panelIPAddress);
            this.panelMenu.Controls.Add(this.buttonIPAddress);
            this.panelMenu.Controls.Add(this.panelNetwork);
            this.panelMenu.Controls.Add(this.buttonNetwork);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 900);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetting.Image")));
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(0, 723);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonSetting.Size = new System.Drawing.Size(240, 46);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // panelMisc
            // 
            this.panelMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panelMisc.Controls.Add(this.buttonBinaryConverter);
            this.panelMisc.Controls.Add(this.buttonTextConversion);
            this.panelMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMisc.Location = new System.Drawing.Point(0, 643);
            this.panelMisc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMisc.Name = "panelMisc";
            this.panelMisc.Size = new System.Drawing.Size(240, 80);
            this.panelMisc.TabIndex = 5;
            // 
            // buttonBinaryConverter
            // 
            this.buttonBinaryConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBinaryConverter.FlatAppearance.BorderSize = 0;
            this.buttonBinaryConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBinaryConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinaryConverter.Location = new System.Drawing.Point(0, 39);
            this.buttonBinaryConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBinaryConverter.Name = "buttonBinaryConverter";
            this.buttonBinaryConverter.Size = new System.Drawing.Size(240, 39);
            this.buttonBinaryConverter.TabIndex = 2;
            this.buttonBinaryConverter.Text = "Binary Converter";
            this.buttonBinaryConverter.UseVisualStyleBackColor = true;
            this.buttonBinaryConverter.Click += new System.EventHandler(this.buttonBinaryConverter_Click);
            // 
            // buttonTextConversion
            // 
            this.buttonTextConversion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTextConversion.FlatAppearance.BorderSize = 0;
            this.buttonTextConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTextConversion.Location = new System.Drawing.Point(0, 0);
            this.buttonTextConversion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTextConversion.Name = "buttonTextConversion";
            this.buttonTextConversion.Size = new System.Drawing.Size(240, 39);
            this.buttonTextConversion.TabIndex = 1;
            this.buttonTextConversion.Text = "Text Conversion";
            this.buttonTextConversion.UseVisualStyleBackColor = true;
            this.buttonTextConversion.Click += new System.EventHandler(this.buttonTextConversion_Click);
            // 
            // buttonMisc
            // 
            this.buttonMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMisc.FlatAppearance.BorderSize = 0;
            this.buttonMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMisc.Image = ((System.Drawing.Image)(resources.GetObject("buttonMisc.Image")));
            this.buttonMisc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMisc.Location = new System.Drawing.Point(0, 597);
            this.buttonMisc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMisc.Name = "buttonMisc";
            this.buttonMisc.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonMisc.Size = new System.Drawing.Size(240, 46);
            this.buttonMisc.TabIndex = 4;
            this.buttonMisc.Text = "Misc";
            this.buttonMisc.UseVisualStyleBackColor = true;
            this.buttonMisc.Click += new System.EventHandler(this.buttonMisc_Click);
            // 
            // panelIPAddress
            // 
            this.panelIPAddress.Controls.Add(this.buttonWhoIs);
            this.panelIPAddress.Controls.Add(this.buttonIPGeoLocation);
            this.panelIPAddress.Controls.Add(this.buttonIPSubnetCalc);
            this.panelIPAddress.Controls.Add(this.buttonIPScanner);
            this.panelIPAddress.Controls.Add(this.buttonMyIP);
            this.panelIPAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIPAddress.Location = new System.Drawing.Point(0, 397);
            this.panelIPAddress.Name = "panelIPAddress";
            this.panelIPAddress.Size = new System.Drawing.Size(240, 200);
            this.panelIPAddress.TabIndex = 8;
            // 
            // buttonWhoIs
            // 
            this.buttonWhoIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonWhoIs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWhoIs.FlatAppearance.BorderSize = 0;
            this.buttonWhoIs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhoIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhoIs.Location = new System.Drawing.Point(0, 156);
            this.buttonWhoIs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWhoIs.Name = "buttonWhoIs";
            this.buttonWhoIs.Size = new System.Drawing.Size(240, 39);
            this.buttonWhoIs.TabIndex = 6;
            this.buttonWhoIs.Text = "WhoIs";
            this.buttonWhoIs.UseVisualStyleBackColor = false;
            this.buttonWhoIs.Click += new System.EventHandler(this.buttonWhoIs_Click);
            // 
            // buttonIPGeoLocation
            // 
            this.buttonIPGeoLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonIPGeoLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPGeoLocation.FlatAppearance.BorderSize = 0;
            this.buttonIPGeoLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPGeoLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPGeoLocation.Location = new System.Drawing.Point(0, 117);
            this.buttonIPGeoLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIPGeoLocation.Name = "buttonIPGeoLocation";
            this.buttonIPGeoLocation.Size = new System.Drawing.Size(240, 39);
            this.buttonIPGeoLocation.TabIndex = 5;
            this.buttonIPGeoLocation.Text = "IP Geo Location";
            this.buttonIPGeoLocation.UseVisualStyleBackColor = false;
            this.buttonIPGeoLocation.Click += new System.EventHandler(this.buttonIPGeoLocation_Click);
            // 
            // buttonIPSubnetCalc
            // 
            this.buttonIPSubnetCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonIPSubnetCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPSubnetCalc.FlatAppearance.BorderSize = 0;
            this.buttonIPSubnetCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPSubnetCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPSubnetCalc.Location = new System.Drawing.Point(0, 78);
            this.buttonIPSubnetCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIPSubnetCalc.Name = "buttonIPSubnetCalc";
            this.buttonIPSubnetCalc.Size = new System.Drawing.Size(240, 39);
            this.buttonIPSubnetCalc.TabIndex = 4;
            this.buttonIPSubnetCalc.Text = "IP Subnet Calculator";
            this.buttonIPSubnetCalc.UseVisualStyleBackColor = false;
            this.buttonIPSubnetCalc.Click += new System.EventHandler(this.buttonIPSubnetCalc_Click);
            // 
            // buttonIPScanner
            // 
            this.buttonIPScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonIPScanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPScanner.FlatAppearance.BorderSize = 0;
            this.buttonIPScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPScanner.Location = new System.Drawing.Point(0, 39);
            this.buttonIPScanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIPScanner.Name = "buttonIPScanner";
            this.buttonIPScanner.Size = new System.Drawing.Size(240, 39);
            this.buttonIPScanner.TabIndex = 3;
            this.buttonIPScanner.Text = "IP Scanner";
            this.buttonIPScanner.UseVisualStyleBackColor = false;
            this.buttonIPScanner.Click += new System.EventHandler(this.buttonIPScanner_Click);
            // 
            // buttonMyIP
            // 
            this.buttonMyIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonMyIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMyIP.FlatAppearance.BorderSize = 0;
            this.buttonMyIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyIP.Location = new System.Drawing.Point(0, 0);
            this.buttonMyIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMyIP.Name = "buttonMyIP";
            this.buttonMyIP.Size = new System.Drawing.Size(240, 39);
            this.buttonMyIP.TabIndex = 2;
            this.buttonMyIP.Text = "My IP";
            this.buttonMyIP.UseVisualStyleBackColor = false;
            this.buttonMyIP.Click += new System.EventHandler(this.buttonMyIP_Click);
            // 
            // buttonIPAddress
            // 
            this.buttonIPAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPAddress.FlatAppearance.BorderSize = 0;
            this.buttonIPAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPAddress.Image = ((System.Drawing.Image)(resources.GetObject("buttonIPAddress.Image")));
            this.buttonIPAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIPAddress.Location = new System.Drawing.Point(0, 351);
            this.buttonIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIPAddress.Name = "buttonIPAddress";
            this.buttonIPAddress.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonIPAddress.Size = new System.Drawing.Size(240, 46);
            this.buttonIPAddress.TabIndex = 7;
            this.buttonIPAddress.Text = "IP Address";
            this.buttonIPAddress.UseVisualStyleBackColor = true;
            this.buttonIPAddress.Click += new System.EventHandler(this.buttonIPAddress_Click);
            // 
            // panelNetwork
            // 
            this.panelNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panelNetwork.Controls.Add(this.buttonIPHeader);
            this.panelNetwork.Controls.Add(this.buttonTraceRoute);
            this.panelNetwork.Controls.Add(this.buttonPing);
            this.panelNetwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNetwork.Location = new System.Drawing.Point(0, 231);
            this.panelNetwork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNetwork.Name = "panelNetwork";
            this.panelNetwork.Size = new System.Drawing.Size(240, 120);
            this.panelNetwork.TabIndex = 3;
            // 
            // buttonIPHeader
            // 
            this.buttonIPHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPHeader.FlatAppearance.BorderSize = 0;
            this.buttonIPHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPHeader.Location = new System.Drawing.Point(0, 78);
            this.buttonIPHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIPHeader.Name = "buttonIPHeader";
            this.buttonIPHeader.Size = new System.Drawing.Size(240, 39);
            this.buttonIPHeader.TabIndex = 0;
            this.buttonIPHeader.Text = "HTTP Headers";
            this.buttonIPHeader.UseVisualStyleBackColor = true;
            this.buttonIPHeader.Click += new System.EventHandler(this.buttonIPHeader_Click);
            // 
            // buttonTraceRoute
            // 
            this.buttonTraceRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTraceRoute.FlatAppearance.BorderSize = 0;
            this.buttonTraceRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraceRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraceRoute.Location = new System.Drawing.Point(0, 39);
            this.buttonTraceRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTraceRoute.Name = "buttonTraceRoute";
            this.buttonTraceRoute.Size = new System.Drawing.Size(240, 39);
            this.buttonTraceRoute.TabIndex = 3;
            this.buttonTraceRoute.Text = "Trace Route";
            this.buttonTraceRoute.UseVisualStyleBackColor = true;
            this.buttonTraceRoute.Click += new System.EventHandler(this.buttonTraceRoute_Click);
            // 
            // buttonPing
            // 
            this.buttonPing.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPing.FlatAppearance.BorderSize = 0;
            this.buttonPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPing.Location = new System.Drawing.Point(0, 0);
            this.buttonPing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(240, 39);
            this.buttonPing.TabIndex = 2;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonNetwork
            // 
            this.buttonNetwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNetwork.FlatAppearance.BorderSize = 0;
            this.buttonNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNetwork.Image = ((System.Drawing.Image)(resources.GetObject("buttonNetwork.Image")));
            this.buttonNetwork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNetwork.Location = new System.Drawing.Point(0, 185);
            this.buttonNetwork.Margin = new System.Windows.Forms.Padding(51, 2, 3, 2);
            this.buttonNetwork.Name = "buttonNetwork";
            this.buttonNetwork.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonNetwork.Size = new System.Drawing.Size(240, 46);
            this.buttonNetwork.TabIndex = 2;
            this.buttonNetwork.Text = "Network";
            this.buttonNetwork.UseVisualStyleBackColor = true;
            this.buttonNetwork.Click += new System.EventHandler(this.buttonNetwork_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 185);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = null;
            this.pictureLogo.Location = new System.Drawing.Point(29, 11);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(184, 119);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // labelLogo
            // 
            this.labelLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelLogo.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(0, 130);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(240, 55);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Nettools";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(240, 70);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(980, 830);
            this.panelDesktop.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(9, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(84, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panelTitle.Controls.Add(this.panelWindowControl);
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(240, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(980, 70);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // panelWindowControl
            // 
            this.panelWindowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWindowControl.Controls.Add(this.buttonMinimizeWindow);
            this.panelWindowControl.Controls.Add(this.buttonMaximizeWindow);
            this.panelWindowControl.Controls.Add(this.buttonExitWindow);
            this.panelWindowControl.Location = new System.Drawing.Point(863, 12);
            this.panelWindowControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelWindowControl.Name = "panelWindowControl";
            this.panelWindowControl.Size = new System.Drawing.Size(107, 28);
            this.panelWindowControl.TabIndex = 1;
            // 
            // buttonMinimizeWindow
            // 
            this.buttonMinimizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizeWindow.Image")));
            this.buttonMinimizeWindow.Location = new System.Drawing.Point(0, 0);
            this.buttonMinimizeWindow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimizeWindow.Name = "buttonMinimizeWindow";
            this.buttonMinimizeWindow.Size = new System.Drawing.Size(39, 28);
            this.buttonMinimizeWindow.TabIndex = 2;
            this.buttonMinimizeWindow.UseVisualStyleBackColor = true;
            this.buttonMinimizeWindow.Click += new System.EventHandler(this.buttonMinimizeWindow_Click);
            // 
            // buttonMaximizeWindow
            // 
            this.buttonMaximizeWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.buttonMaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizeWindow.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximizeWindow.Image")));
            this.buttonMaximizeWindow.Location = new System.Drawing.Point(39, 0);
            this.buttonMaximizeWindow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMaximizeWindow.Name = "buttonMaximizeWindow";
            this.buttonMaximizeWindow.Size = new System.Drawing.Size(32, 28);
            this.buttonMaximizeWindow.TabIndex = 1;
            this.buttonMaximizeWindow.UseVisualStyleBackColor = true;
            this.buttonMaximizeWindow.Click += new System.EventHandler(this.buttonMaximizeWindow_Click);
            // 
            // buttonExitWindow
            // 
            this.buttonExitWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExitWindow.FlatAppearance.BorderSize = 0;
            this.buttonExitWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitWindow.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitWindow.Image")));
            this.buttonExitWindow.Location = new System.Drawing.Point(71, 0);
            this.buttonExitWindow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitWindow.Name = "buttonExitWindow";
            this.buttonExitWindow.Size = new System.Drawing.Size(36, 28);
            this.buttonExitWindow.TabIndex = 0;
            this.buttonExitWindow.UseVisualStyleBackColor = true;
            this.buttonExitWindow.Click += new System.EventHandler(this.buttonExitWindow_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1220, 900);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1198, 859);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetTools";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMisc.ResumeLayout(false);
            this.panelIPAddress.ResumeLayout(false);
            this.panelNetwork.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelWindowControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonNetwork;
        private System.Windows.Forms.Panel panelNetwork;
        private System.Windows.Forms.Button buttonTraceRoute;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonIPHeader;
        private System.Windows.Forms.Panel panelMisc;
        private System.Windows.Forms.Button buttonBinaryConverter;
        private System.Windows.Forms.Button buttonTextConversion;
        private System.Windows.Forms.Button buttonMisc;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelWindowControl;
        private System.Windows.Forms.Button buttonMinimizeWindow;
        private System.Windows.Forms.Button buttonMaximizeWindow;
        private System.Windows.Forms.Button buttonExitWindow;
        private System.Windows.Forms.Button buttonIPAddress;
        private System.Windows.Forms.Panel panelIPAddress;
        private System.Windows.Forms.Button buttonIPSubnetCalc;
        private System.Windows.Forms.Button buttonIPGeoLocation;
        private System.Windows.Forms.Button buttonIPScanner;
        private System.Windows.Forms.Button buttonMyIP;
        private System.Windows.Forms.Button buttonWhoIs;
    }
}

