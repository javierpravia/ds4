using System;

namespace Laboratorio31
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculosMatematicos calculos = new CalculosMatematicos();

            Console.Write("Introduce la base del rectangulo: ");
            calculos.num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la altura del rectangulo: ");
            calculos.num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("El perimertro del rectangulo es: " + calculos.calculoPerimetro());

        }
    }

    public class CalculosMatematicos
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double resultado;


        public double calculoPerimetro()
        {
            resultado = 2*(num1+num2);
            return resultado;
        }

    }
}