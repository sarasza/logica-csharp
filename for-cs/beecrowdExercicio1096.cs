/* Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo:
   I=1  J=7
   I=1  J=6
   I=1  J=5
   I=3  J=7
   I=3  J=6
   I=3  J=5 */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int I = 1; I <= 9; I += 2)
            {
                for (int J = 7; J >= 5; J--)
                {
                    Console.WriteLine("I=" + I + " J=" + J);
                }
            }

        }
    }
}
