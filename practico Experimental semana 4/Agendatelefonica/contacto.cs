using System;

namespace AgendaTelefonica.Models
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string NumeroTelefono { get; set; }

        public Contacto(string nombre, string numeroTelefono)
        {
            Nombre = nombre;
            NumeroTelefono = numeroTelefono;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Teléfono: {NumeroTelefono}");
        }
    }
}
