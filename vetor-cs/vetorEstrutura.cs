/* Fazer um programa para ler um número inteiro positivo N, depois ler N números quaisquer e armazená-los em um vetor. Em seguida, mostrar na tela todos elementos do vetor. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            int N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
