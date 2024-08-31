/* Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma disciplina anual. Em seguida, mostrar a nota fiscal que o aluno
   obteve no ano justamente com um texto explicativo. Caso a nota final do aluno seja inferior a 60.00, mostrar a mensagem "REPROVADO", conforme exemplos. Todos os
   valores devem ter uma casa decimal. */

using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media = nota1 + nota2;

            if (media >= 60.00)
            {
                Console.WriteLine("NOTA FINAL = " + media.ToString("F1"), CultureInfo.InvariantCulture);
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + media.ToString("F1"), CultureInfo.InvariantCulture);
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();

        }
    }
}
