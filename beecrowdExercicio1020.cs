/* Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
   Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação
   que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, anos, meses, dias, restante;
            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            restante = idade % 365;
            meses = restante / 30;
            dias = restante % 30;

            Console.WriteLine(anos + " ano (s)");
            Console.WriteLine(meses + " mes (es)");
            Console.WriteLine(dias + " dia (s)");
        }
    }
}
