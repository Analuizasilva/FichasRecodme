using System;

namespace Ficha22
{
    public class Ficha22solucao
    {
        #region Exercicio1
        public enum MeiosDeTransporte
        {
            Terra = 1,
            Mar = 2,
            Ar = 4
        }
        #endregion

        #region Exercicio2
        public enum TiposDeUrgencia
        {
            Verde = 100,
            Amarelo = 125,
            Larjanja = 150,
            Vermelho = 200
        }
        #endregion

        #region Exercicio3
        public enum DimensoesDePacotes
        {
            Xs = 1,
            S = 2,
            M = 4,
            L = 8,
            Xl = 16,
            Xxl = 32
        }
        #endregion

        #region Exercicio4
        public static void Exercicio4(double distance, TiposDeUrgencia tiposDeUrgencia, MeiosDeTransporte meiosDeTransporte,
            DimensoesDePacotes dimensoesDePacotes)
        {
            var timeDistance = (distance / 10);

            var timeToProcess = tiposDeUrgencia switch
            {
                TiposDeUrgencia.Verde => 24,
                TiposDeUrgencia.Amarelo => 12,
                TiposDeUrgencia.Larjanja => 6,
                TiposDeUrgencia.Vermelho => 3,
                _ => 0,
            };

            var time = (timeDistance / (int)meiosDeTransporte) + timeToProcess;
            var baseTime = DateTime.Now.AddHours(time + 1);
            var flag = true;

            while (flag)
            {
                if (baseTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    baseTime = baseTime.AddHours((24 - baseTime.Hour) + 33);
                }
                else if (baseTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    baseTime = baseTime.AddHours((24 - baseTime.Hour) + 9);
                }
                else if (baseTime.Hour < 9)
                {
                    baseTime = baseTime.AddHours(9 - baseTime.Hour);
                }
                else if (baseTime.Hour > 20)
                {
                    baseTime = baseTime.AddHours((24 - baseTime.Hour) + 9);
                }
                else { flag = false; Console.WriteLine($"O dia da entrega será {baseTime.ToString()}"); }
            }
        }
        #endregion
    }
}
