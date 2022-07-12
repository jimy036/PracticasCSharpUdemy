using System;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Andres", 33);
            p.Saludar();
            Console.WriteLine(p);

            Empleado e = new Empleado("Jhon", 29, "Ventas", 3000);
            e.Saludar();
            Console.WriteLine("\nLlamando al método e.trabajar:");
            e.Trabajar();
            Console.WriteLine("\nllamando a e");
            Console.WriteLine(e);

            Estudiante es = new Estudiante("Juan", 22, "sistemas", 1, "La Nacional");
            Console.WriteLine("\nmetodo es.saludar");
            es.Saludar();
            Console.WriteLine("\nLlamando a (es) que es el método toString de estudiante: ");
            Console.WriteLine(es);
        }
    }
}
