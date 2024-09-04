/* Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas cada. Depois, gerar uma terceira matriz C onde cada elemento desta
   é a soma dos elementos correspondentes das matrizes originais. Imprimir na tela a matriz gerada. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(vet[j]);
                }
            }

            int[,] C = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
