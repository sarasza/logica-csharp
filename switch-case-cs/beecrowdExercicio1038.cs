/* Escreva um programa que leia o código de um item e a quantidade deste item
   CÓDIGO   ESPECIFICAÇÃO        PREÇO
    1       Cachorro Quente      R$4,00    
    2       X-Salada             R$4,50
    3       X-Bacon              R$5,00
    4       Torrada Simples      R$2,00
    5       Refrigerante         R$1,50  */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int cod = int.Parse(valores[0]);
            int qnt = int.Parse(valores[1]);

            double produto, total;

            switch (cod)
            {
                case 1:
                    produto = 4.00;
                    break;
                case 2:
                    produto = 4.50;
                    break;
                case 3:
                    produto = 5.00;
                    break;
                case 4:
                    produto = 2.00;
                    break;
                case 5:
                    produto = 1.50;
                    break;
                default:
                    produto = 00.00;
                    break;
            }

            total = produto * qnt;

            Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
          
            Console.ReadLine();

        }
    }
}
