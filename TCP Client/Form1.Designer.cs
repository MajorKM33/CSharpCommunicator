namespace TCP_Client
{
    partial class fWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHostAddress = new System.Windows.Forms.TextBox();
            this.nUDPort = new System.Windows.Forms.NumericUpDown();
            this.Connect = new System.Windows.Forms.Button();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.bCancel = new System.Windows.Forms.Button();
            this.bwConnection2 = new System.ComponentModel.BackgroundWorker();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.lbNotify = new System.Windows.Forms.Label();
            this.bItalics = new System.Windows.Forms.Button();
            this.bBold = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // tbHostAddress
            // 
            this.tbHostAddress.Location = new System.Drawing.Point(95, 26);
            this.tbHostAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbHostAddress.Name = "tbHostAddress";
            this.tbHostAddress.Size = new System.Drawing.Size(151, 22);
            this.tbHostAddress.TabIndex = 2;
            // 
            // nUDPort
            // 
            this.nUDPort.Location = new System.Drawing.Point(296, 27);
            this.nUDPort.Margin = new System.Windows.Forms.Padding(4);
            this.nUDPort.Maximum = new decimal(new int[] {
            65635,
            0,
            0,
            0});
            this.nUDPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.Size = new System.Drawing.Size(72, 22);
            this.nUDPort.TabIndex = 3;
            this.nUDPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(71, 527);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(193, 25);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // bCancel
            // 
            this.bCancel.Enabled = false;
            this.bCancel.Location = new System.Drawing.Point(272, 527);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(167, 25);
            this.bCancel.TabIndex = 6;
            this.bCancel.Text = "Disconnect";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bwConnection2
            // 
            this.bwConnection2.WorkerSupportsCancellation = true;
            this.bwConnection2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection2_DoWork);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(30, 458);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(355, 22);
            this.tbMessage.TabIndex = 7;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(400, 458);
            this.bSend.Margin = new System.Windows.Forms.Padding(4);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(117, 22);
            this.bSend.TabIndex = 8;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(416, 26);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(100, 22);
            this.tbNickname.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nick";
            // 
            // webBrowser
            // 
            this.webBrowser.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(30, 69);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(486, 365);
            this.webBrowser.TabIndex = 11;
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Location = new System.Drawing.Point(27, 437);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(100, 17);
            this.lbNotify.TabIndex = 12;
            this.lbNotify.Text = "Not connected";
            // 
            // bItalics
            // 
            this.bItalics.Image = global::TCP_Client.Properties.Resources.italicverysmall;
            this.bItalics.Location = new System.Drawing.Point(72, 487);
            this.bItalics.Name = "bItalics";
            this.bItalics.Size = new System.Drawing.Size(36, 36);
            this.bItalics.TabIndex = 14;
            this.bItalics.UseVisualStyleBackColor = true;
            this.bItalics.Click += new System.EventHandler(this.bItalics_Click);
            // 
            // bBold
            // 
            this.bBold.Image = global::TCP_Client.Properties.Resources.boldverysmall;
            this.bBold.Location = new System.Drawing.Point(30, 487);
            this.bBold.Name = "bBold";
            this.bBold.Size = new System.Drawing.Size(36, 36);
            this.bBold.TabIndex = 13;
            this.bBold.UseVisualStyleBackColor = true;
            this.bBold.Click += new System.EventHandler(this.bBold_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 56);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 565);
            this.Controls.Add(this.bItalics);
            this.Controls.Add(this.bBold);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNickname);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.tbHostAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fWindow";
            this.Text = "TCP Client";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHostAddress;
        private System.Windows.Forms.NumericUpDown nUDPort;
        private System.Windows.Forms.Button Connect;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.Windows.Forms.Button bCancel;
        private System.ComponentModel.BackgroundWorker bwConnection2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.Button bBold;
        private System.Windows.Forms.Button bItalics;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

