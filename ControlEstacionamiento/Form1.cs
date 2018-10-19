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
            try
            {
                int renglon = e.RowIndex;
                
                
                miVehiculo = new Vehiculo(dgvDatosVehículo.Rows[renglon].Cells[0].Value.ToString(), dgvDatosVehículo.Rows[renglon].Cells[1].Value.ToString(), int.Parse(dgvDatosVehículo.Rows[renglon].Cells[4].Value.ToString()), 32.5f, dgvDatosVehículo.Rows[renglon].Cells[3].Value.ToString(), dgvDatosVehículo.Rows[renglon].Cells[2].Value.ToString());
                vehiculos.Enqueue(miVehiculo);
                MessageBox.Show("Vehículo ingresado");
                timerEstacionamiento.Enabled = true;
                errorProvider1.Clear();
            }
            catch (FormatException error)
            {
                errorProvider1.SetError(dgvDatosVehículo, error.Message);
            }
            catch (NullReferenceException )
            {
                errorProvider1.SetError(dgvDatosVehículo, "Llena todos los campos, por favor bombón");
            }
            
        }
        int i = 0;
        Random valorauto;
        private void timerEstacionamiento_Tick(object sender, EventArgs e)
        {
            i++;
            lb_timer.Text = i.ToString() + " s";
            valorauto = new Random();
            int valor= valorauto.Next(1, 3);
            switch(valor )
            {
                case 1:
                    this.ptbCroquis.Image = global::ControlEstacionamiento.Properties.Resources.coche1;
                    break;
                case 2:
                    this.ptbCroquis.Image = global::ControlEstacionamiento.Properties.Resources.coche2;
                    break;
                case 3:
                    this.ptbCroquis.Image = global::ControlEstacionamiento.Properties.Resources.coche3;
                    break;

            }
            

        }
    }
}
