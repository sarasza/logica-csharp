/* Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. O problema
   é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.
   Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.
   Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, hh, mm, ss, day1, day2, inicio, fim, duracao, restante;

            day1 = int.Parse(Console.ReadLine());

            string[] vet1 = Console.ReadLine().Split(' ');
            int hh1 = int.Parse(vet1[0]);
            int mm1 = int.Parse(vet1[1]);
            int ss1 = int.Parse(vet1[2]);

            day2 = int.Parse(Console.ReadLine());

            string[] vet2 = Console.ReadLine().Split(' ');
            int hh2 = int.Parse(vet2[0]);
            int mm2 = int.Parse(vet2[1]);
            int ss2 = int.Parse(vet2[2]);

            // day1 - 1 * 86400 -> 24 * 60 * 60 (segundos em um dia)
            // hh1 * 3600 (segundos por hora)
            // mm1 * 60 (segundos por minuto)
            // ss1 (segundos)

            inicio = (day1 - 1) * 86400 + hh1 * 3600 + mm1 * 60 + ss1;
            fim = (day2 - 1) * 86400 + hh2 * 3600 + mm2 * 60 + ss2;

            duracao = fim - inicio;

            // calcula o numero de dias inteiro
            day = duracao / (24 * 60 * 60);
            restante = duracao % (24 * 60 * 60);
            // calcula o numero de horas inteiro
            hh = restante / (60 * 60);
            restante = restante % (60 * 60);
            // calcula o numero de minutos inteiro
            mm = restante / 60;
            // calcula o numero de segundos inteiro
            ss = restante % 60;

            Console.WriteLine(day + " dia(s)");
            Console.WriteLine(hh + " hora(s)");
            Console.WriteLine(mm + " minuto(s)");
            Console.WriteLine(ss + " segundo(s)");

        }
    }
}
