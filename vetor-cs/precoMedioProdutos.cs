/* Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar um conjunto de N mercadorias, cada uma contendo nome,
   preço de compra e preço de venda das mesmas. Fazer um programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
   - lucro < 10%
   - 10% ≤ lucro ≤ 20%
   - lucro > 20%
   Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.
   Lucro = (precoVenda - precoCompra / precoCompra) * 100 */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cont = 0, cont2 = 0, cont3 = 0;

            string[] nome = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] vetores = Console.ReadLine().Split(' ');
                nome[i] = (vetores[0]);
                precoCompra[i] = double.Parse(vetores[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(vetores[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                double lucro = ((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100.0;

                if (lucro < 10.00)
                {
                    cont++;
                }
                else if (lucro >= 10.00 && lucro <= 20.00)
                {
                    cont2++;
                }
                else
                {
                    cont3++;
                }
            }

            double somaCompra = 0;
            for (int i = 0; i < N; i++)
            {
                somaCompra = precoCompra[i] + somaCompra;
            }

            double somaVenda = 0;
            for (int i = 0; i < N; i++)
            {
                somaVenda = precoVenda[i] + somaVenda;
            }

            double lucroTotal = 0;
            for (int i = 0; i < N; i++)
            {
                lucroTotal = somaVenda - somaCompra;
            }

            Console.WriteLine("Lucro abaixo de 10%: " + cont);
            Console.WriteLine("Lucro entre 10% e 20%: " + cont2);
            Console.WriteLine("Lucro acima de 20%: " + cont3);
            Console.WriteLine("Valor total de compra: " + somaCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + somaVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
