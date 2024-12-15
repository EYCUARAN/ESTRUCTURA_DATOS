using System;

namespace FigurasGeometricas
{
    // Clase para representar un círculo
    public class Circulo
    {
        // Propiedad privada para encapsular el radio
        private double radio;

        // Constructor para inicializar el círculo con un radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        // El área de un círculo se calcula como π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro del círculo
        // El perímetro de un círculo (circunferencia) se calcula como 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para representar un rectángulo
    public class Rectangulo
    {
        // Propiedades privadas para encapsular la base y la altura
        private double baseRectangulo;
        private double altura;

        // Constructor para inicializar el rectángulo con su base y altura
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Método para calcular el área del rectángulo
        // El área de un rectángulo se calcula como base * altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // Método para calcular el perímetro del rectángulo
        // El perímetro de un rectángulo se calcula como 2 * (base + altura)
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    // Programa principal para probar las clases
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Circulo con un radio de 5
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Circulo:");
            Console.WriteLine($"Area: {circulo.CalcularArea()}");
            Console.WriteLine($"Perimetro: {circulo.CalcularPerimetro()}");

            // Crear un objeto de la clase Rectangulo con una base de 4 y altura de 7
            Rectangulo rectangulo = new Rectangulo(4, 7);
            Console.WriteLine("\nRectangulo:");
            Console.WriteLine($"Area: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perimetro: {rectangulo.CalcularPerimetro()}");
        }
    }
}