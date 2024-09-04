/* Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. Suponha não haver empates. */

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

            for (int i = 0; i < N; i++)
            {
                int maior = A[i,0];
                for (int j = 0; j < N; j++)
                {
                    if (A[i,j] > maior)
                    {
                        maior = A[i,j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}
