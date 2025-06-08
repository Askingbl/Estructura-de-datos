using System;

namespace FigurasGeometricas
{
    // Clase para representar un Círculo
    public class Circulo
    {
        // Atributo privado que almacena el radio del círculo (encapsulamiento)
        private double radio;

        // Constructor que inicializa el radio del círculo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método que devuelve el área del círculo
        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un círculo, requiere como argumento el radio
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método que devuelve el perímetro (circunferencia) del círculo
        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un círculo, requiere como argumento el radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase para representar un Rectángulo
    public class Rectangulo
    {
        // Atributos privados que almacenan la base y la altura del rectángulo (encapsulamiento)
        private double baseRectangulo;
        private double altura;

        // Constructor que inicializa la base y la altura del rectángulo
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Método que devuelve el área del rectángulo
        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un rectángulo, requiere como argumentos la base y la altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // Método que devuelve el perímetro del rectángulo
        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un rectángulo, requiere como argumentos la base y la altura
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
            // Crear un círculo con radio 5.0
            Circulo miCirculo = new Circulo(5.0);
            Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

            // Crear un rectángulo con base 4.0 y altura 6.0
            Rectangulo miRectangulo = new Rectangulo(4.0, 6.0);
            Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
        }
    }
}
