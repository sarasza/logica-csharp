/* Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a
   média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada
   nota pode ir de 0 até 10.0, sempre com uma casa decimal. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, D, Dif;


            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            Dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + Dif);
            
        }
    }
}
