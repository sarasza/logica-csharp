/* Apresentar a tabuada (multiplicação de 1 a 9) de um número qualquer informado pelo usuário, a qual deve ser impressa no seguinte formato:
   2 x 1 / 2 x 2 / 2 x 3 */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(X + " x " + i + " = " + (X * i));
            }

        }
    }
}
