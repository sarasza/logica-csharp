/* Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à
   variável PROD. A seguir mostre a variável PROD com mensagem correspondente. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int X, Y, PROD;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            PROD = X * Y;

            Console.WriteLine("PROD = " + PROD);
            
        }
    }
}
