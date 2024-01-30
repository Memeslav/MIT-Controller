using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIT_Controller
{
    public partial class Form1 : Form
    {
        byte[] data = new byte[1];

        public Form1()
        {
            InitializeComponent();

            serialPort1.PortName = "COM9";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialPort1.Read(data, 0, 1);

            string receivedDataHex = data[0].ToString("X2");
            MessageBox.Show($"Received data (HEX): {receivedDataHex}");

            serialPort1.Close();
        }
    }
}
