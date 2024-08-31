/* Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível
   gasto (em litros). */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, total;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = X / Y;

            Console.WriteLine((total.ToString("F3") + " km/l"), CultureInfo.InvariantCulture);

        }
    }
}
