namespace Estacionamientos
{
    public class Estacionamiento
    {
        private string nombre;
        private double longitud;
        private double latitud;
        private string direccion;

       

        public string Nombre { get => nombre; set => nombre = value; }
        public double Longitud { get => longitud; set => longitud = value; }
        public double Latitud { get => latitud; set => latitud = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Estacionamiento(string nombre, double longitud, double latitud, string direccion)
        {
            Nombre = nombre;
            Longitud = longitud;
            Latitud = latitud;
            Direccion = direccion;
        }
    }


}
