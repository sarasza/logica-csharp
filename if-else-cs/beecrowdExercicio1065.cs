/* Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, E;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            E = int.Parse(Console.ReadLine());

            int contador = 0;

            if (A % 2 == 0)
            {
                contador = contador + 1;
            }
            if (B % 2 == 0)
            {
                contador = contador + 1;
            }
            if (C % 2 == 0)
            {
                contador = contador + 1;
            }
            if (D % 2 == 0)
            {
                contador = contador + 1;
            }
            if (E % 2 == 0)
            {
                contador = contador + 1;
            }

            Console.WriteLine(contador + " valores pares");
        }
    }
}
