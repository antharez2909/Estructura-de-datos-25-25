using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("EJERCICIOS SEMANA 05");

        while (true)
        {
            Console.WriteLine("\nSeleccione un ejercicio (1 - 5), o 0 para salir:");

            string? opcion = Console.ReadLine();

            if (string.IsNullOrEmpty(opcion))
            {
                Console.WriteLine("No se ingresó ninguna opción. Intente nuevamente.");
                continue;
            }

            switch (opcion)
            {
                case "1":
                    Ejercicio01.Ejecutar();
                    break;
                case "2":
                    Ejercicio02.Ejecutar();
                    break;
                case "3":
                    Ejercicio03.Ejecutar();
                    break;
                case "4":
                    Ejercicio04.Ejecutar();
                    break;
                case "5":
                    Ejercicio05.Ejecutar();
                    break;
                case "0":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}
