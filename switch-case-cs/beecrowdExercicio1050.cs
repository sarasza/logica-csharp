/* Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:
   DDD      DESTINATION 
   61        Brasília
   71        Salvador
   11        São Paulo
   21        Rio de Janeiro
   32        Juiz de Fora
   19        Campinas
   27        Vitoria
   31        Belo Horizonte
   Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar: DDD nao cadastrado */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string cidade;
            int DDD = int.Parse(Console.ReadLine());

            switch (DDD)
            {
                case 61:
                    cidade = "Brasilia";
                    Console.WriteLine(cidade);
                    break;
                case 71:
                    cidade = "Salvador";
                    Console.WriteLine(cidade);
                    break;
                case 11:
                    cidade = "Sao Paulo";
                    Console.WriteLine(cidade);
                    break;
                case 21:
                    cidade = "Rio de Janeiro";
                    Console.WriteLine(cidade);
                    break;
                case 32:
                    cidade = "Juiz de Fora";
                    Console.WriteLine(cidade);
                    break;
                case 19:
                    cidade = "Campinas";
                    Console.WriteLine(cidade);
                    break;
                case 27:
                    cidade = "Vitoria";
                    Console.WriteLine(cidade);
                    break;
                case 31:
                    cidade = "Belo Horizonte";
                    Console.WriteLine(cidade);
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;


            }

        }
    }
}
