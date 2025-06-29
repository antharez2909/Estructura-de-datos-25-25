using System;
using System.Collections.Generic; // Para usar List

public class Ejercicio03
{
    public static void Ejecutar()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua",
            "Educación Física",
            "Biología",
            "Inglés",
            "Informática",
            "Arte"
        };

        // Lista para almacenar las notas ingresadas por el usuario
        List<double> notas = new List<double>();

        // Solicitar la nota de cada asignatura
        foreach (string asignatura in asignaturas)
        {
            Console.Write($"Introduce la nota de {asignatura}: ");
            double nota = Convert.ToDouble(Console.ReadLine()); // Convertir lo ingresado a número
            notas.Add(nota); // Guardar nota en la lista
        }

        // Mostrar todas las notas con sus respectivas asignaturas
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }
    }
}
// Ejemplo de uso