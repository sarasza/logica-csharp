/* Leia 5 valores Inteiros. A seguir mostre quantos valores digitados foram pares, quantos valores digitados foram ímpares, quantos valores digitados foram positivos e
   quantos valores digitados foram negativos. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorPar = 0;
            int contadorImpar = 0;
            int contadorPositivo = 0;
            int contadorNegativo = 0;

            int A = int.Parse(Console.ReadLine());

            if (A % 2 == 0)
            {
                contadorPar++;
            }
            else
            {
                contadorImpar++;
            }
            if (A > 0)
            {
                contadorPositivo++;
            }
            else if (A < 0)
            {
                contadorNegativo++;
            }

            int B = int.Parse(Console.ReadLine());

            if (B % 2 == 0)
            {
                contadorPar++;
            }
            else
            {
                contadorImpar++;
            }
            if (B > 0)
            {
                contadorPositivo++;
            }
            else if (B < 0)
            {
                contadorNegativo++;
            }

            int C = int.Parse(Console.ReadLine());

            if (C % 2 == 0)
            {
                contadorPar++;
            }
            else
            {
                contadorImpar++;
            }
            if (C > 0)
            {
                contadorPositivo++;
            }
            else if (C < 0)
            {
                contadorNegativo++;
            }

            int D = int.Parse(Console.ReadLine());

            if (D % 2 == 0)
            {
                contadorPar++;
            }
            else
            {
                contadorImpar++;
            }
            if (D > 0)
            {
                contadorPositivo++;
            }
            else if (D < 0)
            {
                contadorNegativo++;
            }

            int E = int.Parse(Console.ReadLine());

            if (E % 2 == 0)
            {
                contadorPar++;
            }
            else
            {
                contadorImpar++;
            }
            if (E > 0)
            {
                contadorPositivo++;
            }
            else if (E < 0)
            {
                contadorNegativo++;
            }

            Console.WriteLine(contadorPar + " valor(es) par (es)");
            Console.WriteLine(contadorImpar + " valor(es) impar (es)");
            Console.WriteLine(contadorPositivo + " valor(es) positivo (s)");
            Console.WriteLine(contadorNegativo + " valor(es) negativo (s)");

        }
    }
}
