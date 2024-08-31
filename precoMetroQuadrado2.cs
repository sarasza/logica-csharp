using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width, length, area, pricePerSquareMeter, priceTotal;

            Console.WriteLine("Digite a largura: ");
            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento: ");
            length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço por metro quadrado: ");
            pricePerSquareMeter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = width * length;
            priceTotal = area * pricePerSquareMeter;

            Console.WriteLine("A área total é: " + area.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("O valor do terreno é: " + priceTotal.ToString("F2"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
