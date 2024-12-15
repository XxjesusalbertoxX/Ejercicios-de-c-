using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._6_Area_y__Perimetro_Triangulo
{
    internal class Program
    {
        /*
         * Construye un diagrama de flujo tal quedado la base y la altura de un triangulo 
         * equilatero calcule e imprima el area y perimetro de las figuras.
         */
        static void Main(string[] args)
        {
            float Base,Altura,area,perimetro;

            Console.WriteLine("Escribe la base del triangulo");
            Base=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la altura del triangulo");
            Altura=float.Parse(Console.ReadLine());

            area= (Base* Altura)/2;
            perimetro = Base * 3;

            Console.WriteLine("El Area del triangulo es: "+area);
            Console.WriteLine("El Perimetro del triangulo es: "+perimetro);
            Console.ReadKey();
        }
    }
}
