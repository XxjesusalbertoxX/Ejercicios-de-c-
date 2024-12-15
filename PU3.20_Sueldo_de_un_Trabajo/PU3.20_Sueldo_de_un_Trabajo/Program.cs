using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._20_Sueldo_de_un_Trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo, total;
            Console.WriteLine("Escribe el sueldo del empleado");
            sueldo = float.Parse(Console.ReadLine());

            if(sueldo >= 5000)
            {
                total= (float)(sueldo*1.16);
                Console.WriteLine("Su sueldo se le agrego el 16% de iva, su sueldo es de: " + total + "$");
            }
            else
            {
                Console.WriteLine("Su sueldo no se le puede aplicar iva por cauda de ser menor a 5 mil, su sueldo actual es de: " + sueldo + "$");
            }
            Console.ReadLine();
        }
    }
}
