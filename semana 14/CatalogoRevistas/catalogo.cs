using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    public static class Catalogo
    {
        // Lista estática con las revistas
        public static List<string> revistas = new List<string>()
        {
            "National Geographic",
            "Time",
            "Forbes",
            "People",
            "Nature",
            "Scientific American",
            "The Economist",
            "Sports Illustrated",
            "Vogue",
            "Rolling Stone"
        };

        // Método para mostrar catálogo
        public static void MostrarCatalogo()
        {
            Console.WriteLine("\n=== Catálogo de Revistas ===");
            foreach (var revista in revistas)
            {
                Console.WriteLine("- " + revista);
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
