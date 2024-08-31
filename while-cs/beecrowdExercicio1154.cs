/* Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos, contém o valor de
   idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, contIdade = 0, soma = 0;
            double media;

            idade = int.Parse(Console.ReadLine());
            while (idade >= 0)
            {
                soma = soma + idade;
                contIdade = ++contIdade;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / contIdade;
            Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
            
            Console.ReadLine();
        }
    }
}
