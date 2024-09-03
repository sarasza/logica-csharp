/* Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar na tela somente os números negativos da matriz. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] variaveis = Console.ReadLine().Split(' ');
            int M = int.Parse(variaveis[0]);
            int N = int.Parse(variaveis[1]);

            int[,] A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                variaveis = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(variaveis[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        Console.WriteLine(A[i, j]);
                    }
                }
            }
        }
    }
}
