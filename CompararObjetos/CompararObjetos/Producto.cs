using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararObjetos
{
    internal class Producto : IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo(Producto otro)
        {
            if (this.Precio > otro.Precio) return 1;   // > 0 es mayor al que llegó
            if (this.Precio == otro.Precio) return 0;  // == 0 es igual
            
            return -1;  // < 0 es menor que el producto actual.
        }
    }
}
