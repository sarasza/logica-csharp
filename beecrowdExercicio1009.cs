/* Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que
   este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            double salaryFixed, totalSales, totalSalary;

            name = Console.ReadLine();
            salaryFixed = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalSales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalSalary = (totalSales * 15.0 / 100) + salaryFixed;

            Console.WriteLine("TOTAL = R$ " + totalSalary.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
