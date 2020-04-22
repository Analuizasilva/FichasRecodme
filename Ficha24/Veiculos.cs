using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    #region Exercicio 2
    public class Veiculos
    {        
        public int AnoDeMatricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string CarState { get; set; }

        public Veiculos()
        {
            this.CarState = "Desligado";
        }

        public void Ligar()
        {
            if (this.CarState == "Desligado")
            {
                this.CarState = "Ligado";
            }
            else
            {
                Console.WriteLine("Para ligar o carro ele precisa estar desligado!");
            }
        }

        public void Acelerar()
        {
            if (this.CarState == "Ligado")
            {
                this.CarState = "Andando";
            }
            else
            {
                Console.WriteLine("Para acelerar o carro, e necessario que ele esteja ligado!");
            }
        }

        public void Desligar()
        {
            if (this.CarState == "Travado")
            {
                this.CarState = "Desligado";
            }
            else
            {
                Console.WriteLine("Trave o carro para desliga-lo!");
            }
        }

        public void RodarVolante()
        {
            Console.WriteLine("O volante foi rodado!");
        }

        public void Travar()
        {
            if (this.CarState == "Andando")
            {
                this.CarState = "Travado";
            }
            else
            {
                Console.WriteLine("O carro so pode ser travado quando estiver andando!");
            }
        }

        public void InserirMarca(string Marca)
        {
            if (Marca.Length <= 2)
            {
                Console.WriteLine("A marca do veiculo tem que ter mais que 3 caracteres!");
            }
            else
            {
                this.Marca = Marca;
            }
        }

        public void InserirAnoDeMatricula(int anoDeMatricula)
        {
            if (anoDeMatricula < 1950)
            {
                this.AnoDeMatricula = anoDeMatricula;
            }
            else
            {
                Console.WriteLine("O ano de matricula é menor do que 1950!");
            }
        }       
    }
    #endregion
}
