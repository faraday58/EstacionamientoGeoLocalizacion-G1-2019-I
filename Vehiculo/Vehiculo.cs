

namespace Vehiculos
{
    public class Vehiculo
    { 
 
        private string placa;
        private string horaEntrada;
        private int cajon;
        private float tarifa;
        private string detalles;
        private string horaSalida;

        #region Propiedades
        public string Placa { get => placa; set => placa = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int Cajon { get => cajon; set => cajon = value; }
        public float Tarifa { get => tarifa; set => tarifa = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }

        #endregion

        public Vehiculo(string placa, string horaEntrada, int cajon, float tarifa, string detalles, string horaSalida)
        {
            this.placa = placa;
            this.horaEntrada = horaEntrada;
            this.cajon = cajon;
            this.tarifa = tarifa;
            this.detalles = detalles;
            this.horaSalida = horaSalida;
        }

        
    }
}
