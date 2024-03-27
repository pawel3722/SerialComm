using System.Diagnostics;
using System.IO.Ports;
using System.Xml.Linq;

namespace SerialComm
{
    public partial class SerialComm : Form
    {
        SerialPort serialPort = new SerialPort();
        string receivedText = "";
        string terminator = "";
        long nanosecPerTick = (1000L * 1000L * 1000L) / Stopwatch.Frequency;
        public SerialComm()
        {
            InitializeComponent();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;         
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

                    if (controlBox.Text == "RTS/CTS")
                        serialPort.Handshake = Handshake.RequestToSend;
                    else if (controlBox.Text == "XON/XOFF")
                        serialPort.Handshake = Handshake.XOnXOff;
                    else
                        serialPort.Handshake = Handshake.None;

                    if (terminatorBox.Text == "CR")
                        terminator = "\r";
                    else if (terminatorBox.Text == "LF")
                        terminator = "\n";
                    else if (terminatorBox.Text == "CR-LF")
                        terminator = "\r\n";
                    else if (terminatorBox.Text == "W³asny")
                    {
                        terminator = "";
                        terminator += (char)numericUpDown1.Value;
                        terminator += (char)numericUpDown2.Value;

                    }
                    int size = terminator.Length;
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
                string text = inputText.Text;
                text += terminator;
                serialPort.Write(text);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (outputText.Text != "")
                outputText.Text = "";
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            receivedText = serialPort.ReadExisting();
            this.Invoke(new EventHandler(updateOutputText));
        }

        private void updateOutputText(object? sender, EventArgs e)
        {
            outputText.Text += receivedText;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = radioButton1.Checked || radioButton2.Checked;
            numericUpDown2.Enabled = radioButton2.Checked;
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                bool wasPinged = false;
                Stopwatch sw = new Stopwatch();
                serialPort.Write("ping");
                sw.Start();
                while (sw.ElapsedMilliseconds < 5000)
                {
                    if(serialPort.CtsHolding)
                    {
                        wasPinged = true;
                        break;
                    }
                }
                sw.Stop();
                receivedText = wasPinged ? (sw.ElapsedTicks * nanosecPerTick).ToString() + " ns" : "Time exceeded.";
                this.Invoke(new EventHandler(updateOutputText));
            }
        }
    }
}