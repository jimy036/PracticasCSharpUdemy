using System;


namespace IteracionesArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 5, 6, 7, 8, 9, 10, 11, 12, 5, -4, 0, 21 };

            Console.WriteLine("Iterar arreglo con ciclo for");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("{0} ", arreglo[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Iterar arreglo con ciclo for each ");

            foreach (int num in arreglo)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine("Ahora para permitiremos que el usuario puede escoger su propio tamaño de arreglo");
            Console.Write("Ingrese el tamaño del arreglo: ");
            int arregloScan = Convert.ToInt32(Console.ReadLine());

            int [] numeros = new int[arregloScan];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escribe el número del índice: {0}", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Console.WriteLine("los números ingresados fueron: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("{0} ",numeros[i]);
            }*/

            Console.WriteLine("Sus datos son: ");
            MostrarArreglo(numeros);

            //CLASE ARRAY Y SUS MÉTODOS:

            int[] listArreglo = { 8, 24, 4, 3, 15, 78, 10, 22 };
            int[] arregloTemp = new int [listArreglo.Length]; //Con esto creamos una copia exacta del arreglo anterior
            Console.WriteLine("\n");
            Console.WriteLine("Arreglo original: ");
            MostrarArreglo(listArreglo);

            Array.Copy(listArreglo, arregloTemp, arregloTemp.Length); //Para copiar el contenido de otro arreglo.
            Console.WriteLine("\nArreglo copia: ");
            MostrarArreglo(arregloTemp);

            Console.WriteLine("\nInvertir el orden del arreglo");
            Array.Reverse(arregloTemp);                             //Con este método se invierte el arreglo.
            MostrarArreglo (arregloTemp);

            Console.WriteLine("\nOrdenar un arreglo de menor a mayor");
            Array.Sort(arregloTemp);
            MostrarArreglo(arregloTemp);
            Console.WriteLine("\nEl mismo pero de mayor a menor");
            Array.Reverse(arregloTemp); //esta sería una forma de ordenar de mayor a menor, pero hay otra forma que es
                                        //con el método comparate y comparison.
            MostrarArreglo(arregloTemp);

            //haremos lo mismo pero con otro metodo

            Console.WriteLine("\nLo mismo pero con el método ComparateTo");
            Comparison<int> compararNum = new Comparison<int>((num1, num2) => num2.CompareTo(num1)); //Se puede ordenar de forma
                                                                                                     //ascendente comparando
                                                                                                     //num1 con num2.
            Array.Sort<int>(listArreglo, compararNum);
            MostrarArreglo(listArreglo);
        }

        static void MostrarArreglo(int [] arreglo) //para evitar estar copiando el ciclo for para mostar
                                                   //arreglos, creamos un método que lo haga siempre, y
                                                   //como vamos a interactuar con el método estático main
                                                   //este también debe ser estático.
        {
            foreach (int i in arreglo)
            {
                Console.Write("{0} ", i);
            }
        }

    }
}
