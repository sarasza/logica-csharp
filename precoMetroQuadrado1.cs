using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = 10.0;
            double length = 30.0;
            double area = width * length;

            double pricePerSquareMeter = 200.0;
            double priceTotal = area * pricePerSquareMeter;

            Console.WriteLine("A área total é: " + area.ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine("O valor do terreno é: " + priceTotal.ToString("F2"), CultureInfo.InvariantCulture) ;

            Console.ReadLine();
        }
    }
}
