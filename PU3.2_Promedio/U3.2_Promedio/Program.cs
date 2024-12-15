using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._2_Promedio
{
    internal class Program
    {
        /*
         * Construye un diagrama de flujo dada la calificacion de S datos, obtenga el promediod
         */
        static void Main(string[] args)
        {
            float c1, c2, c3, c4, c5, promedio;
            Console.WriteLine("Introduce las calificaciones de la primera materia");
            c1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce las calificaciones de la segunda materia");
            c2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce las calificaciones de la tercera materia");
            c3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce las calificaciones de la cuarta materia");
            c4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce las calificaciones de la quinta materia");
            c5 = float.Parse(Console.ReadLine());

            promedio = (c1 + c2 + c3 + c4 + c5) / 5;
            Console.WriteLine("El promedio de las calificaciones es: " + promedio);
            Console.ReadLine();
        }
    }
}
