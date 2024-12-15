using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace U3._10_Numero_De_Segundo
{
    internal class Program
    {
        /*
         * Construye un diagrama de flujo que calcule e imprima 
         * el numero de segundos que hay en un determinado numero de días y segundos
         */
        static void Main(string[] args)
        {
            int Ndias = 0, segundos = 0;
            Console.WriteLine("Escirbe el numero de días que quieras calcuar los segundos de esos dias");
            Ndias = Convert.ToInt32(Console.ReadLine());
            
            segundos = 60*60*24*Ndias;

            Console.WriteLine("Los segundos que tienen los "+ Ndias +" son de: "+segundos);
            Console.ReadLine();

        }
    }
}
