using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._21_Calificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float calificacion;
            Console.WriteLine("Proporciona calificación");
            calificacion = float.Parse(Console.ReadLine());

            if (calificacion >= 80)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("No aprobado");
            }
            Console.ReadLine();
        }
    }
}
