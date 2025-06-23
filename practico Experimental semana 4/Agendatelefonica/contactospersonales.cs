using System;

namespace AgendaTelefonica.Models
{
    public class ContactoPersonal : Contacto
    {
        public string Relacion { get; set; }

        public ContactoPersonal(string nombre, string numeroTelefono, string relacion)
            : base(nombre, numeroTelefono)
        {
            Relacion = relacion;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Tipo: Personal, Relación: {Relacion}");
        }
    }
}
