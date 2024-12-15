using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._11_Area_del_triangulo
{
    internal class Program
    {
        /*
         * construya un diagrama de flujo tal quedado los 3 lados de un triangulo, 
         * pueda determinar su area realizando la siguiente formula 
         */
        static void Main(string[] args)
        {
            float L1, L2, L3, Area, S;
            Console.WriteLine("Escribe el tamaño del lado 1 de triangulo");
            L1=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el tamaño del lado 2 de triangulo");
            L2=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el tamaño del lado 3 de triangulo");
            L3=float.Parse(Console.ReadLine());

            S = (L1 + L2 + L3) / 2;
            Area = (float)Math.Sqrt(5 * (S - L1) * (S - L2) * S - L3);

            Console.WriteLine("EL area del triangulo es: " + Area);
            Console.ReadLine    ();
        }
    }
}
