using System;

namespace ClasePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Andres", "Cardenas");
            persona1.Saludar();

            persona1.Age = -10;
            Console.WriteLine(persona1);
        }
    }
}
