using System;
using System.Collections.Generic;

namespace Ficha17
{
    public class Ficha17solucao
    {

        #region Exercicio 1
        public static void Exercicio1()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            Console.WriteLine("Insira o indice!");
            int indice = int.Parse(Console.ReadLine());
            Console.WriteLine(frase[indice]);
        }
        #endregion
        #region Exercicio 2
        public static void Exercicio2()
        {
            Console.WriteLine("Insira 1ª Frase!");
            string frase1 = Console.ReadLine();

            Console.WriteLine("Insira 2ª frase!");
            string frase2 = Console.ReadLine();
            bool podeimpr = true;

            if (frase1.Length != frase2.Length)
            {
                Console.WriteLine("As frase são diferentes");
                podeimpr = false;
            }
            else
            {
                for (int i = 0; i < frase1.Length; i++)
                {
                    if (frase2[i] != frase1[i])
                    {
                        Console.WriteLine("As frases são diferentes!");
                        break;
                        podeimpr = false;
                    }
                }
                if (podeimpr)
                {
                    Console.WriteLine("As frases são iguais!");
                }
            }
        }
        #endregion
        #region Exercicio 3
        public static void Exercicio3()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            string[] palavras = new string[frase.Length];

            for (int i = 0; i < frase.Length; i++)
            {
                if (!String.IsNullOrEmpty(frase))
                {
                    palavras = frase.Split(" ");
                }
            }
            Console.WriteLine($"{palavras.Length} palavras!");
        }
        #endregion
        #region Exercicio 4
        public static void Exercicio4()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{frase[i]}");
            }
        }
        #endregion
        #region Exercicio 5 
        public static void Exercicio5()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            for (int i = (frase.Length - 10); i < frase.Length; i++)
            {
                Console.Write($"{frase[i]}");
            }
        }
        #endregion
        #region Exercicio 6
        public static void Exercicio6()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            char[] alfabeto = new char[26] {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'};

            List<int> acum = new List<int>();

            foreach (char carac in frase)
            {
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (alfabeto[i] == carac)
                    {
                        acum.Add(i+1);
                    }
                }            
            }
            for (int i = 0; i <acum.Count; i++)
            {
                Console.Write($" {acum[i]} ");
            }
        }
        #endregion
        #region Exercicio 7
        public static void Exercicio7()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            for (int i =( frase.Length-1); i >= 0; i--)
            {
                Console.Write(frase[i]);
            }
            
        }
        #endregion
        #region Exercicio 8
        public static void Exercicio8()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();
            char result = ' ';
            char[] alfabeto = new char[26] {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'};

            List<char> caracOrdem = new List<char>();

            foreach (char carac in frase)
            {
                for (int i = 0; i <alfabeto.Length; i++)
                {
                    if (alfabeto[i] == carac)
                    {                        
                       caracOrdem.Add(carac);
                    }                    
                }
                for (int j = 0; j < caracOrdem.Count; j++)
                {
                    
                }
                Console.Write(caracOrdem[]);

            }
           

        }
        #endregion
        #region Exercicio 9
        public static void Exercicio9()
        {

        }
        #endregion
        #region Exercicio 10
        public static void Exercicio10()
        {

        }
        #endregion
        #region Exercicio 11
        public static void Exercicio11()
        {

        }
        #endregion
        #region Exercicio 12
        public static void Exercicio12()
        {

        }
        #endregion
        #region Exercicio 13
        public static void Exercicio13()
        {

        }
        #endregion
    
    }
}

