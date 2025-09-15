using System;

namespace CatalogoRevistas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== Catálogo de Revistas =====");
                Console.WriteLine("1. Buscar revista");
                Console.WriteLine("2. Mostrar catálogo");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nIngrese el título a buscar: ");
                        string titulo = Console.ReadLine();

                        bool encontrado = Busqueda.BuscarRecursivo(Catalogo.revistas, titulo, 0);

                        Console.WriteLine(encontrado ? "\nResultado: Encontrado" : "\nResultado: No encontrado");
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Catalogo.MostrarCatalogo();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 3);
        }
    }
}
