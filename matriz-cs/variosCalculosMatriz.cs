/* Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
   a) calcular e imprimir a soma de todos os elementos positivos da matriz.
   b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
   c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
   d) imprimir os elementos da diagonal principal da matriz.
   e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[,] A = new double[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = double.Parse(vet[j],CultureInfo.InvariantCulture);
                }
            }

            // a) calcular e imprimir a soma de todos os elementos positivos da matriz.
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i,j] > 0.0)
                    {
                        soma = soma + A[i,j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            // b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
            Console.Write("LINHA ESCOLHIDA: ");
            int linha = int.Parse(Console.ReadLine());
            for (int j = 0; j < N; j++)
            {
                Console.Write(A[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
            Console.Write("COLUNA ESCOLHIDA: ");
            int coluna = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // d) imprimir os elementos da diagonal principal da matriz.
            Console.Write("DIAGONAl PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N ; j++)
                {
                    if (A[i,j] < 0)
                    {
                        A[i,j] = A[i,j] * A[i,j];
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < N; i++)
            {
                for (int j=0; j < N ; j++)
                {
                    Console.Write(A[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
