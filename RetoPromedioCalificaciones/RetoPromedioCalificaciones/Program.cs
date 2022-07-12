using System;

class Program
{
    public static void Main(String [] args)
    {
        int columna, fila, alumnos, notas;
        


        Console.WriteLine("PROGRAMA DE CALCULO FINAL NOTAS:\n");
        Console.Write("Ingrese cuántos alumnos va a evaluar: ");
        alumnos = int.Parse(Console.ReadLine());
        fila = alumnos + 1;

        Console.Write("Ingrese cuántas notas va a evaluar: ");
        notas = int.Parse(Console.ReadLine());
        columna = notas + 2;
         
        dynamic[,] dyn = new dynamic[fila,columna];

        Console.WriteLine("longitud x {0}", dyn.GetLength(0)); //Obtenemos el valor de las filas
        Console.WriteLine("longitud y {0}", dyn.GetLength(1));  //Obtenemos el valor de las columnas

        dyn[0, 0] = "Alumno:";
        
        for (int i = 1; i <= notas; i++)
        {
            dyn[0, i] = ("Nota "+i);
            //Console.Write(dyn[0,i]);
        }

        dyn[ 0 , columna-1] = "Nota final";

        

        for (int y = 1; y < fila; y++)
        {
            double nFinal = 0;
            Console.Write("Ingrese el nombre del alumno No: {0}: ", y);

            string name = Console.ReadLine();
            dyn[ y , 0 ] = name;
            for (int x = 1; x < columna-1; x++)
            {
                Console.Write("Ingrese la nota {0}: ", x);
                double note = double.Parse(Console.ReadLine());
                dyn[ y , x ] = note;
                nFinal += note;
            }
            nFinal /= notas;
         
            dyn[y, columna-1] = nFinal;
        }
        Console.WriteLine("\nResultados: ");
        for (int i = 0; i < fila; i++)
        {
            for (int j = 0; j < columna; j++)
            {
                while(i>0 && i<fila && j ==columna-1)
                {
                    if (dyn[i,j] < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (dyn[i, j] >= 6 && dyn[i, j] < 8)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    break;
                }
                Console.Write("{0}\t\t",dyn[i,j]);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
        }
    }
}