
namespace NetTools.UserControls.Misc
{
    partial class UCTextConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTextConversion));
            this.panelInput = new System.Windows.Forms.Panel();
            this.checkboxDigitGrouping = new System.Windows.Forms.CheckBox();
            this.labelTextLength = new System.Windows.Forms.Label();
            this.richtextInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxCharacterEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.comboxBase64Option = new System.Windows.Forms.ComboBox();
            this.richtextBase64 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richtextBinary = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richtextHex = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelChecksum = new System.Windows.Forms.Panel();
            this.richtextChecksum = new System.Windows.Forms.RichTextBox();
            this.comboxChecksumType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.panelChecksum.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.checkboxDigitGrouping);
            this.panelInput.Controls.Add(this.labelTextLength);
            this.panelInput.Controls.Add(this.richtextInput);
            this.panelInput.Controls.Add(this.label2);
            this.panelInput.Controls.Add(this.comboxCharacterEncoding);
            this.panelInput.Controls.Add(this.label1);
            this.panelInput.Controls.Add(this.buttonReset);
            this.panelInput.Controls.Add(this.buttonConvert);
            this.panelInput.Controls.Add(this.buttonOpenFile);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelInput.Size = new System.Drawing.Size(980, 318);
            this.panelInput.TabIndex = 0;
            // 
            // checkboxDigitGrouping
            // 
            this.checkboxDigitGrouping.AutoSize = true;
            this.checkboxDigitGrouping.Location = new System.Drawing.Point(50, 288);
            this.checkboxDigitGrouping.Name = "checkboxDigitGrouping";
            this.checkboxDigitGrouping.Size = new System.Drawing.Size(135, 24);
            this.checkboxDigitGrouping.TabIndex = 6;
            this.checkboxDigitGrouping.Text = "Digit grouping";
            this.checkboxDigitGrouping.UseVisualStyleBackColor = true;
            this.checkboxDigitGrouping.CheckedChanged += new System.EventHandler(this.checkboxDigitGrouping_CheckedChanged);
            // 
            // labelTextLength
            // 
            this.labelTextLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextLength.AutoSize = true;
            this.labelTextLength.Location = new System.Drawing.Point(699, 202);
            this.labelTextLength.Name = "labelTextLength";
            this.labelTextLength.Size = new System.Drawing.Size(122, 20);
            this.labelTextLength.TabIndex = 5;
            this.labelTextLength.Text = "Length (bytes):";
            // 
            // richtextInput
            // 
            this.richtextInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextInput.Location = new System.Drawing.Point(50, 99);
            this.richtextInput.Name = "richtextInput";
            this.richtextInput.Size = new System.Drawing.Size(877, 100);
            this.richtextInput.TabIndex = 4;
            this.richtextInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text input";
            // 
            // comboxCharacterEncoding
            // 
            this.comboxCharacterEncoding.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboxCharacterEncoding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboxCharacterEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxCharacterEncoding.FormattingEnabled = true;
            this.comboxCharacterEncoding.Items.AddRange(new object[] {
            "UTF8",
            "ASCII",
            "Unicode"});
            this.comboxCharacterEncoding.Location = new System.Drawing.Point(50, 245);
            this.comboxCharacterEncoding.Name = "comboxCharacterEncoding";
            this.comboxCharacterEncoding.Size = new System.Drawing.Size(152, 28);
            this.comboxCharacterEncoding.TabIndex = 2;
            this.comboxCharacterEncoding.SelectedIndexChanged += new System.EventHandler(this.comboxCharacterEncoding_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character encoding";
            // 
            // buttonReset
            // 
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(365, 240);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(106, 37);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "       Reset";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.FlatAppearance.BorderSize = 0;
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Image = ((System.Drawing.Image)(resources.GetObject("buttonConvert.Image")));
            this.buttonConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConvert.Location = new System.Drawing.Point(234, 240);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(125, 37);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "       Convert";
            this.buttonConvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile.Location = new System.Drawing.Point(50, 30);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(138, 37);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "       Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.comboxBase64Option);
            this.panelOutput.Controls.Add(this.richtextBase64);
            this.panelOutput.Controls.Add(this.label5);
            this.panelOutput.Controls.Add(this.richtextBinary);
            this.panelOutput.Controls.Add(this.label4);
            this.panelOutput.Controls.Add(this.richtextHex);
            this.panelOutput.Controls.Add(this.label3);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOutput.Location = new System.Drawing.Point(0, 318);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelOutput.Size = new System.Drawing.Size(980, 424);
            this.panelOutput.TabIndex = 1;
            // 
            // comboxBase64Option
            // 
            this.comboxBase64Option.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboxBase64Option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboxBase64Option.FormattingEnabled = true;
            this.comboxBase64Option.Items.AddRange(new object[] {
            "None",
            "Line break"});
            this.comboxBase64Option.Location = new System.Drawing.Point(179, 281);
            this.comboxBase64Option.Name = "comboxBase64Option";
            this.comboxBase64Option.Size = new System.Drawing.Size(172, 28);
            this.comboxBase64Option.TabIndex = 6;
            this.comboxBase64Option.SelectedIndexChanged += new System.EventHandler(this.comboxBase64Option_SelectedIndexChanged);
            // 
            // richtextBase64
            // 
            this.richtextBase64.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextBase64.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextBase64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextBase64.Location = new System.Drawing.Point(50, 315);
            this.richtextBase64.Name = "richtextBase64";
            this.richtextBase64.ReadOnly = true;
            this.richtextBase64.Size = new System.Drawing.Size(877, 100);
            this.richtextBase64.TabIndex = 5;
            this.richtextBase64.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Base64 (bytes)";
            // 
            // richtextBinary
            // 
            this.richtextBinary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextBinary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextBinary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextBinary.Location = new System.Drawing.Point(50, 165);
            this.richtextBinary.Name = "richtextBinary";
            this.richtextBinary.ReadOnly = true;
            this.richtextBinary.Size = new System.Drawing.Size(877, 100);
            this.richtextBinary.TabIndex = 5;
            this.richtextBinary.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Binary (bytes)";
            // 
            // richtextHex
            // 
            this.richtextHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextHex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextHex.Location = new System.Drawing.Point(50, 26);
            this.richtextHex.Name = "richtextHex";
            this.richtextHex.ReadOnly = true;
            this.richtextHex.Size = new System.Drawing.Size(877, 100);
            this.richtextHex.TabIndex = 5;
            this.richtextHex.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hex (bytes)";
            // 
            // panelChecksum
            // 
            this.panelChecksum.Controls.Add(this.richtextChecksum);
            this.panelChecksum.Controls.Add(this.comboxChecksumType);
            this.panelChecksum.Controls.Add(this.label6);
            this.panelChecksum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChecksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChecksum.Location = new System.Drawing.Point(0, 742);
            this.panelChecksum.Name = "panelChecksum";
            this.panelChecksum.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelChecksum.Size = new System.Drawing.Size(980, 87);
            this.panelChecksum.TabIndex = 2;
            // 
            // richtextChecksum
            // 
            this.richtextChecksum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextChecksum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtextChecksum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextChecksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextChecksum.Location = new System.Drawing.Point(335, 26);
            this.richtextChecksum.Multiline = false;
            this.richtextChecksum.Name = "richtextChecksum";
            this.richtextChecksum.ReadOnly = true;
            this.richtextChecksum.Size = new System.Drawing.Size(536, 28);
            this.richtextChecksum.TabIndex = 4;
            this.richtextChecksum.Text = "";
            // 
            // comboxChecksumType
            // 
            this.comboxChecksumType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboxChecksumType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboxChecksumType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxChecksumType.FormattingEnabled = true;
            this.comboxChecksumType.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-512",
            "2\'s complement",
            "Xor"});
            this.comboxChecksumType.Location = new System.Drawing.Point(50, 26);
            this.comboxChecksumType.Name = "comboxChecksumType";
            this.comboxChecksumType.Size = new System.Drawing.Size(231, 28);
            this.comboxChecksumType.TabIndex = 2;
            this.comboxChecksumType.SelectedIndexChanged += new System.EventHandler(this.comboxChecksumType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Checksum";
            // 
            // UCTextConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelChecksum);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTextConversion";
            this.Size = new System.Drawing.Size(980, 829);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.panelChecksum.ResumeLayout(false);
            this.panelChecksum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelChecksum;
        private System.Windows.Forms.ComboBox comboxCharacterEncoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.RichTextBox richtextInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.RichTextBox richtextHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtextBase64;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richtextBinary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboxChecksumType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richtextChecksum;
        private System.Windows.Forms.ComboBox comboxBase64Option;
        private System.Windows.Forms.Label labelTextLength;
        private System.Windows.Forms.CheckBox checkboxDigitGrouping;
    }
}
