using System;

namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    public class Estudiante
    {
        // Propiedades del estudiante
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        // Constructor para inicializar los datos
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo con los teléfonos
            string[] telefonos = new string[3] { "099111222", "098333444", "097555666" };

            // Crear un objeto estudiante con datos de ejemplo
            Estudiante estudiante1 = new Estudiante(1, "Juan", "Pérez", "Av. Siempre Viva 123", telefonos);

            // Mostrar los datos en consola
            estudiante1.MostrarDatos();

            Console.ReadKey(); // Esperar una tecla para cerrar
        }
    }
}
