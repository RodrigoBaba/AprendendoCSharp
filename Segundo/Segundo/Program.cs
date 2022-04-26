using System;
using System.Globalization;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiro Teste

            /* #int n1 = Console.ReadLine(); <== Esse comando da conflito,
             * pois #RealLine() lê string, então tem que haver um conversão, 
             * logo fica assim:
             */
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // O #tipoVariavel.Parse() serve para converter o tipo
            // Com o #CultureInfo.InvariantCulture voce pode digitar com ponto(.) no console
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char sex = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3],CultureInfo.InvariantCulture);
            // OBS: Aqui na hora do vetor com #Split() tambem se pode usar o #tipoVariavel.Parse()

            Console.WriteLine("\nVoce Digitou:");
            Console.WriteLine("n1: " + n1);
            Console.WriteLine("ch: " + ch);
            Console.WriteLine("n2: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("name: " + name);
            Console.WriteLine("sex: " + sex);
            Console.WriteLine("age: " + age);
            Console.WriteLine("height: " + height.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
