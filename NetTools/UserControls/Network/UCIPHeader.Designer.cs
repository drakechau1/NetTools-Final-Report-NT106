
namespace NetTools.UserControls.Network
{
    partial class UCIPHeader
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
            this.checkboxAllowRedirects = new System.Windows.Forms.CheckBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.richtextHTTPHeaders = new System.Windows.Forms.RichTextBox();
            this.panelControl.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.checkboxAllowRedirects);
            this.panelControl.Controls.Add(this.buttonGo);
            this.panelControl.Controls.Add(this.txtDomain);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelControl.Size = new System.Drawing.Size(980, 100);
            this.panelControl.TabIndex = 0;
            // 
            // checkboxAllowRedirects
            // 
            this.checkboxAllowRedirects.AutoSize = true;
            this.checkboxAllowRedirects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAllowRedirects.Location = new System.Drawing.Point(162, 60);
            this.checkboxAllowRedirects.Name = "checkboxAllowRedirects";
            this.checkboxAllowRedirects.Size = new System.Drawing.Size(142, 24);
            this.checkboxAllowRedirects.TabIndex = 2;
            this.checkboxAllowRedirects.Text = "Allow redirects";
            this.checkboxAllowRedirects.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGo.FlatAppearance.BorderSize = 0;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(709, 23);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 35);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.Location = new System.Drawing.Point(162, 27);
            this.txtDomain.MinimumSize = new System.Drawing.Size(528, 27);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(541, 27);
            this.txtDomain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL/Domain";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.richtextHTTPHeaders);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(0, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panelDesktop.Size = new System.Drawing.Size(980, 729);
            this.panelDesktop.TabIndex = 1;
            // 
            // richtextHTTPHeaders
            // 
            this.richtextHTTPHeaders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextHTTPHeaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextHTTPHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtextHTTPHeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextHTTPHeaders.Location = new System.Drawing.Point(50, 0);
            this.richtextHTTPHeaders.Name = "richtextHTTPHeaders";
            this.richtextHTTPHeaders.ReadOnly = true;
            this.richtextHTTPHeaders.Size = new System.Drawing.Size(880, 699);
            this.richtextHTTPHeaders.TabIndex = 0;
            this.richtextHTTPHeaders.Text = "";
            // 
            // UCIPHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCIPHeader";
            this.Size = new System.Drawing.Size(980, 829);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.CheckBox checkboxAllowRedirects;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtextHTTPHeaders;
    }
}
