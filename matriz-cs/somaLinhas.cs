/* Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos elementos de cada linha da matriz. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] A = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + A[i, j];
                }

                Console.WriteLine(soma);
            }
        }
    }
}
