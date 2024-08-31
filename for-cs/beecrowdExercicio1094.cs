/* Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar os experimentos de um laboratório o qual ela é responsável.
   Ela quer saber no final do ano, quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada. Este laboratório em especial utiliza
   três tipos de cobaias: sapos, ratos e coelhos. Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia utilizada
   e a quantidade de cobaias utilizadas em cada experimento. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int qntC = 0, qntR = 0, qntS = 0;

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int X = int.Parse(valores[0]);
                char Y = char.Parse(valores[1]);

                if (X <= 15)
                {
                    if (Y == 'C')
                    {
                        qntC = qntC + X;
                    }
                    else if (Y == 'R')
                    {
                        qntR = qntR + X;
                    }
                    else
                    {
                        qntS = qntS + X;
                    }

                }
            }

            int totalCobaias = qntC + qntR + qntS;
            double percC = (double)qntC / totalCobaias * 100.0;
            double percR = (double)qntR / totalCobaias * 100.0;
            double percS = (double)qntS / totalCobaias * 100.0;

            Console.WriteLine("Total: " + totalCobaias);
            Console.WriteLine("Total de coelhos: " + qntC);
            Console.WriteLine("Total de ratos: " + qntR);
            Console.WriteLine("Total de sapos: " + qntS);
            Console.WriteLine("Percentual de coelhos: " + percC.ToString("F2") + "%");
            Console.WriteLine("Percentual de ratos: " + percR.ToString("F2") + "%");
            Console.WriteLine("Percentual de sapos: " + percS.ToString("F2") + "%");

        }
    }
}
