using System;                          // Para imprimir en consola
using System.Collections.Generic;      // Para usar colecciones (Dictionary, HashSet)
using System.Linq;                     // Para ordenar con LINQ (OrderBy)

namespace PremiacionDeportistas.Servicios
{
    public static class Reporteria
    {
        // -------------------------------------------------
        // Muestra cada disciplina con su lista de jugadores
        // -------------------------------------------------
        public static void MostrarDisciplinas()
        {
            Console.WriteLine("\n🏅 Disciplinas y participantes:");
            foreach (var deporte in GestionDisciplinas.Disciplinas)
            {
                // deporte.Key = nombre de la disciplina
                // deporte.Value = conjunto de jugadores
                Console.WriteLine($" - {deporte.Key}: {string.Join(", ", deporte.Value)}");
            }
        }

        // -------------------------------------------------
        // Premia al primer deportista en orden alfabético
        // -------------------------------------------------
        public static Dictionary<string, string> PremiarDeportistas()
        {
            Console.WriteLine("\n🎖️ Premiación por disciplina:");
            var ganadores = new Dictionary<string, string>(); // Guardará los ganadores

            foreach (var deporte in GestionDisciplinas.Disciplinas)
            {
                // Ordenamos alfabéticamente los nombres y tomamos el primero
                string ganador = deporte.Value.OrderBy(nombre => nombre).First();

                // Guardamos el resultado en el diccionario de ganadores
                ganadores[deporte.Key] = ganador;

                // Mostramos en consola
                Console.WriteLine($" -> {deporte.Key}: {ganador}");
            }

            return ganadores;
        }

        // -------------------------------------------------
        // Une todos los deportistas de todas las disciplinas
        // (sin duplicados, gracias a HashSet)
        // -------------------------------------------------
        public static HashSet<string> MostrarParticipacionTotal()
        {
            HashSet<string> todos = new HashSet<string>(); // Conjunto vacío

            foreach (var jugadores in GestionDisciplinas.Disciplinas.Values)
            {
                todos.UnionWith(jugadores); // Se agregan los jugadores de cada disciplina
            }

            Console.WriteLine("\n📋 Deportistas únicos registrados: " + string.Join(", ", todos));
            return todos;
        }

        // -------------------------------------------------
        // Encuentra a los jugadores que participan en
        // más de una disciplina (intersección de conjuntos)
        // -------------------------------------------------
        public static HashSet<string> MostrarMultidisciplina()
        {
            var listas = GestionDisciplinas.Disciplinas.Values.ToList(); // Lista de todos los conjuntos
            HashSet<string> comunes = new HashSet<string>(listas[0]);    // Empezamos con el primer grupo

            for (int i = 1; i < listas.Count; i++)
            {
                comunes.IntersectWith(listas[i]); // Solo deja los que están en común
            }

            Console.WriteLine("\n🤝 Deportistas que participan en varias disciplinas: " +
                              (comunes.Count > 0 ? string.Join(", ", comunes) : "Ninguno"));

            return comunes;
        }
    }
}
