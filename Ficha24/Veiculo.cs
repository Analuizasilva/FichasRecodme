using Ficha26;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    #region Exercicio 2
    public class Vehicle : IVehicle
    {        
        public int YearOfEnrollment { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarState { get; set; }

        public Vehicle()
        {
            this.CarState = "Desligado";
        }

        public void TurnOn()
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

        public void SpeedUp()
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

        public void Delicate()
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

        public void RotateSteeringWheel()
        {
            Console.WriteLine("O volante foi rodado!");
        }

        public void Halt()
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

        public void InsertBrand(string brand)
        {
            if (Brand.Length <= 2)
            {
                Console.WriteLine("A marca do veiculo tem que ter mais que 3 caracteres!");
            }
            else
            {
                this.Brand = brand;
            }
        }

        public void InsertYearOfEnrollment(int yearOfEnrollment)
        {
            if (yearOfEnrollment < 1950)
            {
                this.YearOfEnrollment = yearOfEnrollment;
            }
            else
            {
                Console.WriteLine("O ano de matricula é menor do que 1950!");
            }
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void ChangeGear()
        {
            throw new NotImplementedException();
        }

        public void Break()
        {
            throw new NotImplementedException();
        }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void TurnWheel()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
