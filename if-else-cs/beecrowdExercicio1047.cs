/* Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.
   Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, duracao, duracaoH, duracaoM;

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            inicio = horaInicial * 60 + minutoInicial;
            fim = horaFinal * 60 + minutoFinal;

            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = (24 * 60 - inicio) + fim;
            }

            duracaoH = duracao / 60;
            duracaoM = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");

        }
    }
}
