using System;

namespace FigurasGeometricas
{
    // Clase Circulo representa un círculo con un radio
    public class Circulo
    {
        // Campo privado que almacena el radio del círculo
        private double radio;

        // Constructor para inicializar el valor del radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        // CalcularArea devuelve un valor double que representa el área
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro del círculo
        // CalcularPerimetro devuelve el perímetro del círculo (circunferencia)
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo representa un rectángulo con base y altura
    public class Rectangulo
    {
        // Campos privados para base y altura
        private double baseRectangulo;
        private double altura;

        // Constructor para inicializar base y altura
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Método para calcular el área del rectángulo
        // CalcularArea devuelve base * altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // Método para calcular el perímetro del rectángulo
        // CalcularPerimetro devuelve la suma de todos los lados
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    // Clase principal para probar las figuras
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

            // Crear un rectángulo con base 4 y altura 3
            Rectangulo miRectangulo = new Rectangulo(4, 3);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine("Área: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());
        }
    }
}
