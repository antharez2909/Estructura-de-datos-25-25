using System;

namespace Ejercicio1_ContarElementos
{
    // Clase Nodo representa un elemento de la lista
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

    // Clase ListaEnlazada que gestiona los nodos
    public class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Inserta un nodo al final de la lista
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

        // Cuenta la cantidad de nodos en la lista
        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;
            while (actual != null)
            {
