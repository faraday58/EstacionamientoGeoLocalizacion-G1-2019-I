using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace ControlEstacionamiento
{
    public partial class EncendidoLuz : Form
    {
        SerialPort serialPort;
        bool boton = false;
        public EncendidoLuz(SerialPort serialPort, ControlGeneral formcontrol )
        {
            InitializeComponent();
            this.serialPort = serialPort;
            pictureBox1.BackColor = Color.Black;
            this.MdiParent = formcontrol;
        }

        private void btnPrendeApaga_Click(object sender, EventArgs e)
        {
            if (!boton)
            {
                serialPort.Write("a");
                pictureBox1.BackColor = Color.Yellow;
                boton = true;
            }
            else
            {
                serialPort.Write("b");
                pictureBox1.BackColor = Color.Black;
                boton = false;
            }

        }
    }
}
