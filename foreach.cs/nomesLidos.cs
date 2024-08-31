/* Fazer um programa para ler um valor N e depois o nome de N pessoas. Em seguida, mostrar os nomes lidos. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string x in vet)
            {
                Console.WriteLine(x);
            }
        }
    }
}
