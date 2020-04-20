using System;

namespace Ficha10
{
    public class Ficha10Solucao
    {
        #region Exercicio1.1
        public static void Exercicio1()
        {
            Console.WriteLine(" What's your name? ");
            var name = Console.ReadLine();
            HelloName(name);
        }

        protected static void HelloName(string name)
        {
            Console.WriteLine(" Hello! " + name);
        }

        #endregion exercicio1
        #region Exercicio1.2
        public static void Exercicio2()
        {
            Console.WriteLine("Number1");
            var num1 = Console.ReadLine();
            Console.WriteLine("Number2");
            var num2 = Console.ReadLine();

            var numconv1 = ConverterStringParaNumero(num1);
            var numconv2 = ConverterStringParaNumero(num2);

            Somar(numconv1, numconv2);
        }
        public static int ConverterStringParaNumero(string num)
        {
            var parseOK = int.TryParse(num, out int parsedNum);
            if (parseOK)
            {
                return parsedNum;
            }
            else
            {
                return 0;
            }

        }

        public static void Somar(int num1, int num2)
        {
            var soma = num1 + num2;
            Console.WriteLine(" O resultado da soma é = " + soma);
        }
        #endregion
        #region Exercicio1.3
        public static void Exercicio3()
        {
            var total = LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            total += LerEConverter();
            Console.WriteLine(" Total = " + total);

        }
        public static int LerEConverter()
        {
            Console.WriteLine("Insira um número");
            var num = Console.ReadLine();
            var numParsed = ConverterStringParaNumero(num);
            return numParsed;

        }




