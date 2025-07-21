using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear diccionario con las atracciones y su capacidad
            Dictionary<int, Atraccion> atracciones = new Dictionary<int, Atraccion>
            {
                {1, new Atraccion("Montaña Rusa", 30)},
                {2, new Atraccion("Carros Chocones", 30)},
                {3, new Atraccion("Casa Embrujada", 30)},
                {4, new Atraccion("Tiro al Blanco", 30)},
                {5, new Atraccion("Castillo Inflable", 30)}
            };

            int opcion;

            // Bucle principal que muestra el menú hasta que el usuario salga
            do
            {
                Console.WriteLine("\n🎠 MENÚ PRINCIPAL 🎠");
                Console.WriteLine("1. Ingresar personas a una atracción");
                Console.WriteLine("2. Ver cantidad de personas por atracción");
                Console.WriteLine("3. Ver asignaciones de una atracción");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

                switch (opcion)
                {
                    case 1:
                        int atraccionElegida = ElegirAtraccion();

                        if (atracciones.ContainsKey(atraccionElegida))
                        {
                            var atraccion = atracciones[atraccionElegida];
                            int espacioDisponible = 30 - atraccion.CantidadPersonas();

                            Console.Write($"Ingrese la cantidad de personas a asignar (max {espacioDisponible}): ");

                            if (int.TryParse(Console.ReadLine(), out int cantidad))
                            {
                                if (cantidad <= 0)
                                    Console.WriteLine("⚠️ Debe ingresar una cantidad positiva.");
                                else if (cantidad > espacioDisponible)
                                    Console.WriteLine($"🚫 Solo hay espacio para {espacioDisponible} personas.");
                                else
                                {
                                    for (int i = 1; i <= cantidad; i++)
                                    {
                                        string nombre = $"Persona {atraccion.CantidadPersonas() + 1}";
                                        atraccion.AsignarAsiento(nombre);
                                    }
                                    Console.WriteLine($"✅ Se asignaron {cantidad} personas a la atracción {atraccion.Nombre}.");
                                }
                            }
                            else
                                Console.WriteLine("⚠️ Entrada inválida.");
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Opción inválida de atracción.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nCantidad de personas en cada atracción:");
                        foreach (var kvp in atracciones)
                        {
                            Console.WriteLine($"{kvp.Value.Nombre}: {kvp.Value.CantidadPersonas()} personas");
                        }
                        break;

                    case 3:
                        int verAtraccion = ElegirAtraccion();
                        if (atracciones.ContainsKey(verAtraccion))
                        {
                            atracciones[verAtraccion].MostrarAsignaciones();
                        }
                        else
                        {
                            Console.WriteLine("⚠️ Opción inválida.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("👋 Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción no válida.");
                        break;
                }

            } while (opcion != 4);
        }

        // Muestra el menú de atracciones y devuelve la opción seleccionada por el usuario
        static int ElegirAtraccion()
        {
            Console.WriteLine("\nSeleccione una atracción:");
            Console.WriteLine("1. Montaña Rusa");
            Console.WriteLine("2. Carros Chocones");
            Console.WriteLine("3. Casa Embrujada");
            Console.WriteLine("4. Tiro al Blanco");
            Console.WriteLine("5. Castillo Inflable");
            Console.Write("Opción: ");

            int.TryParse(Console.ReadLine(), out int opcion);
            return opcion;
        }
    }
}
