/* A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
   - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, raio, raioAtual, area;

            n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            raioAtual = Math.Pow(raio, 2.0);

            area = n * raioAtual;

            Console.WriteLine("A=" + area.ToString("F4"), CultureInfo.InvariantCulture);
            
        }
    }
}
