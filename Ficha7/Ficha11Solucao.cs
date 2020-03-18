using System;

namespace Ficha11
{
    public class Ficha11Solucao
    {
        #region Exercicio 1.1
        public static void Exercicio1_1()
        {
            Console.WriteLine(" Inserir sua nota ");
            var nota = double.Parse(Console.ReadLine());
            if (nota < 9.44)
            {
                Console.WriteLine(" Chumbou! ");
            }
            else
            {
                Console.WriteLine(" Passou! ");
            }
        }
        #endregion
        #region Exercicio 1.2
        public static void Exercicio1_2()
        {
            Console.WriteLine(" Qual sua altura ? ");
            var alt = double.Parse(Console.ReadLine());
            Console.WriteLine(" Qual seu peso? ");
            var peso = double.Parse(Console.ReadLine());
            CalcularBmi(alt, peso);
        }
        public static void CalcularBmi(double alt, double peso)
        {
            var bmi = (peso / (alt * alt));
            if (bmi <= 18.5)
            {
                Console.WriteLine("Você está abaixo do peso!");
            }
            else if (bmi > 18.5 || bmi <= 24.9)
            {
                Console.WriteLine("Você está no peso normal!");
            }
            else if (bmi >= 25 || bmi <= 29.9)
            {
                Console.WriteLine("Você está acima do peso!");
            }
            else
            {
                Console.WriteLine("Você está obeso!");
            }
        }

        #endregion
        #region Exercicio 1.3
        public static void Exercicio1_3()
        {
            Console.WriteLine("Insira um Numero!");
            var num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine("Este número é multiplo de 3!");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("Este número é multiplo de 7!");
            }
            else
            {
                Console.WriteLine("Este número nao é multiplo de 3 nem de 7!");
            }
        }

        #endregion
        #region Exercicio 1.4
        public static void Exercicio1_4()
        {
            Console.WriteLine("Insira um numero!");
            int num = int.Parse(Console.ReadLine());
            if (num >= 30 && num <= 50)
            {
                Console.WriteLine("Este numero ESTÁ entre 30 e 50!");
            }
            else
            {
                Console.WriteLine("Este numero NÃO está entre 30 e 50!");
            }
        }
        #endregion
        #region Exercicio1.5
        public static void Exercicio1_5()
        {
            Console.WriteLine("Insira um número!");
            int num = int.Parse(Console.ReadLine());
            if (num > 10 && num < 20)
            {
                Console.WriteLine("Este numero ESTÁ entre 10 e 20");
            }
            else
            {
                Console.WriteLine("Este número NÃO está entre 10 e 20");
            }
        }
        #endregion
        #region Exercicio1.6
        public static void Exercicio1_6()
        {
            Console.WriteLine("Insira o numero do andar!");
            int andar = int.Parse(Console.ReadLine());
            DirigirAoAndar(andar);
        }
        public static void DirigirAoAndar(int andar)
        {
            if (andar < -2 || andar > 6 || andar == 3 || andar == 5)
            {
                Console.WriteLine("Piso indisponivel!");
            }
            else
            {
                Console.WriteLine("O piso de destino é " + andar);
            }
        }
        #endregion
        #region Exercicio1.7
        public static void Exercicio1_7()
        {
            int som = 0;
            //for (int count=1; count<=10; count++)
            //{     
            //    Console.WriteLine("Insira um número!");
            //    int num = int.Parse(Console.ReadLine());
            //    som += num;
            //    Console.WriteLine($"O resultado da soma é = {som}");
            //}   
            int count = 1;
            //while (count<=10)
            //{
            //    Console.WriteLine("Insira um número!");
            //    int num = int.Parse(Console.ReadLine());
            //    som += num;
            //    Console.WriteLine($"O resultado da soma é = {som}");
            //    count++;
            //}
            do
            {
                Console.WriteLine("Insira um número!");
                int num = int.Parse(Console.ReadLine());
                som += num;
                Console.WriteLine($"O resultado da soma é = {som}");
                count++;
            }
            while (count <= 10);

        }

