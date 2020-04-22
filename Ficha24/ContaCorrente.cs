using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    #region Exercicio 4
    public class ContaCorrente
    {
        public string Cliente { get; set; }
        public int NumeroAgencia { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

        public double VerificarSaldo()
        {
            Console.WriteLine( Saldo );
            return Saldo;
        }
        public void Sacar(double value)
        {
            if (this.Saldo > value)
            {
                Console.WriteLine("Saque efetuado com sucesso!");
                this.Saldo -= value;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        public void Depositar(double value)
        {
            this.Saldo += value;
            Console.WriteLine(" Deposito efetuado com sucesso ");
        }
    }
    #endregion
}
