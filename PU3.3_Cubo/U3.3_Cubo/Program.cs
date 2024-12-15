using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._3_Cubo
{
    internal class Program
    {
        /*
         * Escribe un diagrama de flujo que permita 
         * calcular e imprimir el cuadrado y el cubo de un entero positivo.
         */
        static void Main(string[] args)
        {
            float entero,cubo,cuadrado;
            Console.WriteLine("Escribe el entero que quieres elevar el cubo");
            entero = float.Parse(Console.ReadLine());
            cubo = (float)Math.Pow(entero,3);
            cuadrado = (float)Math.Pow(entero,2);

            Console.WriteLine("Resultado es: " + cuadrado);
            Console.WriteLine("El resutado del cubo es :"+ cubo);
            Console.ReadLine();
        }
    }
}
