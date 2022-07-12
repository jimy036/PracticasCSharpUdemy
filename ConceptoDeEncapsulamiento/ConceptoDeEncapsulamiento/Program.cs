using System;

using ModificadorAcceso; //Acá se debe llamar al Namespace para poder instanciar los objetos.

/*ENCAPSULAMIENTO
 *Es un mecanismo para ocultar datos.
 *Los datos de una clase sólo son accesibles a través de las propiedades y métodos designados.
 *Grantiza la integridad de los datos que contiene un objeto (que funcione correctamente el programa).
 *
 *Estos se garantiza con los NIVELES DE ACCESO
 *
 **public: todos pueden acceder
 **internal: todos deltro del mismo ensamblado pueden acceder.
 **protected: todas las subclases pueden accerder
 **private: solo la clase actual puede acceder
 */
/*El NAMESPACE: Es un contenedor de tipos de datos, es decir de clases
 * 
 * 
 */

namespace MiNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("dentro de Mi namespace");
        }
    }
     
}namespace OtraNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("dentro de otra namespace");
        }
    }
     
}

namespace ConceptoDeEncapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creando objetos de clases contenidas en otros namespaces

            MiNamespace.Clase1 nombreObject = new MiNamespace.Clase1();
            OtraNamespace.Clase1 otroObject = new OtraNamespace.Clase1();  

            nombreObject.Metodo();
            otroObject.Metodo();

            Class1 obj1 = new Class1();

            obj1.MetodoPublico(); //sí permite ser llamado desde esta otra clase.
            obj1.MetodoInternal(); //También permite
            //obj1.MetodoPrivate();  este no permite ser llamado
            //obj1.MetodoProtected(); Tampoco lo permite.



        }
    }
}
