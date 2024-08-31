/* Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato
   horas:minutos:segundos. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, horas, minutos, segundos, restante;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            restante = N % 3600;
            minutos = restante / 60;
            segundos = restante % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
