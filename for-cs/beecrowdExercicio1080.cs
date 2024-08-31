/* Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, posicao = 0;

            for (int i = 0; i < 100; i++)
            {
                int N = int.Parse(Console.ReadLine());
                if (N > maior)
                {
                    maior = N;
                    posicao = i + 1;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
            Console.ReadLine();

        }
    }
}
