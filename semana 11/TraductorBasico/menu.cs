using System;

public static class Menu
{
    // Muestra el menú y controla la interacción con el usuario
    public static void Mostrar()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1; // valor inválido
            }

            switch (opcion)
            {
                case 1:
                    // Llama a la función de traducción
                    Traductor.TraducirFrase();
                    break;
                case 2:
                    // Llama a la función para agregar palabras
                    Diccionario.AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida, intente de nuevo.");
                    break;
            }

        } while (opcion != 0); // el programa termina solo si el usuario elige 0
    }
}
