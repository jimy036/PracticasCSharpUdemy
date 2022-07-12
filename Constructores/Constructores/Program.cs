using System;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria("000001"); //Creamos un nuevo objeto, luego que decimos new se crea un
                                                                   //constructor por default que se genera en la clase usada
                                                                   //solo si no se ha generado ningún constructor manualmente.

            CuentaBancaria cuenta2 = new CuentaBancaria("0000002", "Jhon Doe");
            CuentaBancaria cuenta3 = new CuentaBancaria("0000004", "David Jons", 9000);
            CuentaBancaria cuenta4 = new CuentaBancaria();

            cuenta4.NoCuenta = "0000005";
            cuenta4.Usuario = "Alex Paterson";
            cuenta4.Saldo = 20000;

            cuenta1.MostrarInfo();
            Console.WriteLine("");
            cuenta2.MostrarInfo();
            Console.WriteLine();
            cuenta3.MostrarInfo();
            Console.WriteLine();
            cuenta4.MostrarInfo();
            cuenta4.Retirar(20);
            cuenta4.Depositar(100);
            cuenta3.Retirar(10000);

            Console.WriteLine();
            //metodo toString:
            Console.WriteLine(cuenta4.ToString());
            Console.WriteLine(cuenta4);  //También se puede llamar al método de fórma implícita como en este ejmplo.


        }

        //método:
       

    }
}
