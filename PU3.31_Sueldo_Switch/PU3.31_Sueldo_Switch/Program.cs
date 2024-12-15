using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._31_Sueldo_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cat;
            float sueldo, total=0;

            Console.WriteLine("Escribe la categoria del trabajador");
            cat = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el sueldo del trabajado");
            sueldo = int.Parse(Console.ReadLine());

            switch (cat)
            {
                case 1:
                    total= (float)(sueldo*1.15); 
                    break;
                case 2:
                    total = (float)(sueldo * 1.10);
                    break;
                case 3:
                    total = (float)(sueldo * 1.08);
                    break;
                case 4:
                    total = (float)(sueldo * 1.07);
                    break;
                default: 
                    Console.WriteLine("Opcion no valida"); 
                    break;
            }
            Console.WriteLine("La categoria del trabajador es: " + cat + " El total del sueldo es: " + total);
            Console.ReadLine();
        }
    }
}
