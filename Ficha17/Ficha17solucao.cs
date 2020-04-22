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
                        acum.Add(i + 1);
                    }
                }
            }
            for (int i = 0; i < acum.Count; i++)
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

            for (int i = (frase.Length - 1); i >= 0; i--)
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

            char[] alfabeto = new char[26] {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'};

            int[] caracOrdem = new int[frase.Length];
            var index = 0;
            foreach (char carac in frase)
            {
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (alfabeto[i] == carac)
                    {
                        caracOrdem[index] = (i);
                        index++;
                        break;
                    }
                }
            }

            var ordererArray = BubbleSort(caracOrdem);

            for (int i = 0; i < ordererArray.Length; i++)
            {
                var current = ordererArray[i];
                Console.Write($"{alfabeto[current]} ");
            }
        }

        public static int[] BubbleSort(int[] vetor)
        {
            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            return vetor;
        }

        #endregion
        #region Exercicio 9
        public static void Exercicio9()
        {
            Console.WriteLine(" Qual seu nome ? ");
            string nome = Console.ReadLine();

            Console.WriteLine($" Hello {nome}! ");
        }
        #endregion
        #region Exercicio 10 
        public static void Exercicio10()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();
            int quantidadeDeLetras = 0;
            int quantidadeDeCaracteresEsp = 0;
            int quantidadeDeNumeros = 0;
            char[] caracteresEspeciais = new char[] { '#', '*', '@', '&', '$', '_' };
            char[] numeros = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            foreach (char letra in frase.Replace(" ", ""))
            {
                for (int i = 0; i < caracteresEspeciais.Length; i++)
                {
                    if (letra == caracteresEspeciais[i])
                    {
                        quantidadeDeCaracteresEsp += 1;
                    }
                }
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (letra == numeros[j])
                    {
                        quantidadeDeNumeros++;
                    }
                }
                if (letra != caracteresEspeciais.Length && letra != numeros.Length)
                {
                    quantidadeDeLetras++;
                }
            }
            Console.WriteLine($"Letras: {quantidadeDeLetras - quantidadeDeCaracteresEsp - quantidadeDeNumeros}" +
                $"\nCaracteres especiais: {quantidadeDeCaracteresEsp}" +
                $"\nNumeros: {quantidadeDeNumeros}");
        }
        #endregion
        #region Exercicio 11
        public static void Exercicio11()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            var vogais = "aeiou";
            int numVogais = 0;
            int numConsoante = 0;

            foreach (var letra in frase.Replace(" ", ""))
            {
                if (vogais.Contains(letra))
                    numVogais += 1;
                else
                    numConsoante += 1;
            }
            Console.WriteLine($"Vogais: {numVogais}\nConsoante: {numConsoante}");
        }
        #endregion
        #region Exercicio 12(Falta fazer)
        public static void Exercicio12()
        {
            Console.WriteLine("Insira uma Frase!");
            string frase = Console.ReadLine();

            char[] alfabeto = new char[26] {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'};
            int max = 0;
            int indexMax = 0;
            foreach (var carac in frase)
            {
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (alfabeto[i] > max)
                    {
                        indexMax = i;
                        max = alfabeto[i];
                    }
                }        
            }
           Console.WriteLine($"O caracter que mais se repete na frase" +
                $" {frase} é {alfabeto[indexMax]}");
        }
        #endregion
        #region Exercicio 13(Falta fazer)
        public static void Exercicio13()
        {

        }
        #endregion

    }
}

