/* Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, perímetro e
   diagonal deste retângulo, com quatro casas decimais. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            double altura, baseR, area, perimetro, diagonal, alturaQuadrado, baseQuadrado;

            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            baseR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = altura * baseR;
            perimetro = 2 * (baseR + altura);

            // diagonal = Math.Sqrt(Math.Pow(baseR, 2.0) + Math.Pow(altura, 2.0));
            
            alturaQuadrado = Math.Pow(altura, 2.0);
            baseQuadrado = Math.Pow(baseR, 2.0);

            diagonal = Math.Sqrt(alturaQuadrado + baseQuadrado);

            Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

        }
    }
}
