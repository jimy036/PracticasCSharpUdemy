using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjet
{
    internal class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Persona(string name, int age)
        {
            Name = name;
            Age = age;  
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Persona p = obj as Persona;
            if (p == null)
            {
                return false;
            }

            return Name == p.Name && Age == p.Age;
        }

        public override int GetHashCode()
        {
            int hash = 1;
            hash = 31 * hash + Name.GetHashCode();
            hash = 31 * hash + Age;
            return hash;

        }

    }
}
