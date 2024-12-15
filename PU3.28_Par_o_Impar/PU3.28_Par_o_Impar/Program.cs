using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._28_Par_o_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float N,R;

            Console.WriteLine("Escribe un numero entero para validar si es par o impar");
            N=float.Parse(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("El numero es nulo");
            }
            else
            {
                R = N % 2;

                if (R== 0)
                {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }
            }
            Console.ReadLine();
        }
    }
}
