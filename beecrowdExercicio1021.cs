/* Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de
   notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são
   de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int notas, quociente, moedas;

            N = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");

            notas = 100;
            quociente = (int)  N / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            N = N % (notas * 100);

            notas = 50;
            quociente = (int) N / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            N = N % (notas * 100);

            notas = 20;
            quociente = (int) N / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            N = N % (notas * 100);

            notas = 10;
            quociente = (int) N / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            N = N % (notas * 100);

            notas = 5;
            quociente = (int) N / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            N = N % (notas * 100);

            notas = 2;
            quociente = (int) N / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            N = N % (notas * 100);

            Console.WriteLine("MOEDAS:");

            moedas = 100;
            quociente = (int) N / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$1.00");
            N = N % moedas;

            moedas = 50;
            quociente = (int) N / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$0.50");
            N = N % moedas;

            moedas = 25;
            quociente = (int) N / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$0.25");
            N = N % moedas;

            moedas = 10;
            quociente = (int) N / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$0.10");
            N = N % moedas;

            moedas = 5;
            quociente = (int) N / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$0.05");
            N = N % moedas;

            Console.WriteLine(N + " moeda(s) de R$0.01");
        }
    }
}
