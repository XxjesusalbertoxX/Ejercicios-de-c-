using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._42_Suma_de_Gastos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sumagastos = 0, g;

            Console.WriteLine("Monto del gasto");
            g = float.Parse(Console.ReadLine());

            while (g > 0)
            {
                sumagastos = sumagastos + g;
                Console.WriteLine("Monto del gasto");
                g = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("El total de gastos fue: " + sumagastos);
            Console.ReadKey();
        }
    }
}
