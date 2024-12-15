using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._18_Formula_General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, x1, x2,ecua;
            Console.WriteLine("Escribe el valor de A");
            a=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el valor de B");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el valor de C");
            c = float.Parse(Console.ReadLine());

            ecua = (float)(Math.Sqrt(Math.Pow(b, 2) - 4 * a * c));
            ecua = (float)(Math.Sqrt(Math.Pow(b, 2) - 4 * a * c));

            if(ecua <= 0)
            {
                Console.WriteLine("No es posible seguir con la operacion por que su valor esta expresado en numeros imaginarios");
            }
            else
            {
                x2 = (float)(-(b) - ecua) / (2 * a);
                x1 = (float)(-(b) + ecua) / (2 * a);
                Console.WriteLine("El valor de X1 es: " + x1);
                Console.WriteLine("El valor de X2 es: " + x2);
            }

            Console.ReadLine();
        }
    }
}
