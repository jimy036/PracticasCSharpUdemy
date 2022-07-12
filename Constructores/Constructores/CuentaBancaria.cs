using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class CuentaBancaria
    {
        //Propiedades
        //Existen dos tipos de propiedades automáticas (Auto properties) y propiedades completas (full properties)
        //Las propiedades automáticas significan que podemos utilizar para leer y escribir datos en ellas dierctamente.
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        //Las full properties sierve para definir cierto tipo de validación para nuestras propiedades, por ejemplo
        //en la siguiente propiedad si no quiero que se ingresen valores negativos le puedo indicar que no permita
        //este tipo de valor.
        //para lograr esto primero debemos crear una variable donde podamos guardar el valor de esa propiedad.
        //A esto se le llama Backing field.
        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                //if(value < 0)
                //{
                //    _saldo = 0;
                //}
                //else
                //{
                //    _saldo = value;
                //}

                //El códico anterior se puede reemplazar con el siguiente reuciendo la sintaxis del mismo:
                _saldo = value < 0 ? 0 : value;

            }
        }
        



        //Por defecto se crea un constructor vacío, que sería CuentaBancaria();, pero podemos crear los que queramos manualmente.
        //Constructores:
        #region Construtores
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }
         //Y podemos crear cuantos constructores queramos, hasta ahora solo tenemos uno con el numero de cuenta

        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta) //Acá llamamos el constructor anterior para evitar repetir código
        {
            Usuario = usuario;
        }        
        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : this(noCuenta, usuario)
        {
            Saldo = saldo;
        }

        public CuentaBancaria() { } //Constructor vacío.
        #endregion

        //metodos
        #region Metodos
        public void MostrarInfo()
        {
            Console.WriteLine("Número de cuenta: {0}, Usuario: {1}, Saldo: {2}", NoCuenta, Usuario, Saldo);
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Hola {0}, la cantidad a retirar es mayor a su saldo: ${1}.",Usuario, Saldo);
                Console.WriteLine("Intente de nuevo con una cantidad menor");

            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine("Su nuevo saldo es ${0}", Saldo);
            }
        }

        public void Depositar(decimal cantidad)
        {
            Saldo +=cantidad;
            Console.WriteLine("Su nuevo saldo es ${0}", Saldo);

        }

        //Hablando de métodos, haremos un metodo que sirve para convertir un objeto en una cadena y así
        //mostrarlo más fácil en consola.
        //Este método se llama ToString:

        public override string ToString()
        {
            return String.Format("NoCuenta: {0}, Usuario: {1}, Saldo ${2}", NoCuenta, Usuario, Saldo);
        }

        #endregion

    }
}
