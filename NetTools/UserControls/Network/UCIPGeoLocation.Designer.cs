﻿
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Status");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Continent");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Continent Code");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Country");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Country Code");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Region Code");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Region Name");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("City");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("District");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Zip Code");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Latitude");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Longitude");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Time Zone");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Offset");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Currency");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("ISP Name");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Organization Name");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("AS Number");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("AS Name");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Reverse DNS");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Mobile");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Proxy");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Hosting");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("IP Address");
            this.panelInfo = new System.Windows.Forms.Panel();
            this.listViewGeoLocationInfo = new System.Windows.Forms.ListView();
            this.columnField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.listViewGeoLocationInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewGeoLocationInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnField,
            this.columnValue});
            this.listViewGeoLocationInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewGeoLocationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGeoLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGeoLocationInfo.FullRowSelect = true;
            this.listViewGeoLocationInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewGeoLocationInfo.HideSelection = false;
            this.listViewGeoLocationInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24});
            this.listViewGeoLocationInfo.Location = new System.Drawing.Point(10, 0);
            this.listViewGeoLocationInfo.Name = "listViewGeoLocationInfo";
            this.listViewGeoLocationInfo.Size = new System.Drawing.Size(960, 706);
            this.listViewGeoLocationInfo.TabIndex = 0;
            this.listViewGeoLocationInfo.TileSize = new System.Drawing.Size(500, 44);
            this.listViewGeoLocationInfo.UseCompatibleStateImageBehavior = false;
            this.listViewGeoLocationInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnField
            // 
            this.columnField.Text = "Field";
            this.columnField.Width = 246;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Value";
            this.columnValue.Width = 262;
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPAddress.Location = new System.Drawing.Point(93, 37);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(149, 20);
            this.labelIPAddress.TabIndex = 0;
            this.labelIPAddress.Text = "Domain/IPAddress";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Geo Location information provided by ip-api.com";
            // 
            // textIPAddress
            // 
            this.textIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIPAddress.Location = new System.Drawing.Point(248, 34);
            this.textIPAddress.MinimumSize = new System.Drawing.Size(528, 27);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(528, 27);
            this.textIPAddress.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.buttonGo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonGo.FlatAppearance.BorderSize = 0;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(782, 29);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 37);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
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
            this.Load += new System.EventHandler(this.UCIPGeoLocation_Load);
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
        private System.Windows.Forms.ColumnHeader columnField;
        private System.Windows.Forms.ColumnHeader columnValue;
    }
}
