
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "TraceRoute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addresslist
            // 
            this.addresslist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addresslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslist.Location = new System.Drawing.Point(232, 45);
            this.addresslist.Margin = new System.Windows.Forms.Padding(4);
            this.addresslist.Name = "addresslist";
            this.addresslist.Size = new System.Drawing.Size(597, 27);
            this.addresslist.TabIndex = 1;
            this.addresslist.Text = "\r\n\r\n";
            // 
            // TraceRoute
            // 
            this.TraceRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TraceRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraceRoute.FormattingEnabled = true;
            this.TraceRoute.ItemHeight = 20;
            this.TraceRoute.Location = new System.Drawing.Point(17, 110);
            this.TraceRoute.Margin = new System.Windows.Forms.Padding(4);
            this.TraceRoute.Name = "TraceRoute";
            this.TraceRoute.Size = new System.Drawing.Size(946, 704);
            this.TraceRoute.TabIndex = 2;
            // 
            // UCTraceRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TraceRoute);
            this.Controls.Add(this.addresslist);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTraceRoute";
            this.Size = new System.Drawing.Size(980, 830);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addresslist;
        private System.Windows.Forms.ListBox TraceRoute;
    }
}
