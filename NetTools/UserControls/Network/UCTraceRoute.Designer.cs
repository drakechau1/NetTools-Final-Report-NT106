
namespace NetTools.UserControls.Network
{
    partial class UCTraceRoute
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
            this.button1 = new System.Windows.Forms.Button();
            this.addresslist = new System.Windows.Forms.TextBox();
            this.TraceRoute = new System.Windows.Forms.ListBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(717, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "TraceRoute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addresslist
            // 
            this.addresslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslist.Location = new System.Drawing.Point(134, 31);
            this.addresslist.Margin = new System.Windows.Forms.Padding(4);
            this.addresslist.Name = "addresslist";
            this.addresslist.Size = new System.Drawing.Size(566, 30);
            this.addresslist.TabIndex = 2;
            this.addresslist.Text = "\r\n\r\n";
            // 
            // TraceRoute
            // 
            this.TraceRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TraceRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraceRoute.FormattingEnabled = true;
            this.TraceRoute.ItemHeight = 25;
            this.TraceRoute.Location = new System.Drawing.Point(10, 0);
            this.TraceRoute.Margin = new System.Windows.Forms.Padding(4);
            this.TraceRoute.Name = "TraceRoute";
            this.TraceRoute.Size = new System.Drawing.Size(960, 707);
            this.TraceRoute.TabIndex = 0;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.addresslist);
            this.panelControl.Controls.Add(this.button1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(980, 113);
            this.panelControl.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.TraceRoute);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(0, 113);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelDesktop.Size = new System.Drawing.Size(980, 717);
            this.panelDesktop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Example: https://www.google.com/";
            // 
            // UCTraceRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTraceRoute";
            this.Size = new System.Drawing.Size(980, 830);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addresslist;
        private System.Windows.Forms.ListBox TraceRoute;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
