/* Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma
   peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal1, valorTotal2, totalPagar;

            string[] vet1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(vet1[0]);
            int numPecas1 = int.Parse(vet1[1]);
            double valorUnitario1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(vet2[0]);
            int numPecas2 = int.Parse(vet2[1]);
            double valorUnitario2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);


            valorTotal1 = numPecas1 * valorUnitario1;
            valorTotal2 = numPecas2 * valorUnitario2;

            totalPagar = valorTotal1 + valorTotal2;

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
