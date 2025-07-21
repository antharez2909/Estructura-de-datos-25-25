namespace ParqueDiversiones
{
    // Clase que representa a una persona con nombre y número de asiento asignado
    public class Persona
    {
        public string Nombre { get; set; }         // Nombre de la persona
        public int AsientoAsignado { get; set; }   // Número de asiento asignado

        // Constructor que inicializa nombre y asiento
        public Persona(string nombre, int asiento)
        {
            Nombre = nombre;
            AsientoAsignado = asiento;
        }

        // Método para mostrar la información de la persona en formato legible
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Asiento: {AsientoAsignado}";
        }
    }
}
