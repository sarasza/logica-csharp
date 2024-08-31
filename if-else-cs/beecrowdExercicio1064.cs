/* Leia 6 valores. Em seguida, mostre quantos destes valores digitados foram positivos. Na próxima linha, deve-se mostrar a média de todos os valores positivos digitados,
   com um dígito após o ponto decimal. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, D, E, F, positive, positiveTotal;
            A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            E = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int contador = 0;
            positive = 0;

            if (A > 0.0)
            {
                contador = contador + 1;
                positive = positive + A;
            }
            if (B > 0.0)
            {
                contador = contador + 1;
                positive = positive + B;
            }
            if (C > 0.0)
            {
                contador = contador + 1;
                positive = positive + C;
            }
            if (D > 0.0)
            {
                contador = contador + 1;
                positive = positive + D;
            }
            if (E > 0.0)
            {
                contador = contador + 1;
                positive = positive + E;
            }
            if (F > 0.0)
            {
                contador = contador + 1;
                positive = positive + F;
            }

            Console.WriteLine(contador + " valores positivos");

            positiveTotal = positive / contador;
            Console.WriteLine(positiveTotal.ToString("F1"), CultureInfo.InvariantCulture);
        }
    }
}