        #endregion
        #region Exercicio1.8
        public static void Exercicio1_8()
        {
            double valorTotalCompra = 0;

            for (int count = 1; count <= 5; count++)
            {
                Console.WriteLine("Qual nome do produto?");
                var nome = Console.ReadLine();
                Console.WriteLine("Qual o preço do produto?");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quantidade do produto?");
                int quant = int.Parse(Console.ReadLine());
                double valorProduto = preco * quant;
                valorTotalCompra += valorProduto;
            }
            Console.WriteLine($"R${valorTotalCompra}");

        }
        #endregion
        #region Exercicio1.9
        public static void Exercicio1_9()
        {

            int media = 0;
            int soma = 0;
            int quant = 0;
            int num = 0;

            do
            {
                Console.WriteLine("Insira um numero!");
                num = int.Parse(Console.ReadLine());
                if (num != 0)
                {
                    soma += num;
                    quant++;
                }

            }
            while (num != 0);
            media = soma / quant;
            Console.WriteLine($"A media é = {media}");
        }
        #endregion
        #region Exercicio1.10
        public static void Exercicio1_10()
        {
            Console.WriteLine("Insira o 1º número ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o 2º número");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um operador");
            string op = Console.ReadLine();
            CalcularOperação(num1, num2, op);
        }
        public static void CalcularOperação(int num1, int num2, string op)
        {
            int som = 0;
            if (op == "+")
            {
                som = num1 + num2;
                Console.WriteLine($"A soma dos numeros é = {som}");
            }
            else if (op == "-")
            {
                som = num1 - num2;
                Console.WriteLine($"A subtração dos numeros é = {som}");
            }
            else if (op == "*")
            {
                som = num1 * num2;
                Console.WriteLine($"A multiplicação dos numeros é = {som}");
            }
            else if (op == "/")
            {
                som = num1 / num2;
                Console.WriteLine($"A divisão dos numeros é = {som}");
            }
        }
        #endregion
        #region Exercicio 1.11
        public static void Exercicio1_11()
        {
            Console.WriteLine("Insira um número");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um caracter");
            char caracter = char.Parse(Console.ReadLine());
            Tabela(num, caracter);
        }
        public static void Tabela(int num, char caracter)
        {
            for (int count = 1; count <= 3; count++)
            {

                for (int count1 = 1; count1 <= 3; count1++)
                {
                    Console.Write($"{caracter}");
                }
                Console.Write("\n");
            }

        }

        #endregion
        #region Exercicio 1.12
        public static void Exercicio1_12()
        {
            Console.WriteLine("Insira um número");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um caracter");
            char caracter = char.Parse(Console.ReadLine());
            Tabela1(num, caracter);
        }
        public static void Tabela1(int num, char caracter)
        {
            for (int count = 1; count <= num; count++)
            {

                for (int count1 = 1; count1 <= num; count1++)
                {
                    Console.Write($"{caracter}");
                }
                Console.Write("\n");
            }

        }
        #endregion
        #region Exercicio 1.13
        public static void Exercicio1_13()
        {
            Console.WriteLine("Inserir o numero de colunas");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserir o numero de linhas");
            int lin = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserir o 1º caracter");
            char caracter1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Inserir o 2º caracter");
            char caracter2 = char.Parse(Console.ReadLine());
            Tabela2(col, lin, caracter1, caracter2);
        }
        public static void Tabela2(int col, int lin, char caracter1, char caracter2)
        {
            for (int count = 1; count <= lin; count++)
            {
                for (int count1 = 1; count1 <= col; count1++)
                {
                    Console.Write("" + caracter2 + caracter1);
                }
                Console.Write("\n");

            }
        }
        #endregion
        #region Exercicio 2.1
        public static void Exercicio2_1()
        {
            string escala = "";
            Console.WriteLine("Introduza a temperatura!");
            int temp = int.Parse(Console.ReadLine());
            while (escala != "c" && escala != "k" && escala != "f")
            {
                Console.WriteLine("Em qual escala? (C,K ou F)");
                escala = Console.ReadLine();
            }
            if (escala == "c")
            {
                Console.WriteLine($"{temp}ºC é equivalente a {temp + 273.15}ºK {temp * 9 / 5 + 32}ºF");
            }
            else if (escala == "k")
            {
                Console.WriteLine($"{temp}ºK é equivalente a {temp - 273.15}ºC {temp * 9 / 5 - 459.67}ºF");
            }
            else if (escala == "f")
            {
                Console.WriteLine($"{temp}ºF é equivalente a {(temp - 32) * 5 / 9}ºC {(temp + 459.67) * 5 / 9}ºK");
            }
        }
        #endregion
        #region Exercicio 2.2
        public static void Exercicio2_2()
        {
            Console.WriteLine("Qual o número limite?");
            int numLimit = int.Parse(Console.ReadLine());

            for (int count = 0; count <= numLimit; count++)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine(count);
                }
            }
        }
        #endregion
        #region Exercicio 2.3
        public static void Exercicio2_3()
        {
            string caracteres = "";
            string caracter;
            do
            {
                Console.WriteLine("Introduza um caracter ou enter para terminar");
                caracter = Console.ReadLine();
                caracteres = caracter + caracteres;
            } while (caracter != "");
            {
                Console.WriteLine(caracteres);
            }
        }

        #endregion
        #region Exercicio 3.1
        public static void Exercicio3_1()
        {
            Console.WriteLine("Insira um número!");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num}*3 = {num * 3}");
            }
            else
            {
                Console.WriteLine($"{num}*2 = {num * 2}");
            }
        }

        #endregion
        #region Exercicio 3.2
        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual a dimensão do triangulo?");
            double n= double.Parse(Console.ReadLine());
            var i = 1;
                       
            while (n>0)
            {
                n--;
                var a = 0;
                while (a!=n)
                {
                    Console.Write(" ");
                    a++;                  
                }
                var b = 0;
                while (b != i)
                {
                    Console.Write("*");
                    b++;
                }                                
                i += 2;
                Console.Write("\n");
            }
        }
      
        #endregion
    }
}



