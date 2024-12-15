using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._16_Grillo_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ng, temp;
            Console.WriteLine("Escribe el numero de grillares que hace un grillo");
            ng=float.Parse(Console.ReadLine());

            temp = ng / 4 + 40;

            Console.WriteLine("La temperatura del ambiente es: " + temp);
            Console.ReadLine();
        }
    }
}
