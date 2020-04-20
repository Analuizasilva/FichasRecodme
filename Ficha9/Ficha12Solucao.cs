using System;

namespace Ficha12
{
    public class Ficha12Solucao
    {
        #region Exercicio 1.1
        public static void Exercicio1_1()
        {
            Console.WriteLine("Insira o 1º numero!");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o 2º numero!");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o 3º numero!");
            int n3 = int.Parse(Console.ReadLine());
            Produto(n1, n2, n3);
        }
        public static void Produto(int n1, int n2, int n3)
        {
            int resul = n1 * n2 * n3;
            Console.WriteLine($"Resultado de {n1}*{n2}*{n3}= {resul}");
        }
        #endregion

        #region Exercicio 1.2
        public static void Exercicio1_2()
        {
            Console.WriteLine("Insert the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number");
            int n2 = int.Parse(Console.ReadLine());
            MakeOperations(n1, n2);
        }
        public static void MakeOperations(int n1, int n2)
        {
            int sum = n1 + n2;
            int subtract = n1 - n2;
            int multiplication = n1 * n2;
            int division = n1 / n2;
            Console.WriteLine($"{n1}+{n2}={sum}");
            Console.WriteLine($"{n1}-{n2}={subtract}");
            Console.WriteLine($"{n1}*{n2}={multiplication}");
            Console.WriteLine($"{n1}/{n2}={division}");
        }
        #endregion

