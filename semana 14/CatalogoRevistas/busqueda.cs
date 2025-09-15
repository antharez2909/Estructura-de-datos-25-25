using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    public static class Busqueda
    {
        // Método recursivo de búsqueda
        public static bool BuscarRecursivo(List<string> lista, string titulo, int indice)
        {
            if (indice >= lista.Count)
                return false;

            if (lista[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;

            return BuscarRecursivo(lista, titulo, indice + 1);
        }
    }
}
