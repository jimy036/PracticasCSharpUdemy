using System;

namespace OperacionMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrizA = { { 1, 3.41 }, { 4.5, 8 } };
            double[,] matrizB = { { 4, 1.1 }, { 8, 2.1 } };
            double[,] sum = new double [2, 2];

            Console.WriteLine("Matriz A:");
            MostrarMatriz(matrizA);
            Console.WriteLine("\nMatriz B:");
            MostrarMatriz(matrizB);

            for(int i = 0; i < sum.GetLength(0); i++)
            {
                for(int j = 0; j < sum.GetLength(1); j++)
                {
                    sum [i,j]= matrizA [i,j] + matrizB [i,j];
                }
            }

            Console.WriteLine("\nLa suma de las matrices es:");
            MostrarMatriz(sum);

        }
        static void MostrarMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0:0.#0}  ",matriz[i,j]);  //{0:0.#0} Para darle formato a los decim
                }
                Console.WriteLine();
            }
        }
    }
}
