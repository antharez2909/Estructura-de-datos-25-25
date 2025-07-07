using System;

namespace Ejercicio2
{
    // Clase Nodo representa cada nodo de la lista
    public class Nodo
    {
        public int Dato;         // Valor del nodo
        public Nodo Siguiente;   // Referencia al siguiente nodo

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada contiene los métodos para manipular la lista
    public class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Agrega un nodo al final de la lista
        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // Muestra todos los elementos de la lista
        public void Mostrar()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }

        // Invierte la lista enlazada (lo más importante del ejercicio)
        public void Invertir()
        {
            Nodo anterior = null;     // Nodo anterior inicialmente nulo
            Nodo actual = cabeza;     // Nodo actual empieza desde la cabeza
            Nodo siguiente = null;    // Nodo siguiente

            while (actual != null)
            {
                siguiente = actual.Siguiente;    // Guardamos la referencia del siguiente
                actual.Siguiente = anterior;     // Invertimos el puntero
                anterior = actual;               // Avanzamos: anterior se vuelve el actual
                actual = siguiente;              // Avanzamos al siguiente nodo
            }

            cabeza = anterior; // Actualizamos la cabeza al nuevo inicio
        }
    }

    // Clase principal: ejecuta la prueba del ejercicio
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Agregamos algunos datos
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            // Llamamos al método para invertir la lista
            lista.Invertir();

            Console.WriteLine("Lista invertida:");
            lista.Mostrar();
        }
    }
}
