/* Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos elementos. Depois mostrar todos os elementos do vetor
   que estejam abaixo da média. */

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
            double soma = 0, media = 0;

            string[] vetores = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(vetores[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }
            media = soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
