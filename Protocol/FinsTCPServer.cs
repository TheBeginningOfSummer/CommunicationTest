using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static MyToolkit.ConnectionToolkit;

namespace CommunicationsToolkit
{
    public class FinsTCPServer
    {
        public SocketConnection Connection { get; set; }
        public byte[] WArea;
        public byte[] HArea;
        public byte[] DArea;

        public FinsTCPServer()
        {
            Connection = new SocketConnection();
            WArea = new byte[100];
            HArea = new byte[100];
            DArea = new byte[100];
            Connection.ReceiveFromClient += MessageHandling;
        }

        public void MessageHandling(Socket client, byte[] data)
        {
            //byte[]? response = ParseMessage(data);
            //if (response != null)
            //    client.Send(response);
        }

        public byte[]? ParseMessage()
        {

            return default;
        }

        public byte[] HandshakeResponse(int pcIP, int plcIP)
        {
            byte[] response = new byte[24];
            response[0] = 0x46;
            response[1] = 0x49;
            response[2] = 0x4E;
            response[3] = 0x53;
            response[7] = 0x10;
            response[19] = (byte)pcIP;
            response[23] = (byte)plcIP;
            return response;
        }
    }
}
