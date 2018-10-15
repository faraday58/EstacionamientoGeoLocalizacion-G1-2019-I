using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vehiculos;

namespace ControlEstacionamiento
{
    public partial class Form1 : Form
    {
        Vehiculo miVehiculo; 
        Queue<Vehiculo> vehiculos;
        public Form1()
        {
            InitializeComponent();
            vehiculos = new Queue<Vehiculo>();
        }

        private void dgvDatosVehículo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int rowselect = dgvDatosVehículo.SelectedCells.;
            //miVehiculo = new Vehiculo(dgvDatosVehículo.Rows[]
            //vehiculos.Enqueue
            
        }

        private void dgvDatosVehículo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int renglon = e.RowIndex;
            miVehiculo = new Vehiculo(dgvDatosVehículo.Rows[renglon].Cells[0].Value.ToString(), dgvDatosVehículo.Rows[renglon].Cells[1].Value.ToString(), int.Parse(dgvDatosVehículo.Rows[renglon].Cells[2].Value.ToString()), 32.5f, dgvDatosVehículo.Rows[renglon].Cells[3].Value.ToString(), dgvDatosVehículo.Rows[renglon].Cells[4].Value.ToString());

        }
    }
}
