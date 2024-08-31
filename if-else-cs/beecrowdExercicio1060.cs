/* Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos (desconsidere os valores nulos). A seguir, mostre a quantidade de valores
   positivos digitados. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, D, E, F;
            A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            E = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int contador = 0;

            if (A > 0.0)
            {
                contador = contador + 1;
            }
            if (B > 0.0)
            {
                contador = contador + 1;
            }
            if (C > 0.0)
            {
                contador = contador + 1;
            }
            if (D > 0.0)
            {
                contador = contador + 1;
            }
            if (E > 0.0)
            {
                contador = contador + 1;
            }
            if (F > 0.0)
            {
                contador = contador + 1;
            }

            Console.WriteLine(contador + " valores positivos");
        }
    }
}
