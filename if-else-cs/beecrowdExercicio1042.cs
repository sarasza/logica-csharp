/* Leia 3 valores inteiros e ordene-os em ordem crescente. No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, os valores na sequência como
   foram lidos. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int maior, meio, menor;

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0], CultureInfo.InvariantCulture);
            int y = int.Parse(valores[1], CultureInfo.InvariantCulture);
            int z = int.Parse(valores[2], CultureInfo.InvariantCulture);
            
            if (x < y && x < z)
            {
                menor = x;

                if (y < z)
                {
                    meio = y;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = y;
                }
            }
            else if (y < z)
            {
                menor = y;

                if (x < z)
                {
                    meio = x;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = x;
                }
            }
            else {
                menor = z;

                if (x < y)
                {
                    meio = x;
                    maior = y;
                }
                else
                {
                    meio = y;
                    maior = x;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);

            Console.ReadLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
