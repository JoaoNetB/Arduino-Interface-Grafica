using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ProgramaLEDs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                comboBox1.SelectedIndex = 0;
                serialPort1.BaudRate = 9600;
                serialPort1.ReadTimeout = 2000;
                serialPort1.WriteTimeout = 2000;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LED1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("1");
            }
            serialPort1.Close();
        }

        private void LED2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("2");
            }
            serialPort1.Close();
        }

        private void LED3_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("3");
            }
            serialPort1.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("4");
            }
            serialPort1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
