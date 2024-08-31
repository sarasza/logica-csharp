/* Leia um valor inteiro X. Em seguida apresente os 6 valores ímpares consecutivos a partir de X, um valor por linha, inclusive o X ser for o caso. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                X++;
                Console.WriteLine(X);
            }
            else
            {
                Console.WriteLine(X);
            }


            X = X + 2;
            Console.WriteLine(X);
            X = X + 2;
            Console.WriteLine(X);
            X = X + 2;
            Console.WriteLine(X);
            X = X + 2;
            Console.WriteLine(X);
            X = X + 2;
            Console.WriteLine(X);
        }
    }
}
