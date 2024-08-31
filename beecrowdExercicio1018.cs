/* Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. As notas
   consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quociente, cedula;

            N = int.Parse(Console.ReadLine());

            cedula = 100;
            quociente = N / cedula;
            Console.WriteLine(quociente + " nota (s) de R$ " + cedula + ",00");
            N = N % cedula;

            cedula = 50;
            quociente = N / cedula;
            Console.WriteLine(quociente + " nota (s) de R$ " + cedula + ",00");
            N = N % cedula;

            cedula = 20;
            quociente = N / cedula;
            Console.WriteLine(quociente + " nota (s) de R$ " + cedula + ",00");
            N = N % cedula;

            cedula = 10;
            quociente = N / cedula;
            Console.WriteLine(quociente + " nota (s) de R$ " + cedula + ",00");
            N = N % cedula;

            cedula = 5;
            quociente = N / cedula;
            Console.WriteLine(quociente + " nota (s) de R$ " + cedula + ",00");
            N = N % cedula;

            cedula = 2;
            quociente = N / cedula;
            Console.WriteLine(quociente + " nota (s) de R$ " + cedula + ",00");
            N = N % cedula;

            Console.WriteLine(N + " nota (s) de R$1,00");

        }
    }
}
