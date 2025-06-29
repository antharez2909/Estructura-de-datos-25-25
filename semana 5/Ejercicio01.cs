using System;
using System.Collections.Generic; // Para usar List

public class Ejercicio01
{
    public static void Ejecutar()
    {
        // Crear una lista con las asignaturas del curso
        List<string> asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua",
            "Educacíon Física",
            "Biología",
            "Inglés",
            "Informática",
            "Arte"
        };

        // Imprimir en pantalla cada asignatura
        Console.WriteLine("Asignaturas del curso:");
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
