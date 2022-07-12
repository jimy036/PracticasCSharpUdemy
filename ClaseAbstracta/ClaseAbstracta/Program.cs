using System;

/*Las clases abstractas son las que no pueden ser instanciadas, su objetivo es crear subclases que
completen a esa clase abstracta y le den la funcionalidad específica que necesita, es decir una 
clase abstracta es incompleta hasta que nosotros definamos una subclase, y esa subclase sobreescribe
metodos o propiedades que esa clase abstracta dejó definida.
*/

namespace ClaseAbstracta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoHonorarios eh = new EmpleadoHonorarios("Jhon", "Ventas", 12000);
            eh.Saludar();
            eh.Trabajar();
            Console.WriteLine("Salario ${0}", eh.Salario);

            EmpleadoNomina en = new EmpleadoNomina("James", "Gerencia", 20000);
            en.Saludar();
            en.Trabajar();
            Console.WriteLine("Salario ${0}, Cargo: {1}", en.Salario, en.Puesto);

        }
    }
}
