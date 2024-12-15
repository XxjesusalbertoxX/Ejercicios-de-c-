using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PU3._15_Sueldo_Aumento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo, nuevosueldo;
            Console.WriteLine("Escribe el sueldo del trabajador");
            sueldo=float.Parse(Console.ReadLine());
            if(sueldo < 1000)
            {
                nuevosueldo = (float)(sueldo * 1.15);
                Console.WriteLine("El nuevo sueldo es: "+nuevosueldo);
            }
            
            Console.ReadLine();
        }
    }
}
