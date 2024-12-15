using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._35_Internos_Switch
{
    internal class Program
    {
        /*
         * Con el objeto de hacer un aproximación de los costos de 
         * internación por pacientes, se obtuvo un costo promedio 
         * diario según el tipo de enfermedad que aqueja al paciente:
         */
        static void Main(string[] args)
        {
            int catenfermedad, edad, dias;
            float costototal = 0;

            Console.WriteLine("Escribe La edad del paciente");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la categoría de la enfermedad");
            catenfermedad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe cuantos días estará internado ");
            dias = int.Parse(Console.ReadLine());


            switch (catenfermedad)
            {
                case 1:
                    costototal = dias * 25; break;
                case 2:
                    costototal = dias * 16; break;
                case 3:
                    costototal = dias * 20; break;
                case 4:
                    costototal = dias * 32; break;
                default:
                    Console.WriteLine("Categoria de enfermedad erronea");
                    break;
            }
            if (edad > 15 || edad < 23)
            {
                costototal *= (float)1.10;
            }
            Console.WriteLine("El costo diario de la enfermedad categoria " +
                catenfermedad + " es de: " + costototal + "$");
            Console.ReadLine();
        }
    }
}
