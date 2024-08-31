/* Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana (sendo 1 = domingo, 2 = segunda, e assim por diante). Escrever na tela o
   dia da semana correspondente. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string dia;

            x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                dia = "domingo";
            }
            else if (x == 2)
            {
                dia = "segunda";
            }
            else if (x == 3)
            {
                dia = "terça";
            }
            else if (x == 4)
            {
                dia = "quarta";
            }
            else if (x == 5)
            {
                dia = "quinta";
            }
            else if (x == 6)
            {
                dia = "sexta";
            }
            else if (x == 7)
            {
                dia = "sábado";
            }
            else
            {
                dia = "valor inválido";
            }

            Console.WriteLine("Dia da semana: " + dia);
            Console.ReadLine();

        }
    }
}
