using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
