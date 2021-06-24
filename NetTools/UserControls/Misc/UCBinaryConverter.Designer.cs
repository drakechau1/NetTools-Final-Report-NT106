
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.labelOutput3 = new System.Windows.Forms.Label();
            this.textOutput2 = new System.Windows.Forms.TextBox();
            this.textOutput3 = new System.Windows.Forms.TextBox();
            this.textOutput1 = new System.Windows.Forms.TextBox();
            this.checkboxDigitGrouping = new System.Windows.Forms.CheckBox();
            this.panelVisibal2 = new System.Windows.Forms.Panel();
            this.panelVisibal1 = new System.Windows.Forms.Panel();
            this.panelInvisibal = new System.Windows.Forms.Panel();
            this.panelInvisibal.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboxFrom
            // 
            this.comboxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxFrom.FormattingEnabled = true;
            this.comboxFrom.ItemHeight = 20;
            this.comboxFrom.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal"});
            this.comboxFrom.Location = new System.Drawing.Point(71, 79);
            this.comboxFrom.Name = "comboxFrom";
            this.comboxFrom.Size = new System.Drawing.Size(149, 28);
            this.comboxFrom.TabIndex = 0;
            this.comboxFrom.SelectedIndexChanged += new System.EventHandler(this.comboxFrom_SelectedIndexChanged);
            // 
            // comboxTo
            // 
            this.comboxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxTo.FormattingEnabled = true;
            this.comboxTo.Items.AddRange(new object[] {
            "Binary",
            "Decimal",
            "Hexadecimal"});
            this.comboxTo.Location = new System.Drawing.Point(297, 79);
            this.comboxTo.Name = "comboxTo";
            this.comboxTo.Size = new System.Drawing.Size(149, 28);
            this.comboxTo.TabIndex = 0;
            this.comboxTo.SelectedIndexChanged += new System.EventHandler(this.comboxTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNumber.Location = new System.Drawing.Point(67, 119);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(173, 20);
            this.labelEnterNumber.TabIndex = 1;
            this.labelEnterNumber.Text = "Enter decimal number";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(71, 213);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(117, 37);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(208, 213);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 37);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.FlatAppearance.BorderSize = 0;
            this.buttonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwap.Image = ((System.Drawing.Image)(resources.GetObject("buttonSwap.Image")));
            this.buttonSwap.Location = new System.Drawing.Point(226, 72);
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
            this.labelOutput1.Location = new System.Drawing.Point(67, 265);
            this.labelOutput1.Name = "labelOutput1";
            this.labelOutput1.Size = new System.Drawing.Size(109, 20);
            this.labelOutput1.TabIndex = 1;
            this.labelOutput1.Text = "lable output 1";
            // 
            // labelOutput2
            // 
            this.labelOutput2.AutoSize = true;
            this.labelOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput2.Location = new System.Drawing.Point(67, 395);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(109, 20);
            this.labelOutput2.TabIndex = 1;
            this.labelOutput2.Text = "lable output 2";
            // 
            // textInput
            // 
            this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.Location = new System.Drawing.Point(71, 142);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInput.Size = new System.Drawing.Size(841, 50);
            this.textInput.TabIndex = 4;
            // 
            // labelOutput3
            // 
            this.labelOutput3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput3.Location = new System.Drawing.Point(0, 0);
            this.labelOutput3.Name = "labelOutput3";
            this.labelOutput3.Padding = new System.Windows.Forms.Padding(71, 0, 0, 0);
            this.labelOutput3.Size = new System.Drawing.Size(980, 20);
            this.labelOutput3.TabIndex = 1;
            this.labelOutput3.Text = "lable output 3";
            // 
            // textOutput2
            // 
            this.textOutput2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutput2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textOutput2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput2.Location = new System.Drawing.Point(71, 418);
            this.textOutput2.Multiline = true;
            this.textOutput2.Name = "textOutput2";
            this.textOutput2.ReadOnly = true;
            this.textOutput2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput2.Size = new System.Drawing.Size(841, 100);
            this.textOutput2.TabIndex = 4;
            // 
            // textOutput3
            // 
            this.textOutput3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutput3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textOutput3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput3.Location = new System.Drawing.Point(71, 23);
            this.textOutput3.Multiline = true;
            this.textOutput3.Name = "textOutput3";
            this.textOutput3.ReadOnly = true;
            this.textOutput3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput3.Size = new System.Drawing.Size(841, 100);
            this.textOutput3.TabIndex = 4;
            // 
            // textOutput1
            // 
            this.textOutput1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutput1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textOutput1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput1.Location = new System.Drawing.Point(71, 288);
            this.textOutput1.Multiline = true;
            this.textOutput1.Name = "textOutput1";
            this.textOutput1.ReadOnly = true;
            this.textOutput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput1.Size = new System.Drawing.Size(841, 100);
            this.textOutput1.TabIndex = 4;
            // 
            // checkboxDigitGrouping
            // 
            this.checkboxDigitGrouping.AutoSize = true;
            this.checkboxDigitGrouping.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkboxDigitGrouping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxDigitGrouping.Location = new System.Drawing.Point(0, 666);
            this.checkboxDigitGrouping.Name = "checkboxDigitGrouping";
            this.checkboxDigitGrouping.Padding = new System.Windows.Forms.Padding(71, 0, 0, 0);
            this.checkboxDigitGrouping.Size = new System.Drawing.Size(980, 24);
            this.checkboxDigitGrouping.TabIndex = 5;
            this.checkboxDigitGrouping.Text = "Digit grouping";
            this.checkboxDigitGrouping.UseVisualStyleBackColor = true;
            // 
            // panelVisibal2
            // 
            this.panelVisibal2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVisibal2.Location = new System.Drawing.Point(0, 666);
            this.panelVisibal2.Name = "panelVisibal2";
            this.panelVisibal2.Size = new System.Drawing.Size(980, 163);
            this.panelVisibal2.TabIndex = 6;
            // 
            // panelVisibal1
            // 
            this.panelVisibal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVisibal1.Location = new System.Drawing.Point(0, 0);
            this.panelVisibal1.Name = "panelVisibal1";
            this.panelVisibal1.Size = new System.Drawing.Size(980, 526);
            this.panelVisibal1.TabIndex = 7;
            // 
            // panelInvisibal
            // 
            this.panelInvisibal.Controls.Add(this.textOutput3);
            this.panelInvisibal.Controls.Add(this.labelOutput3);
            this.panelInvisibal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInvisibal.Location = new System.Drawing.Point(0, 526);
            this.panelInvisibal.Name = "panelInvisibal";
            this.panelInvisibal.Size = new System.Drawing.Size(980, 140);
            this.panelInvisibal.TabIndex = 8;
            // 
            // UCBinaryConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.checkboxDigitGrouping);
            this.Controls.Add(this.panelVisibal2);
            this.Controls.Add(this.panelInvisibal);
            this.Controls.Add(this.textOutput2);
            this.Controls.Add(this.textOutput1);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelOutput2);
            this.Controls.Add(this.labelOutput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEnterNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboxTo);
            this.Controls.Add(this.comboxFrom);
            this.Controls.Add(this.panelVisibal1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCBinaryConverter";
            this.Size = new System.Drawing.Size(980, 829);
            this.Load += new System.EventHandler(this.UCBinaryConverter_Load);
            this.panelInvisibal.ResumeLayout(false);
            this.panelInvisibal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label labelOutput3;
        private System.Windows.Forms.TextBox textOutput2;
        private System.Windows.Forms.TextBox textOutput3;
        private System.Windows.Forms.TextBox textOutput1;
        private System.Windows.Forms.CheckBox checkboxDigitGrouping;
        private System.Windows.Forms.Panel panelVisibal2;
        private System.Windows.Forms.Panel panelVisibal1;
        private System.Windows.Forms.Panel panelInvisibal;
    }
}
