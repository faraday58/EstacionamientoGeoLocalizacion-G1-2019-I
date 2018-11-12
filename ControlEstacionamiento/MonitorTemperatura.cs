using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace ControlEstacionamiento
{
    public partial class MonitorTemperatura : Form
    {
        SerialPort serialPort;
        int tiempoTemp;
        int temperatura;

        public MonitorTemperatura(SerialPort serialPort,ControlGeneral controlGeneral)
        {
            InitializeComponent();
            this.serialPort = serialPort;
            this.MdiParent = controlGeneral;
        }

        private void tiempoTemperatura_Tick(object sender, EventArgs e)
        {
            temperatura = serialPort.ReadByte();
            chtTiempoTemperatura.Series[0].Points.AddXY(tiempoTemp++, temperatura);

        }

        private void graficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempoTemperatura.Start();
        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempoTemperatura.Stop();
        }
    }
}
