/* Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres. Cada uma dessas informações deve ser armazenada em
   um vetor. Depois, imprimir os nomes dos alunos aprovados, considerando aprovados aqueles cuja média das notas seja maior ou igual a seis. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];


            for (int i = 0; i < N; i++)
            {
                string[] vetores = Console.ReadLine().Split(' ');
                nomes[i] = (vetores[0]);
                nota1[i] = double.Parse(vetores[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(vetores[2], CultureInfo.InvariantCulture);
            }

            double soma = 0;
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++)
            {
                soma = nota1[i] + nota2[i];
                double media = soma / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
