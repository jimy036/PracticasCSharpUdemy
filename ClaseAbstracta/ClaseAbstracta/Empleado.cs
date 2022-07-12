using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    abstract class Empleado
    {
        //propiedades:
        public string Name { get; set; }
        public string Puesto { get; set; }
        public abstract decimal Salario { get;  }

        public Empleado(string name, string puesto)
        {
            Name = name;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola {0}", Name);
        }

        public abstract void Trabajar();

    }
}
