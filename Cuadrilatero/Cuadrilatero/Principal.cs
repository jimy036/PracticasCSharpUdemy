using System;


namespace Cuadrilatero
{
    internal class Principal
    {
        static void Main(String [] args)
        {
            Calculo cuadrilatero;
            float sideA, sideB;

            sideA = float.Parse(Console.ReadLine());
            sideB = float.Parse(Console.ReadLine());

            if (sideA == sideB)
            {
                cuadrilatero = new Calculo(sideA);
            }
            else
            {
                cuadrilatero = new Calculo(sideB, sideB);
            }

        }
    }
}
