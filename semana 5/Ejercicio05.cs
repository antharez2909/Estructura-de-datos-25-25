using System;
using System.Collections.Generic; // Para usar List

public class Ejercicio05
{
    public static void Ejecutar()
    {
        // Crear una lista con los números del 1 al 20
        List<int> numeros = new List<int>();
        for (int i = 1; i <= 20; i++)
        {
            numeros.Add(i); // Agregar número a la lista
        }

        // Invertir la lista (del 20 al 1)
        numeros.Reverse();

        // Mostrar los números separados por comas
        Console.WriteLine("Números del 1 al 20 en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}
