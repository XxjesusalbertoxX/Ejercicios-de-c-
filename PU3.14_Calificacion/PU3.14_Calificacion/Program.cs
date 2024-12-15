using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._14_Calificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float calificacion;

            Console.WriteLine("Escribe la calificacion total");
            calificacion=float.Parse(Console.ReadLine());
            
            if(calificacion >= 8)
            {
                Console.WriteLine("El alumno esta aprobado");
            }
            Console.ReadLine();
        }
    }
}
