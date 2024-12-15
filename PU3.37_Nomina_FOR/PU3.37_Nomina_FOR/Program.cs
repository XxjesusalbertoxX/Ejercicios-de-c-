using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._37_Nomina_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float suma = 0, sueldo = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Proporciona sueldo: "+(i+1));
                sueldo=float.Parse(Console.ReadLine());

                suma +=  sueldo;
            }
            Console.WriteLine("la nomina total es: " + suma);
            Console.ReadLine();
        }
    }
}
