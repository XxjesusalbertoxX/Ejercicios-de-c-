using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._44_Aumento_de_Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float aumento = 0, sueldo = 1;
            while (sueldo!=0)
            {
                Console.WriteLine("Escribe el sueldo del trabajador");
                sueldo=int.Parse(Console.ReadLine());
                if (sueldo < 1000)
                {
                    Console.WriteLine($"El aumento es: {aumento = sueldo*(float)1.15 }");
                }
                else
                {
                    Console.WriteLine($"El aumento es: {aumento = sueldo * (float)1.12}");
                    
                }
            }

            

        }
    }
}
