/* Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à
   variável SOMA. A seguir escrever o valor desta variável. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, Soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            Soma = A + B;
            
            Console.WriteLine("SOMA = " + Soma);
            
        }
    }
}
