
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
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Status");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Continent");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("Continent Code");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("Country");
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem("Country Code");
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem("Region Code");
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("Region Name");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("City");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("District");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("Zip Code");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("Latitude");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("Longitude");
            System.Windows.Forms.ListViewItem listViewItem37 = new System.Windows.Forms.ListViewItem("Time Zone");
            System.Windows.Forms.ListViewItem listViewItem38 = new System.Windows.Forms.ListViewItem("Offset");
            System.Windows.Forms.ListViewItem listViewItem39 = new System.Windows.Forms.ListViewItem("Currency");
            System.Windows.Forms.ListViewItem listViewItem40 = new System.Windows.Forms.ListViewItem("ISP Name");
            System.Windows.Forms.ListViewItem listViewItem41 = new System.Windows.Forms.ListViewItem("Organization Name");
            System.Windows.Forms.ListViewItem listViewItem42 = new System.Windows.Forms.ListViewItem("AS Number");
            System.Windows.Forms.ListViewItem listViewItem43 = new System.Windows.Forms.ListViewItem("AS Name");
            System.Windows.Forms.ListViewItem listViewItem44 = new System.Windows.Forms.ListViewItem("Reverse DNS");
            System.Windows.Forms.ListViewItem listViewItem45 = new System.Windows.Forms.ListViewItem("Mobile");
            System.Windows.Forms.ListViewItem listViewItem46 = new System.Windows.Forms.ListViewItem("Proxy");
            System.Windows.Forms.ListViewItem listViewItem47 = new System.Windows.Forms.ListViewItem("Hosting");
            System.Windows.Forms.ListViewItem listViewItem48 = new System.Windows.Forms.ListViewItem("IP Address");
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
            this.panelInfo.Location = new System.Drawing.Point(0, 100);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panelInfo.Size = new System.Drawing.Size(980, 729);
            this.panelInfo.TabIndex = 1;
            // 
            // listViewGeoLocationInfo
            // 
            this.listViewGeoLocationInfo.BackColor = System.Drawing.Color.WhiteSmoke;
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
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36,
            listViewItem37,
            listViewItem38,
            listViewItem39,
            listViewItem40,
            listViewItem41,
            listViewItem42,
            listViewItem43,
            listViewItem44,
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48});
            this.listViewGeoLocationInfo.Location = new System.Drawing.Point(50, 0);
            this.listViewGeoLocationInfo.Name = "listViewGeoLocationInfo";
            this.listViewGeoLocationInfo.Size = new System.Drawing.Size(880, 699);
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
            this.labelIPAddress.Location = new System.Drawing.Point(50, 30);
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
            this.label2.Location = new System.Drawing.Point(202, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Geo Location information provided by ip-api.com";
            // 
            // textIPAddress
            // 
            this.textIPAddress.BackColor = System.Drawing.SystemColors.Window;
            this.textIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIPAddress.Location = new System.Drawing.Point(205, 27);
            this.textIPAddress.MinimumSize = new System.Drawing.Size(528, 27);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(528, 27);
            this.textIPAddress.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonGo.FlatAppearance.BorderSize = 0;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(739, 22);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 37);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // panelSearchIP
            // 
            this.panelSearchIP.Controls.Add(this.buttonGo);
            this.panelSearchIP.Controls.Add(this.label2);
            this.panelSearchIP.Controls.Add(this.labelIPAddress);
            this.panelSearchIP.Controls.Add(this.textIPAddress);
            this.panelSearchIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearchIP.Location = new System.Drawing.Point(0, 0);
            this.panelSearchIP.Name = "panelSearchIP";
            this.panelSearchIP.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelSearchIP.Size = new System.Drawing.Size(980, 100);
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
