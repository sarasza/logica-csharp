/* Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde cada elemento de C é a soma dos elementos
   correspondentes de A e B. Imprima o vetor C gerado. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] vet1 = new int[N];
            int[] vet2 = new int[N];

            string[] vetores = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet1[i] = int.Parse(vetores[i]);
            }

            vetores = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet2[i] = int.Parse(vetores[i]);
            }

            int[] vet3 = new int[N];
            for (int i = 0; i < N; i++)
            {
                vet3[i] = vet1[i] + vet2[i];
                Console.Write(vet3[i] + " ");
            }
        }
    }
}
