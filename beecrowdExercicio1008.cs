/* Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e
   calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int worker;
            double hoursWork, hoursPrice, salary;

            worker = int.Parse(Console.ReadLine());
            hoursWork = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            hoursPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hoursWork * hoursPrice;

            Console.WriteLine("NUMBER = " + worker);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
