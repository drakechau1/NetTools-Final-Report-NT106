
namespace NetTools.UserControls.IPAddress
{
    partial class UCSubnetCalculator
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
            this.bit1 = new System.Windows.Forms.TextBox();
            this.bit2 = new System.Windows.Forms.TextBox();
            this.bit3 = new System.Windows.Forms.TextBox();
            this.bit4 = new System.Windows.Forms.TextBox();
            this.subnetbit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // bit1
            // 
            this.bit1.Location = new System.Drawing.Point(105, 28);
            this.bit1.Name = "bit1";
            this.bit1.Size = new System.Drawing.Size(79, 20);
            this.bit1.TabIndex = 1;
            // 
            // bit2
            // 
            this.bit2.Location = new System.Drawing.Point(219, 27);
            this.bit2.Name = "bit2";
            this.bit2.Size = new System.Drawing.Size(78, 20);
            this.bit2.TabIndex = 2;
            // 
            // bit3
            // 
            this.bit3.Location = new System.Drawing.Point(329, 27);
            this.bit3.Name = "bit3";
            this.bit3.Size = new System.Drawing.Size(79, 20);
            this.bit3.TabIndex = 3;
            // 
            // bit4
            // 
            this.bit4.Location = new System.Drawing.Point(444, 27);
            this.bit4.Name = "bit4";
            this.bit4.Size = new System.Drawing.Size(78, 20);
            this.bit4.TabIndex = 4;
            // 
            // subnetbit
            // 
            this.subnetbit.Location = new System.Drawing.Point(587, 28);
            this.subnetbit.Name = "subnetbit";
            this.subnetbit.Size = new System.Drawing.Size(79, 20);
            this.subnetbit.TabIndex = 5;
            this.subnetbit.TextChanged += new System.EventHandler(this.subnetbit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output:";
            // 
            // outputbox
            // 
            this.outputbox.Location = new System.Drawing.Point(21, 118);
            this.outputbox.Name = "outputbox";
            this.outputbox.ReadOnly = true;
            this.outputbox.Size = new System.Drawing.Size(645, 255);
            this.outputbox.TabIndex = 8;
            this.outputbox.Text = "";
            // 
            // UCSubnetCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subnetbit);
            this.Controls.Add(this.bit4);
            this.Controls.Add(this.bit3);
            this.Controls.Add(this.bit2);
            this.Controls.Add(this.bit1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCSubnetCalculator";
            this.Size = new System.Drawing.Size(784, 664);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bit1;
        private System.Windows.Forms.TextBox bit2;
        private System.Windows.Forms.TextBox bit3;
        private System.Windows.Forms.TextBox bit4;
        private System.Windows.Forms.TextBox subnetbit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox outputbox;
    }
}
