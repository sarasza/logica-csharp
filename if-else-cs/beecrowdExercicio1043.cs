/* Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:
   Perimetro = XX.X
   Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem
   Area = XX.X */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            double perimetro, area;

            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < C + A && C < B + A)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1"), CultureInfo.InvariantCulture);
            }
            else
            {
                area = (((A + B) * C) / 2.0);
                Console.WriteLine("Area = " + area.ToString("F1"), CultureInfo.InvariantCulture);
            }
        }
    }
}
