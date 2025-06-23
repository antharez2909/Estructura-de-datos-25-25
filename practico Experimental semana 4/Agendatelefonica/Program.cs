using System; // Para usar Console
using AgendaTelefonica.Models; // Para usar clases de contacto
using AgendaTelefonica.Services; // Para usar la clase Agenda

namespace AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una agenda con capacidad para 10 contactos
            Agenda agenda = new Agenda(10);

            // Agrega contactos (2 personales y 2 profesionales)
            agenda.AgregarContacto(new ContactoPersonal("Edison Stiven Remache Cuello", "0980224624", "Amigo"));
            agenda.AgregarContacto(new ContactoPersonal("Jeremy Sebastian Remache Cuello", "0980224624", "Sobrino"));
            agenda.AgregarContacto(new ContactoProfesional("Juan Adrian Pilco Venavidez", "0988336618", "Gerente de ventas"));
            agenda.AgregarContacto(new ContactoProfesional("Carlos Estevan Yepez Narvaez", "0991516201", "Estudiante UEA"));

            // Ordena contactos por nombre
            agenda.OrdenarPorNombre();

            // Muestra la lista completa de contactos
            agenda.MostrarContactos();

            // Solicita nombre para buscar en la agenda
            Console.WriteLine("\nBuscar contacto por nombre:");
            Console.Write("Ingrese nombre a buscar: ");
            string nombre = Console.ReadLine()!;

            // Busca y muestra el contacto si existe
            agenda.BuscarContacto(nombre);
        }
    }
}
