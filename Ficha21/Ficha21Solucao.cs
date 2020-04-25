using System;
using System.Collections.Generic;
using System.IO;

namespace Ficha21
{
    public static class Ficha21Solucao
    {
        #region Exercicio 1
        public static void Exercicio1()
        {
            var array = new int[] { 10, 62, 73, 4 };
            array.SomarArray();
        }
        public static void SomarArray(this int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                count += item;
            }
            Console.WriteLine(count);
        }

        #endregion

        #region Exercicio 2
        public static void Exercicio2()
        {
            int num1 = 20;
            int num2 = 150;
            int num = 10;
            num.Check(num1, num2);
        }
        public static void Check(this int num, int num1, int num2)
        {
            if (num < num2 && num > num1)
            {
                Console.WriteLine($"{num} ESTÁ entre {num1} e {num2}!");
            }
            else
            {
                Console.WriteLine($"{num} NÃO está entre {num1} e {num2}!");
            }
        }
        #endregion

        #region Exercicio 3
        public static void Exercicio3()
        {
            DateTime date = DateTime.Now;
            date.ReturnNameOfTheMonth();
        }
        public static void ReturnNameOfTheMonth(this DateTime date)
        {
            Console.WriteLine(date.ToString("MMMM"));
        }
        #endregion

        #region Exercicio 4
        public static void Exercicio4()
        {
            DateTime date = DateTime.Now;
            date.ReturnNameOfTheDay();
        }
        public static void ReturnNameOfTheDay(this DateTime date)
        {
            Console.WriteLine(date.DayOfWeek);
        }
        #endregion

        #region Exercicio 5
        public static void Exercicio5()
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            char _char = 'b';
            _char.CheckChar(vowels);
        }
        public static void CheckChar(this char _char, char[] vowels)
        {
            foreach (char item in vowels)
            {
                if (item == _char)
                {
                    Console.WriteLine($"{_char} É uma vogal!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{_char} NÃO é uma vogal!");
                    break;
                }
            }
        }
        #endregion

        #region Exercicio 6
        public static void Exercicio6()
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            char _char = 'a';
            _char.CheckCharac(vowels);
        }
        public static void CheckCharac(this char _char, char[] vowels)
        {
            foreach (char item in vowels)
            {
                if (item != _char)
                {
                    Console.WriteLine($"{_char} É uma Consoante!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{_char} NÃO é uma Consoante!");
                    break;
                }
            }
        }
        #endregion

        #region Exercicio 7
        public static void Exercicio7()
        {
            string phase = "Hello word!";
            phase.RetornVowels();
        }
        public static void RetornVowels(this string phase)
        {
            List<char> vowel = new List<char> { };
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (char item in phase)
            {
                if (vowels.Contains(item))
                {
                    if (!vowel.Contains(item))
                    {
                        vowel.Add(item);
                    }
                }
            }
            foreach (var item in vowel)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Exercicio 8
        public static void Exercicio8()
        {
            string phase = "hello word!";
            phase.RetornConsonants();
        }
        public static void RetornConsonants(this string phase)
        {
            List<char> Consonant = new List<char> { };
            List<char> Consonants = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l',
            'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            foreach (char item in phase)
            {
                if (Consonants.Contains(item))
                {
                    if (!Consonant.Contains(item))
                    {
                        Consonant.Add(item);
                    }
                }
            }
            foreach (var item in Consonant)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Exercicio 9 (Falta fazer)

        #endregion

        #region Exercicio 10        
        public static void Exercicio9()
        {
            string phase = "* @n@_Luiz@ * !";
            phase.RetornSpecialChar();
        }
        public static void RetornSpecialChar(this string phase)
        {
            List<char> vowel = new List<char> { };
            List<char> vowels = new List<char> { '@', '#', '_', '*', '&' };
            foreach (char item in phase)
            {
                if (vowels.Contains(item))
                {
                    if (!vowel.Contains(item))
                    {
                        vowel.Add(item);
                    }
                }
            }
            foreach (var item in vowel)
            {
                Console.WriteLine(item);
            }
        }


        #endregion

        #region Exercicio 11 (Falta fazer)
        public static void Exercicio11()
        {

        }
        #endregion

        #region Exercicio 12(Falta fazer)
        public static void Exercicio12()
        {
            StreamWriter x;
            string aFile = ("C:\\Users\\Ana Silva\\Desktop\\Ana.txt");
            x = File.CreateText(aFile);
            x.Close();
        }          
        
        #endregion
    }
}
