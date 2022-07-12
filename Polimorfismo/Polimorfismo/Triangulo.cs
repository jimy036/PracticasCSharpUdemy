using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Triangulo : IFigura
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public Triangulo(int basse, int altura)
        {
            Base = basse;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Base * Altura / 2;
        }

        public void DatosTriangulo()
        {
            Console.WriteLine("Base {0}, Altura {1}", Base, Altura);
        }
    }
}
