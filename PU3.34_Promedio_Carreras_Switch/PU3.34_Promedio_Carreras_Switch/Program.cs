using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._34_Promedio_Carreras_Switch
{
    internal class Program
    {
        /*
         * Dado como datos, matricula del alumno, la carrera en la que esta inscrito, semestre y promedio.
         * Determine si el alumno es apto para alguna de las carreras de la universidad
         */
        static void Main(string[] args)
        {
            int matricula, semestre;
            float promedio;
            string carrera;

            Console.WriteLine("Escribe el la matricula del alumno");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el semestre");
            semestre = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el promedio del alumno");
            promedio = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la carrera a la que deseas entrar");
            carrera=Console.ReadLine();

            switch (carrera)
            {
                case "TICS":
                    if (semestre >= 6||promedio >= 8.8)
                    {
                        Console.WriteLine(matricula + " " + carrera + " Aceptado");
                    }

                    break;
                case "MI":
                    if(semestre >=5 || promedio >= 8)
                    {
                        Console.WriteLine(matricula + " " + carrera + " Aceptado");
                    }
                    break;
                case "Admin":
                    if(semestre > 5 || promedio >= 8.1)
                    {
                        Console.WriteLine(matricula + " " + carrera + " Aceptado");
                    }
                    break;
                case "PI":
                    if(semestre==5||promedio > 8.5)
                    {
                        Console.WriteLine(matricula+ " " + carrera + " Aceptado");
                    }
                    break;
                    default: Console.WriteLine("No es una carrera"); break;
            }
            Console.ReadLine();
        }
    }
}
