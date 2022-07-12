using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public int Grado { get; set; }
        public string Universidad { get; set; }

        public Estudiante(string name, int age, string carrera, int grado, string universidad) : base(name,age)
        {
            Carrera = carrera;
            Grado = grado;
            Universidad = universidad;
        }

        public void Estudiar()
        {
            Console.WriteLine("Estudiando mucho...");
        }

        public void IrAClase()
        {
            Console.WriteLine("Mi clase es de {0}", Grado);
        }

        public override void Saludar()
        {
            base.Saludar();
            Console.WriteLine("Hola soy {0} estudiante de la universidad {1}, tengo " +
                "{2} años y estoy en el {3} semestre", Name, Universidad, Age, Grado);
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}, Edad: {1}, Carrera: {2}, " +
                "Grado: {3}, Universidad: {4}", Name, Age, Carrera, Grado, Universidad);
        }
    }
}
