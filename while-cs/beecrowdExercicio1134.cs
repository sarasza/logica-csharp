/* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido
   (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código
   (até que seja válido). O programa será encerrado quando o código informado for o número 4. */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int contAlcool, contGasolina, contDiesel;
            contAlcool = 0;
            contGasolina = 0;
            contDiesel = 0;


            while (number != 4)
            {
                if (number == 1)
                {
                    contAlcool = ++contAlcool;
                }
                else if (number == 2)
                {
                    contGasolina = ++contGasolina;
                }
                else if (number == 3)
                {
                    contDiesel = ++contDiesel;
                }

                number = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + contAlcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Diesel: " + contDiesel);

            
        }
    }
}
