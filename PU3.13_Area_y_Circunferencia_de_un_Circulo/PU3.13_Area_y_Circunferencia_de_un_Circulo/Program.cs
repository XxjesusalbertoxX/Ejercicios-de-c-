using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PU3._13_Area_y_Circunferencia_de_un_Circulo
{
    internal class Program
    {
        /*
         * Construye un diagrama de flujo tal quedado 
         * el radio de un circulo, calcule el área y 
         * la circunferencia del circulo.
         */
        static void Main(string[] args)
        {
            float Radio, Area, Circunferencia;
            Console.WriteLine("Introduce el radio del circulo:");
            Radio=float.Parse(Console.ReadLine());

            Area = (float)(Math.PI * (Math.Pow(Radio, 2)));
            Circunferencia = (float)(2 * Math.PI * Radio);

            Console.WriteLine("El radio del circulo que proporcionaste es: " + Radio+"cm.");
            Console.WriteLine("El área del circulo es: " + Area + "cm².");
            Console.WriteLine("La circunferencia del circulo es: " + Circunferencia+"cm.");
            Console.ReadKey();
        }
    }
}

