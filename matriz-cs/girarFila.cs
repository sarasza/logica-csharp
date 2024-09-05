/* O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1, sendo cada fila com a mesma quantidade de soldados.
   Exemplo: a organização do pelotão em 3 filas com 8 soldados em cada uma.
   Um dos exercícios que o sargento Silva realiza com o pelotão é o exercício "girar fila", que consiste em dizer o número de uma fila, de modo que os soldados desta fila
   devem se mover para a direita, e o último soldado da direita vai para a posição mais à esquerda. Você deve fazer um programa para ler a formação do pelotão e executar o
   exercício "girar fila". */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(vet[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());
            fila = fila - 1;
            int ultimoFila = A[fila, N - 1];

            for (int j = N - 1; j > 0; j--)
            {
                A[fila, j] = A[fila, j - 1];
            }

            A[fila, 0] = ultimoFila;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
