using MyToolkit;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static MyToolkit.ConnectionToolkit;

namespace CommunicationsToolkit
{
    public partial class Communications : Form
    {
        #region TCP连接及协议
        [AllowNull]
        SocketConnection server;
        [AllowNull]
        ModbusTCP modbus;
        [AllowNull]
        FinsTCPServer fins;
        [AllowNull]
        SocketConnection client;
        #endregion
        readonly SerialPortConnection serialPort;
        readonly OpenFileDialog serverFile;
        readonly OpenFileDialog clientFile;

        readonly List<Label> labels1 = new List<Label>();
        readonly List<Label> labels2 = new List<Label>();
        int minAddress = 0;
        int maxAddress = 20;

        public Communications()
        {
            InitializeComponent();
            serialPort = new();
            serialPort.ReceivedByte = FromSerialPort;
            serverFile = new();
            clientFile = new();
            UpdateRegister();
        }

        #region 消息更新
        private void UpdateClient()
        {
            Invoke(new Action(() =>
            {
                LB_ClientList.Items.Clear();
                foreach (var item in server.ClientDic)
                {
                    LB_ClientList.Items.Add(item.Key);
                }
            }));
        }

        private void FromClient(Socket client, byte[] message)
        {
            Invoke(new Action(() =>
            {
                if (RB_ServerUTF8.Checked)
                {
                    TB_ServerReceive.AppendText(Encoding.UTF8.GetString(message) + Environment.NewLine);
                }
                else if (RB_ServerHex.Checked)
                {
                    TB_ServerReceive.AppendText(DataConverter.BytesToHexString(message) + Environment.NewLine);
                    TB_ModbusReceive.AppendText($"[{DateTime.Now:yyyy MM-dd HH:mm:ss}]\n{DataConverter.BytesToHexString(message)}\n");
                    if (TB_ServerReceive.Text.Length > 99999) TB_ServerReceive.Clear();
                    if (TB_ModbusReceive.Text.Length > 99999) TB_ModbusReceive.Clear();
                }
            }));
        }

        private void FromServer(byte[] message)
        {
            Invoke(new Action(() =>
            {
                if (RB_ClientUTF8.Checked)
                {
                    TB_ClientReceive.AppendText(Encoding.UTF8.GetString(message) + Environment.NewLine);
                }
                else if (RB_ClientHex.Checked)
                {
                    TB_ClientReceive.AppendText(DataConverter.BytesToHexString(message) + Environment.NewLine);
                }
            }));
        }

