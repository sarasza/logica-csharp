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

            double A, B, Media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Media = (A * 3.5 + B * 7.5) / 11;

            Console.WriteLine("MEDIA = " + Media.ToString("F5"), CultureInfo.InvariantCulture);
            
        }
    }
}
