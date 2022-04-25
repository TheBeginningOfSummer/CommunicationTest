namespace CommunicationsToolkit
{
    partial class Communications
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Communications));
            this.TC_Communications = new System.Windows.Forms.TabControl();
            this.TP_TCPServer = new System.Windows.Forms.TabPage();
            this.BTN_ServerOpen = new System.Windows.Forms.Button();
            this.BTN_ServerSend = new System.Windows.Forms.Button();
            this.RB_ServerHex = new System.Windows.Forms.RadioButton();
            this.RB_ServerUTF8 = new System.Windows.Forms.RadioButton();
            this.TB_ServerSend = new System.Windows.Forms.TextBox();
            this.TB_ServerReceive = new System.Windows.Forms.TextBox();
            this.LB_ClientList = new System.Windows.Forms.ListBox();
            this.TS_TCPServer = new System.Windows.Forms.ToolStrip();
            this.TSB_StartListening = new System.Windows.Forms.ToolStripButton();
            this.TSB_StopListening = new System.Windows.Forms.ToolStripButton();
            this.TSB_ServerClear = new System.Windows.Forms.ToolStripButton();
            this.TSTB_ServerPort = new System.Windows.Forms.ToolStripTextBox();
            this.TSL_ServerPort = new System.Windows.Forms.ToolStripLabel();
            this.TSTB_ServerIP = new System.Windows.Forms.ToolStripTextBox();
            this.TSL_ServerIP = new System.Windows.Forms.ToolStripLabel();
            this.TP_TCPClient = new System.Windows.Forms.TabPage();
            this.RB_ClientHex = new System.Windows.Forms.RadioButton();
            this.RB_ClientUTF8 = new System.Windows.Forms.RadioButton();
            this.BTN_ClientOpen = new System.Windows.Forms.Button();
            this.bTN_ClientSend = new System.Windows.Forms.Button();
            this.TB_ClientSend = new System.Windows.Forms.TextBox();
            this.TB_ClientReceive = new System.Windows.Forms.TextBox();
            this.TS_TCPClient = new System.Windows.Forms.ToolStrip();
            this.TSB_ClientConnect = new System.Windows.Forms.ToolStripButton();
            this.TSB_ClientDisconnect = new System.Windows.Forms.ToolStripButton();
            this.TSB_ClientClear = new System.Windows.Forms.ToolStripButton();
            this.TSTB_ClientPort = new System.Windows.Forms.ToolStripTextBox();
            this.TSL_ClientPort = new System.Windows.Forms.ToolStripLabel();
            this.TSTB_ClientIP = new System.Windows.Forms.ToolStripTextBox();
            this.TSL_ClientIP = new System.Windows.Forms.ToolStripLabel();
            this.TP_SerialPort = new System.Windows.Forms.TabPage();
            this.RB_ASCII = new System.Windows.Forms.RadioButton();
            this.RB_Hex = new System.Windows.Forms.RadioButton();
            this.RB_UTF8 = new System.Windows.Forms.RadioButton();
            this.BTN_SerialPortSend = new System.Windows.Forms.Button();
            this.TB_SerialPortSend = new System.Windows.Forms.TextBox();
            this.TB_SerialPortReceive = new System.Windows.Forms.TextBox();
            this.TS_SerialPort = new System.Windows.Forms.ToolStrip();
            this.TSB_OpenSerialPort = new System.Windows.Forms.ToolStripButton();
            this.TSB_CloseSerialPort = new System.Windows.Forms.ToolStripButton();
            this.TSB_Set = new System.Windows.Forms.ToolStripButton();
            this.TC_Communications.SuspendLayout();
            this.TP_TCPServer.SuspendLayout();
            this.TS_TCPServer.SuspendLayout();
            this.TP_TCPClient.SuspendLayout();
            this.TS_TCPClient.SuspendLayout();
            this.TP_SerialPort.SuspendLayout();
            this.TS_SerialPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_Communications
            // 
            this.TC_Communications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_Communications.Controls.Add(this.TP_TCPServer);
            this.TC_Communications.Controls.Add(this.TP_TCPClient);
            this.TC_Communications.Controls.Add(this.TP_SerialPort);
            this.TC_Communications.Location = new System.Drawing.Point(2, 2);
            this.TC_Communications.Multiline = true;
            this.TC_Communications.Name = "TC_Communications";
            this.TC_Communications.Padding = new System.Drawing.Point(3, 1);
            this.TC_Communications.SelectedIndex = 0;
            this.TC_Communications.Size = new System.Drawing.Size(799, 448);
            this.TC_Communications.TabIndex = 0;
            // 
            // TP_TCPServer
            // 
            this.TP_TCPServer.Controls.Add(this.BTN_ServerOpen);
            this.TP_TCPServer.Controls.Add(this.BTN_ServerSend);
            this.TP_TCPServer.Controls.Add(this.RB_ServerHex);
            this.TP_TCPServer.Controls.Add(this.RB_ServerUTF8);
            this.TP_TCPServer.Controls.Add(this.TB_ServerSend);
            this.TP_TCPServer.Controls.Add(this.TB_ServerReceive);
            this.TP_TCPServer.Controls.Add(this.LB_ClientList);
            this.TP_TCPServer.Controls.Add(this.TS_TCPServer);
            this.TP_TCPServer.Location = new System.Drawing.Point(4, 24);
            this.TP_TCPServer.Margin = new System.Windows.Forms.Padding(1);
            this.TP_TCPServer.Name = "TP_TCPServer";
            this.TP_TCPServer.Padding = new System.Windows.Forms.Padding(1);
            this.TP_TCPServer.Size = new System.Drawing.Size(791, 420);
            this.TP_TCPServer.TabIndex = 1;
            this.TP_TCPServer.Text = "服务端";
            this.TP_TCPServer.UseVisualStyleBackColor = true;
            // 
            // BTN_ServerOpen
            // 
            this.BTN_ServerOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ServerOpen.Location = new System.Drawing.Point(713, 360);
            this.BTN_ServerOpen.Name = "BTN_ServerOpen";
            this.BTN_ServerOpen.Size = new System.Drawing.Size(75, 23);
            this.BTN_ServerOpen.TabIndex = 7;
            this.BTN_ServerOpen.Text = "打开";
            this.BTN_ServerOpen.UseVisualStyleBackColor = true;
            this.BTN_ServerOpen.Click += new System.EventHandler(this.BTN_ServerOpen_Click);
            // 
            // BTN_ServerSend
            // 
            this.BTN_ServerSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ServerSend.Location = new System.Drawing.Point(713, 389);
            this.BTN_ServerSend.Name = "BTN_ServerSend";
            this.BTN_ServerSend.Size = new System.Drawing.Size(75, 23);
            this.BTN_ServerSend.TabIndex = 6;
            this.BTN_ServerSend.Text = "发送";
            this.BTN_ServerSend.UseVisualStyleBackColor = true;
            this.BTN_ServerSend.Click += new System.EventHandler(this.BTN_ServerSend_Click);
            // 
            // RB_ServerHex
            // 
            this.RB_ServerHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ServerHex.AutoSize = true;
            this.RB_ServerHex.Location = new System.Drawing.Point(713, 56);
            this.RB_ServerHex.Name = "RB_ServerHex";
            this.RB_ServerHex.Size = new System.Drawing.Size(48, 21);
            this.RB_ServerHex.TabIndex = 5;
            this.RB_ServerHex.Text = "Hex";
            this.RB_ServerHex.UseVisualStyleBackColor = true;
            // 
            // RB_ServerUTF8
            // 
            this.RB_ServerUTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ServerUTF8.AutoSize = true;
            this.RB_ServerUTF8.Checked = true;
            this.RB_ServerUTF8.Location = new System.Drawing.Point(713, 29);
            this.RB_ServerUTF8.Name = "RB_ServerUTF8";
            this.RB_ServerUTF8.Size = new System.Drawing.Size(55, 21);
            this.RB_ServerUTF8.TabIndex = 4;
            this.RB_ServerUTF8.TabStop = true;
            this.RB_ServerUTF8.Text = "UTF8";
            this.RB_ServerUTF8.UseVisualStyleBackColor = true;
            // 
            // TB_ServerSend
            // 
            this.TB_ServerSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ServerSend.Location = new System.Drawing.Point(205, 232);
            this.TB_ServerSend.Multiline = true;
            this.TB_ServerSend.Name = "TB_ServerSend";
            this.TB_ServerSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_ServerSend.Size = new System.Drawing.Size(502, 188);
            this.TB_ServerSend.TabIndex = 3;
            // 
            // TB_ServerReceive
            // 
            this.TB_ServerReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ServerReceive.Location = new System.Drawing.Point(205, 26);
            this.TB_ServerReceive.Multiline = true;
            this.TB_ServerReceive.Name = "TB_ServerReceive";
            this.TB_ServerReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_ServerReceive.Size = new System.Drawing.Size(502, 200);
            this.TB_ServerReceive.TabIndex = 2;
            // 
            // LB_ClientList
            // 
            this.LB_ClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LB_ClientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.LB_ClientList.FormattingEnabled = true;
            this.LB_ClientList.ItemHeight = 17;
            this.LB_ClientList.Location = new System.Drawing.Point(1, 26);
            this.LB_ClientList.Margin = new System.Windows.Forms.Padding(1);
            this.LB_ClientList.Name = "LB_ClientList";
            this.LB_ClientList.Size = new System.Drawing.Size(200, 393);
            this.LB_ClientList.TabIndex = 1;
            // 
            // TS_TCPServer
            // 
            this.TS_TCPServer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_TCPServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_StartListening,
            this.TSB_StopListening,
            this.TSB_ServerClear,
            this.TSTB_ServerPort,
            this.TSL_ServerPort,
            this.TSTB_ServerIP,
            this.TSL_ServerIP});
            this.TS_TCPServer.Location = new System.Drawing.Point(1, 1);
            this.TS_TCPServer.Name = "TS_TCPServer";
            this.TS_TCPServer.Size = new System.Drawing.Size(789, 25);
            this.TS_TCPServer.TabIndex = 0;
            this.TS_TCPServer.Text = "TS_Server";
            // 
            // TSB_StartListening
            // 
            this.TSB_StartListening.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_StartListening.Image = ((System.Drawing.Image)(resources.GetObject("TSB_StartListening.Image")));
            this.TSB_StartListening.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_StartListening.Name = "TSB_StartListening";
            this.TSB_StartListening.Size = new System.Drawing.Size(60, 22);
            this.TSB_StartListening.Text = "开始监听";
            this.TSB_StartListening.Click += new System.EventHandler(this.TSB_StartListening_Click);
            // 
            // TSB_StopListening
            // 
            this.TSB_StopListening.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_StopListening.Enabled = false;
            this.TSB_StopListening.Image = ((System.Drawing.Image)(resources.GetObject("TSB_StopListening.Image")));
            this.TSB_StopListening.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_StopListening.Name = "TSB_StopListening";
            this.TSB_StopListening.Size = new System.Drawing.Size(60, 22);
            this.TSB_StopListening.Text = "停止监听";
            this.TSB_StopListening.Click += new System.EventHandler(this.TSB_StopListening_Click);
            // 
            // TSB_ServerClear
            // 
            this.TSB_ServerClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_ServerClear.Image = ((System.Drawing.Image)(resources.GetObject("TSB_ServerClear.Image")));
            this.TSB_ServerClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ServerClear.Name = "TSB_ServerClear";
            this.TSB_ServerClear.Size = new System.Drawing.Size(36, 22);
            this.TSB_ServerClear.Text = "清除";
            this.TSB_ServerClear.Click += new System.EventHandler(this.TSB_ServerClear_Click_1);
            // 
            // TSTB_ServerPort
            // 
            this.TSTB_ServerPort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSTB_ServerPort.Name = "TSTB_ServerPort";
            this.TSTB_ServerPort.Size = new System.Drawing.Size(60, 25);
            this.TSTB_ServerPort.Text = "6000";
            // 
            // TSL_ServerPort
            // 
            this.TSL_ServerPort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_ServerPort.Name = "TSL_ServerPort";
            this.TSL_ServerPort.Size = new System.Drawing.Size(44, 22);
            this.TSL_ServerPort.Text = "端口：";
            // 
            // TSTB_ServerIP
            // 
            this.TSTB_ServerIP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSTB_ServerIP.Name = "TSTB_ServerIP";
            this.TSTB_ServerIP.Size = new System.Drawing.Size(100, 25);
            this.TSTB_ServerIP.Text = "127.0.0.1";
            // 
            // TSL_ServerIP
            // 
            this.TSL_ServerIP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_ServerIP.Name = "TSL_ServerIP";
            this.TSL_ServerIP.Size = new System.Drawing.Size(31, 22);
            this.TSL_ServerIP.Text = "IP：";
            // 
            // TP_TCPClient
            // 
            this.TP_TCPClient.Controls.Add(this.RB_ClientHex);
            this.TP_TCPClient.Controls.Add(this.RB_ClientUTF8);
            this.TP_TCPClient.Controls.Add(this.BTN_ClientOpen);
            this.TP_TCPClient.Controls.Add(this.bTN_ClientSend);
            this.TP_TCPClient.Controls.Add(this.TB_ClientSend);
            this.TP_TCPClient.Controls.Add(this.TB_ClientReceive);
            this.TP_TCPClient.Controls.Add(this.TS_TCPClient);
            this.TP_TCPClient.Location = new System.Drawing.Point(4, 24);
            this.TP_TCPClient.Margin = new System.Windows.Forms.Padding(1);
            this.TP_TCPClient.Name = "TP_TCPClient";
            this.TP_TCPClient.Padding = new System.Windows.Forms.Padding(1);
            this.TP_TCPClient.Size = new System.Drawing.Size(791, 420);
            this.TP_TCPClient.TabIndex = 2;
            this.TP_TCPClient.Text = "客户端";
            this.TP_TCPClient.UseVisualStyleBackColor = true;
            // 
            // RB_ClientHex
            // 
            this.RB_ClientHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ClientHex.AutoSize = true;
            this.RB_ClientHex.Location = new System.Drawing.Point(713, 56);
            this.RB_ClientHex.Name = "RB_ClientHex";
            this.RB_ClientHex.Size = new System.Drawing.Size(48, 21);
            this.RB_ClientHex.TabIndex = 6;
            this.RB_ClientHex.Text = "Hex";
            this.RB_ClientHex.UseVisualStyleBackColor = true;
            // 
            // RB_ClientUTF8
            // 
            this.RB_ClientUTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ClientUTF8.AutoSize = true;
            this.RB_ClientUTF8.Checked = true;
            this.RB_ClientUTF8.Location = new System.Drawing.Point(713, 29);
            this.RB_ClientUTF8.Name = "RB_ClientUTF8";
            this.RB_ClientUTF8.Size = new System.Drawing.Size(55, 21);
            this.RB_ClientUTF8.TabIndex = 5;
            this.RB_ClientUTF8.TabStop = true;
            this.RB_ClientUTF8.Text = "UTF8";
            this.RB_ClientUTF8.UseVisualStyleBackColor = true;
            // 
            // BTN_ClientOpen
            // 
            this.BTN_ClientOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ClientOpen.Location = new System.Drawing.Point(713, 360);
            this.BTN_ClientOpen.Name = "BTN_ClientOpen";
            this.BTN_ClientOpen.Size = new System.Drawing.Size(75, 23);
            this.BTN_ClientOpen.TabIndex = 4;
            this.BTN_ClientOpen.Text = "打开";
            this.BTN_ClientOpen.UseVisualStyleBackColor = true;
            this.BTN_ClientOpen.Click += new System.EventHandler(this.BTN_ClientOpen_Click);
            // 
            // bTN_ClientSend
            // 
            this.bTN_ClientSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTN_ClientSend.Location = new System.Drawing.Point(713, 389);
            this.bTN_ClientSend.Name = "bTN_ClientSend";
            this.bTN_ClientSend.Size = new System.Drawing.Size(75, 23);
            this.bTN_ClientSend.TabIndex = 3;
            this.bTN_ClientSend.Text = "发送";
            this.bTN_ClientSend.UseVisualStyleBackColor = true;
            this.bTN_ClientSend.Click += new System.EventHandler(this.BTN_ClientSend_Click);
            // 
            // TB_ClientSend
            // 
            this.TB_ClientSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ClientSend.Location = new System.Drawing.Point(1, 232);
            this.TB_ClientSend.Multiline = true;
            this.TB_ClientSend.Name = "TB_ClientSend";
            this.TB_ClientSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_ClientSend.Size = new System.Drawing.Size(706, 188);
            this.TB_ClientSend.TabIndex = 2;
            // 
            // TB_ClientReceive
            // 
            this.TB_ClientReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ClientReceive.Location = new System.Drawing.Point(0, 26);
            this.TB_ClientReceive.Multiline = true;
            this.TB_ClientReceive.Name = "TB_ClientReceive";
            this.TB_ClientReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_ClientReceive.Size = new System.Drawing.Size(707, 200);
            this.TB_ClientReceive.TabIndex = 1;
            // 
            // TS_TCPClient
            // 
            this.TS_TCPClient.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_TCPClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_ClientConnect,
            this.TSB_ClientDisconnect,
            this.TSB_ClientClear,
            this.TSTB_ClientPort,
            this.TSL_ClientPort,
            this.TSTB_ClientIP,
            this.TSL_ClientIP});
            this.TS_TCPClient.Location = new System.Drawing.Point(1, 1);
            this.TS_TCPClient.Name = "TS_TCPClient";
            this.TS_TCPClient.Size = new System.Drawing.Size(789, 25);
            this.TS_TCPClient.TabIndex = 0;
            this.TS_TCPClient.Text = "TS_Client";
            // 
            // TSB_ClientConnect
            // 
            this.TSB_ClientConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_ClientConnect.Image = ((System.Drawing.Image)(resources.GetObject("TSB_ClientConnect.Image")));
            this.TSB_ClientConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ClientConnect.Name = "TSB_ClientConnect";
            this.TSB_ClientConnect.Size = new System.Drawing.Size(36, 22);
            this.TSB_ClientConnect.Text = "连接";
            this.TSB_ClientConnect.Click += new System.EventHandler(this.TSB_ClientConnect_Click);
            // 
            // TSB_ClientDisconnect
            // 
            this.TSB_ClientDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_ClientDisconnect.Enabled = false;
            this.TSB_ClientDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("TSB_ClientDisconnect.Image")));
            this.TSB_ClientDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ClientDisconnect.Name = "TSB_ClientDisconnect";
            this.TSB_ClientDisconnect.Size = new System.Drawing.Size(36, 22);
            this.TSB_ClientDisconnect.Text = "断开";
            this.TSB_ClientDisconnect.Click += new System.EventHandler(this.TSB_ClientDisconnect_Click);
            // 
            // TSB_ClientClear
            // 
            this.TSB_ClientClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_ClientClear.Image = ((System.Drawing.Image)(resources.GetObject("TSB_ClientClear.Image")));
            this.TSB_ClientClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ClientClear.Name = "TSB_ClientClear";
            this.TSB_ClientClear.Size = new System.Drawing.Size(36, 22);
            this.TSB_ClientClear.Text = "清除";
            this.TSB_ClientClear.Click += new System.EventHandler(this.TSB_ClientClear_Click);
            // 
            // TSTB_ClientPort
            // 
            this.TSTB_ClientPort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSTB_ClientPort.Name = "TSTB_ClientPort";
            this.TSTB_ClientPort.Size = new System.Drawing.Size(60, 25);
            this.TSTB_ClientPort.Text = "6000";
            this.TSTB_ClientPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSTB_ClientPort_KeyPress);
            // 
            // TSL_ClientPort
            // 
            this.TSL_ClientPort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_ClientPort.Name = "TSL_ClientPort";
            this.TSL_ClientPort.Size = new System.Drawing.Size(44, 22);
            this.TSL_ClientPort.Text = "端口：";
            // 
            // TSTB_ClientIP
            // 
            this.TSTB_ClientIP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSTB_ClientIP.Name = "TSTB_ClientIP";
            this.TSTB_ClientIP.Size = new System.Drawing.Size(100, 25);
            this.TSTB_ClientIP.Text = "127.0.0.1";
            this.TSTB_ClientIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSTB_ClientIP_KeyPress);
            // 
            // TSL_ClientIP
            // 
            this.TSL_ClientIP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_ClientIP.Name = "TSL_ClientIP";
            this.TSL_ClientIP.Size = new System.Drawing.Size(31, 22);
            this.TSL_ClientIP.Text = "IP：";
            // 
            // TP_SerialPort
            // 
            this.TP_SerialPort.Controls.Add(this.RB_ASCII);
            this.TP_SerialPort.Controls.Add(this.RB_Hex);
            this.TP_SerialPort.Controls.Add(this.RB_UTF8);
            this.TP_SerialPort.Controls.Add(this.BTN_SerialPortSend);
            this.TP_SerialPort.Controls.Add(this.TB_SerialPortSend);
            this.TP_SerialPort.Controls.Add(this.TB_SerialPortReceive);
            this.TP_SerialPort.Controls.Add(this.TS_SerialPort);
            this.TP_SerialPort.Location = new System.Drawing.Point(4, 24);
            this.TP_SerialPort.Margin = new System.Windows.Forms.Padding(1);
            this.TP_SerialPort.Name = "TP_SerialPort";
            this.TP_SerialPort.Padding = new System.Windows.Forms.Padding(1);
            this.TP_SerialPort.Size = new System.Drawing.Size(791, 420);
            this.TP_SerialPort.TabIndex = 3;
            this.TP_SerialPort.Text = "串口";
            this.TP_SerialPort.UseVisualStyleBackColor = true;
            // 
            // RB_ASCII
            // 
            this.RB_ASCII.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ASCII.AutoSize = true;
            this.RB_ASCII.Location = new System.Drawing.Point(713, 83);
            this.RB_ASCII.Name = "RB_ASCII";
            this.RB_ASCII.Size = new System.Drawing.Size(57, 21);
            this.RB_ASCII.TabIndex = 6;
            this.RB_ASCII.TabStop = true;
            this.RB_ASCII.Text = "ASCII";
            this.RB_ASCII.UseVisualStyleBackColor = true;
            // 
            // RB_Hex
            // 
            this.RB_Hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_Hex.AutoSize = true;
            this.RB_Hex.Location = new System.Drawing.Point(713, 56);
            this.RB_Hex.Name = "RB_Hex";
            this.RB_Hex.Size = new System.Drawing.Size(48, 21);
            this.RB_Hex.TabIndex = 5;
            this.RB_Hex.Text = "Hex";
            this.RB_Hex.UseVisualStyleBackColor = true;
            // 
            // RB_UTF8
            // 
            this.RB_UTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_UTF8.AutoSize = true;
            this.RB_UTF8.Checked = true;
            this.RB_UTF8.Location = new System.Drawing.Point(713, 29);
            this.RB_UTF8.Name = "RB_UTF8";
            this.RB_UTF8.Size = new System.Drawing.Size(55, 21);
            this.RB_UTF8.TabIndex = 4;
            this.RB_UTF8.TabStop = true;
            this.RB_UTF8.Text = "UTF8";
            this.RB_UTF8.UseVisualStyleBackColor = true;
            // 
            // BTN_SerialPortSend
            // 
            this.BTN_SerialPortSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SerialPortSend.Location = new System.Drawing.Point(713, 389);
            this.BTN_SerialPortSend.Name = "BTN_SerialPortSend";
            this.BTN_SerialPortSend.Size = new System.Drawing.Size(75, 23);
            this.BTN_SerialPortSend.TabIndex = 3;
            this.BTN_SerialPortSend.Text = "发送";
            this.BTN_SerialPortSend.UseVisualStyleBackColor = true;
            this.BTN_SerialPortSend.Click += new System.EventHandler(this.BTN_SerialPortSend_Click);
            // 
            // TB_SerialPortSend
            // 
            this.TB_SerialPortSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_SerialPortSend.Location = new System.Drawing.Point(1, 232);
            this.TB_SerialPortSend.Multiline = true;
            this.TB_SerialPortSend.Name = "TB_SerialPortSend";
            this.TB_SerialPortSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_SerialPortSend.Size = new System.Drawing.Size(706, 188);
            this.TB_SerialPortSend.TabIndex = 2;
            // 
            // TB_SerialPortReceive
            // 
            this.TB_SerialPortReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_SerialPortReceive.Location = new System.Drawing.Point(0, 26);
            this.TB_SerialPortReceive.Multiline = true;
            this.TB_SerialPortReceive.Name = "TB_SerialPortReceive";
            this.TB_SerialPortReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_SerialPortReceive.Size = new System.Drawing.Size(707, 200);
            this.TB_SerialPortReceive.TabIndex = 1;
            // 
            // TS_SerialPort
            // 
            this.TS_SerialPort.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_SerialPort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_OpenSerialPort,
            this.TSB_CloseSerialPort,
            this.TSB_Set});
            this.TS_SerialPort.Location = new System.Drawing.Point(1, 1);
            this.TS_SerialPort.Name = "TS_SerialPort";
            this.TS_SerialPort.Size = new System.Drawing.Size(789, 25);
            this.TS_SerialPort.TabIndex = 0;
            this.TS_SerialPort.Text = "TS_SerialPort";
            // 
            // TSB_OpenSerialPort
            // 
            this.TSB_OpenSerialPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_OpenSerialPort.Image = ((System.Drawing.Image)(resources.GetObject("TSB_OpenSerialPort.Image")));
            this.TSB_OpenSerialPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_OpenSerialPort.Name = "TSB_OpenSerialPort";
            this.TSB_OpenSerialPort.Size = new System.Drawing.Size(36, 22);
            this.TSB_OpenSerialPort.Text = "打开";
            this.TSB_OpenSerialPort.Click += new System.EventHandler(this.TSB_OpenSerialPort_Click);
            // 
            // TSB_CloseSerialPort
            // 
            this.TSB_CloseSerialPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_CloseSerialPort.Enabled = false;
            this.TSB_CloseSerialPort.Image = ((System.Drawing.Image)(resources.GetObject("TSB_CloseSerialPort.Image")));
            this.TSB_CloseSerialPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_CloseSerialPort.Name = "TSB_CloseSerialPort";
            this.TSB_CloseSerialPort.Size = new System.Drawing.Size(36, 22);
            this.TSB_CloseSerialPort.Text = "关闭";
            this.TSB_CloseSerialPort.Click += new System.EventHandler(this.TSB_CloseSerialPort_Click);
            // 
            // TSB_Set
            // 
            this.TSB_Set.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Set.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Set.Image")));
            this.TSB_Set.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Set.Name = "TSB_Set";
            this.TSB_Set.Size = new System.Drawing.Size(36, 22);
            this.TSB_Set.Text = "设置";
            this.TSB_Set.Click += new System.EventHandler(this.TSB_Set_Click);
            // 
            // Communications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TC_Communications);
            this.Name = "Communications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接工具";
            this.TC_Communications.ResumeLayout(false);
            this.TP_TCPServer.ResumeLayout(false);
            this.TP_TCPServer.PerformLayout();
            this.TS_TCPServer.ResumeLayout(false);
            this.TS_TCPServer.PerformLayout();
            this.TP_TCPClient.ResumeLayout(false);
            this.TP_TCPClient.PerformLayout();
            this.TS_TCPClient.ResumeLayout(false);
            this.TS_TCPClient.PerformLayout();
            this.TP_SerialPort.ResumeLayout(false);
            this.TP_SerialPort.PerformLayout();
            this.TS_SerialPort.ResumeLayout(false);
            this.TS_SerialPort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TC_Communications;
        private TabPage TP_TCPServer;
        private TabPage TP_TCPClient;
        private TabPage TP_SerialPort;
        private ToolStrip TS_TCPServer;
        private ToolStripButton TSB_StartListening;
        private ToolStripButton TSB_StopListening;
        private ToolStripButton TSB_ServerClear;
        private ListBox LB_ClientList;
        private TextBox TB_ServerSend;
        private TextBox TB_ServerReceive;
        private ToolStripTextBox TSTB_ServerPort;
        private ToolStripLabel TSL_ServerPort;
        private ToolStripTextBox TSTB_ServerIP;
        private ToolStripLabel TSL_ServerIP;
        private RadioButton RB_ServerUTF8;
        private RadioButton RB_ServerHex;
        private Button BTN_ServerSend;
        private ToolStrip TS_TCPClient;
        private ToolStripButton TSB_ClientConnect;
        private ToolStripButton TSB_ClientDisconnect;
        private ToolStripButton TSB_ClientClear;
        private ToolStripTextBox TSTB_ClientPort;
        private ToolStripLabel TSL_ClientPort;
        private ToolStripTextBox TSTB_ClientIP;
        private ToolStripLabel TSL_ClientIP;
        private TextBox TB_ClientSend;
        private TextBox TB_ClientReceive;
        private Button bTN_ClientSend;
        private Button BTN_ServerOpen;
        private Button BTN_ClientOpen;
        private RadioButton RB_ClientHex;
        private RadioButton RB_ClientUTF8;
        private ToolStrip TS_SerialPort;
        private ToolStripButton TSB_OpenSerialPort;
        private ToolStripButton TSB_CloseSerialPort;
        private ToolStripButton TSB_Set;
        private TextBox TB_SerialPortReceive;
        private TextBox TB_SerialPortSend;
        private Button BTN_SerialPortSend;
        private RadioButton RB_Hex;
        private RadioButton RB_UTF8;
        private RadioButton RB_ASCII;
    }
}