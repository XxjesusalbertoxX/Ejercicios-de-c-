using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._24_Promedio_Calificacion
{
    internal class Program
    {
        /*
         * Construya un diagrama del flujo tal que dado las 
         * 5 calificaciones de un estudiante, calcular el promedio y si el promedio es mayor a 8.
         */
        static void Main(string[] args)
        {
            float a,b,c,d,f;
            float promedio;
            Console.WriteLine("Escribe la caliicación de matemáticas");
            a=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la calificación de historia");
            b=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la calificación de geografía");
            c=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la calificación de educación física");
            d=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la calificación de ingles");
            f=float.Parse(Console.ReadLine());

            promedio = (a+b+c+d+f)/5;
            if(promedio < 8)
            {
                Console.WriteLine("Estas reprobado");
            }
            else
            {
                Console.WriteLine("Estas aprobado");
            }
            Console.ReadLine();
        }
    }
}
