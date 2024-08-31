/* A Federação Gaúcha de Futebol contratou você para escrever um programa para fazer uma estatística do resultado de vários GRENAIS. Escreva um programa para ler o número
   de gols marcados pelo Inter e pelo Grêmio em um GRENAL. Logo após escrever a mensagem "Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1, o
   algoritmo deve ser executado novamente solicitando o número de gols marcados pelos times em uma nova partida, caso contrário deve ser encerrado imprimindo:
   - Quantos GRENAIS fizeram parte da estatística.
   - O número de vitórias do Inter.
   - O número de vitórias do Grêmio.
   - O número de Empates.
   - Uma mensagem indicando qual o time que venceu o maior número de GRENAIS (ou "Nao houve vencedor", caso termine empatado). */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 1, contInter = 0, contGremio = 0, contGrenal = 0, contEmpate = 0;

            while (number == 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int golInter = int.Parse(valores[0]);
                int golGremio = int.Parse(valores[1]);

                if (golInter == golGremio)
                {
                    contEmpate = ++contEmpate;
                }
                else if (golGremio > golInter)
                {
                    contGremio = ++contGremio;
                }
                else
                {
                    contInter = ++contInter;
                }

                contGrenal = ++contGrenal;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                number = int.Parse(Console.ReadLine());
                while (number != 1 && number != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    number = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(contGrenal + " grenais");
            Console.WriteLine("Inter:" + contInter);
            Console.WriteLine("Gremio:" + contGremio);
            Console.WriteLine("Empates:" + contEmpate);

            if (contInter > contGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (contGremio > contInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

            Console.ReadLine();

        }
    }
}
