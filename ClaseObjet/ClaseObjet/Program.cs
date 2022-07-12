using System;

namespace ClaseObjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Jhon Doe", 31);
            Persona p2 = new Persona("Jhon Doe", 31);
            Persona p3 = p1;

            //Comparacación por referencia:
            Console.WriteLine("Referencia p1 y p2 son iguales: {0}", p1 == p2);
            Console.WriteLine("Referencia p2 y p3 son iguales: {0}", p2 == p3);
            Console.WriteLine("Referencia p1 y p3 son iguales: {0}", p1 == p3);

            //Comparación de objetos: 
            Console.WriteLine();
            Console.WriteLine("Referencia p1 y p2 son iguales: {0}", p1.Equals(p2));
            Console.WriteLine("Referencia p2 y p3 son iguales: {0}", p2.Equals(p3));
            Console.WriteLine("Referencia p1 y p3 son iguales: {0}", p1.Equals(p3));
            
        }
    }
}
