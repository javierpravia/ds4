using System;

namespace Laboratorio46
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite el radio del Circulo");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * Math.PI;

            Console.WriteLine($"El area del circulo es: {area}");
        }
    }
}