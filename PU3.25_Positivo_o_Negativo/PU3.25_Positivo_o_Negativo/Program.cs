using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PU3._25_Positivo_o_Negativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0;

            Console.WriteLine("Escribe un numero entero");
            Numero = Convert.ToInt32(Console.ReadLine());

            if (Numero == 0)
            {
                Console.WriteLine("es nulo");
            }
            else
            {
                if (Numero > 0)
                {
                    Console.WriteLine("El numero es positivo");
                }
                else
                {
                    Console.WriteLine("El numero es negativo");
                }
            }
            Console.ReadLine();
        }
    }
}
