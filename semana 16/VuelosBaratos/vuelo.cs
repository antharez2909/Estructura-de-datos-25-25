using System;

namespace VuelosBaratos
{
    // Clase que representa un vuelo con sus datos principales
    public class Vuelo
    {
        // Propiedades del vuelo (atributos)
        public string Origen { get; set; }       // Ciudad de origen
        public string Destino { get; set; }      // Ciudad de destino
        public string Aerolinea { get; set; }    // Nombre de la aerolínea
        public double Precio { get; set; }       // Precio del vuelo
        public string Fecha { get; set; }        // Fecha del vuelo

        // Constructor que inicializa los datos de cada vuelo
        public Vuelo(string origen, string destino, string aerolinea, double precio, string fecha)
        {
            Origen = origen;
            Destino = destino;
            Aerolinea = aerolinea;
            Precio = precio;
            Fecha = fecha;
        }

        // Método para mostrar la información de un vuelo en consola
        public void MostrarInfo()
        {
            Console.WriteLine($"Origen: {Origen} | Destino: {Destino} | Aerolínea: {Aerolinea} | Precio: ${Precio} | Fecha: {Fecha}");
        }
    }
}
