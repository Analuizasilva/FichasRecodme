using System;

namespace Ficha19
{
    public class Ficha19Solucao
    {
        #region Exercicio1
        public static void Exercicio1()
        {
            double raio = 5;      
            double perimetro;
            CalcularArea(raio);
            CalcularPerimetro(raio);
        }
        public static void CalcularArea( double raio)
        {
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"Área = {area}");
        }
        public static void CalcularPerimetro(double raio)
        {
            double perimero = (Math.PI * 2)*raio;
            Console.WriteLine($"Perimetro = {perimero}");
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            double num = 7.69;
            double numArredondado = Math.Ceiling(num);
            Console.WriteLine($"{num} arrendondado para cima = {numArredondado}");
        }
        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            double num = 7.68;
            double numArredondado = Math.Floor(num);
            Console.WriteLine($"{num} arrendondado para baixo = {numArredondado}");
        }
        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            double num = 9.67;
            double numArredondado = Math.Round(num);
            Console.WriteLine($"{num} = {numArredondado}");
        }
        #endregion            

        #region Exercicio5
        public static void Exercicio5()
        {
           int num = 30;          
            double squareOfANumber = Math.Pow(num,2);
            Console.WriteLine($"O quadrado de {num} = {squareOfANumber}");
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6()
        {
            int num = 25;
            double squareRoot = Math.Sqrt(num);
            Console.WriteLine($"Raiz quadrada de {num} = {squareRoot}");
        }
        #endregion

        #region Exercicio7
        public static void Exercicio7()
        {
            double num = 1000;
            double numberLog = Math.Log(num);
            Console.WriteLine($"log de {num} = {numberLog}");
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8()
        {
            var degrees = 180;
            double radians = (Math.PI / 180) * degrees;

            Console.WriteLine($"{radians}°");
        }
        #endregion

        #region Exercicio9
        public static void Exercicio9()
        {
            int num = -45;
            int numAbs = Math.Abs(num);
            Console.WriteLine(numAbs);
        }
        #endregion

        #region Exercicio10
        public static void Exercicio10()
        {        
            int num = 102;
            int verifNum = Math.Sign(num);
            if (verifNum == 1)
            {
                Console.WriteLine($"{num} é POSITIVO!");
            }
            else if (verifNum == -1)
            {
                Console.WriteLine($"{num} é NEGATIVO!");
            }
            else
            {
                Console.WriteLine($"{num} é ZERO!");
            }                   
        }
        #endregion

    }
}
