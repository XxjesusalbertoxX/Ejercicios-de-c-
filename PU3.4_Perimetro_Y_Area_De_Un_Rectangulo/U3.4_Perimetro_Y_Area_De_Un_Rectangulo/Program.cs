using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._4_Perimetro_Y_Area_De_Un_Rectangulo
{
    internal class Program
    {
        /*
         * Construya un diagrama de flujo tal quedado los datos, 
         * la base y la altura de un rectangulo calule e imprima el perimetro y area de la figura
         */
        static void Main(string[] args)
        {
            float A, B, Pe, Ar;
            Console.WriteLine("Escribe la base del rectangulo");
            B=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la altura del rectangulo");
            A = float.Parse(Console.ReadLine());

            Pe = 2*B+2*A;
            Ar = B * A;

            Console.WriteLine("El area del rectangulo es: "+Ar);
            Console.WriteLine("El perimetro del rectangulo es: " + Pe);
            Console.ReadKey();
        }
    }
}
