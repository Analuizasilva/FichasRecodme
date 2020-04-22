using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    public class GestaoDeEntregaDeEncomenda
    {
        public DateTime? DataDaRececao { get; set; } = null;
        public string NifCliente { get; set; }
        public DateTime? DataDaChegada { get; set; } = null;


        public void MovimentoDaEncomenda()
        {
            if (this.DataDaChegada != null)
            {
                Console.WriteLine(" Sua encomenda foi entregue! ");
            }
            else if (this.DataDaRececao == null)
            {
                Console.WriteLine(" Sua encomenda ainda nao saiu do armazem! ");
            }
            else if(this.DataDaRececao !=null && this.DataDaChegada ==null)
            {
                Console.WriteLine(" Sua encomenda saiu para entrega! ");
            }
        }
    }
}

