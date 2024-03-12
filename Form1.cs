using System.IO.Ports;

namespace SerialComm
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = portBox.Text;
                    serialPort.BaudRate = Convert.ToInt32(speedBox.Text);
                    serialPort.DataBits = Convert.ToInt32(formatBox.Text);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsBox.Text);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parityControlBox.Text);

                    serialPort.Open();
                    connectionInfoLabel.Text = "Po³¹czono";
                    connectionInfoLabel.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                connectionInfoLabel.Text = "Nie po³¹czono";
                connectionInfoLabel.ForeColor = Color.Red;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(inputText.Text);
            }
        }
    }
}