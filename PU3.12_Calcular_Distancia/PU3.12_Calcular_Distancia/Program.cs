using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._12_Calcular_Distancia
{
    internal class Program
    {
        /*
         * Construye un diagrama de flujo que calcule 
         * la distancia entre 2 puntos dado como datos 
         * las coordenadas de los puntos P1 y P2.
         */

        static void Main(string[] args)
        {
            float X1, Y1, X2, Y2, distancia;

            Console.WriteLine("Escribe las coordenadas de X1");
            X1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe las coordenadas de Y1");
            Y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe las coordenadas de X2");
            X2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe las coordenadas de Y2");
            Y2 = float.Parse(Console.ReadLine());

            distancia = (float)((Math.Pow(X1 - X2, 2)) + (Math.Pow(Y1 - Y2, 2)));
            distancia = (float)(Math.Sqrt(distancia));

            Console.WriteLine("La distancia entre los 2 puntos P1 y P2 es de: "+distancia);
            Console.ReadKey();
        }
    }
}
