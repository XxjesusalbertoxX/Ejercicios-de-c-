using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._43_Imprime_Cubos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int np;
            double c;

            Console.WriteLine("Proporcione un numero");
            np = int.Parse(Console.ReadLine());

            while (np > 0)
            {
                c = Math.Pow(np, 3);
                Console.WriteLine("El resultado del cubo es: " + c);
                Console.WriteLine("Proporcione un numero");
                np = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
