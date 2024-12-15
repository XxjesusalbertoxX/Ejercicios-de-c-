using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._38_Obtener_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, ceros = 0;
            float numero;
            bool w = true;
            
                Console.WriteLine("Escribe un numero entero");
                n=int.Parse(Console.ReadLine());
            
                for(int i = 0; i < n; i++)
                {
                     Console.WriteLine("Proporciona un numero");
                     numero = float.Parse(Console.ReadLine());
                     if(numero == 0)
                     {
                          ceros++;
                     }
                }


            Console.Write($"El numero de ceros total es de:{ceros}");
            Console.ReadLine();
        }
    }
}