        private void FromSerialPort(byte[] message)
        {
            Invoke(new Action(() =>
            {
                if (RB_UTF8.Checked)
                    TB_SerialPortReceive.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "    " +
                        Encoding.UTF8.GetString(message) + Environment.NewLine);
                else if (RB_Hex.Checked)
                    TB_SerialPortReceive.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "    " +
                        DataConverter.BytesToHexString(message) + Environment.NewLine);
                else if (RB_ASCII.Checked)
                    TB_SerialPortReceive.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "    " +
                        Encoding.ASCII.GetString(message) + Environment.NewLine);
            }));
        }
        #endregion

        #region 串口
        private void TSB_OpenSerialPort_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ConfigurationManager.AppSettings["BaudRate"]!.ToString(), out int baudRate)) return;
            string port = ConfigurationManager.AppSettings["Port"]!.ToString();
            if (serialPort.OpenMySerialPort(baudRate, port, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One))
            {
                TSB_OpenSerialPort.Enabled = false;
                TSB_CloseSerialPort.Enabled = true;
                MessageBox.Show("打开成功", "串口");
            }
            else
            {
                MessageBox.Show("打开失败", "串口");
            }
        }

        private void TSB_CloseSerialPort_Click(object sender, EventArgs e)
        {
            if (serialPort.CloseMySerialPort())
            {
                TSB_OpenSerialPort.Enabled = true;
                TSB_CloseSerialPort.Enabled = false;
                MessageBox.Show("关闭成功", "串口");
            }
            else
            {
                MessageBox.Show("关闭失败", "串口");
            }
        }

        private void TSB_Set_Click(object sender, EventArgs e)
        {
            new SerialPortSet().ShowDialog();
        }

        private void BTN_SerialPortSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (RB_UTF8.Checked)
                    serialPort.SendMessage(TB_SerialPortSend.Text);
                else if (RB_Hex.Checked)
                    serialPort.MySerialPort.Write(DataConverter.HexStringToBytes(TB_SerialPortSend.Text), 0, DataConverter.HexStringToBytes(TB_SerialPortSend.Text).Length);
                else if (RB_ASCII.Checked)
                    serialPort.MySerialPort.Write(Encoding.ASCII.GetBytes(TB_SerialPortSend.Text), 0, Encoding.ASCII.GetBytes(TB_SerialPortSend.Text).Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "串口发送");
            }
        }

        #endregion

        #region 服务端
        private void TSB_StartListening_Click(object sender, EventArgs e)
        {
            if (!IPAddress.TryParse(TSTB_ServerIP.Text, out IPAddress? ipAddress)) return;
            if (!int.TryParse(TSTB_ServerPort.Text.Trim(), out int port)) return;
            if (RB_NoProtocol.Checked)
            {
                server = new SocketConnection();
            }
            else if (RB_Modbus.Checked)
            {
                modbus = new ModbusTCP(1);
                server = modbus.Connection;
            }
            else if (RB_Fins.Checked)
            {
                fins = new FinsTCPServer(10);
                server = fins.Connection;
            }
            else
            {
                return;
            }
            if (server.StartListening(ipAddress, port))
            {
                server.ClientListUpdate = UpdateClient;//客户端列表委托更新绑定
                server.ReceiveFromClient += FromClient;//服务端数据收发委托绑定
                TSB_StartListening.Enabled = false;
                TSB_StopListening.Enabled = true;
                MessageBox.Show("监听成功", "服务端");
            }
        }

        private void TSB_StopListening_Click(object sender, EventArgs e)
        {
            if (server.ClientDic.Count != 0)
            {
                MessageBox.Show("有客户端未断开", "服务端");
                return;
            }
            if (server.StopListening())
            {
                TSB_StartListening.Enabled = true;
                TSB_StopListening.Enabled = false;
                MessageBox.Show("停止监听成功", "服务端");
            }
        }

        private void TSB_ServerClear_Click(object sender, EventArgs e)
        {
            TB_ServerReceive.Clear();
            TB_ServerSend.Clear();
        }

        private void BTN_ServerSend_Click(object sender, EventArgs e)
        {
            if (server == null) return;
            if (server.ClientDic.Count == 0) return;
            if (LB_ClientList.SelectedItem == null) return;
            try
            {
                if (RB_ServerHex.Checked)
                    server.ClientDic[LB_ClientList.SelectedItem.ToString()!].Send(DataConverter.HexStringToBytes(TB_ServerSend.Text));
                else if (RB_ServerUTF8.Checked)
                    server.ClientDic[LB_ClientList.SelectedItem.ToString()!].Send(Encoding.UTF8.GetBytes(TB_ServerSend.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "服务端发送消息");
            }
        }

        private void BTN_ServerOpen_Click(object sender, EventArgs e)
        {
            serverFile.Filter = "json文件|*.Json";
            if (serverFile.ShowDialog() == DialogResult.OK)
            {
                TB_ServerSend.Text = File.ReadAllText(Path.GetFullPath(serverFile.FileName));//读取文件
            }
        }
        #endregion

        #region 客户端
        private void TSB_ClientConnect_Click(object sender, EventArgs e)
        {
            if (!IPAddress.TryParse(TSTB_ClientIP.Text, out IPAddress? ipAddress)) return;
            if (!int.TryParse(TSTB_ClientPort.Text.Trim(), out int port)) return;
            client = new SocketConnection();
            if (client.Connection(ipAddress, port, out string error))
            {
                client.ReceiveFromServer = FromServer;
                TSB_ClientConnect.Enabled = false;
                TSB_ClientDisconnect.Enabled = true;
                MessageBox.Show("连接成功", "客户端");
            }
            else
            {
                MessageBox.Show(error, "客户端");
            }
        }

        private void TSB_ClientDisconnect_Click(object sender, EventArgs e)
        {
            if (client.Disconnection(out string error))
            {
                TSB_ClientConnect.Enabled = true;
                TSB_ClientDisconnect.Enabled = false;
                MessageBox.Show("连接断开", "客户端");
            }
            else if(client.SocketItem == null)
            {
                TSB_ClientConnect.Enabled = true;
                TSB_ClientDisconnect.Enabled = false;
                MessageBox.Show("连接断开", "客户端");
            }
            else
            {
                MessageBox.Show(error, "客户端");
            }
        }

        private void TSB_ClientClear_Click(object sender, EventArgs e)
        {
            TB_ClientReceive.Clear();
            TB_ClientSend.Clear();
        }

        private void BTN_ClientSend_Click(object sender, EventArgs e)
        {
            if (client == null) return;
            try
            {
                if (RB_ClientHex.Checked)
                    client.SocketItem.Send(DataConverter.HexStringToBytes(TB_ClientSend.Text));
                else if (RB_ClientUTF8.Checked)
                    client.SendUTF8(TB_ClientSend.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "客户端发送消息");
            }
        }

        private void BTN_ClientOpen_Click(object sender, EventArgs e)
        {
            clientFile.Filter = "json文件|*.Json";
            if (clientFile.ShowDialog() == DialogResult.OK)
            {
                TB_ClientSend.Text = File.ReadAllText(Path.GetFullPath(clientFile.FileName));//读取文件
            }
        }

        private void TSTB_ClientIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '.' || e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
                e.Handled = true;
        }

        private void TSTB_ClientPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
                e.Handled = true;
        }

        #endregion

        #region ModbusTCP
        private void BTN_ModbusWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (RB_HoldingRegister.Checked)
                {
                    ModbusTCP.SetRegister(modbus.HoldingRegister, ushort.Parse(TB_InputData.Text), ushort.Parse(TB_Address.Text));
                }
                else if (RB_InputRegister.Checked)
                {
                    ModbusTCP.SetRegister(modbus.InputRegister, ushort.Parse(TB_InputData.Text), ushort.Parse(TB_Address.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_DisplayRegister_Click(object sender, EventArgs e)
        {
            if (modbus == null) return;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            WinformToolkit.InitializeDisplayLabel(PN_ModbusTCP, maxAddress - minAddress + 1, labels1, labels2, 88);
            for (int i = 0; i < labels1.Count; i++)
            {
                labels1[i].Text = (minAddress + i).ToString();
            }
            if (RB_HoldingRegister.Checked)
                for (int i = 0; i < labels2.Count; i++)
                {
                    byte[]? value = ModbusTCP.ReadRegister(modbus.HoldingRegister, (ushort)(minAddress + i));
                    if (value != null) labels2[i].Text = DataConverter.BytesToHexString(value);
                }
            else if (RB_InputRegister.Checked)
                for (int i = 0; i < labels2.Count; i++)
                {
                    byte[]? value = ModbusTCP.ReadRegister(modbus.InputRegister, (ushort)(minAddress + i));
                    if (value != null) labels2[i].Invoke(new Action(() => labels2[i].Text = DataConverter.BytesToHexString(value)));
                }
        }

        private void UpdateRegister()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        Thread.Sleep(500);
                        if (labels1.Count == 0) continue;
                        if (labels2.Count == 0) continue;
                        if (modbus == null) continue;
                        if (RB_HoldingRegister.Checked)
                            for (int i = 0; i < labels2.Count; i++)
                            {
                                byte[]? value = ModbusTCP.ReadRegister(modbus.HoldingRegister, (ushort)(minAddress + i));
                                if (value != null) labels2[i].Invoke(new Action(() => labels2[i].Text = DataConverter.BytesToHexString(value)));
                            }
                        else if (RB_InputRegister.Checked)
                            for (int i = 0; i < labels2.Count; i++)
                            {
                                byte[]? value = ModbusTCP.ReadRegister(modbus.InputRegister, (ushort)(minAddress + i));
                                if (value != null) labels2[i].Invoke(new Action(() => labels2[i].Text = DataConverter.BytesToHexString(value)));
                            }
                    }
                    catch (Exception)
                    {

                    }
                }
            });
        }

        private void TB_MinAddress_TextChanged(object sender, EventArgs e)
        {
            if (modbus == null) return;
            if (!int.TryParse(TB_MinAddress.Text, out int min)) return;
            minAddress = min;
            if (minAddress < 0) return;
            if (maxAddress < minAddress) return;
            UpdateLabels();
        }

        private void TB_MaxAdress_TextChanged(object sender, EventArgs e)
        {
            if (modbus == null) return;
            if (!int.TryParse(TB_MaxAdress.Text, out int max)) return;
            maxAddress = max;
            if (minAddress < 0) return;
            if (maxAddress < minAddress) return;
            UpdateLabels();
        }

        #endregion

        private void BTN_ShowASCIICode_Click(object sender, EventArgs e)
        {
            LB_ASCII.Text = Encoding.ASCII.GetString(FinsTCPServer.WordByteReverse(DataConverter.HexStringToBytes(TB_ASCIICode.Text)));
        }
    }
}