/* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.
   Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double A, B, C;

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                A = double.Parse(valores[0], CultureInfo.InvariantCulture);
                B = double.Parse(valores[1], CultureInfo.InvariantCulture);
                C = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double divisao = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;

                Console.WriteLine(divisao.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
