using System;

namespace Parcial1
{
    class Matriz
    {
        private int[,] mat;
        private int N;
        private int suma;

        public void IngresarDimension()
        {

            while (true)
            {
                Console.Write("Ingrese un numero N que sea mayor o igual a 4: ");
                N = int.Parse(Console.ReadLine());

                if (N >= 4 && N % 2 == 0)
                    break;

                Console.WriteLine("Valor inválido. Intente de nuevo.");
            }


            mat = new int[N, N];
        }

        public void LlenarPatron()
        {
            var rnd = new Random();
            suma = 0;

            int bordeFilas = N / 2 - 1;
            int bordeCols = 1;

            for (int f = 0; f < N; f++)
            {
                for (int c = 0; c < N; c++)
                {
                    // control de 0 y numeros random en la matriz
                    if (f >= bordeFilas && f < N - bordeFilas &&
                        c >= bordeCols && c < N - bordeCols)
                    {
                        mat[f, c] = rnd.Next(101, 201); 
                        suma += mat[f, c];
                    }
                    else
                    {
                        mat[f, c] = 0;
                    }
                }
            }
        }

        public void Imprimir()
        {
            
            for (int f = 0; f < N; f++)
            {
                for (int c = 0; c < N; c++)
                    Console.Write($"{mat[f, c],4}");
                Console.WriteLine();
            }

            Console.WriteLine($"Suma de los elementos aleatorios: {suma}");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.IngresarDimension();
            ma.LlenarPatron();
            ma.Imprimir();
        }
    }
}

