﻿
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.TraceRoute = new System.Windows.Forms.ListBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(759, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TraceRoute
            // 
            this.TraceRoute.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TraceRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TraceRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TraceRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraceRoute.FormattingEnabled = true;
            this.TraceRoute.ItemHeight = 20;
            this.TraceRoute.Location = new System.Drawing.Point(50, 0);
            this.TraceRoute.Margin = new System.Windows.Forms.Padding(4);
            this.TraceRoute.Name = "TraceRoute";
            this.TraceRoute.Size = new System.Drawing.Size(880, 700);
            this.TraceRoute.TabIndex = 0;
            this.TraceRoute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TraceRoute_MouseDown);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtHostname);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.button1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panelControl.Size = new System.Drawing.Size(980, 100);
            this.panelControl.TabIndex = 0;
            // 
            // txtHostname
            // 
            this.txtHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostname.Location = new System.Drawing.Point(205, 27);
            this.txtHostname.MinimumSize = new System.Drawing.Size(547, 27);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(547, 27);
            this.txtHostname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Example: www.google.com";
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
            this.panelDesktop.Controls.Add(this.TraceRoute);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(0, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this.panelDesktop.Size = new System.Drawing.Size(980, 730);
            this.panelDesktop.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearAll});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(143, 28);
            // 
            // ClearAll
            // 
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(142, 24);
            this.ClearAll.Text = "Clear All";
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
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
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox TraceRoute;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ClearAll;
        private System.Windows.Forms.TextBox txtHostname;
    }
}