        #endregion
        #region Exercicio1.4
        public static void Exercicio4()
        {
            Console.WriteLine("Insira o primeiro numero");
            var num1 = Console.ReadLine();
            Console.WriteLine("Insira o segundo numero");
            var num2 = Console.ReadLine();
            var a = num1;
            var b = num2;
            var c = a;

            Console.WriteLine(" B = " + a);
            Console.WriteLine(" A = " + b);

        }
        #endregion
        #region Exercicio1.5
        public static void Exercicio5a()
        {
            Console.WriteLine("Insira o primeiro numero");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro numero");
            var n3 = int.Parse(Console.ReadLine());
            var b = Calc(n1, n2, n3);
            Console.WriteLine(" a + b * c = " + b);
        }
        public static int Calc(int num1, int num2, int num3)
        {
            return (num1 + num2 * num3);
        }
        public static void Exercicio5b()
        {
            Console.WriteLine(" Insira um numero! ");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Insira um numero! ");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Insira um numero! ");
            var n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calc1(n1, n2, n3));
        }
        public static int Calc1(int n1, int n2, int n3)
        {
            return (n1 + n2) % n3;
        }

        public static void Exerciocio5c()
        {
            Console.WriteLine(" Insira o 1º numero! ");
            var n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Insera o 2º numero! ");
            var n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o 3º numero !");
            var n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o 4º numero !");
            var n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("O Resultado é = " + Calc2(n1, n2, n3, n4));
        }
        public static int Calc2(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 * n3 / n4;
        }
        public static void Exercicio5d()
        {
            Console.WriteLine("Insira o numero 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero 2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero 3");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero 4");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero 5");
            int n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero 6");
            int n6 = int.Parse(Console.ReadLine());
            Console.WriteLine("O resutado é = " + Calc3(n1, n2, n3, n4, n5, n6));
        }
        public static int Calc3(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            return n1 + n2 / 6 * 17 % 2;
        }
        #endregion
        #region Exercicio1.6
        public static void Exercicio6()
        {
            Console.WriteLine("Insira um número!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"A tabuada de é ");
            Tabuada(num);
        }
        public static void Tabuada(int num)
        {

            for (int count = 1; count <= 10; count++)
            {
                Console.WriteLine($"{num}*{count}={(num * count)}");
            }


        }
        #endregion
        #region Exercicio1.7
        public static void Exercicio7()
        {
            Console.WriteLine("Insira o primeiro numero!");
            int firstName = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero!");
            int secondName = int.Parse(Console.ReadLine());
            Console.WriteLine(" A media dos dois numero é = " + CalcularMedia(firstName, secondName));
        }
        public static int CalcularMedia(int firstName, int secondName)
        {
            return ((firstName + secondName) / 2);
        }
        #endregion
        #region Exercicio1.8
        public static void Exercicio8()
        {
            Console.WriteLine("Insira um numero!");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("A media dos numero é = " + CalcularMedia(n1, n2, n3, n4, n5));
        }
        public static int CalcularMedia(int n1, int n2, int n3, int n4, int n5)
        {
            return ((n1 + n2 + n3 + n4 + n5) / 5);
        }
        #endregion
        #region Exercicio1.9
        public static void Exercicio9()
        {
            Console.WriteLine("Insira um numero!");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um numero!");
            int n10 = int.Parse(Console.ReadLine());
            Console.WriteLine("A media dos numero é = " + CalcularMedia(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10));

            static int CalcularMedia(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10)
            {
                return ((n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10);
            }

        }
        #endregion
        #region Exercicio1.10
        public static void Exercicio10()
        {
            Console.WriteLine("Insira um caracter!");
            var caracter = Console.ReadLine();
            Console.WriteLine(caracter + " " + caracter + " " + caracter + "\n" + caracter + " " + caracter + " " + caracter + "\n" + caracter + " " + caracter + " " + caracter);


        }

        #endregion
        #region Exercicio1.11
        public static void Exercicio11()
        {
            Console.WriteLine("Insira o nome do produto!");
            var nome = Console.ReadLine();
            Console.WriteLine("Insira o preço do produto!");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de produtos!");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine($" O valor total da compra é =  R${(preco * quant)}");
        }
        #endregion
        #region Exercicio2.1
        public static void Exercicio2_1()
        {
            Console.WriteLine("Diz-me algo que eu não saiba");
            var algo = Console.ReadLine();
            Console.WriteLine($"Eu ja sabia que {algo}");
        }
        #endregion
        #region Exercicio2.2
        public static void Exercicio2_2()
        {
            Console.WriteLine("Insira o primeiro numero!");
            int firstName = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero!");
            int secondName = int.Parse(Console.ReadLine());
            Console.WriteLine($"O primeiro numero é {firstName} e o segundo número é {secondName}");
        }
        #endregion
        #region Exercicio2.3
        public static void Exercicio2_3()
        {
            Console.WriteLine("Introduza uma temperatura");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("A temperatura em kelvin é = " + ConverterTempF(temp)
                + "ºK" + " \n temperatura em fahrenheit é = " + ConverterTempK(temp) + "ºF");

        }
        public static int ConverterTempF(int temp)
        {
            int tempF = temp * 9 / 5 + 32;
            return tempF;

        }
        public static double ConverterTempK(int temp)
        {
            double tempK = temp + 273.15;
            return tempK;
        }
        #endregion
        #region Exercicio3.1
        public static void Exercicio3_1()
        {
            Console.WriteLine("Quantas horas?");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos minutos?");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos segundos?");
            int seg = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcularHora(hora)+":"+ CalcularMin(min)+":"+seg);
        }

        public static int CalcularHora(int hora)
        {
            int horas = hora * 3600;
            return horas; 
        }
        public static int CalcularMin(int min)
        {
            int minut = min * 60;
            return minut;
        }
        #endregion
        #region Exercicio 3.2
        public static void Exercicio3_2()
        {
            Console.WriteLine("Qual é o raio? ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimetro = "+CalcularPerimetro(r)+"\nArea = "+CalcularPerimetro(r));
        }
        public static double CalcularPerimetro(int r)
        {
            double p = 2 * 3.14 * r;
            return p;
        } public static double CalcularArea(int r)
        {
            double a = 3.14 * r *r;
            return a;
        }
        #endregion
    }
}
    


