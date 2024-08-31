/* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int cont = 0;

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    cont--;
                    Console.WriteLine(i);
                }
            }


        }
    }
}
