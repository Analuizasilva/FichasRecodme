using System;

namespace Ficha14
{
    public class Ficha14solucao
    {
        #region Exercicio 1
        public static void Exercicio_1()
        {
            GerarNumerosNaturais(10);
        }
        public static void GerarNumerosNaturais(int limite, int count = 0)
        {
            if (count == limite)
            {
                Console.WriteLine(limite);
            }
            else
            {
                Console.WriteLine(count);
                GerarNumerosNaturais(limite, count + 1);
            }
        }
        #endregion
        #region Exercicio 2 
        public static void Exercicio_2()
        {
            ImprimirNumerosNaturais(50);
        }
        public static void ImprimirNumerosNaturais(int numNat)
        {

            if (numNat >= 0)
            {
                Console.WriteLine(numNat);
                ImprimirNumerosNaturais(numNat -= 1);
            }
        }
        #endregion
        #region Exercicio 3
        public static void Exercicio_3()
        {
            SomarNumerorosNaturais(10);
        }
        public static void SomarNumerorosNaturais(int numNaturais, int count = 1, int acumul = 1)
        {
            if (count < numNaturais)
            {
                SomarNumerorosNaturais(numNaturais, count += 1, acumul += count);
            }
            else
            {
                Console.WriteLine(acumul);
            }
        }
        #endregion
        #region Exercicio 4
        public static void Exercicio_4()
        {
            ApresentarNumerosPares(1, 20);
        }
        public static void ApresentarNumerosPares(int count, int limite)
        {
            {
                if (count <= limite)
                {
                    if (count % 2 == 0)
                    {
                        Console.WriteLine(count);
                    }
                    ApresentarNumerosPares(count + 1, limite);
                }
            }
        }
        #endregion
        #region Exercicio 5
        public static void Exercicio_5()
        {
            ImprimirNumerosDeFibonacci(10);
        }

        public static void ImprimirNumerosDeFibonacci(int limit, int count = 0)
        {

            if (count <= limit)
            {
                Console.WriteLine(NumerosDeFibonacci(count));
                ImprimirNumerosDeFibonacci(limit, count + 1);
            }
        }
        public static int NumerosDeFibonacci(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
            {
                return NumerosDeFibonacci(num - 1) + NumerosDeFibonacci(num - 2);
            }
        }

        #endregion
        #region Exercicio 6
        public static void Exercicio_6()
        {
            Console.WriteLine(ImprimirFatorial(5));
        }
        public static int ImprimirFatorial(int num)
        { 
            if (num == 1)
            {
                return 1;
            }            
            return  num * ImprimirFatorial(num - 1);        
        }
        #endregion
    }
}
