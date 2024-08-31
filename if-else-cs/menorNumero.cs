// Fazer um programa para ler três números inteiros. Em seguida, mostrar qual o menor dentre os três números lidos. Em caso de empate, mostrar apenas uma vez

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta, r1, r2;

            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                Console.WriteLine("MENOR = " + A);
            }
            else {
                if (B < A)
                {
                    Console.WriteLine("MENOR = " + B);
                }
                else
                {
                    Console.WriteLine("MENOR = " + C);
                }
            }
            
            Console.ReadLine();

        }
    }
}
