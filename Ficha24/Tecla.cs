using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    public class Tecla
    {
        public string Color { get; set; }
        public string Key { get; set; }
        public string MusicalNote { get; set; }

        public void Play()
        {
            Console.WriteLine($"{MusicalNote}");
        }

    }
}












