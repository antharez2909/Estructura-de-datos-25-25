using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    // Clase que representa una atracción con cola y capacidad limitada
    public class Atraccion
    {
        public string Nombre { get; }
        private Queue<Persona> cola;
        private int capacidad;
        private int asientoActual;

        public Atraccion(string nombre, int capacidadMaxima)
        {
            Nombre = nombre;
            capacidad = capacidadMaxima;
            cola = new Queue<Persona>();
            asientoActual = 1;
        }

        // Asigna un asiento a una persona con nombre dado
        public bool AsignarAsiento(string nombre)
        {
            if (asientoActual > capacidad)
            {
                return false; // No hay más espacio
            }

            Persona nueva = new Persona(nombre, asientoActual);
            cola.Enqueue(nueva);
            asientoActual++;
            return true;
        }

        // Muestra todas las personas asignadas en esta atracción
        public void MostrarAsignaciones()
        {
            Console.WriteLine($"\n🎡 Asignaciones en {Nombre}:");

            if (cola.Count == 0)
            {
                Console.WriteLine("No hay personas asignadas todavía.");
                return;
            }

            foreach (var persona in cola)
            {
                Console.WriteLine(persona);
            }
        }

        // Devuelve la cantidad actual de personas asignadas
        public int CantidadPersonas()
        {
            return cola.Count;
        }
    }
}
