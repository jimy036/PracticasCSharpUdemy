using System;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //UpCasting (Conversión hacia arriba). Lo que hace es que tomamos una clase y vamos a tratrarla
            //como si fuera del tipo de la interfaz.


            IFigura f1 = new Circulo(5);
            IFigura f2 = new Triangulo(4, 6);
            IFigura f3 = new Rectangulo(7, 3);
            IFigura f4 = new Circulo(9);

            IFigura[] figuras = new IFigura[] { f1, f2, f3, f4 };

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
            }

            //DownCasting (Conversión hacia abajo) ahora tomaremos un objeto referido como el tipo de la interfaz
            //y regresarlo a su tipo original.

            Circulo c = f1 as Circulo;
            Console.WriteLine("Datos del circulo: ");
            c.DatosCirulo();

        }
    }
}
