// Namespace para organizar el código en el proyecto
namespace AgendaTelefonica.Models
{
    // Clase ContactoProfesional que hereda de Contacto
    public class ContactoProfesional : Contacto
    {
        // Propiedad que almacena el nombre de la empresa o puesto profesional
        public string Empresa { get; set; }

        // Constructor que recibe nombre, teléfono y empresa
        public ContactoProfesional(string nombre, string numeroTelefono, string empresa)
            : base(nombre, numeroTelefono) // Llama al constructor de la clase base Contacto
        {
            Empresa = empresa; // Asigna la empresa al atributo Empresa
        }

        // Método que muestra la información del contacto profesional
        public override void Mostrar()
        {
            base.Mostrar(); // Muestra nombre y teléfono (método base)
            Console.WriteLine($"Tipo: Profesional, Empresa: {Empresa}"); // Muestra tipo y empresa
        }
    } // Fin de la clase ContactoProfesional
} // Fin del namespace


