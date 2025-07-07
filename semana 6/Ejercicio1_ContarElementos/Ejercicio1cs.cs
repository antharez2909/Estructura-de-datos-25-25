using System;

namespace Ejercicio1_ContarElementos
{
    // Nodo de la lista
    public class Nodo
    {
        public int Valor;
        public Nodo Siguiente;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    // Lista enlazada
    public class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        public void InsertarAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);
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

        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        public void ImprimirLista()
        {
            Nodo actual = cabeza;
            Console.Write("Lista: ");
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            lista.InsertarAlFinal(5);
            lista.InsertarAlFinal(10);
            lista.InsertarAlFinal(15);

            Console.WriteLine("Lista ingresada:");
            lista.ImprimirLista();

            int total = lista.ContarElementos();
            Console.WriteLine($"Cantidad de elementos: {total}");
        }
    }
}
