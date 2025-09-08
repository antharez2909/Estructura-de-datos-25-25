using System.Collections.Generic; // Importa colecciones como Dictionary y HashSet

namespace PremiacionDeportistas.Servicios
{
    public static class GestionDisciplinas
    {
        // Diccionario principal del programa:
        // clave = nombre de la disciplina (ej: "Fútbol")
        // valor = conjunto de deportistas (HashSet evita repetidos)
        public static Dictionary<string, HashSet<string>> Disciplinas =
            new Dictionary<string, HashSet<string>>()
            {
                // Se inicializan tres disciplinas con sus respectivos deportistas
                { "Fútbol", new HashSet<string> { "Carlos", "María", "Pedro" } },
                { "Natación", new HashSet<string> { "Ana", "Pedro", "Lucía" } },
                { "Atletismo", new HashSet<string> { "María", "José", "Lucía" } }
            };
    }
}
