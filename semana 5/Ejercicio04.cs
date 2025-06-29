using System;
using System.Collections.Generic; // Para usar List

public class Ejercicio04
{
    public static void Ejecutar()
    {
        // Lista para guardar los números ganadores ingresados por el usuario
        List<int> numerosGanadores = new List<int>();

        Console.WriteLine("Introduce 6 números ganadores de la lotería primitiva:");

        // Pedir 6 números al usuario y agregarlos a la lista
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine()); // Convertir entrada a entero
            numerosGanadores.Add(numero);
        }

        // Ordenar la lista de menor a mayor
        numerosGanadores.Sort();

        // Mostrar los números ganadores ordenados
        Console.WriteLine("Números ganadores ordenados:");
        numerosGanadores.ForEach(n => Console.Write(n + " "));
        Console.WriteLine(); // Salto de línea final
    }
}
