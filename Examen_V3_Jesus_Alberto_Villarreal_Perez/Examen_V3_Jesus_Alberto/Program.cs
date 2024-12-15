using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_V3_Jesus_Alberto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerodetabla = 0, numerodecomienzo = 0, numerofinaltabla=0, orden;
            Console.WriteLine("Proporciona el numero de la tabla a multiplicar");
            numerodetabla = int.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona el COMIENZO de la tabla");
            numerodecomienzo = int.Parse(Console.ReadLine());
            Console.WriteLine("Proporciona el FIN de la tabla");
            numerofinaltabla = int.Parse(Console.ReadLine());
            Console.WriteLine("Como desea mostrar el orden de tabla:");
            Console.WriteLine("1. Mostrar en orden ASCendente");
            Console.WriteLine("2. Mostrar en orden DESCendente");

            orden = int.Parse(Console.ReadLine());
            
            switch (orden)
            {
                case 1: 
                    for (int i = numerodecomienzo; i <= numerofinaltabla; i++)
                    {
                        Console.WriteLine(numerodetabla + " * " + i + $" = {numerodetabla*i}");
                        
                    }
                    break;
                case 2:
                    for (int i = numerofinaltabla; i >= numerodecomienzo; i++)
                    {
                        Console.WriteLine(numerodetabla + " * " + i + $" = {numerodetabla * i}");

                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
