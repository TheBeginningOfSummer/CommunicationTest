﻿namespace CommunicationsToolkit
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
            this.GB_ShowCode = new System.Windows.Forms.GroupBox();
            this.RB_ServerUTF8 = new System.Windows.Forms.RadioButton();
            this.RB_ServerHex = new System.Windows.Forms.RadioButton();
            this.GB_Protocol = new System.Windows.Forms.GroupBox();
            this.RB_Fins = new System.Windows.Forms.RadioButton();
            this.RB_Modbus = new System.Windows.Forms.RadioButton();
            this.RB_NoProtocol = new System.Windows.Forms.RadioButton();
            this.BTN_ServerOpen = new System.Windows.Forms.Button();
            this.BTN_ServerSend = new System.Windows.Forms.Button();
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
            this.TP_ModbusTCP = new System.Windows.Forms.TabPage();
            this.BTN_DisplayRegister = new System.Windows.Forms.Button();
            this.BTN_ModbusSend = new System.Windows.Forms.Button();
            this.LB_连接符 = new System.Windows.Forms.Label();
            this.TB_ModbusSend = new System.Windows.Forms.TextBox();
            this.TB_MaxAdress = new System.Windows.Forms.TextBox();
            this.PN_ModbusTCP = new System.Windows.Forms.Panel();
            this.TB_MinAddress = new System.Windows.Forms.TextBox();
            this.GB_DataInput = new System.Windows.Forms.GroupBox();
            this.RB_InputRegister = new System.Windows.Forms.RadioButton();
            this.RB_HoldingRegister = new System.Windows.Forms.RadioButton();
            this.BTN_ModbusWrite = new System.Windows.Forms.Button();
            this.LB_输入数据 = new System.Windows.Forms.Label();
            this.LB_数据地址 = new System.Windows.Forms.Label();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.TB_InputData = new System.Windows.Forms.TextBox();
            this.LB_地址显示范围 = new System.Windows.Forms.Label();
            this.TB_ModbusReceive = new System.Windows.Forms.TextBox();
            this.TP_FinsTCPServer = new System.Windows.Forms.TabPage();
            this.GB_FinsServerHArea = new System.Windows.Forms.GroupBox();
            this.GB_FinsServerDArea = new System.Windows.Forms.GroupBox();
            this.GB_FinsServerWArea = new System.Windows.Forms.GroupBox();
            this.LB_ASCII = new System.Windows.Forms.Label();
            this.BTN_StopFins = new System.Windows.Forms.Button();
            this.BTN_StartFins = new System.Windows.Forms.Button();
            this.BTN_ShowASCIICode = new System.Windows.Forms.Button();
            this.TB_ASCIICode = new System.Windows.Forms.TextBox();
            this.TC_Communications.SuspendLayout();
            this.TP_TCPServer.SuspendLayout();
            this.GB_ShowCode.SuspendLayout();
            this.GB_Protocol.SuspendLayout();
            this.TS_TCPServer.SuspendLayout();
            this.TP_TCPClient.SuspendLayout();
            this.TS_TCPClient.SuspendLayout();
            this.TP_SerialPort.SuspendLayout();
            this.TS_SerialPort.SuspendLayout();
            this.TP_ModbusTCP.SuspendLayout();
            this.GB_DataInput.SuspendLayout();
            this.TP_FinsTCPServer.SuspendLayout();
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
            this.TC_Communications.Controls.Add(this.TP_ModbusTCP);
            this.TC_Communications.Controls.Add(this.TP_FinsTCPServer);
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
            this.TP_TCPServer.Controls.Add(this.GB_ShowCode);
            this.TP_TCPServer.Controls.Add(this.GB_Protocol);
            this.TP_TCPServer.Controls.Add(this.BTN_ServerOpen);
            this.TP_TCPServer.Controls.Add(this.BTN_ServerSend);
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
            // GB_ShowCode
            // 
            this.GB_ShowCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_ShowCode.Controls.Add(this.RB_ServerUTF8);
            this.GB_ShowCode.Controls.Add(this.RB_ServerHex);
            this.GB_ShowCode.Location = new System.Drawing.Point(708, 26);
            this.GB_ShowCode.Name = "GB_ShowCode";
            this.GB_ShowCode.Size = new System.Drawing.Size(82, 100);
            this.GB_ShowCode.TabIndex = 9;
            this.GB_ShowCode.TabStop = false;
            this.GB_ShowCode.Text = "显示编码";
            // 
            // RB_ServerUTF8
            // 
            this.RB_ServerUTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ServerUTF8.AutoSize = true;
            this.RB_ServerUTF8.Checked = true;
            this.RB_ServerUTF8.Location = new System.Drawing.Point(14, 22);
            this.RB_ServerUTF8.Name = "RB_ServerUTF8";
            this.RB_ServerUTF8.Size = new System.Drawing.Size(55, 21);
            this.RB_ServerUTF8.TabIndex = 4;
            this.RB_ServerUTF8.TabStop = true;
            this.RB_ServerUTF8.Text = "UTF8";
            this.RB_ServerUTF8.UseVisualStyleBackColor = true;
            // 
            // RB_ServerHex
            // 
            this.RB_ServerHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RB_ServerHex.AutoSize = true;
            this.RB_ServerHex.Location = new System.Drawing.Point(14, 49);
            this.RB_ServerHex.Name = "RB_ServerHex";
            this.RB_ServerHex.Size = new System.Drawing.Size(48, 21);
            this.RB_ServerHex.TabIndex = 5;
            this.RB_ServerHex.Text = "Hex";
            this.RB_ServerHex.UseVisualStyleBackColor = true;
            // 
            // GB_Protocol
            // 
            this.GB_Protocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Protocol.Controls.Add(this.RB_Fins);
            this.GB_Protocol.Controls.Add(this.RB_Modbus);
            this.GB_Protocol.Controls.Add(this.RB_NoProtocol);
            this.GB_Protocol.Location = new System.Drawing.Point(708, 132);
            this.GB_Protocol.Name = "GB_Protocol";
            this.GB_Protocol.Size = new System.Drawing.Size(83, 100);
            this.GB_Protocol.TabIndex = 8;
            this.GB_Protocol.TabStop = false;
            this.GB_Protocol.Text = "协议";
            // 
            // RB_Fins
            // 
            this.RB_Fins.AutoSize = true;
            this.RB_Fins.Location = new System.Drawing.Point(6, 73);
            this.RB_Fins.Name = "RB_Fins";
            this.RB_Fins.Size = new System.Drawing.Size(48, 21);
            this.RB_Fins.TabIndex = 10;
            this.RB_Fins.TabStop = true;
            this.RB_Fins.Text = "Fins";
            this.RB_Fins.UseVisualStyleBackColor = true;
            // 
            // RB_Modbus
            // 
            this.RB_Modbus.AutoSize = true;
            this.RB_Modbus.Location = new System.Drawing.Point(6, 49);
            this.RB_Modbus.Name = "RB_Modbus";
            this.RB_Modbus.Size = new System.Drawing.Size(75, 21);
            this.RB_Modbus.TabIndex = 1;
            this.RB_Modbus.TabStop = true;
            this.RB_Modbus.Text = "Modbus";
            this.RB_Modbus.UseVisualStyleBackColor = true;
            // 
            // RB_NoProtocol
            // 
            this.RB_NoProtocol.AutoSize = true;
            this.RB_NoProtocol.Checked = true;
            this.RB_NoProtocol.Location = new System.Drawing.Point(6, 22);
            this.RB_NoProtocol.Name = "RB_NoProtocol";
            this.RB_NoProtocol.Size = new System.Drawing.Size(62, 21);
            this.RB_NoProtocol.TabIndex = 0;
            this.RB_NoProtocol.TabStop = true;
            this.RB_NoProtocol.Text = "无协议";
            this.RB_NoProtocol.UseVisualStyleBackColor = true;
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
            this.TSB_ServerClear.Click += new System.EventHandler(this.TSB_ServerClear_Click);
            // 
            // TSTB_ServerPort
            // 
            this.TSTB_ServerPort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSTB_ServerPort.Name = "TSTB_ServerPort";
            this.TSTB_ServerPort.Size = new System.Drawing.Size(60, 25);
            this.TSTB_ServerPort.Text = "9600";
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
            this.TSTB_ServerIP.Text = "192.168.1.10";
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
            // TP_ModbusTCP
            // 
            this.TP_ModbusTCP.Controls.Add(this.BTN_DisplayRegister);
            this.TP_ModbusTCP.Controls.Add(this.BTN_ModbusSend);
            this.TP_ModbusTCP.Controls.Add(this.LB_连接符);
            this.TP_ModbusTCP.Controls.Add(this.TB_ModbusSend);
            this.TP_ModbusTCP.Controls.Add(this.TB_MaxAdress);
            this.TP_ModbusTCP.Controls.Add(this.PN_ModbusTCP);
            this.TP_ModbusTCP.Controls.Add(this.TB_MinAddress);
            this.TP_ModbusTCP.Controls.Add(this.GB_DataInput);
            this.TP_ModbusTCP.Controls.Add(this.LB_地址显示范围);
            this.TP_ModbusTCP.Controls.Add(this.TB_ModbusReceive);
            this.TP_ModbusTCP.Location = new System.Drawing.Point(4, 24);
            this.TP_ModbusTCP.Name = "TP_ModbusTCP";
            this.TP_ModbusTCP.Padding = new System.Windows.Forms.Padding(3);
            this.TP_ModbusTCP.Size = new System.Drawing.Size(791, 420);
            this.TP_ModbusTCP.TabIndex = 4;
            this.TP_ModbusTCP.Text = "ModbusTCPSlave";
            this.TP_ModbusTCP.UseVisualStyleBackColor = true;
            // 
            // BTN_DisplayRegister
            // 
            this.BTN_DisplayRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_DisplayRegister.Location = new System.Drawing.Point(223, 364);
            this.BTN_DisplayRegister.Name = "BTN_DisplayRegister";
            this.BTN_DisplayRegister.Size = new System.Drawing.Size(75, 23);
            this.BTN_DisplayRegister.TabIndex = 4;
            this.BTN_DisplayRegister.Text = "显示";
            this.BTN_DisplayRegister.UseVisualStyleBackColor = true;
            this.BTN_DisplayRegister.Click += new System.EventHandler(this.BTN_DisplayRegister_Click);
            // 
            // BTN_ModbusSend
            // 
            this.BTN_ModbusSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ModbusSend.Location = new System.Drawing.Point(588, 389);
            this.BTN_ModbusSend.Name = "BTN_ModbusSend";
            this.BTN_ModbusSend.Size = new System.Drawing.Size(75, 23);
            this.BTN_ModbusSend.TabIndex = 4;
            this.BTN_ModbusSend.Text = "发送";
            this.BTN_ModbusSend.UseVisualStyleBackColor = true;
            // 
            // LB_连接符
            // 
            this.LB_连接符.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_连接符.AutoSize = true;
            this.LB_连接符.Location = new System.Drawing.Point(144, 366);
            this.LB_连接符.Name = "LB_连接符";
            this.LB_连接符.Size = new System.Drawing.Size(17, 17);
            this.LB_连接符.TabIndex = 3;
            this.LB_连接符.Text = "~";
            // 
            // TB_ModbusSend
            // 
            this.TB_ModbusSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ModbusSend.Location = new System.Drawing.Point(6, 389);
            this.TB_ModbusSend.Name = "TB_ModbusSend";
            this.TB_ModbusSend.Size = new System.Drawing.Size(576, 23);
            this.TB_ModbusSend.TabIndex = 3;
            // 
            // TB_MaxAdress
            // 
            this.TB_MaxAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_MaxAdress.Location = new System.Drawing.Point(167, 363);
            this.TB_MaxAdress.Name = "TB_MaxAdress";
            this.TB_MaxAdress.Size = new System.Drawing.Size(50, 23);
            this.TB_MaxAdress.TabIndex = 2;
            this.TB_MaxAdress.Text = "20";
            this.TB_MaxAdress.TextChanged += new System.EventHandler(this.TB_MaxAdress_TextChanged);
            // 
            // PN_ModbusTCP
            // 
            this.PN_ModbusTCP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_ModbusTCP.AutoScroll = true;
            this.PN_ModbusTCP.Location = new System.Drawing.Point(6, 6);
            this.PN_ModbusTCP.Name = "PN_ModbusTCP";
            this.PN_ModbusTCP.Size = new System.Drawing.Size(576, 351);
            this.PN_ModbusTCP.TabIndex = 2;
            // 
            // TB_MinAddress
            // 
            this.TB_MinAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_MinAddress.Location = new System.Drawing.Point(92, 363);
            this.TB_MinAddress.Name = "TB_MinAddress";
            this.TB_MinAddress.Size = new System.Drawing.Size(50, 23);
            this.TB_MinAddress.TabIndex = 1;
            this.TB_MinAddress.Text = "0";
            this.TB_MinAddress.TextChanged += new System.EventHandler(this.TB_MinAddress_TextChanged);
            // 
            // GB_DataInput
            // 
            this.GB_DataInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_DataInput.Controls.Add(this.RB_InputRegister);
            this.GB_DataInput.Controls.Add(this.RB_HoldingRegister);
            this.GB_DataInput.Controls.Add(this.BTN_ModbusWrite);
            this.GB_DataInput.Controls.Add(this.LB_输入数据);
            this.GB_DataInput.Controls.Add(this.LB_数据地址);
            this.GB_DataInput.Controls.Add(this.TB_Address);
            this.GB_DataInput.Controls.Add(this.TB_InputData);
            this.GB_DataInput.Location = new System.Drawing.Point(588, 268);
            this.GB_DataInput.Name = "GB_DataInput";
            this.GB_DataInput.Size = new System.Drawing.Size(200, 107);
            this.GB_DataInput.TabIndex = 1;
            this.GB_DataInput.TabStop = false;
            this.GB_DataInput.Text = "数据写入";
            // 
            // RB_InputRegister
            // 
            this.RB_InputRegister.AutoSize = true;
            this.RB_InputRegister.Location = new System.Drawing.Point(115, 49);
            this.RB_InputRegister.Name = "RB_InputRegister";
            this.RB_InputRegister.Size = new System.Drawing.Size(86, 21);
            this.RB_InputRegister.TabIndex = 16;
            this.RB_InputRegister.Text = "输入寄存器";
            this.RB_InputRegister.UseVisualStyleBackColor = true;
            // 
            // RB_HoldingRegister
            // 
            this.RB_HoldingRegister.AutoSize = true;
            this.RB_HoldingRegister.Checked = true;
            this.RB_HoldingRegister.Location = new System.Drawing.Point(115, 22);
            this.RB_HoldingRegister.Name = "RB_HoldingRegister";
            this.RB_HoldingRegister.Size = new System.Drawing.Size(86, 21);
            this.RB_HoldingRegister.TabIndex = 15;
            this.RB_HoldingRegister.TabStop = true;
            this.RB_HoldingRegister.Text = "保持寄存器";
            this.RB_HoldingRegister.UseVisualStyleBackColor = true;
            // 
            // BTN_ModbusWrite
            // 
            this.BTN_ModbusWrite.Location = new System.Drawing.Point(44, 80);
            this.BTN_ModbusWrite.Name = "BTN_ModbusWrite";
            this.BTN_ModbusWrite.Size = new System.Drawing.Size(69, 23);
            this.BTN_ModbusWrite.TabIndex = 13;
            this.BTN_ModbusWrite.Text = "写入";
            this.BTN_ModbusWrite.UseVisualStyleBackColor = true;
            this.BTN_ModbusWrite.Click += new System.EventHandler(this.BTN_ModbusWrite_Click);
            // 
            // LB_输入数据
            // 
            this.LB_输入数据.AutoSize = true;
            this.LB_输入数据.Location = new System.Drawing.Point(6, 54);
            this.LB_输入数据.Name = "LB_输入数据";
            this.LB_输入数据.Size = new System.Drawing.Size(32, 17);
            this.LB_输入数据.TabIndex = 14;
            this.LB_输入数据.Text = "数据";
            // 
            // LB_数据地址
            // 
            this.LB_数据地址.AutoSize = true;
            this.LB_数据地址.Location = new System.Drawing.Point(6, 28);
            this.LB_数据地址.Name = "LB_数据地址";
            this.LB_数据地址.Size = new System.Drawing.Size(32, 17);
            this.LB_数据地址.TabIndex = 13;
            this.LB_数据地址.Text = "地址";
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(44, 22);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(69, 23);
            this.TB_Address.TabIndex = 11;
            // 
            // TB_InputData
            // 
            this.TB_InputData.Location = new System.Drawing.Point(44, 51);
            this.TB_InputData.Name = "TB_InputData";
            this.TB_InputData.Size = new System.Drawing.Size(69, 23);
            this.TB_InputData.TabIndex = 12;
            // 
            // LB_地址显示范围
            // 
            this.LB_地址显示范围.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_地址显示范围.AutoSize = true;
            this.LB_地址显示范围.Location = new System.Drawing.Point(6, 369);
            this.LB_地址显示范围.Name = "LB_地址显示范围";
            this.LB_地址显示范围.Size = new System.Drawing.Size(80, 17);
            this.LB_地址显示范围.TabIndex = 0;
            this.LB_地址显示范围.Text = "地址显示范围";
            // 
            // TB_ModbusReceive
            // 
            this.TB_ModbusReceive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ModbusReceive.Location = new System.Drawing.Point(588, 3);
            this.TB_ModbusReceive.Multiline = true;
            this.TB_ModbusReceive.Name = "TB_ModbusReceive";
            this.TB_ModbusReceive.Size = new System.Drawing.Size(197, 259);
            this.TB_ModbusReceive.TabIndex = 0;
            // 
            // TP_FinsTCPServer
            // 
            this.TP_FinsTCPServer.Controls.Add(this.TB_ASCIICode);
            this.TP_FinsTCPServer.Controls.Add(this.BTN_ShowASCIICode);
            this.TP_FinsTCPServer.Controls.Add(this.GB_FinsServerHArea);
            this.TP_FinsTCPServer.Controls.Add(this.GB_FinsServerDArea);
            this.TP_FinsTCPServer.Controls.Add(this.GB_FinsServerWArea);
            this.TP_FinsTCPServer.Controls.Add(this.LB_ASCII);
            this.TP_FinsTCPServer.Controls.Add(this.BTN_StopFins);
            this.TP_FinsTCPServer.Controls.Add(this.BTN_StartFins);
            this.TP_FinsTCPServer.Location = new System.Drawing.Point(4, 24);
            this.TP_FinsTCPServer.Name = "TP_FinsTCPServer";
            this.TP_FinsTCPServer.Padding = new System.Windows.Forms.Padding(3);
            this.TP_FinsTCPServer.Size = new System.Drawing.Size(791, 420);
            this.TP_FinsTCPServer.TabIndex = 5;
            this.TP_FinsTCPServer.Text = "FinsTCPServer";
            this.TP_FinsTCPServer.UseVisualStyleBackColor = true;
            // 
            // GB_FinsServerHArea
            // 
            this.GB_FinsServerHArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GB_FinsServerHArea.Location = new System.Drawing.Point(418, 6);
            this.GB_FinsServerHArea.Name = "GB_FinsServerHArea";
            this.GB_FinsServerHArea.Size = new System.Drawing.Size(200, 406);
            this.GB_FinsServerHArea.TabIndex = 4;
            this.GB_FinsServerHArea.TabStop = false;
            this.GB_FinsServerHArea.Text = "H区";
            // 
            // GB_FinsServerDArea
            // 
            this.GB_FinsServerDArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GB_FinsServerDArea.Location = new System.Drawing.Point(212, 6);
            this.GB_FinsServerDArea.Name = "GB_FinsServerDArea";
            this.GB_FinsServerDArea.Size = new System.Drawing.Size(200, 406);
            this.GB_FinsServerDArea.TabIndex = 3;
            this.GB_FinsServerDArea.TabStop = false;
            this.GB_FinsServerDArea.Text = "D区";
            // 
            // GB_FinsServerWArea
            // 
            this.GB_FinsServerWArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GB_FinsServerWArea.Location = new System.Drawing.Point(6, 6);
            this.GB_FinsServerWArea.Name = "GB_FinsServerWArea";
            this.GB_FinsServerWArea.Size = new System.Drawing.Size(200, 406);
            this.GB_FinsServerWArea.TabIndex = 2;
            this.GB_FinsServerWArea.TabStop = false;
            this.GB_FinsServerWArea.Text = "W区";
            // 
            // LB_ASCII
            // 
            this.LB_ASCII.AutoSize = true;
            this.LB_ASCII.Location = new System.Drawing.Point(630, 6);
            this.LB_ASCII.Name = "LB_ASCII";
            this.LB_ASCII.Size = new System.Drawing.Size(32, 17);
            this.LB_ASCII.TabIndex = 0;
            this.LB_ASCII.Text = "数据";
            // 
            // BTN_StopFins
            // 
            this.BTN_StopFins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_StopFins.Location = new System.Drawing.Point(696, 389);
            this.BTN_StopFins.Name = "BTN_StopFins";
            this.BTN_StopFins.Size = new System.Drawing.Size(92, 23);
            this.BTN_StopFins.TabIndex = 1;
            this.BTN_StopFins.Text = "停止返回报文";
            this.BTN_StopFins.UseVisualStyleBackColor = true;
            // 
            // BTN_StartFins
            // 
            this.BTN_StartFins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_StartFins.Location = new System.Drawing.Point(696, 360);
            this.BTN_StartFins.Name = "BTN_StartFins";
            this.BTN_StartFins.Size = new System.Drawing.Size(92, 23);
            this.BTN_StartFins.TabIndex = 0;
            this.BTN_StartFins.Text = "返回Fins报文";
            this.BTN_StartFins.UseVisualStyleBackColor = true;
            // 
            // BTN_ShowASCIICode
            // 
            this.BTN_ShowASCIICode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ShowASCIICode.Location = new System.Drawing.Point(630, 68);
            this.BTN_ShowASCIICode.Name = "BTN_ShowASCIICode";
            this.BTN_ShowASCIICode.Size = new System.Drawing.Size(158, 23);
            this.BTN_ShowASCIICode.TabIndex = 5;
            this.BTN_ShowASCIICode.Text = "显示ASCII编码";
            this.BTN_ShowASCIICode.UseVisualStyleBackColor = true;
            this.BTN_ShowASCIICode.Click += new System.EventHandler(this.BTN_ShowASCIICode_Click);
            // 
            // TB_ASCIICode
            // 
            this.TB_ASCIICode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ASCIICode.Location = new System.Drawing.Point(630, 39);
            this.TB_ASCIICode.Name = "TB_ASCIICode";
            this.TB_ASCIICode.Size = new System.Drawing.Size(158, 23);
            this.TB_ASCIICode.TabIndex = 6;
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
            this.GB_ShowCode.ResumeLayout(false);
            this.GB_ShowCode.PerformLayout();
            this.GB_Protocol.ResumeLayout(false);
            this.GB_Protocol.PerformLayout();
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
            this.TP_ModbusTCP.ResumeLayout(false);
            this.TP_ModbusTCP.PerformLayout();
            this.GB_DataInput.ResumeLayout(false);
            this.GB_DataInput.PerformLayout();
            this.TP_FinsTCPServer.ResumeLayout(false);
            this.TP_FinsTCPServer.PerformLayout();
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
        private TabPage TP_ModbusTCP;
        private TextBox TB_ModbusReceive;
        private GroupBox GB_DataInput;
        private Button BTN_ModbusWrite;
        private TextBox TB_Address;
        private TextBox TB_InputData;
        private Label LB_输入数据;
        private Label LB_数据地址;
        private RadioButton RB_HoldingRegister;
        private RadioButton RB_InputRegister;
        private Panel PN_ModbusTCP;
        private TextBox TB_ModbusSend;
        private Button BTN_ModbusSend;
        private Label LB_地址显示范围;
        private Label LB_连接符;
        private TextBox TB_MaxAdress;
        private TextBox TB_MinAddress;
        private Button BTN_DisplayRegister;
        private TabPage TP_FinsTCPServer;
        private Button BTN_StopFins;
        private Button BTN_StartFins;
        private GroupBox GB_ShowCode;
        private GroupBox GB_Protocol;
        private RadioButton RB_NoProtocol;
        private RadioButton RB_Fins;
        private RadioButton RB_Modbus;
        private Label LB_ASCII;
        private GroupBox GB_FinsServerHArea;
        private GroupBox GB_FinsServerDArea;
        private GroupBox GB_FinsServerWArea;
        private TextBox TB_ASCIICode;
        private Button BTN_ShowASCIICode;
    }
}