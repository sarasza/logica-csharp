/* Fazer um programa que mostre todos os números múltiplos de 5 de 100 até 0. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            while (X >= 0)
            {
                if (X % 5 == 0)
                {
                    Console.WriteLine(X);
                }
                X--;
            }
        }
    }
}
