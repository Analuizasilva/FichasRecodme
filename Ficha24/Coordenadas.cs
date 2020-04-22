using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha24
{
    public class Coordenadas
    {
        public string CoordenadaX { get; set; }
        public string CoordenadaY { get; set; }
        public string Guardado { get; set; }

        public override string ToString()
        {
            return $"O {Guardado} está localizado na coordenada X {CoordenadaX} e na coordenada Y {CoordenadaY}";
        }

    }
}
