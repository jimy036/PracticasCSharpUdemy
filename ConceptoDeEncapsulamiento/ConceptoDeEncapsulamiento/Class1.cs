using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAcceso
{
    class Class1
    {
        public void MetodoPublico() //puede ser visto por cualquier clase.
        {
            Console.WriteLine("Llamando a método público.");
        }

        protected void MetodoProtected() //Puede ser visto desde cualquier clase o
                                         //desde cualquier clase que herede de Class1.
        {
            Console.WriteLine("Llamando a método protected");
        }

        internal void MetodoInternal() //Puede ser visto por cualquier clase dentro del mismo
                                       //assembly (ensamblado).
        {
            Console.WriteLine("Llamando a método internal");
        }

        private void MetodoPrivete() //Puede ser visto solo por esta clase
        {
            Console.WriteLine("Llamando al método private");
        }

    }
}
