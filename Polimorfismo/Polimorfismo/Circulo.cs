using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Circulo : IFigura
    {
        public int Radio { get; set; }

        public Circulo(int radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public void DatosCirulo()
        {
            Console.WriteLine("Radio: {0}", Radio);
        }
    }
}
