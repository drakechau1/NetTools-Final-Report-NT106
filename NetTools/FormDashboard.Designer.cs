
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
            this.buttonSIDConverter = new System.Windows.Forms.Button();
            this.buttonBinaryConverter = new System.Windows.Forms.Button();
            this.buttonBase64 = new System.Windows.Forms.Button();
            this.buttonMisc = new System.Windows.Forms.Button();
            this.panelNetwork = new System.Windows.Forms.Panel();
            this.buttonTraceRoute = new System.Windows.Forms.Button();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonIPGeoLocation = new System.Windows.Forms.Button();
            this.buttonIPHeader = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.panelNetwork);
            this.panelMenu.Controls.Add(this.buttonNetwork);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 900);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetting.Image")));
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(0, 558);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonSetting.Size = new System.Drawing.Size(220, 46);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // panelMisc
            // 
            this.panelMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panelMisc.Controls.Add(this.buttonSIDConverter);
            this.panelMisc.Controls.Add(this.buttonBinaryConverter);
            this.panelMisc.Controls.Add(this.buttonBase64);
            this.panelMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMisc.Location = new System.Drawing.Point(0, 437);
            this.panelMisc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMisc.Name = "panelMisc";
            this.panelMisc.Size = new System.Drawing.Size(220, 121);
            this.panelMisc.TabIndex = 5;
            // 
            // buttonSIDConverter
            // 
            this.buttonSIDConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSIDConverter.FlatAppearance.BorderSize = 0;
            this.buttonSIDConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSIDConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSIDConverter.Location = new System.Drawing.Point(0, 78);
            this.buttonSIDConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSIDConverter.Name = "buttonSIDConverter";
            this.buttonSIDConverter.Size = new System.Drawing.Size(220, 39);
            this.buttonSIDConverter.TabIndex = 3;
            this.buttonSIDConverter.Text = "SID Converter";
            this.buttonSIDConverter.UseVisualStyleBackColor = true;
            this.buttonSIDConverter.Click += new System.EventHandler(this.buttonSIDConverter_Click);
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
            this.buttonBinaryConverter.Size = new System.Drawing.Size(220, 39);
            this.buttonBinaryConverter.TabIndex = 2;
            this.buttonBinaryConverter.Text = "Binary Converter";
            this.buttonBinaryConverter.UseVisualStyleBackColor = true;
            this.buttonBinaryConverter.Click += new System.EventHandler(this.buttonBinaryConverter_Click);
            // 
            // buttonBase64
            // 
            this.buttonBase64.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBase64.FlatAppearance.BorderSize = 0;
            this.buttonBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBase64.Location = new System.Drawing.Point(0, 0);
            this.buttonBase64.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBase64.Name = "buttonBase64";
            this.buttonBase64.Size = new System.Drawing.Size(220, 39);
            this.buttonBase64.TabIndex = 1;
            this.buttonBase64.Text = "Base64";
            this.buttonBase64.UseVisualStyleBackColor = true;
            this.buttonBase64.Click += new System.EventHandler(this.buttonBase64_Click);
            // 
            // buttonMisc
            // 
            this.buttonMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMisc.FlatAppearance.BorderSize = 0;
            this.buttonMisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMisc.Image = ((System.Drawing.Image)(resources.GetObject("buttonMisc.Image")));
            this.buttonMisc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMisc.Location = new System.Drawing.Point(0, 391);
            this.buttonMisc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMisc.Name = "buttonMisc";
            this.buttonMisc.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonMisc.Size = new System.Drawing.Size(220, 46);
            this.buttonMisc.TabIndex = 4;
            this.buttonMisc.Text = "Misc";
            this.buttonMisc.UseVisualStyleBackColor = true;
            this.buttonMisc.Click += new System.EventHandler(this.buttonMisc_Click);
            // 
            // panelNetwork
            // 
            this.panelNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panelNetwork.Controls.Add(this.buttonTraceRoute);
            this.panelNetwork.Controls.Add(this.buttonPing);
            this.panelNetwork.Controls.Add(this.buttonIPGeoLocation);
            this.panelNetwork.Controls.Add(this.buttonIPHeader);
            this.panelNetwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNetwork.Location = new System.Drawing.Point(0, 231);
            this.panelNetwork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNetwork.Name = "panelNetwork";
            this.panelNetwork.Size = new System.Drawing.Size(220, 160);
            this.panelNetwork.TabIndex = 3;
            // 
            // buttonTraceRoute
            // 
            this.buttonTraceRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTraceRoute.FlatAppearance.BorderSize = 0;
            this.buttonTraceRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTraceRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTraceRoute.Location = new System.Drawing.Point(0, 117);
            this.buttonTraceRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTraceRoute.Name = "buttonTraceRoute";
            this.buttonTraceRoute.Size = new System.Drawing.Size(220, 39);
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
            this.buttonPing.Location = new System.Drawing.Point(0, 78);
            this.buttonPing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(220, 39);
            this.buttonPing.TabIndex = 2;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonIPGeoLocation
            // 
            this.buttonIPGeoLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPGeoLocation.FlatAppearance.BorderSize = 0;
            this.buttonIPGeoLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPGeoLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPGeoLocation.Location = new System.Drawing.Point(0, 39);
            this.buttonIPGeoLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIPGeoLocation.Name = "buttonIPGeoLocation";
            this.buttonIPGeoLocation.Size = new System.Drawing.Size(220, 39);
            this.buttonIPGeoLocation.TabIndex = 1;
            this.buttonIPGeoLocation.Text = "IP Geo Location";
            this.buttonIPGeoLocation.UseVisualStyleBackColor = true;
            this.buttonIPGeoLocation.Click += new System.EventHandler(this.buttonIPGeoLocation_Click);
            // 
            // buttonIPHeader
            // 
            this.buttonIPHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIPHeader.FlatAppearance.BorderSize = 0;
            this.buttonIPHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPHeader.Location = new System.Drawing.Point(0, 0);
            this.buttonIPHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIPHeader.Name = "buttonIPHeader";
            this.buttonIPHeader.Size = new System.Drawing.Size(220, 39);
            this.buttonIPHeader.TabIndex = 0;
            this.buttonIPHeader.Text = "IP Header";
            this.buttonIPHeader.UseVisualStyleBackColor = true;
            this.buttonIPHeader.Click += new System.EventHandler(this.buttonIPHeader_Click);
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
            this.buttonNetwork.Size = new System.Drawing.Size(220, 46);
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
            this.panelLogo.Size = new System.Drawing.Size(220, 185);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.InitialImage = null;
            this.pictureLogo.Location = new System.Drawing.Point(19, 11);
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
            this.labelLogo.Size = new System.Drawing.Size(220, 55);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Nettools";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(220, 71);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(980, 829);
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
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(980, 71);
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
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1198, 859);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetTools";
            this.panelMenu.ResumeLayout(false);
            this.panelMisc.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonIPGeoLocation;
        private System.Windows.Forms.Button buttonIPHeader;
        private System.Windows.Forms.Panel panelMisc;
        private System.Windows.Forms.Button buttonSIDConverter;
        private System.Windows.Forms.Button buttonBinaryConverter;
        private System.Windows.Forms.Button buttonBase64;
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
    }
}

