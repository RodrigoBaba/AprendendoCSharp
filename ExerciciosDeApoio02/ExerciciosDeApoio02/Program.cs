using System;
using System.Globalization;

namespace ExerciciosDeApoio02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura Condicional (if-else)
            // Exercicio 01
            /* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo
             * ou não
             */

            //Console.Write("Digite um número inteiro: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("Número Positivo!");
            //}
            //else if (number == 0)
            //{
            //    Console.WriteLine("Número Zero!");
            //}
            //else
            //{
            //    Console.WriteLine("Número Negativo!");
            //}

            //-----------------------------------------------------------------------------------------

            // Exercicio 02
            /* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
             */

            //Console.Write("Digite um número inteiro: ");
            //int number = int.Parse(Console.ReadLine());
            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Número Par!");
            //} else
            //{
            //    Console.WriteLine("Número Ímpar!");
            //}

            //-----------------------------------------------------------------------------------------

            // Exercicio 03
            /* Leia 2 valores inteiro (A e B). Após, o programa deve mostrar uma mensagem "São Multiplos"
             * ou "Não são Multiplos", indicando se os valores lidos são multiplos entre si. Atenção: os
             * números devem poder ser digitados em ordem crescente ou descrescente
             */

            //Console.Write("Digite dois números inteiros: ");
            //string[] vet = Console.ReadLine().Split(' ');
            //int itemA = int.Parse(vet[0]);
            //int itemB = int.Parse(vet[1]);
            //int resultado;

            //if(itemA > itemB)
            //{
            //    resultado = itemA % itemB;
            //} else
            //{
            //    resultado = itemB % itemA;
            //}

            //if (resultado == 0) {
            //    Console.WriteLine("São multiplos");
            //} else
            //{
            //    Console.WriteLine("Não são Multiplos");
            //}

            //-----------------------------------------------------------------------------------------

            // Exercicio 04
            /* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo
             * que o mesmo pode começar em um dia e terminar em outro, tendo uma duração de 1 hora e máxima
             * de 24 horas
             */

            //Console.Write("Digite hora de começo e hora de término: ");
            //string[] vet = Console.ReadLine().Split(' ');
            //int inicio = int.Parse(vet[0]);
            //int fim = int.Parse(vet[1]);
            //int totalHoras = (24 - inicio) + fim;
            //if(totalHoras <= 24)
            //{
            //    Console.WriteLine($"O jogo durou {totalHoras} hora(s)");
            //} else
            //{
            //    totalHoras -= 24;
            //    Console.WriteLine($"O jogo durou {totalHoras} hora(s)");
            //}

            //-----------------------------------------------------------------------------------------

            // Exercicio 05
            /* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade
             * deste item. A seguir, calcule e mostre o valor da conta a pagar
             */

            //Console.WriteLine("Codigo - 1 - Cachorro Quente - R$4,00(Uni)" +
            //    "\nCodigo - 2 - X-Salada - R$4,50(Uni)" +
            //    "\nCodigo - 3 - X-Bacon - R$5,00(Uni)" +
            //    "\nCodigo - 4 - Torrada simples - R$2,00(Uni)" +
            //    "\nCodigo - 5 - Refrigerante - R$1,50(Uni)");
            //Console.Write("\nDigite o Código e Quantidade: ");
            //string[] vet = Console.ReadLine().Split(' ');
            //int code = int.Parse(vet[0]);
            //int qtd = int.Parse(vet[1]);
            //double total = 0.0;

            //if (code == 1)
            //{
            //    total = 4.0 * qtd;
            //    Console.WriteLine("Total: R${0}", total.ToString("F2", CultureInfo.InvariantCulture));

            //}
            //else if (code == 2)
            //{
            //    total = 4.5 * qtd;
            //    Console.WriteLine("Total: R${0}", total.ToString("F2", CultureInfo.InvariantCulture));

            //}
            //else if (code == 3)
            //{
            //    total = 5.0 * qtd;
            //    Console.WriteLine("Total: R${0}", total.ToString("F2", CultureInfo.InvariantCulture));

            //}
            //else if (code == 4)
            //{
            //    total = 2.0 * qtd;
            //    Console.WriteLine("Total: R${0}", total.ToString("F2", CultureInfo.InvariantCulture));

            //}
            //else if (code == 5)
            //{
            //    total = 1.5 * qtd;
            //    Console.WriteLine("Total: R${0}", total.ToString("F2", CultureInfo.InvariantCulture));

            //}
            //else
            //{
            //    Console.WriteLine("Código Errado!");

            //}

            //-----------------------------------------------------------------------------------------

            // Exercicio 06
            /* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem
             * dizendo em qual dos seguintes intervalos ([0,25], [25,50], [50,75], [75,100]) este
             * valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá
             * ser impressa a mensagem "Fora de intervalo"
             */
            Console.Write("Digite um valor: ");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(number >= 0.0 && number <= 25.0)
            {
                Console.WriteLine("Intervalor [0,25]");
            } else if (number > 25.0 && number <= 50.0)
            {
                Console.WriteLine("Intervalor [25,50]");

            }
            else if (number > 50.0 && number <= 75.0)
            {
                Console.WriteLine("Intervalor [50,75]");

            }
            else if (number > 75.0 && number <= 100.0)
            {
                Console.WriteLine("Intervalor [75,100]");

            } else
            {
                Console.WriteLine("Fora de intervalo");

            }

        }
    }
}
