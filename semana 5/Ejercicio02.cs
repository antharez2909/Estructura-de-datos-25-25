using System;
using System.Collections.Generic; // Para usar List

public class Ejercicio02
{
    public static void Ejecutar()
    {
        // Crear la lista de asignaturas
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

        // Mostrar el mensaje "Yo estudio <asignatura>" para cada materia
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
