/* Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima da diagonal principal. */

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
                    A[i,j] = int.Parse(vet[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < N; ++i)
            {
                for (int j = i + 1; j < N; j++)
                {
                    soma = soma + A[i, j];
                }
            }
            Console.WriteLine(soma);
        }
    }
}
