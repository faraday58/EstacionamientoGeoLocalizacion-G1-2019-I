using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace ControlEstacionamiento
{
    public partial class ControlGeneral : Form
    {
        SerialPort serialPort;

        public ControlGeneral()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            selecciona();
        }

        public void selecciona()
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            tscmbpuertos.Items.AddRange(puertos);
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = tscmbpuertos.SelectedItem.ToString();
                serialPort.BaudRate = int.Parse(tscmbVelocidad.SelectedItem.ToString());
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Open();
        }

        private void encenderLuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncendidoLuz encendidoLuz = new EncendidoLuz(serialPort, this);
            encendidoLuz.Show();
        }

        private void monitorTemperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorTemperatura monitorTemperatura = new MonitorTemperatura(serialPort, this);
            monitorTemperatura.Show();
        }
    }
}
