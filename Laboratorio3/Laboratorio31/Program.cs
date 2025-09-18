using System;

namespace Laboratorio31
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculosMatematicos calculos = new CalculosMatematicos();

            Console.Write("Introduce el numero 1: ");
            calculos.num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el numero 1: ");
            calculos.num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculos.Calcular());

        }
    }

    public class CalculosMatematicos
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int resultado;

        public int Calcular()

        {
            resultado = (num1 + num2) * (num1 - num2);
            return resultado;

        }

    }
}


