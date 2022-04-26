using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 01: \n");
            // Exercicio 01:
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto2, preco2);
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} " +
                $"e gênero: {genero}");
            Console.WriteLine("\nMedida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3",
                CultureInfo.InvariantCulture));
            
            //---------------------------------------------------------------------------------
            Console.WriteLine("\nExercicio 02:\n");

            // Exercicio 02:
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa:");
            int room = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade, altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("\nVocê digitou:");
            Console.WriteLine("name: " + name);
            Console.WriteLine("room: " + room);
            Console.WriteLine("price: " + price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("lastName: " + lastName);
            Console.WriteLine("age: " + age);
            Console.WriteLine("height: " + height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
