/* Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre
   eles, mostrando 4 casas decimais, segundo a fórmula:
   Distancia = √(x2 - x1)^2 + (y2 - y1)^2 */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, distancia;
            string[] vet1;
            string[] vet2;

            vet1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            vet2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);


        }
    }
}
