using System;
using System.Text.RegularExpressions;

public static class Traductor
{
    // Traduce una frase ingresada por el usuario
    public static void TraducirFrase()
    {
        Console.Write("Ingrese una frase en español: ");
        string frase = Console.ReadLine();

        // Separa las palabras sin perder signos de puntuación
        string[] palabras = frase.Split(' ', ',', '.', ';', '!', '?');
        string resultado = frase;

        // Revisa cada palabra de la frase
        foreach (string palabra in palabras)
        {
            if (Diccionario.Palabras.ContainsKey(palabra.ToLower()))
            {
                string traduccion = Diccionario.Palabras[palabra.ToLower()];
                resultado = ReemplazarPalabra(resultado, palabra, traduccion);
            }
        }

        Console.WriteLine("Traducción parcial: " + resultado);
    }

    // Reemplaza la palabra en la frase, manteniendo mayúsculas/minúsculas
    private static string ReemplazarPalabra(string texto, string original, string traduccion)
    {
        return Regex.Replace(
            texto,
            $@"\b{original}\b",   // busca la palabra exacta
            traduccion,
            RegexOptions.IgnoreCase
        );
    }
}
