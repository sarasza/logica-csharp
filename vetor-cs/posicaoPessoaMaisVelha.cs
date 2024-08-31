/* Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome da pessoa mais velha. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];


            for (int i = 0; i < N; i++)
            {
                string[] vetores = Console.ReadLine().Split(' ');
                nomes[i] = (vetores[0]);
                idades[i] = int.Parse(vetores[1]);
            }

            int maior = 0, posicao = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] > maior)
                {
                    maior = idades[i];
                    posicao = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[posicao]);
        }
    }
}
