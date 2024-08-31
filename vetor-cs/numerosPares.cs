/* Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
   - todos os números pares
   - a quantidade de números pares */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            string[] vetores = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(vetores[i]);
            }

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    cont++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(cont);
        }
    }
}
