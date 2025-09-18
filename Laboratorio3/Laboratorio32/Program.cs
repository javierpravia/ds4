using System;

namespace Laboratorio31
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculosMatematicos calculos = new CalculosMatematicos();

            Console.Write("Introduce el radio del circulo: ");
            calculos.num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("El area del circulo es: "+calculos.calculoArea());

        }
    }

    public class CalculosMatematicos
    {
        public double num1 { get; set; }
        public int num2 { get; set; }

        public double resultado;


        public double calculoArea()
        {
            resultado = 3.1415 * (num1*num1);
            return resultado;
        }

    }
}
