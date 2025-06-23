using AgendaTelefonica.Models; // Importa las clases de contacto

// Namespace para servicios o lógica del proyecto
namespace AgendaTelefonica.Services
{
    // Clase Agenda que gestiona los contactos
    public class Agenda
    {
        private Contacto[] contactos; // Vector para almacenar contactos
        private int contador; // Contador para saber cuántos contactos hay

        // Constructor que inicializa la agenda con una capacidad fija
        public Agenda(int capacidad)
        {
            contactos = new Contacto[capacidad]; // Crea el vector con tamaño 'capacidad'
            contador = 0; // Inicializa el contador en 0
        }

        // Método para agregar un contacto a la agenda
        public void AgregarContacto(Contacto contacto)
        {
            if (contador < contactos.Length) // Si hay espacio en el vector
            {
                contactos[contador++] = contacto; // Agrega el contacto y aumenta el contador
            }
            else
            {
                Console.WriteLine("Agenda llena. No se puede agregar más contactos."); // Mensaje si no hay espacio
            }
        }

        // Método para mostrar todos los contactos almacenados
        public void MostrarContactos()
        {
            Console.WriteLine("\n--- Lista de Contactos ---");
            for (int i = 0; i < contador; i++) // Recorre solo los contactos agregados
            {
                contactos[i].Mostrar(); // Llama al método Mostrar según el tipo de contacto
                Console.WriteLine("---------------------------");
            }
        }

        // Método para ordenar los contactos por nombre alfabéticamente
        public void OrdenarPorNombre()
        {
            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    // Compara los nombres sin diferenciar mayúsculas/minúsculas
                    if (string.Compare(contactos[i].Nombre, contactos[j].Nombre, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        var temp = contactos[i]; // Intercambia contactos
                        contactos[i] = contactos[j];
                        contactos[j] = temp;
                    }
                }
            }
        }

        // Método para buscar un contacto por nombre
        public void BuscarContacto(string nombre)
        {
            bool encontrado = false; // Variable para indicar si encontró el contacto

            for (int i = 0; i < contador; i++) // Recorre la agenda
            {
                // Compara nombres ignorando mayúsculas/minúsculas
                if (contactos[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nContacto encontrado:");
                    contactos[i].Mostrar(); // Muestra el contacto encontrado
                    encontrado = true;
                    break; // Sale del ciclo al encontrar el contacto
                }
            }

            if (!encontrado) // Si no encontró ningún contacto
            {
                Console.WriteLine("Contacto no encontrado.");
            }
        }
    } // Fin de la clase Agenda
} // Fin del namespace
