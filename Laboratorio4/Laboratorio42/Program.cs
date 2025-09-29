using System;
using System.Runtime.CompilerServices;

namespace Laboratorio42
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int fac = 1, n;
            string linea;
            Console.Write("Ingrese un numero entero: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }

            Console.Write("La Factorial es: " + fac);
            Console.ReadKey();
        }
    }
}