        #region Exercicio 1.3
        public static void Exercicio1_3()
        {
            Console.WriteLine("Insert the first number!");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number!");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the third number!");
            int n3 = int.Parse(Console.ReadLine());
            Calcular(n1, n2, n3);
        }
        public static void Calcular(int n1, int n2, int n3)
        {
            int resul1 = (n1 + n2) * n3;
            int resul2 = n1 * n2 + n2 * n3;
            Console.WriteLine($"({n1}+{n2})*{n3}={resul1}");
            Console.WriteLine($"{n1}*{n2}+{n2}*{n3}={resul2}");
        }
        #endregion

        #region Exercicio 1.4
        public static void Exercicio1_4()
        {
            Console.WriteLine("Insert the number!");
            int num = int.Parse(Console.ReadLine());
            ApresentarNumerosPrimosAteN(num);
        }
        public static void ApresentarNumerosPrimosAteN(int num)
        {
            for (int count = 2; count < num; count++)
            {
                bool isPrime = true;
                for (int count1 = 2; count1 < count; count1++)
                {
                    if (count % count1 == 0)
                    {
                        isPrime = false;

                    }
                }
                if (isPrime) Console.WriteLine($"{count}");
            }
        }

        #endregion

        #region Exercicio 1.5
        public static void Exercicio1_5()
        {
            Console.WriteLine("Hello?");
            var phrase = Console.ReadLine();


            if (phrase == "Is it me you're looking for?")
            {
                Console.WriteLine("i can see it in your eyes");
            }
            else
            {
                Console.WriteLine("noooo!");
            }
        }
        #endregion

        #region Exercicio 1.6
        public static void Exercicio1_6()
        {

        }
        #endregion

        #region Exercicio 1.7
        public static void Exercicio1_7()
        {
            Console.WriteLine("Insira um ano");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
            {
                Console.WriteLine($"É bissexto!");
            }
            else
            {
                Console.WriteLine($"NÃO é um ano bissexto!");
            }
        }
        #endregion

        #region Exercicio 1.8
        public static void Exercicio1_8()
        {
            for (int beerCound = 99; beerCound > 0; beerCound--)
            {
                Console.WriteLine($"{beerCound} bottles of beer on the wall, {beerCound} bottles of beer.");
                if (beerCound != 0)
                {
                    Console.WriteLine($"Take one down and pass it around, {beerCound} bottles of beer on the wall.");
                    if (beerCound == 0)
                    {

                    }
                }
            }
            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
        }
        #endregion

        #region Exercicio 1.9
        public static void Exercicio1_9()
        {
            Console.WriteLine("Qual o comprimento 1?");
            int comp = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o comprimento 2?");
            int comp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o comprimento 3?");
            int comp2 = int.Parse(Console.ReadLine());
            CalcularIgualdadeDosLados(comp, comp1, comp2);
        }
        public static void CalcularIgualdadeDosLados(int comp, int comp1, int comp2)
        {
            if (comp == comp1 && comp == comp2)
            {
                Console.WriteLine("Este triangulo e equilatero!");
            }
            else if (comp != comp1 && comp != comp2 && comp1 != comp2)
            {
                Console.WriteLine("Este triangulo e escaleno!");
            }
            else
            {
                Console.WriteLine("Este triangulo e isoseles!");
            }
        }
        #endregion

        #region Exercicio 1.10
        public static void Exercicio1_10()
        {
            Console.WriteLine("Qual o valor inicial");
            int valorInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor final");
            int valorFinal = int.Parse(Console.ReadLine());
            int balanco = valorFinal - valorInicial;
            if (balanco < 0)
            {
                Console.WriteLine("Você teve PREJUIZO ;( ");
            }
            else if (balanco > 0)
            {
                Console.WriteLine("Você teve LUCROU \0/ ");
            }

        }
        #endregion

        #region Exercicio 1.11
        public static void Exercicio1_11()
        {
            int mes = 0;

            Console.WriteLine("Qual mês?");
            mes = int.Parse(Console.ReadLine());

            if (mes > 12)
            {
                Console.WriteLine("O ano so tem 12 meses.Por Favor escolha novamente!");
            }
            else
            {
                CalcularMes(mes);
                CalcularQuantidadeDeDiasDoMes(mes);
            }
        }
        public static void CalcularMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Marco");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Setembro");
                    break;
                case 10:
                    Console.WriteLine("Outubro");
                    break;
                case 11:
                    Console.WriteLine("Novembro");
                    break;
                case 12:
                    Console.WriteLine("Dezembro");
                    break;

            }
        }
        public static void CalcularQuantidadeDeDiasDoMes(int mes)
        {
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("31 dias");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("30 dias");
            }
            else
            {
                Console.WriteLine("29 dias");
            }

        }

        //if (mes== 1)
        // {
        //     Console.WriteLine("Janeiro 31 dias");
        // }
        //else if (mes == 2)
        // {
        //     Console.WriteLine("Fevereiro 29 dias");
        // }
        // else if (mes == 3)
        // {
        //     Console.WriteLine("Marco 31 dias");
        // }
        // else if (mes == 4)
        // {
        //     Console.WriteLine("Abril 30 dias");
        // }
        // else if (mes == 5)
        // {
        //     Console.WriteLine("Maio 31 dias");
        // }
        // else if (mes == 6)
        // {
        //     Console.WriteLine("Junho 30 dias");
        // }
        // else if (mes == 7)
        // {
        //     Console.WriteLine("Julho 31 dias");
        // }
        // else if (mes == 8)
        // {
        //     Console.WriteLine("Agosto 31 dias");
        // }
        // else if (mes == 9)
        // {
        //     Console.WriteLine("Setembro 30 dias");
        // }
        // else if (mes == 10)
        // {
        //     Console.WriteLine("Outubro 31 dias");
        // }
        // else if (mes == 11)
        // {
        //     Console.WriteLine("Novembro 30 dias");
        // }
        // else if (mes == 12)
        // {
        //     Console.WriteLine("Dezembro 31 dias");
        // }

        #endregion

        #region Exercicio 1.12
        public static void Exercicio1_12()
        {
            Console.WriteLine("Qual dimensao do triangulo invertido?");
            int n = int.Parse(Console.ReadLine());
           if (n != 0)
            {
                var a = 1;
                int espaco;
                for (int i = n; i >= 1; i--)
                {
                    espaco =  (n - (i-1));
                    for (int j = 0; j < espaco; j++)
                        Console.Write(" ");
                    for (int i2 = 0; i2 < (i * 2) - 1; i2++)
                        Console.Write("*");
                    a += 2;
                    Console.Write("\n");
                }
            }
        }
            #endregion

        #region Exercicio 1.13
            public static void Exercicio1_13()
            {
                Console.WriteLine("Qual a quantidade de unidades de agua consumidas?");
                double quantidadeDeUnidadeDeAgua = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual sua regiao?");
                var regiao = Console.ReadLine();
                if (regiao == "a")
                {
                    double total = 2 * quantidadeDeUnidadeDeAgua;
                    Console.WriteLine($"2 * {quantidadeDeUnidadeDeAgua} =  {total} euros");
                }
                else if (regiao == "b")
                {
                    double total = 1.2 * quantidadeDeUnidadeDeAgua;
                    Console.WriteLine($"1,2 * {quantidadeDeUnidadeDeAgua} =  {total} euros");
                }
                else if (regiao == "c")
                {
                    double total = 1 * quantidadeDeUnidadeDeAgua;
                    Console.WriteLine($"1 * {quantidadeDeUnidadeDeAgua} =  {total} euros");
                }
                else if (regiao == "d")
                {
                    double total = 0.75 * quantidadeDeUnidadeDeAgua;
                    Console.WriteLine($"0,75 * {quantidadeDeUnidadeDeAgua} =  {total} euros");
                }
            }
            #endregion

        #region Exercicio 1.14
            public static void Exercicio1_14()
            {
                Console.WriteLine("Insira um numero!");
                int num = int.Parse(Console.ReadLine());

                int f1 = 0;
                int f2 = 1;

                for (int i = 1; i <= num; i++)
                {
                    int som = f1 + f2;
                    f1 = f2;
                    f2 = som;
                    Console.WriteLine(f2);
                }
            }
            #endregion

        #region Exercicio 1.15
            public static void Exercicio1_15()
            {
                Console.WriteLine("Insira um numero!");
                int num = int.Parse(Console.ReadLine());
                int f1 = 0;
                int f2 = 1;

                for (int i = 1; i <= num; i++)
                {
                    int som = f1 + f2;
                    f1 = f2;
                    f2 = som;
                    if (num == f1 || num == f2)
                    {
                        Console.WriteLine($"{num} é Fibonacci!");
                        break;
                    }
                }
            }
            #endregion

        #region Exercicio 1.16 Advinhar numero entre 1 e 100.
            public static void Exercicio1_16()
            {
                var min = 1;
                var max = 100;
                bool numeroCerto = false;

                while (!numeroCerto)
                {
                    Console.WriteLine();
                    var avg = (int)Math.Floor((double)(min + max) / 2);
                    var keyOk = false;
                    var intConf = max - min;
                    if (intConf < 2)
                    {
                        for (int i = min; i < max + 1; i++)
                        {
                            Console.Write($"É {i}?");
                            var key = Console.ReadKey().Key;
                            if (key == ConsoleKey.Y || key == ConsoleKey.S)
                            {
                                numeroCerto = true;
                                break;
                            }
                            Console.WriteLine("");
                        }
                    }
                    if (!numeroCerto)
                    {
                        while (!keyOk)
                        {
                            Console.WriteLine($"O número é inferior a {avg} ?");

                            switch (Console.ReadKey().Key)
                            {
                                case ConsoleKey.Y:
                                case ConsoleKey.S:
                                    keyOk = true;
                                    max = avg - 1;
                                    break;
                                case ConsoleKey.N:
                                    keyOk = true;
                                    min = avg;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            #endregion
    }
}



