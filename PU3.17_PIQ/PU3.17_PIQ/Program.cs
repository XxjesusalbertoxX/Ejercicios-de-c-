using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._17_PIQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float P, Q, resultado;
            Console.WriteLine("Escribe el valor de Q");
            Q=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el valor de P");
            P = float.Parse(Console.ReadLine());

            resultado = (float)(Math.Pow(P,3)+Math.Pow(Q,4)-2*Math.Pow(P,2));
            if(resultado < 680)
            {
                Console.WriteLine("Es correcto");
            }
            else
            {
                Console.WriteLine("Es incorrecto");
            }
            Console.ReadLine();
        }
    }
}
