using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PU3._33_Horas_Extras_Switch
{
    internal class Program
    {
        /*
         * Construye un diagrama de flujo que permita calcular lo que hay que pagarle a 
         * un trabajador teniendo en cuenta su sueldo y las horas extras
         */
        static void Main(string[] args)
        {
            int categoria, horas;
            float sueldo, sueldototal = 0;
            Console.WriteLine("Escribe el sueldo del empleado");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe cuantas horas extras trabajo");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe a que categoría pertenece el empleado");
            categoria = int.Parse(Console.ReadLine());

            if (horas > 30)
            {
                horas = 30;
            }
            switch (categoria)
            {
                case 1:
                    sueldototal = sueldo + horas * 30; break;
                case 2:
                    sueldototal = sueldo + horas * 38; break;
                case 3:
                    sueldototal = sueldo + horas * 50; break;
                case 4:
                    sueldototal = sueldo + horas * 38; break;
                default:
                    Console.WriteLine("Sin paga extra, su sueldo es de: "+sueldo+"$"); break;
            }
            if (categoria <= 4 && categoria >= 1)
            {
                Console.WriteLine("Su sueldo es de: " + sueldo + "$ + las horas extras (Máximo 30) fueron en total: " + sueldototal+"$");
            }
            Console.ReadLine();
        }
    }
}
