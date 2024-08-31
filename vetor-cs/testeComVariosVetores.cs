/* Faça um programa para ler um número N, depois nome (apenas uma palavra), idade e altura de N pessoas, conforme exemplo. Depois, mostrar na tela a altura média das pessoas
   e mostrar também a porcentagem de pessoas com menos de 16 anos.
   5
   Joao 15 1.82         Altura media: 1.67
   Maria 16 1.60        Pessoas com menos de 16 anos: 40.0%*/

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];


            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);
                alturas[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }

            double porcentagem = (double) cont / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}
