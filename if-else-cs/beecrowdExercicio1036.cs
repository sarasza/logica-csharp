/* Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente
   “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.
   Bhaskara:
   ax^2 + bx + c = 0
   x -> x = (-b ± √Δ) / 2a
   Δ -> Δ = b^2 - 4ac
   Δ não pode ser negativo e A não pode ser zero */


using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta, r1, r2;

            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            
            delta = Math.Pow(B, 2.0) - 4 * A * C;
            r1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
            r2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

            if (A == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + r1.ToString("F5"), CultureInfo.InvariantCulture);
                Console.WriteLine("R2 = " + r2.ToString("F5"), CultureInfo.InvariantCulture);
            }

            Console.ReadLine();

        }
    }
}
