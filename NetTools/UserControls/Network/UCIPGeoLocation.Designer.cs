
namespace NetTools.UserControls.Network
{
    partial class UCIPGeoLocation
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.listViewGeoLocationInfo = new System.Windows.Forms.ListView();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIPAddress = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.panelSearchIP = new System.Windows.Forms.Panel();
            this.panelInfo.SuspendLayout();
            this.panelSearchIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.listViewGeoLocationInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfo.Location = new System.Drawing.Point(0, 113);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelInfo.Size = new System.Drawing.Size(980, 716);
            this.panelInfo.TabIndex = 1;
            // 
            // listViewGeoLocationInfo
            // 
            this.listViewGeoLocationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGeoLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGeoLocationInfo.HideSelection = false;
            this.listViewGeoLocationInfo.Location = new System.Drawing.Point(10, 0);
            this.listViewGeoLocationInfo.Name = "listViewGeoLocationInfo";
            this.listViewGeoLocationInfo.Size = new System.Drawing.Size(960, 706);
            this.listViewGeoLocationInfo.TabIndex = 0;
            this.listViewGeoLocationInfo.UseCompatibleStateImageBehavior = false;
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPAddress.Location = new System.Drawing.Point(71, 31);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(91, 20);
            this.labelIPAddress.TabIndex = 0;
            this.labelIPAddress.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Geo Location information provided by ip-api.com";
            // 
            // textIPAddress
            // 
            this.textIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIPAddress.Location = new System.Drawing.Point(187, 28);
            this.textIPAddress.MinimumSize = new System.Drawing.Size(300, 27);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(494, 27);
            this.textIPAddress.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGo.FlatAppearance.BorderSize = 0;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(712, 23);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 37);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
            // 
            // panelSearchIP
            // 
            this.panelSearchIP.AutoScroll = true;
            this.panelSearchIP.Controls.Add(this.buttonGo);
            this.panelSearchIP.Controls.Add(this.textIPAddress);
            this.panelSearchIP.Controls.Add(this.label2);
            this.panelSearchIP.Controls.Add(this.labelIPAddress);
            this.panelSearchIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearchIP.Location = new System.Drawing.Point(0, 0);
            this.panelSearchIP.Name = "panelSearchIP";
            this.panelSearchIP.Size = new System.Drawing.Size(980, 113);
            this.panelSearchIP.TabIndex = 0;
            // 
            // UCIPGeoLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelSearchIP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCIPGeoLocation";
            this.Size = new System.Drawing.Size(980, 829);
            this.panelInfo.ResumeLayout(false);
            this.panelSearchIP.ResumeLayout(false);
            this.panelSearchIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ListView listViewGeoLocationInfo;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIPAddress;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Panel panelSearchIP;
    }
}
