/* A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
   SALÁRIO              PERCENTUAL DE REAJUSTE
   0 - 400,00                   15%
   400,01 - 800,00              12%
   800,01 - 1200,00             10%
   1200,01 - 2000,00            7%
   ACIMA DE 2000,00             4% 
   Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioFinal, reajuste, percentual;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
            {
                salarioFinal = (salario * 15.0 / 100) + salario;
                reajuste = salarioFinal - salario;
                percentual = 15;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                salarioFinal = (salario * 12.0 / 100) + salario;
                reajuste = salarioFinal - salario;
                percentual = 12;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                salarioFinal = (salario * 10.0 / 100) + salario;
                reajuste = salarioFinal - salario;
                percentual = 10;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                salarioFinal = (salario * 7.0 / 100) + salario;
                reajuste = salarioFinal - salario;
                percentual = 7;
            }
            else
            {
                salarioFinal = (salario * 4.0 / 100) + salario;
                reajuste = salarioFinal - salario;
                percentual = 4;
            }

            Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
