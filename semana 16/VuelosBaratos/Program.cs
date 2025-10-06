using System;

namespace VuelosBaratos
{
    // Clase principal donde se ejecuta el programa
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia del buscador de vuelos
            BuscadorVuelos buscador = new BuscadorVuelos();

            // Cargamos los datos iniciales (base ficticia)
            buscador.CargarVuelos();

            int opcion; // Variable para controlar el menú

            do
            {
                Console.Clear(); // Limpia la pantalla
                Console.WriteLine("=== SISTEMA DE VUELOS BARATOS ===");
                Console.WriteLine("1. Ver todos los vuelos");
                Console.WriteLine("2. Buscar vuelo más barato");
                Console.WriteLine("3. Ver cantidad total de vuelos");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                // Convertimos la opción ingresada por el usuario en número entero
                opcion = int.Parse(Console.ReadLine());

                // Menú de opciones principales
                switch (opcion)
                {
                    case 1:
                        // Opción 1: Mostrar todos los vuelos disponibles
                        buscador.MostrarTodos();
                        break;

                    case 2:
                        // Opción 2: Buscar el vuelo más barato entre dos ciudades
                        Console.Write("\nIngrese ciudad de origen: ");
                        string origen = Console.ReadLine();
                        Console.Write("Ingrese ciudad de destino: ");
                        string destino = Console.ReadLine();

                        // Llamamos al método para buscar el vuelo más barato
                        var vueloBarato = buscador.BuscarMasBarato(origen, destino);

                        // Verificamos si se encontró un vuelo
                        if (vueloBarato != null)
                        {
                            Console.WriteLine("\n=== VUELO MÁS BARATO ENCONTRADO ===");
                            vueloBarato.MostrarInfo();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay vuelos disponibles para esa ruta.");
                        }
                        break;

                    case 3:
                        // Opción 3: Mostrar cuántos vuelos hay en total
                        Console.WriteLine($"\nCantidad total de vuelos registrados: {buscador.ContarVuelos()}");
                        break;
                }

                // Pausa antes de volver al menú
                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 0); // Repite mientras no elija salir

            // Mensaje final
            Console.WriteLine("Programa finalizado.");
        }
    }
}
