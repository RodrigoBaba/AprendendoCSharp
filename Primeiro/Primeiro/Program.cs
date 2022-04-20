
using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiro Teste
            Console.WriteLine("Ola Mundo!");

            //----------------------------------------------------------------------------

            // Segundo Teste
            SByte x = 100;
            Console.WriteLine(x);

            byte n1 = 126; // byte não aceita número negativo e  vai ate 255
            Console.WriteLine(n1);

            int n2 = 1000;
            Console.WriteLine(n2);

            int n3 = 2147483647;
            long n4 = 2147483648L;
            /* OBS: recomendado colocar L no final, para especificar que esta trabalhando
             *com número Long
            */
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            Console.WriteLine(genero);
            /*com codigo unicode*/
            char letra = '\u0041';
            Console.WriteLine(letra);

            float n5 = 4.5F; // para especificar que é float tem que colcocar F no final
            double n6 = 4.5;
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            string nome = "\nMaria Green";
            Console.WriteLine(nome);

            // object é um tipo generico
            object obj1 = "Alex Brown";
            object obj2 = 4.5F;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            // Valor maximo e minimo
            Console.WriteLine();
            int m1 = int.MinValue;
            int m2 = int.MaxValue;
            sbyte m3 = sbyte.MinValue;
            sbyte m4 = sbyte.MaxValue;
            decimal m5 = decimal.MaxValue;
            decimal m6 = decimal.MinValue;

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);
            Console.WriteLine(m6);

            //----------------------------------------------------------------------------

            // Terceiro Teste
            /* Nomes de variáveis:
             * 
             * ERRADO: começar com numero (int 5minutos), acentuação (int salário) e 
             * com barra de espaço (int salario do funcionario);
             * 
             * CORRETO: começar com underline (int _5minutos), sem acentuação 
             * (int salario) e camel case (int salarioDoFuncionario)
             */

            /* Conveções:
             * 
             * Camel Case: lastName(parêmetro de métodos, variáveis dentro de métodos)
             * Pascal Case: LastName(namespaces, classes, properties e métodos)
             * Padrão: _lastName(atributos "internos" da classe)
             */

            //----------------------------------------------------------------------------

            Console.WriteLine();
            // Quarto Teste
            Console.Write("Bom Dia!"); // Não quebra a linha
            Console.WriteLine("Boa Tarde!"); // Quebra a linha 
            Console.WriteLine("----------------------------------------------");

            char genero1 = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string name = "Maria";
            Console.WriteLine(genero1);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(name);
            Console.WriteLine(saldo.ToString("F2")); // Duas casas decimais
            Console.WriteLine(saldo.ToString("F4")); // Quatro casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            /* Quatro casas decimais com ponto inves da virgula
             * OBS: Lembrar de colocar o (#using System.Globalization;)
             */

            //----------------------------------------------------------------------------
            Console.WriteLine();
            // Quinto Teste

            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", 
                name, idade, saldo);
            /* Posso deixar o #{2} com duas casas decimais assim: #{2:F2} 
             * ou
             * na variavel saldo deixar assim: 
             * #saldo.ToString("F2", CultureInfo.InvariantCulture))
             * que será ponto inves de virgula
             */

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem " +
                $"saldo igual a {saldo:F2} reais");
            Console.WriteLine($"{nome} tem {idade} anos e tem" +
                $" saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais");

            // Concatenação
            Console.WriteLine(name + " tem " + idade + " anos e tem saldo igual a "
                + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            //----------------------------------------------------------------------------

            Console.WriteLine();
            // Sexto Teste
 
            // Operadores de atribuição
            int a = 10;
            Console.WriteLine("a = " + a);
            a += 2;
            Console.WriteLine("a += 2: " + a);
            a = 10;
            a -= 2;
            Console.WriteLine("a -= 2: " + a);
            a = 10;
            a *= 2;
            Console.WriteLine("a *= 2: " + a);
            a = 10;
            a /= 2;
            Console.WriteLine("a /= 2: " + a);
            a = 10;
            a %= 2;
            Console.WriteLine("a %= 2: " + a);

            // Também funciona com string
            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine("s += 'DEF' " + s);

            // Incrementar +1
            int b = 10;
            Console.WriteLine(b);
            b++;
            Console.WriteLine("b++ : " + b);
            int c = 10;
            int d = ++c;
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);

            //----------------------------------------------------------------------------

            Console.WriteLine();
            // Setimo Teste

            float l = 4.5f;
            double v = l;
            Console.WriteLine(v);

            // Casting
            double u = 5.1;
            // #float o = u; <== Esse modo não pode, tem que fazer o Casting
            float o = (float)u;
            Console.WriteLine(o);

            double i = 5.1;
            /* #int e = i; <== Também tem que fazer Casting, porém valor apos virgular seram
             * perdidos
             */
            int e = (int)i;
            Console.WriteLine(e);

            int k = 5;
            int w = 2;
            double resultado = k / w;
            Console.WriteLine(resultado);
            /* Nesse caso, sem o Casting, devido as variaveis K e W serem do tipo INT
             * o resultado não ira ser quebrado, mesmo RESULTADO sendo DOUBLE, por isso
             * se deve fazer o Casting         
             */
            resultado = (double) k / w;
            Console.WriteLine("Com Casting: " + resultado);

            //----------------------------------------------------------------------------

            Console.WriteLine();
            // Oitavo Teste

            /* Ordem dos operadores aritméticos:
             * Operadores realizados em primeiro lugar: * / % seguido de + -
             * Lembrando que () tem vem primeiro, ocupando o primeiro lugar na ordem
             */

            double f = 1.0, g = -3.0, h = -4.0;
            double delta = Math.Pow(g, 2.0) - 4.0 * f * h;
            // Potencia => #Math.Pow(base, expoente)
            // Raiz quadrada => #Math.Sqrt(valor)
            double x1 = (-g + Math.Sqrt(delta)) / (2.0 * f);
            Console.WriteLine("x1: " + x1);
            double x2 = (-g - Math.Sqrt(delta)) / (2.0 * f);
            Console.WriteLine("x2: " + x2);

            //----------------------------------------------------------------------------

            Console.WriteLine();
            // Nono Teste

            // Trabalhando com valores de ENTRADA => Console.ReadLine()

            string frase = Console.ReadLine();
            Console.WriteLine("Frase digitada: " + frase);

            // Comando Split:
            // Um modo de fazer:
            // #string split = Console.ReadLine();
            // #string[] vet = split.Split(' ');
            // Outro modo de fazer:
            // #string[] vet = Console.ReadLine().Split(' ');
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine("Com Split p1: " + p1 );
            Console.WriteLine("Com Split p2: " + p2 );
            Console.WriteLine("Com Split p3: " + p3 );
        }
    }
}
