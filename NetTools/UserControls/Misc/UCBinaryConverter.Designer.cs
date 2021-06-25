
namespace NetTools.UserControls.Misc
{
    partial class UCBinaryConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBinaryConverter));
            this.comboxFrom = new System.Windows.Forms.ComboBox();
            this.comboxTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEnterNumber = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.labelOutput1 = new System.Windows.Forms.Label();
            this.labelOutput2 = new System.Windows.Forms.Label();
            this.labelOutput3 = new System.Windows.Forms.Label();
            this.checkboxDigitGrouping = new System.Windows.Forms.CheckBox();
            this.panelVisibal1 = new System.Windows.Forms.Panel();
            this.richtextOutput2 = new System.Windows.Forms.RichTextBox();
            this.richtextOutput1 = new System.Windows.Forms.RichTextBox();
            this.richtextInput = new System.Windows.Forms.RichTextBox();
            this.panelInvisibal = new System.Windows.Forms.Panel();
            this.richtextOutput3 = new System.Windows.Forms.RichTextBox();
            this.panelVisibal1.SuspendLayout();
            this.panelInvisibal.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboxFrom
            // 
            this.comboxFrom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboxFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxFrom.FormattingEnabled = true;
            this.comboxFrom.ItemHeight = 20;
            this.comboxFrom.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal"});
            this.comboxFrom.Location = new System.Drawing.Point(47, 63);
            this.comboxFrom.Name = "comboxFrom";
            this.comboxFrom.Size = new System.Drawing.Size(174, 28);
            this.comboxFrom.TabIndex = 0;
            this.comboxFrom.SelectedIndexChanged += new System.EventHandler(this.comboxFrom_SelectedIndexChanged);
            // 
            // comboxTo
            // 
            this.comboxTo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboxTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxTo.FormattingEnabled = true;
            this.comboxTo.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal"});
            this.comboxTo.Location = new System.Drawing.Point(298, 63);
            this.comboxTo.Name = "comboxTo";
            this.comboxTo.Size = new System.Drawing.Size(174, 28);
            this.comboxTo.TabIndex = 0;
            this.comboxTo.SelectedIndexChanged += new System.EventHandler(this.comboxTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNumber.Location = new System.Drawing.Point(43, 101);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(173, 20);
            this.labelEnterNumber.TabIndex = 1;
            this.labelEnterNumber.Text = "Enter decimal number";
            // 
            // buttonConvert
            // 
            this.buttonConvert.FlatAppearance.BorderSize = 0;
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Image = ((System.Drawing.Image)(resources.GetObject("buttonConvert.Image")));
            this.buttonConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConvert.Location = new System.Drawing.Point(47, 247);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(117, 37);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "     Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(161, 247);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(108, 37);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "     Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.FlatAppearance.BorderSize = 0;
            this.buttonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwap.Image = ((System.Drawing.Image)(resources.GetObject("buttonSwap.Image")));
            this.buttonSwap.Location = new System.Drawing.Point(227, 54);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(65, 44);
            this.buttonSwap.TabIndex = 3;
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // labelOutput1
            // 
            this.labelOutput1.AutoSize = true;
            this.labelOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput1.Location = new System.Drawing.Point(43, 341);
            this.labelOutput1.Name = "labelOutput1";
            this.labelOutput1.Size = new System.Drawing.Size(109, 20);
            this.labelOutput1.TabIndex = 1;
            this.labelOutput1.Text = "lable output 1";
            // 
            // labelOutput2
            // 
            this.labelOutput2.AutoSize = true;
            this.labelOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput2.Location = new System.Drawing.Point(43, 492);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(109, 20);
            this.labelOutput2.TabIndex = 1;
            this.labelOutput2.Text = "lable output 2";
            // 
            // labelOutput3
            // 
            this.labelOutput3.AutoSize = true;
            this.labelOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput3.Location = new System.Drawing.Point(46, 2);
            this.labelOutput3.Name = "labelOutput3";
            this.labelOutput3.Size = new System.Drawing.Size(109, 20);
            this.labelOutput3.TabIndex = 1;
            this.labelOutput3.Text = "lable output 3";
            // 
            // checkboxDigitGrouping
            // 
            this.checkboxDigitGrouping.AutoSize = true;
            this.checkboxDigitGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxDigitGrouping.Location = new System.Drawing.Point(47, 306);
            this.checkboxDigitGrouping.Name = "checkboxDigitGrouping";
            this.checkboxDigitGrouping.Size = new System.Drawing.Size(135, 24);
            this.checkboxDigitGrouping.TabIndex = 5;
            this.checkboxDigitGrouping.Text = "Digit grouping";
            this.checkboxDigitGrouping.UseVisualStyleBackColor = true;
            this.checkboxDigitGrouping.CheckedChanged += new System.EventHandler(this.checkboxDigitGrouping_CheckedChanged);
            // 
            // panelVisibal1
            // 
            this.panelVisibal1.Controls.Add(this.checkboxDigitGrouping);
            this.panelVisibal1.Controls.Add(this.richtextOutput2);
            this.panelVisibal1.Controls.Add(this.richtextOutput1);
            this.panelVisibal1.Controls.Add(this.richtextInput);
            this.panelVisibal1.Controls.Add(this.labelEnterNumber);
            this.panelVisibal1.Controls.Add(this.comboxFrom);
            this.panelVisibal1.Controls.Add(this.buttonReset);
            this.panelVisibal1.Controls.Add(this.buttonSwap);
            this.panelVisibal1.Controls.Add(this.buttonConvert);
            this.panelVisibal1.Controls.Add(this.labelOutput2);
            this.panelVisibal1.Controls.Add(this.comboxTo);
            this.panelVisibal1.Controls.Add(this.labelOutput1);
            this.panelVisibal1.Controls.Add(this.label1);
            this.panelVisibal1.Controls.Add(this.label2);
            this.panelVisibal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVisibal1.Location = new System.Drawing.Point(0, 0);
            this.panelVisibal1.Name = "panelVisibal1";
            this.panelVisibal1.Padding = new System.Windows.Forms.Padding(50, 40, 50, 0);
            this.panelVisibal1.Size = new System.Drawing.Size(980, 644);
            this.panelVisibal1.TabIndex = 7;
            // 
            // richtextOutput2
            // 
            this.richtextOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextOutput2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextOutput2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextOutput2.Location = new System.Drawing.Point(47, 515);
            this.richtextOutput2.Name = "richtextOutput2";
            this.richtextOutput2.Size = new System.Drawing.Size(880, 125);
            this.richtextOutput2.TabIndex = 5;
            this.richtextOutput2.Text = "";
            // 
            // richtextOutput1
            // 
            this.richtextOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextOutput1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextOutput1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextOutput1.Location = new System.Drawing.Point(47, 364);
            this.richtextOutput1.Name = "richtextOutput1";
            this.richtextOutput1.Size = new System.Drawing.Size(880, 125);
            this.richtextOutput1.TabIndex = 4;
            this.richtextOutput1.Text = "";
            // 
            // richtextInput
            // 
            this.richtextInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextInput.Location = new System.Drawing.Point(47, 124);
            this.richtextInput.Name = "richtextInput";
            this.richtextInput.Size = new System.Drawing.Size(883, 100);
            this.richtextInput.TabIndex = 0;
            this.richtextInput.Text = "";
            // 
            // panelInvisibal
            // 
            this.panelInvisibal.Controls.Add(this.richtextOutput3);
            this.panelInvisibal.Controls.Add(this.labelOutput3);
            this.panelInvisibal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInvisibal.Location = new System.Drawing.Point(0, 644);
            this.panelInvisibal.Name = "panelInvisibal";
            this.panelInvisibal.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelInvisibal.Size = new System.Drawing.Size(980, 185);
            this.panelInvisibal.TabIndex = 8;
            // 
            // richtextOutput3
            // 
            this.richtextOutput3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextOutput3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextOutput3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextOutput3.Location = new System.Drawing.Point(47, 25);
            this.richtextOutput3.Name = "richtextOutput3";
            this.richtextOutput3.Size = new System.Drawing.Size(880, 125);
            this.richtextOutput3.TabIndex = 6;
            this.richtextOutput3.Text = "";
            // 
            // UCBinaryConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelInvisibal);
            this.Controls.Add(this.panelVisibal1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCBinaryConverter";
            this.Size = new System.Drawing.Size(980, 829);
            this.panelVisibal1.ResumeLayout(false);
            this.panelVisibal1.PerformLayout();
            this.panelInvisibal.ResumeLayout(false);
            this.panelInvisibal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxFrom;
        private System.Windows.Forms.ComboBox comboxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEnterNumber;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Label labelOutput1;
        private System.Windows.Forms.Label labelOutput2;
        private System.Windows.Forms.Label labelOutput3;
        private System.Windows.Forms.CheckBox checkboxDigitGrouping;
        private System.Windows.Forms.Panel panelVisibal1;
        private System.Windows.Forms.Panel panelInvisibal;
        private System.Windows.Forms.RichTextBox richtextInput;
        private System.Windows.Forms.RichTextBox richtextOutput2;
        private System.Windows.Forms.RichTextBox richtextOutput1;
        private System.Windows.Forms.RichTextBox richtextOutput3;
    }
}
