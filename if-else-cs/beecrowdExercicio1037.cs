/* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor
   se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
   O símbolo ( representa "maior que". Por exemplo:
   [0,25]  indica valores entre 0 e 25.0000, inclusive eles.
   (25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000 */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (x >= 0 && x <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (x >= 25.01 && x <= 50.0) {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (x >= 50.01 && x <= 75.0) {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (x >= 75.01 && x <= 100.0)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Fora de Intervalo");
            }

            Console.ReadLine();

        }
    }
}
