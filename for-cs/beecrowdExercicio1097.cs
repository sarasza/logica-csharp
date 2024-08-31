/* Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo:
   I=1  J=7
   I=1  J=6
   I=1  J=5
   I=3  J=9
   I=3  J=8
   I=3  J=7 */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int I = 1; I <= 9; I += 2)
            {

                if (I == 1)
                {
                    for (int J = 7; J >= 5; J--)
                    {
                        Console.WriteLine("I=" + I + " J=" + J);
                    }
                }

                if (I == 3)
                {
                    for (int J = 9; J >= 7; J--)
                    {
                        Console.WriteLine("I=" + I + " J=" + J);
                    }
                }

                if (I == 5)
                {
                    for (int J = 11; J >= 9; J--)
                    {
                        Console.WriteLine("I=" + I + " J=" + J);
                    }
                }

                if (I == 7)
                {
                    for (int J = 13; J >= 11; J--)
                    {
                        Console.WriteLine("I=" + I + " J=" + J);
                    }
                }

                if (I == 9)
                {
                    for (int J = 15; J >= 13; J--)
                    {
                        Console.WriteLine("I=" + I + " J=" + J);
                    }
                }
            }
        }
    }
}
