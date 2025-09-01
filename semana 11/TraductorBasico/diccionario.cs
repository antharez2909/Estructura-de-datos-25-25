using System;
using System.Collections.Generic;

public static class Diccionario
{
    // Diccionario Español → Inglés (base de datos inicial)
    public static Dictionary<string, string> Palabras = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"forma", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"niña", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"tema", "point"},
        {"gobierno", "government"},
        {"empresa", "company"},
        {"compañía", "company"}
    };

    // Método para agregar nuevas palabras al diccionario
    public static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string esp = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese la traducción en inglés: ");
        string eng = Console.ReadLine().Trim().ToLower();

        if (!Palabras.ContainsKey(esp))
        {
            Palabras.Add(esp, eng);
            Console.WriteLine($"✅ Palabra agregada: {esp} → {eng}");
        }
        else
        {
            Console.WriteLine("⚠️ La palabra ya existe en el diccionario.");
        }
    }
}
