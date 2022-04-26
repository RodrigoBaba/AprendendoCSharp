using System;
using System.Globalization;

namespace ExerciciosDeApoio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 01:
            /* Faça um programa para ler dois valores inteiros, e depois mostrar
             * na tela a soma desses números com uma mensagem explicativa:
             */
            //Console.WriteLine("Exercicio 01:");            
            //Console.Write("Digite um número inteiro: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro número inteiro: ");
            //int n2 = int.Parse(Console.ReadLine());
            //int sum = n1 + n2;
            //Console.WriteLine("SOMA = " + sum);

            //--------------------------------------------------------------
            //Exercicio 02:
            /* Faça um programa para ler o valor do raio de um círculo, e 
             * depois mostrar o valor da área deste círculo com quatro 
             * casas decimais:
             * Formula da área: pi * raio²
             * Considere pi = 3.14159
             */
            //Console.WriteLine("\nExercicio 02:");
            //Console.Write("Entre com um valor de raio: ");
            //double pi = 3.14159;
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double area = pi * Math.Pow(raio, 2);
            //Console.WriteLine("Resultado da área do círculo é " + 
            //    area.ToString("F4", CultureInfo.InvariantCulture));

            //--------------------------------------------------------------
            //Exercicio 03:
            /* Fazer um programa para ler quatro valores inteiros A, B, C e D.
             * A seguir, calcule e mostre a diferença do produto de A e B pelo
             * produto C e D segundo a formula: DIFERENCA = (A * B - C * D)
             */
            //Console.WriteLine("\nExercicio 03:");
            //Console.Write("Digite valor do item A: ");
            //int itemA = int.Parse(Console.ReadLine());
            //Console.Write("Digite valor do item B: ");
            //int itemB = int.Parse(Console.ReadLine());
            //Console.Write("Digite valor do item C: ");
            //int itemC = int.Parse(Console.ReadLine());
            //Console.Write("Digite valor do item D: ");
            //int itemD = int.Parse(Console.ReadLine());
            //int diferenca = (itemA * itemB - itemC * itemD);
            //Console.WriteLine("Resultado da diferença foi: " + diferenca);

            //--------------------------------------------------------------
            //Exercicio 04:
            /* Fazer um programa que leia o número de um funcionario, seu 
             * numero de horas trabalhadas, o valor que recebe por hora e 
             * calcula o salario desse funcionario. A seguir, mostre o número 
             * e o salario do funcionario, com duas casas decimais.
             */
            //Console.WriteLine("\nExercicio 04:");
            //Console.Write("Digite o número do funcinário: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Digite o número de horas trabalhadas: ");
            //int hour = int.Parse(Console.ReadLine());
            //Console.Write("Digite o valor por hora: ");
            //double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double salary = hour * perHour;
            //Console.WriteLine("Número do funcionário: " + number);
            //Console.WriteLine("Valor total à receber U$ " + 
            //    salary.ToString("F2", CultureInfo.InvariantCulture));

            //--------------------------------------------------------------
            //Exercicio 05:
            /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor 
             * unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor
             * unitário de cada peça 2. Calcule e mostre o valor a ser pago.
             */
            //Console.WriteLine("\nExercicio 05:");
            //Console.WriteLine("Digite as informações da peça 1 (Código|Quantidade|Valor Unitário):");
            //string[] vet1 = Console.ReadLine().Split(' ');
            //int code1 = int.Parse(vet1[0]);
            //int qtd1 = int.Parse(vet1[1]);
            //double value1 = double.Parse(vet1[2], CultureInfo.InvariantCulture); ;

            //Console.WriteLine("Digite as informações da peça 2 (Código|Quantidade|Valor Unitário):");
            //string[] vet2 = Console.ReadLine().Split(' ');
            //int code2 = int.Parse(vet2[0]);
            //int qtd2 = int.Parse(vet2[1]);
            //double value2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            //double price = (qtd1 * value1) + (qtd2 * value2);
            //Console.WriteLine("Valor a pagar: R$ " + price.ToString("F2", CultureInfo.InvariantCulture));

            //--------------------------------------------------------------
            //Exercicio 06:
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.
             * Em seguida, calcule e mostre:
             * a) A área do triângulo retangulo que tem A por base C por altura
             * b) A área do círculo de raio C. (pi = 3.14159)
             * c) A área do do trapézio que tem A e B por bases C por altura
             * d) A área do quadrado que tem lado B
             * e) A área do retangulo que tem lados A e B
             */
            Console.WriteLine("\nExercicio 06:");
            Console.WriteLine("Digite os valor de A, B e C, respectivamente: ");
            string[] vet = Console.ReadLine().Split(' ');
            double itemA = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double itemB = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double itemC = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double areaTri = (itemA * itemC) / 2;
            double areaCir = 3.14159 * Math.Pow(itemC, 2);
            double areaTra = ((itemA + itemB) * itemC) / 2;
            double areaQua = Math.Pow(itemB, 2);
            double areaRet = itemA * itemB;

            Console.WriteLine("Resultados:\nTriangulo: " + areaTri.ToString("F3",CultureInfo.InvariantCulture)
                + "\nCirculo: " + areaCir.ToString("F3", CultureInfo.InvariantCulture)
                + "\nTrapezio: " + areaTra.ToString("F3", CultureInfo.InvariantCulture)
                + "\nQuadrado: " + areaQua.ToString("F3", CultureInfo.InvariantCulture)
                + "\nRetangulo: " + areaRet.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
