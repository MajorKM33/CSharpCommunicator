namespace TCP_Server
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
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.nUDPort = new System.Windows.Forms.NumericUpDown();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.bwConnection2 = new System.ComponentModel.BackgroundWorker();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.cbAddressList = new System.Windows.Forms.ComboBox();
            this.lbNotify = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bItalic = new System.Windows.Forms.Button();
            this.bBold = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(117, 564);
            this.bStart.Margin = new System.Windows.Forms.Padding(4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(103, 26);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(228, 565);
            this.bStop.Margin = new System.Windows.Forms.Padding(4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(120, 25);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(20, 20);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 17);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Address";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(269, 20);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 17);
            this.lbPort.TabIndex = 3;
            this.lbPort.Text = "Port";
            // 
            // nUDPort
            // 
            this.nUDPort.Location = new System.Drawing.Point(312, 17);
            this.nUDPort.Margin = new System.Windows.Forms.Padding(4);
            this.nUDPort.Maximum = new decimal(new int[] {
            65365,
            0,
            0,
            0});
            this.nUDPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.Size = new System.Drawing.Size(160, 22);
            this.nUDPort.TabIndex = 6;
            this.nUDPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // bwConnection2
            // 
            this.bwConnection2.WorkerSupportsCancellation = true;
            this.bwConnection2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection2_DoWork);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(23, 503);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(336, 22);
            this.tbMessage.TabIndex = 7;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(381, 503);
            this.bSend.Margin = new System.Windows.Forms.Padding(4);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(91, 24);
            this.bSend.TabIndex = 8;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // cbAddressList
            // 
            this.cbAddressList.FormattingEnabled = true;
            this.cbAddressList.Location = new System.Drawing.Point(87, 15);
            this.cbAddressList.Name = "cbAddressList";
            this.cbAddressList.Size = new System.Drawing.Size(163, 24);
            this.cbAddressList.TabIndex = 9;
            this.cbAddressList.SelectedIndexChanged += new System.EventHandler(this.cbAddressList_SelectedIndexChanged);
            this.cbAddressList.TextChanged += new System.EventHandler(this.cbAddressList_TextChanged);
            // 
            // lbNotify
            // 
            this.lbNotify.AutoSize = true;
            this.lbNotify.Location = new System.Drawing.Point(20, 482);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(100, 17);
            this.lbNotify.TabIndex = 10;
            this.lbNotify.Text = "Not connected";
            // 
            // webBrowser
            // 
            this.webBrowser.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(23, 45);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(449, 434);
            this.webBrowser.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 52);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // bItalic
            // 
            this.bItalic.Image = global::TCP_Server.Properties.Resources.italicverysmall;
            this.bItalic.Location = new System.Drawing.Point(65, 532);
            this.bItalic.Name = "bItalic";
            this.bItalic.Size = new System.Drawing.Size(36, 36);
            this.bItalic.TabIndex = 13;
            this.bItalic.UseVisualStyleBackColor = true;
            this.bItalic.Click += new System.EventHandler(this.bItalic_Click);
            // 
            // bBold
            // 
            this.bBold.Image = global::TCP_Server.Properties.Resources.boldverysmall;
            this.bBold.Location = new System.Drawing.Point(23, 532);
            this.bBold.Name = "bBold";
            this.bBold.Size = new System.Drawing.Size(36, 36);
            this.bBold.TabIndex = 12;
            this.bBold.UseVisualStyleBackColor = true;
            this.bBold.Click += new System.EventHandler(this.bBold_Click);
            // 
            // fWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 603);
            this.Controls.Add(this.bItalic);
            this.Controls.Add(this.bBold);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.cbAddressList);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fWindow";
            this.Text = "TCP Server";
            ((System.ComponentModel.ISupportInitialize)(this.nUDPort)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.NumericUpDown nUDPort;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.ComponentModel.BackgroundWorker bwConnection2;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.ComboBox cbAddressList;
        private System.Windows.Forms.Label lbNotify;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button bBold;
        private System.Windows.Forms.Button bItalic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

