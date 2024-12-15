using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._22_Aumento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float aumento, sueldo;
            Console.WriteLine("Escribe el sueldo del trabajador");
            sueldo = float.Parse(Console.ReadLine());

            if (sueldo <= 1000)
            {
                aumento = sueldo * (float)1.15;
                Console.WriteLine("Tu sueldo aumento un 15% mas, tu sueldo actual es: " + aumento + "$");
            }
            else
            {
                aumento = sueldo * (float)1.12;
                Console.WriteLine("Tu sueldo aumento un 12% mas, tu sueldo actual es: " + aumento + "$");
            }
            Console.ReadLine();
        }
    }
}
