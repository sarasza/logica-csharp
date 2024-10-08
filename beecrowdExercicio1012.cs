/* Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
   a) a área do triângulo retângulo que tem A por base e C por altura.
   b) a área do círculo de raio C. (pi = 3.14159)
   c) a área do trapézio que tem A e B por bases e C por altura.
   d) a área do quadrado que tem lado B.
   e) a área do retângulo que tem lados A e B. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTrianguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            double pi = 3.14159;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            areaTrianguloRetangulo = (A * C) / 2.0;
            areaCirculo = Math.Pow(C, 2.0) * pi;
            areaTrapezio = ((A + B) * C) / 2.0;
            areaQuadrado = Math.Pow(B, 2.0);
            areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + areaTrianguloRetangulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"), CultureInfo.InvariantCulture);


        }
    }
}
