/* Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e escreva:
   - a maior e a menor altura do grupo
   - a média de altura das mulheres
   - o número de homens */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] sexo = new char[N];


            for (int i = 0; i < N; i++)
            {
                string[] vetores = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(vetores[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vetores[1]);
            }

            double menor = alturas[0];
            for (int i = 0; i < N; i++)
            {
                if (alturas[i] < menor)
                {
                    menor = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menor);

            double maior = alturas[0];
            for (int i = 0; i < N; i++)
            {
                if (alturas[i] > maior)
                {
                    maior = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maior);

            double media = 0, soma = 0, cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'F')
                {
                    soma = soma + alturas[i];
                    cont++;
                }
            }

            media = soma / cont;
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));

            double cont2 = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'M')
                {
                    cont2++;
                }
            }

            Console.WriteLine("Numero de homens = " + cont2);
        }
    }
}
