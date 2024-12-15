using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._23_Temperatura
{
    internal class Program
    {
        /*
         * El numero emitido de sonido por un grillo en un minuto  es una función 
         * de la temperatura con el resultado de esos es posible determinar la 
         * temperatura haciendo uso del grillito el programa debe imprimir cunado no hay grillos.
         */
        static void Main(string[] args)
        {
            int NG, T;
            Console.WriteLine("Cuantos sonidos emitio el grillo");
            NG = int.Parse(Console.ReadLine());

            if (NG <= 0)
            {
                Console.WriteLine("No hay grillos");
            }
            else
            {
                T = (NG / 4) + 40;
                Console.WriteLine("La temperatura es:"+T);
            }
            Console.ReadLine();
        }
    }
}
