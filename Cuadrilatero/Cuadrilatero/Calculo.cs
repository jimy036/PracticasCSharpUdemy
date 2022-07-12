using System;



namespace Cuadrilatero
{
    internal class Calculo
    { 
    private float sideA;
    private float sideB;

    //Método constructor, recordar debe ser público y no devuelve ningún valor
    //para este constructor sería para el cuadrilátero
    public Calculo(float sideA, float sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    //Metodo constructor para el cuadrado:
    public Calculo(float sideA)
    {
        this.sideA = sideA = this.sideB = sideA;
    }

    public float getPerimetro()
    {
        float perimetro = 2 * (sideA + sideB);
        return perimetro;
    }

    public float getArea()
    {
        float area = (sideA * sideB);
        return area;
    }
}
}
