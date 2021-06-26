
namespace NetTools.UserControls.Network
{
    partial class UCWhoIs
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
            this.panelInput = new System.Windows.Forms.Panel();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.panelInfor = new System.Windows.Forms.Panel();
            this.richTextInfomation = new System.Windows.Forms.RichTextBox();
            this.panelInput.SuspendLayout();
            this.panelInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.buttonGo);
            this.panelInput.Controls.Add(this.textIPAddress);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.labelIPAddress);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelInput.Size = new System.Drawing.Size(980, 100);
            this.panelInput.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonGo.FlatAppearance.BorderSize = 0;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(758, 22);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 37);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textIPAddress
            // 
            this.textIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIPAddress.Location = new System.Drawing.Point(205, 27);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(547, 27);
            this.textIPAddress.TabIndex = 1;
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
            this.label2.Size = new System.Drawing.Size(370, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "WhoIs information provided by whois.whoisxmlapi.com";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPAddress.Location = new System.Drawing.Point(50, 30);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(149, 20);
            this.labelIPAddress.TabIndex = 4;
            this.labelIPAddress.Text = "Domain/IPAddress";
            // 
            // panelInfor
            // 
            this.panelInfor.Controls.Add(this.richTextInfomation);
            this.panelInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfor.Location = new System.Drawing.Point(0, 100);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panelInfor.Size = new System.Drawing.Size(980, 729);
            this.panelInfor.TabIndex = 2;
            // 
            // richTextInfomation
            // 
            this.richTextInfomation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextInfomation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextInfomation.Location = new System.Drawing.Point(50, 0);
            this.richTextInfomation.Name = "richTextInfomation";
            this.richTextInfomation.ReadOnly = true;
            this.richTextInfomation.Size = new System.Drawing.Size(880, 699);
            this.richTextInfomation.TabIndex = 0;
            this.richTextInfomation.Text = "";
            // 
            // UCWhoIs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelInfor);
            this.Controls.Add(this.panelInput);
            this.Name = "UCWhoIs";
            this.Size = new System.Drawing.Size(980, 829);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelInfor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelInfor;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.RichTextBox richTextInfomation;
    }
}
