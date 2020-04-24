using System;
using System.Globalization;

namespace Ficha18
{
    public class Ficha18Solucao
    {
        #region Exercicio1
        public static void Exercicio1(int year1, int year2)
        {
            for (int year = year1; year <= year2; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
            }
        }
        #endregion

        #region Exercicio2
        public static void Exercicio2()
        {
            Console.WriteLine("Insira dia/mes/ano");
            DateTime date;
            var converted = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            if (converted)
            {
                Console.WriteLine($"{date.DayOfWeek}");
            }
            else
            {
                Console.WriteLine($"Nao foi possivel");
            }
        }

        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            var mouthName = DateTime.UtcNow.ToString("MMMMM");
            Console.WriteLine(mouthName);
        }
        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            DateTime currentYear = DateTime.UtcNow;
            DateTime currentMonth = DateTime.UtcNow;

            int daysInMonth = System.DateTime.DaysInMonth(currentYear.Year, currentMonth.Month);
            Console.WriteLine(daysInMonth + " Dias! ");
        }

        #endregion

        #region Exercicio5
        public static void Exercicio5()
        {
            DateTime currentdate = DateTime.UtcNow;
            DateTime tomorrowsDate = currentdate.AddDays(1);
            Console.WriteLine(tomorrowsDate);
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6()
        {
            DateTime currentdate = DateTime.UtcNow;
            DateTime yesterdaysTomorrow = currentdate.AddDays(-1);
            Console.WriteLine(yesterdaysTomorrow);
        }
        #endregion

        #region Exercicio7
        public static void Exercicio7()
        {
            var date = new DateTime(1996, 11, 07);
            var str = date.ToString("dd'/'MM'/'yyyy");
            Console.WriteLine(str);
        }
        #endregion

        #region Exercicio8
        public static void Exercicio8()
        {
            var str = "07/11/1996";
            var date = DateTime.Parse(str);
            Console.WriteLine(str);
        }

        #endregion

        #region Exercicio9
        public static void Exercicio9()
        {            
            var date = DateTime.UtcNow;
            var strDate = date.ToString("MM/dd/yyyy HH:mm:ss");
            Console.WriteLine(strDate);
        }
        #endregion

        #region Exercicio10
        public static void Exercicio10()
        {
            DateTime date = DateTime.Now;
            var str = date.ToString("MMMM");

            Console.WriteLine($"Hoje, {date.DayOfWeek}, dia {date.Day}, do mês {str}, de {date.Year}," +
                $" às {date.Hour} horas, e {date.Minute} minutos, e {date.Second} segundos");
        }
        #endregion
    }
}
