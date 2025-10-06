using System;
using System.Collections.Generic;
using System.Linq;

namespace VuelosBaratos
{
    // Clase encargada de manejar la lista de vuelos y las búsquedas
    public class BuscadorVuelos
    {
        // Lista (estructura de datos) que almacena los objetos de tipo Vuelo
        private List<Vuelo> vuelos = new List<Vuelo>();

        // Método que carga una base de datos ficticia de vuelos
        public void CargarVuelos()
        {
            // Agregamos vuelos manualmente a la lista (simula una base de datos)
            vuelos.Add(new Vuelo("Quito", "Guayaquil", "LATAM", 120.50, "2025-10-15"));
            vuelos.Add(new Vuelo("Quito", "Cuenca", "Avianca", 90.00, "2025-10-16"));
            vuelos.Add(new Vuelo("Guayaquil", "Cuenca", "TAME", 70.00, "2025-10-17"));
            vuelos.Add(new Vuelo("Quito", "Guayaquil", "Avianca", 110.00, "2025-10-15"));
            vuelos.Add(new Vuelo("Cuenca", "Quito", "LATAM", 95.00, "2025-10-18"));
        }

        // Método que muestra todos los vuelos almacenados en la lista
        public void MostrarTodos()
        {
            Console.WriteLine("\n=== LISTA DE VUELOS DISPONIBLES ===");
            foreach (var vuelo in vuelos)
            {
                vuelo.MostrarInfo();  // Llama al método MostrarInfo() de cada objeto Vuelo
            }
        }

        // Método que busca el vuelo más barato entre dos ciudades dadas
        public Vuelo BuscarMasBarato(string origen, string destino)
        {
            // Filtramos los vuelos que coincidan con el origen y destino ingresados
            var disponibles = vuelos.Where(v => v.Origen == origen && v.Destino == destino).ToList();

            // Si no existen vuelos para esa ruta, devolvemos null
            if (disponibles.Count == 0) return null;

            // Ordenamos por precio y devolvemos el más barato
            return disponibles.OrderBy(v => v.Precio).First();
        }

        // Método que devuelve el número total de vuelos en la lista
        public int ContarVuelos() => vuelos.Count;
    }
}
