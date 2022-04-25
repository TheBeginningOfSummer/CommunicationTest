using System.Configuration;
using System.IO.Ports;

namespace CommunicationsToolkit
{
    public partial class SerialPortSet : Form
    {
        public SerialPortSet()
        {
            InitializeComponent();
        }

        private void SerialPortSet_Load(object sender, EventArgs e)
        {
            CB_BaudRate.Items.Add("9600");
            CB_BaudRate.Items.Add("115200");

            string[] ports = SerialPort.GetPortNames();//获取端口号
            for (int i = 0; i < ports.Length; i++)
                CB_SerialPort.Items.Add(ports[i]);

            CB_BaudRate.Text = ConfigurationManager.AppSettings["BaudRate"]!.ToString();
            CB_SerialPort.Text = ConfigurationManager.AppSettings["Port"]!.ToString();
        }

        private void BTN_Set_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["BaudRate"].Value = this.CB_BaudRate.Text;
            config.AppSettings.Settings["Port"].Value = this.CB_SerialPort.Text;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
            this.Close();
        }
    }
}
