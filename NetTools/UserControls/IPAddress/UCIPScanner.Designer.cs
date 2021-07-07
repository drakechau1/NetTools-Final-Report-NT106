
namespace NetTools.UserControls.IPAddress
{
    partial class UCIPScanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIPSubnet = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listviewInfor = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalDevice = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            // 
            // textIPSubnet
            // 
            this.textIPSubnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIPSubnet.Location = new System.Drawing.Point(117, 27);
            this.textIPSubnet.Name = "textIPSubnet";
            this.textIPSubnet.Size = new System.Drawing.Size(272, 27);
            this.textIPSubnet.TabIndex = 1;
            this.textIPSubnet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textIPSubnet_KeyDown);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelStatus.Location = new System.Drawing.Point(118, 83);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(55, 20);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "status";
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScan.Location = new System.Drawing.Point(395, 22);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(75, 37);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(476, 22);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 37);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonScan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textIPSubnet);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panel1.Size = new System.Drawing.Size(980, 154);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listviewInfor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 0, 50, 3);
            this.panel2.Size = new System.Drawing.Size(980, 436);
            this.panel2.TabIndex = 4;
            // 
            // listviewInfor
            // 
            this.listviewInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewInfor.HideSelection = false;
            this.listviewInfor.Location = new System.Drawing.Point(50, 0);
            this.listviewInfor.Name = "listviewInfor";
            this.listviewInfor.Size = new System.Drawing.Size(880, 433);
            this.listviewInfor.TabIndex = 0;
            this.listviewInfor.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTotalDevice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 240);
            this.panel3.TabIndex = 1;
            // 
            // labelTotalDevice
            // 
            this.labelTotalDevice.AutoSize = true;
            this.labelTotalDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDevice.Location = new System.Drawing.Point(46, 19);
            this.labelTotalDevice.Name = "labelTotalDevice";
            this.labelTotalDevice.Size = new System.Drawing.Size(104, 20);
            this.labelTotalDevice.TabIndex = 0;
            this.labelTotalDevice.Text = "Total device:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(50, 115);
            this.progressBar.Maximum = 254;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(880, 25);
            this.progressBar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Example: 192.168.1";
            // 
            // UCIPScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCIPScanner";
            this.Size = new System.Drawing.Size(980, 830);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIPSubnet;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listviewInfor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotalDevice;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
    }
}
