/* Fazer um programa que lê números inteiros até que um zero seja lido. Ao final mostra a soma dos números lidos */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, soma;
            X = int.Parse(Console.ReadLine());
            soma = 0;

            while (X != 0)
            {
                soma = soma + X;
                X = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
        }
    }
}
