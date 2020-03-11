using System;

namespace Ficha7
{
    public class Ficha7Solucao
    {
        #region Exercicio1.1
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
        #region Exercicio1.2
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
        #region Exercicio1.3
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
            else {
                Console.WriteLine("Este número nao é multiplo de 3 nem de 7!");
            }
        }

    #endregion
        #region Exercicio1.4
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
            if (num>10 && num<20)
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
            if (andar <-2 || andar>6 || andar ==3 || andar ==5)
            {
                Console.WriteLine("Piso indisponivel!");
            }
            else
            {
                Console.WriteLine("O piso de destino é " + andar);
            }
        }
        #endregion
    }
}

