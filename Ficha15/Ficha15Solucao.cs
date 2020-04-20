using System;
using System.Linq;

namespace Ficha15
{
    public class Ficha15solucao
    {
        #region Exercicio 1
        public static void Exercicio_1()
        {
            int[] numeros = new int[5];

            for (int count = 0; count < numeros.Length; count++)
            {
                Console.WriteLine("Insira um numero e aperte enter para inserir o proximo!");
                int num = int.Parse(Console.ReadLine());
                numeros[count] = num;
                Console.Clear();
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        #endregion
        #region Exercicio 2
        public static void Exercicio_2()
        {
            int[] numeros = new int[5];

            for (int count = 0; count < numeros.Length; count++)
            {
                Console.WriteLine("Insira um numero e aperte enter para inserir o proximo!");
                int num = int.Parse(Console.ReadLine());
                numeros[count] = num;
                Console.Clear();
            }
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);

            }
        }
        #endregion
        #region Exercicio 3
        public static void Exercicio_3()
        {
            int[] numeros = new int[5];

            for (int count = 0; count < numeros.Length; count++)
            {
                Console.WriteLine("Insira um numero e aperte enter para inserir o proximo!");
                int num = int.Parse(Console.ReadLine());
                numeros[count] = num;
                Console.Clear();
            }
            int somar = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                somar += numeros[i];
            }
            Console.WriteLine($"A soma dos numeros  = {somar}");
        }
        #endregion
        #region Exercicio 4
        public static void Exercicio_4()
        {
            int[] numeros = new int[5];

            for (int count = 0; count < numeros.Length; count++)
            {
                Console.WriteLine("Insira um numero e aperte enter para inserir o proximo!");
                int num = int.Parse(Console.ReadLine());
                numeros[count] = num;
                Console.Clear();
            }
            Console.WriteLine($"O array possui {numeros.Length} elementos.");
        }
        #endregion
        #region Exercicio 5 
        public static void Exercicio_5()
        {        
            int[] numeros = new int[5] { 1, 2, 3, 1, 2 };
            int[] numerosNaoRepetidos = new int[5];
            int[] contagem = new int[5];
            
            for (int count = 0; count < numeros.Length; count++)
            {
                if (numerosNaoRepetidos.Contains(numeros[count]))
                {
                    for (int i = 0; i < numerosNaoRepetidos.Length; i++)
                    {
                        if (numerosNaoRepetidos[i] == numeros[count])
                        {
                            contagem[i] += 1;
                            break;
                        }                        
                    }
                }
                else
                {
                    for (int i = 0; i < numerosNaoRepetidos.Length; i++)
                    {
                        if (numerosNaoRepetidos[i] == 0)
                        {
                            numerosNaoRepetidos[i] = numeros[count];
                            contagem[i] = 1;
                            break;
                        }                        
                    }
                }
            }

            for (int i = 0; i < numerosNaoRepetidos.Length; i++)
            {
                if (contagem[i] != 0) 
                {
                    Console.WriteLine($"Numero: {numerosNaoRepetidos[i]} - {contagem[i]} veze(s)");
                }
            }
        }
        #endregion
        #region Exercicio 6 (Falta fazer)
        public static void Exercicio_6()
        {
            int[] array = new int[] {1,2,2,3,4,4,5};
            ImprimirNumerosRepetidos(array);
        }
        public static void ImprimirNumerosRepetidos(int[]array)
        {
            var repeated = new int[array.Length];
            int cont = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for ( int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        cont++;
                        break;
                    }                    
                }                
            }
            var repetido = 0;        
            int[] numRepedido = new int[cont];
            for (int i = 0; i < cont; i++)
            {
                if (repeated[i]!=0)
                {
                    numRepedido[i] = repeated[i];                    
                }
                foreach (var numero in numRepedido)
                {
                    Console.WriteLine(numero);
                } 
            }
            

        }
        #endregion
        #region Exercicio 7 
        public static void Exercicio_7()
        {
            int[] numeros = new int[7] {3, 6, 10, 25, 80, 53, 60};
            
            int numeroMaior = numeros[0];
            int numeroMenor = numeros[0];

            foreach (var numero in numeros)
            {
                if (numeroMenor > numero)
                {
                    numeroMenor = numero;
                }
                else if (numeroMaior < numero)
                {
                    numeroMaior = numero;
                }             
            }
            Console.WriteLine($" Menor numero do array {numeroMenor}");
            Console.WriteLine($" Maior numero do array {numeroMaior}");


        }
        #endregion
        #region Exercicio 8 
        public static void Exercicio_8()
        {
            int[] Numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] NumerosPares = new int[5];
            int[] NumerosImpares = new int[5];
            int contNumImp = 0;
            int contNumPar = 0;

            for (int cont = 0; cont < Numeros.Length; cont++)
            {
                if (Numeros[cont] % 2 == 0)
                {
                    NumerosPares[contNumPar] = Numeros[cont];
                    contNumPar++;
                }
                else
                {
                    NumerosImpares[contNumImp] = Numeros[cont];
                    contNumImp++;
                }
            }
            for (int i = 0; i < NumerosPares.Length; i++)
            {
                Console.WriteLine(" Numeros Pares! " + NumerosPares[i]);
            }
            for (int j = 0; j < NumerosImpares.Length; j++)
            {
                Console.WriteLine(" Numeros Impares! " + NumerosImpares[j]);
            }
        }
        #endregion
        #region Exercicio 9
        public static void Exercicio_9()
        {
            Console.WriteLine(" Insira um numero ente 0 e 50 para saber se ele se encontra no array ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            int[] numeros = new int[10] { 3, 7, 12, 25, 29, 30, 36, 42, 45, 50 };

            if (numeros.Contains(num))
            {
                Console.WriteLine($"{num} ESTÁ no array!");
            }
            else
            {
                Console.WriteLine($"{num} NÃO esta no array!");
            }

        }
        #endregion
    }
}

