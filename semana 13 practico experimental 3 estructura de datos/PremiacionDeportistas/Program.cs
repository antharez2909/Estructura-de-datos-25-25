using System;                                    // Librería básica para entrada/salida en consola
using PremiacionDeportistas.Servicios;           // Importa nuestras clases que están en la carpeta Servicios

namespace PremiacionDeportistas
{
    class Program
    {
        static void Main(string[] args)          // Punto de inicio del programa
        {
            // Mensaje de bienvenida
            Console.WriteLine("🏆 Aplicación de Premiación de Deportistas\n");

            // Llamamos a los métodos de Reporteria
            Reporteria.MostrarDisciplinas();        // 1. Muestra las disciplinas y sus deportistas
            Reporteria.PremiarDeportistas();        // 2. Premia a los ganadores por disciplina
            Reporteria.MostrarParticipacionTotal(); // 3. Lista todos los deportistas únicos (sin duplicados)
            Reporteria.MostrarMultidisciplina();    // 4. Muestra quiénes participan en varias disciplinas

            // Mensaje final y espera
            Console.WriteLine("\n✅ Programa finalizado. Presiona una tecla para salir.");
            Console.ReadKey();                      // Evita que la consola se cierre de inmediato
        }
    }
}
