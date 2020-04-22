using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    public class Cartao
    {
        public string Color { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public void ShowQuestion()
        {            
            Console.WriteLine(this.Question);
        }

        public void CheckAnswer(string answer)
        {
            if (answer == this.Answer)
            {
                Console.WriteLine("Você acertou! \\O/");
            }
            else
            {
                Console.WriteLine($"Você errou. A resposta é {this.Answer}!");
            }
        }
    }
}
