/* Fazer um programa para ler dois números inteiros M e N. Em seguida, ler uma matriz de M linhas e N colunas contendo números inteiros. Gerar um vetor de modo que cada
   elemento do vetor seja a soma dos elementos da linha correspondente da matriz. Mostrar o vetor gerado. */

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

            for (int i = 0; i < M; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(vet[j]);
                }
            }

            int[] vetor = new int[M];

            for (int i = 0; i < M; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + A[i, j];
                }
                vetor[i] = soma;
            }

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
