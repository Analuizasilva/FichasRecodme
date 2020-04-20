using System;
using System.Collections.Generic;

namespace Ficha16
{
    public class Ficha16solucao
    {
        #region Exercicio 1
        public static void Exercicio1()
        {
            List<int> listaDeNumeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Insira o primeiro numero e aperte enter para inserir os proximos");
                int num = int.Parse(Console.ReadLine());
                Console.Clear();
                listaDeNumeros.Add(num);

                foreach (var numero in listaDeNumeros)
                {
                    Console.WriteLine($"{numero}");
                }
            }
        }
        #endregion

        #region Exercicio 2
        public static void Exercicio2()
        {
            List<int> listaDeNumeros = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Insira o primeiro numero e aperte enter para inserir os proximos");
                int num = int.Parse(Console.ReadLine());
                Console.Clear();
                listaDeNumeros.Add(num);
            }

            for (int j = listaDeNumeros.Count - 1; j >= 0; j--)
            {
                Console.WriteLine($"{listaDeNumeros[j]}");
            }
        }
        #endregion

        #region Exercicio 3
        public static void Exercicio3()
        {
            int soma = 0;
            List<int> SomaDosNumeros = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Insira o primeiro numero e aperte enter para inserir os proximos");
                int num = int.Parse(Console.ReadLine());
                SomaDosNumeros.Add(num);
                Console.Clear();
            }
            foreach (var numero in SomaDosNumeros)
            {
                soma += numero;
            }
            Console.WriteLine(soma);

        }
        #endregion

        #region Exercicio 4
        public static void Exercicio4()
        {
            List<int> numerosNaoRepetidos = new List<int>();
            List<int> contagemDeNumeros = new List<int>();
            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(10);
            numeros.Add(15);
            for (int count = 0; count < numeros.Count; count++)
            {
                if (numerosNaoRepetidos.Contains(numeros[count]))
                {
                    for (int i = 0; i < numerosNaoRepetidos.Count; i++)
                    {
                        if (numerosNaoRepetidos[i] == numeros[count])
                        {
                            contagemDeNumeros[i] += 1;
                            break;
                        }
                    }
                }
                else
                {
                    numerosNaoRepetidos.Add(numeros[count]);
                    contagemDeNumeros.Add(1);
                }
            }

            for (int i = 0; i < numerosNaoRepetidos.Count; i++)
            {
                if (contagemDeNumeros[i] > 1)
                {
                    Console.WriteLine($"Numero: {numerosNaoRepetidos[i]} - {contagemDeNumeros[i]} veze(s)");
                }
            }
        }

        #endregion

        #region Exercicio 5
        public static void Exercicio5()
        {
            List<int> numerosNaoRepetidos = new List<int>();
            List<int> contagemDeNumeros = new List<int>();
            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(10);
            numeros.Add(15);
            for (int count = 0; count < numeros.Count; count++)
            {
                if (numerosNaoRepetidos.Contains(numeros[count]))
                {
                    for (int i = 0; i < numerosNaoRepetidos.Count; i++)
                    {
                        if (numerosNaoRepetidos[i] == numeros[count])
                        {
                            contagemDeNumeros[i] += 1;
                            break;
                        }
                    }
                }
                else
                {
                    numerosNaoRepetidos.Add(numeros[count]);
                    contagemDeNumeros.Add(1);
                }
            }

            for (int i = 0; i < numerosNaoRepetidos.Count; i++)
            {
                if (contagemDeNumeros[i] == 1)
                {
                    Console.WriteLine($"Numero: {numerosNaoRepetidos[i]} - {contagemDeNumeros[i]} vez");
                }
            }
        }
        #endregion

        #region Exercicio 6
        public static void Exercicio6()
        {
            List<int> numeros = new List<int>();

            numeros.Add(20);
            numeros.Add(10);
            numeros.Add(30);
            numeros.Add(5);
            numeros.Add(50);
            numeros.Add(3);
            int menorNumero = numeros[0];
            int maiorNumero = numeros[0];

            foreach (var numero in numeros)
            {
                if (maiorNumero < numero)
                {
                    maiorNumero = numero;
                }               
                else if (numero < menorNumero)
                { 
                    menorNumero = numero;
                }
            }
            Console.WriteLine($"  O maior numero da lista é {maiorNumero} ");
            Console.WriteLine($" O menor numero da lista é {menorNumero} ");



        }
        #endregion

        #region Exercicio 7
        public static void Exercicio7()
        {
            List<int> numeros = new List<int>();
            List<int> numerosPares = new List<int>();
            List<int> numerosImpares = new List<int>();
            numeros.Add(5);
            numeros.Add(15);
            numeros.Add(20);
            numeros.Add(53);
            numeros.Add(66);
            foreach (var numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    numerosPares.Add(numero);
                }
                else 
                {
                    numerosImpares.Add(numero);
                }          
            }
            foreach (var numero in numerosPares)
            {
                Console.WriteLine($" Números pares {numero} ");
            }
            foreach (var numero in numerosImpares)
            {
                Console.WriteLine($" Números impares {numero} ");
            }
        }                
        #endregion

        #region Exercicio 8
        public static void Exercicio8(char letra)
        {         
            List<char> letras = new List<char>();
            letras.Add('a');
            letras.Add('d');
            letras.Add('s');
            letras.Add('r');
            if (letras.Contains(letra))
            {
                Console.WriteLine($"{letra} ESTÁ na lista!");
            }
            else
            {
                Console.WriteLine($"{letra} NÃO está na  lista!");
            }
        }
        
        #endregion
    }
}
