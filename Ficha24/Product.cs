using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    #region Exercicio 3
    public class Product
    {       
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public int QuantityInStock { get; set; }

        public void sell(int quantity)
        {
            if (this.QuantityInStock < quantity)
            {
                Console.WriteLine(" Não temos essa quantidade em estoque! ");
            }
            else
            {
                Console.WriteLine(" Produto adicionado ao carrinho de compras! ");
            }
        }
        public void CheckPayment(double value)
        {
            if(this.Price > value)
            {
                Console.WriteLine("Você não tem limite suficiente!");
            }
            else
            {
                Console.WriteLine("Compra efetuadacom sucesso!");
            }
        }
        public void QuantityOfPossibleProductsToBuy(double value)
        {
            if (value > this.Price)
            {
                var quantity = Math.Floor(value / this.Price);
                Console.WriteLine($"Você pode comprar {quantity}!");
            }
            else
            {
                Console.WriteLine($"Não e possivel comprar o produto, o valor minimo é {this.Price}");
            }
        }
    }
    #endregion
}
