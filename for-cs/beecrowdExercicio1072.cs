/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20]
  e quantos estão fora do intervalo, mostrando essas informações. Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
  Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int contIn = 0;
            int contOut = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    ++contIn;
                }
                else
                {
                    ++contOut;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");

        }
    }
}
