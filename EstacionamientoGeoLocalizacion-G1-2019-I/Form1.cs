using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Estacionamientos;

namespace EstacionamientoGeoLocalizacion_G1_2019_I
{
    public partial class Form1 : Form
    {
        //Listas
        Estacionamiento estacionamiento;
        List<Estacionamiento> lstEstacionamientos;

        public Form1()
        {
            InitializeComponent();

            lstEstacionamientos = new List<Estacionamiento>();
            lstEstacionamientos.Add(new Estacionamiento("Anexo Ingeniería",19.325419,-99.182945,"Estacionamiento profesores"));
            lstEstacionamientos.Add(new Estacionamiento("Contabilidad", 19.323207, -99.183732, "Estacionamiento de Alumnos"));
            lstEstacionamientos.Add(new Estacionamiento("Estadio", 19.330447, -99.190688, "Estacionamiento de Alumnos número 8"));

            for(int i=0; i < lstEstacionamientos.Count; i++)
            {
                lstbDirecciones.Items.Add(lstEstacionamientos[i].Nombre);
            }
           

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstEstacionamientos.Add(new Estacionamiento(txtbNombre.Text, double.Parse(txtbLongitud.Text), double.Parse(txtbLatitud.Text), txtbDireccion.Text));
            lstbDirecciones.Items.Add(lstEstacionamientos[lstEstacionamientos.Count-1].Nombre);

            txtbDireccion.Clear();
            txtbNombre.Clear();
            txtbLatitud.Clear();
            txtbLongitud.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lstEstacionamientos.RemoveAt(lstbDirecciones.SelectedIndex);
            lstbDirecciones.Items.RemoveAt(lstbDirecciones.SelectedIndex);
        }
    }
}
