using System;

namespace CompararObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto();

            p1.Codigo = "A1";
            p1.Precio = 123;

            Producto p2 = new Producto { Codigo = "A2", Precio = 34.5m};
            Producto p3 = new Producto { Codigo = "A3", Precio = 59.6m};

            Producto[] productos = new Producto[] { p1, p2, p3 };
            Array.Sort(productos);
            foreach (var prod in productos)
            {
                Console.WriteLine("Código: {0}, Precio: ${1}", prod.Codigo, prod.Precio);
            }
        }
    }
}
