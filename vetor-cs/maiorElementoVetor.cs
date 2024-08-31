/* Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número do vetor (supor não haver empates). Mostrar também a
   posição do maior elemento. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            int maior = 0, posicao = 0;

            string[] vetores = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(vetores[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] > maior)
                {
                    maior = (int)vet[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
