namespace NetTools.UserControls.IPAddress
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textDomain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.listViewGeoLocationInfo = new System.Windows.Forms.ListView();
            this.panelControl.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonGo);
            this.panelControl.Controls.Add(this.textDomain);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelControl.Size = new System.Drawing.Size(980, 100);
            this.panelControl.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(758, 22);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 37);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textDomain
            // 
            this.textDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDomain.Location = new System.Drawing.Point(205, 27);
            this.textDomain.Name = "textDomain";
            this.textDomain.Size = new System.Drawing.Size(547, 27);
            this.textDomain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Geo Location information provided bu ip-api.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain/IPAddress";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.listViewGeoLocationInfo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(0, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panelDesktop.Size = new System.Drawing.Size(980, 730);
            this.panelDesktop.TabIndex = 1;
            // 
            // listViewGeoLocationInfo
            // 
            this.listViewGeoLocationInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewGeoLocationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewGeoLocationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGeoLocationInfo.HideSelection = false;
            this.listViewGeoLocationInfo.Location = new System.Drawing.Point(50, 0);
            this.listViewGeoLocationInfo.Name = "listViewGeoLocationInfo";
            this.listViewGeoLocationInfo.Size = new System.Drawing.Size(880, 700);
            this.listViewGeoLocationInfo.TabIndex = 3;
            this.listViewGeoLocationInfo.UseCompatibleStateImageBehavior = false;
            // 
            // UCIPGeoLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelControl);
            this.Name = "UCIPGeoLocation";
            this.Size = new System.Drawing.Size(980, 830);
            this.Load += new System.EventHandler(this.UCIPGeoLocation_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewGeoLocationInfo;
    }
}
