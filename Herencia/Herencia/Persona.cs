using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Persona() { }

        public Persona(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Saludar()
        {
            Console.WriteLine("Hola, mi nomnbre es: {0}", Name);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} años", Name, Age);
        }
    }
}
