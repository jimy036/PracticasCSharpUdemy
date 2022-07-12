using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Empleado : Persona
    {
        public string Puesto { get; set; }
        public decimal Suledo { get; set; }

        public Empleado(string name, int age, string puesto, decimal sueldo) : base(name, age)
        {
            Puesto = puesto;
            Suledo = sueldo;
        }

        public override void Saludar()
        {
            Console.WriteLine("hola soy {0} y mi puesto es {1}", Name, Puesto);
        }

        public void Trabajar()
        {
            Console.WriteLine("{0} está trabajando...", Name);
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} años, {2}, sueldo: ${3}", Name, Age, Puesto, Suledo);
        }
    }
}
