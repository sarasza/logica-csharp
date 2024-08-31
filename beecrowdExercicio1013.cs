/* Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
MaiorAB = (a + b + abs(a - b)) / 2
Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MaiorAB, MaiorTotal;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            MaiorTotal = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine(MaiorTotal + " eh o maior");


        }
    }
}
