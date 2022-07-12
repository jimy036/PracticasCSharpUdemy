using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Rectangulo : IFigura
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Rectangulo(int basse, int altura)
        {
            Base = basse;
            Altura = altura;
        }

        public double CalcularArea()
        {

            return Base * Altura;
        }

        public void DatosRectangulo()
        {
            Console.WriteLine("Base {0}, Altura {1}", Base, Altura);
        }

    }
}
