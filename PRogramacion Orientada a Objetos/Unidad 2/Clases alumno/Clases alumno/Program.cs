using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_alumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matricula,i=1,materias,nalumnos,j=1,h=0;
            string nombre;
            Console.WriteLine("Escribe el cuantos alumnos vas a registrar");
            nalumnos = int.Parse(Console.ReadLine());
            float[] promedio = new float[nalumnos];
            Alumno[] alumno = new Alumno[nalumnos];
            do
            {
                Console.Write($"Escribe el nombre del alumno {i}: ");
                nombre = Console.ReadLine();
                Console.Write($"\nEscribe la matricula del alumno {i} ");
                matricula = int.Parse(Console.ReadLine());
                Console.Write("\nEscribe el numero de materias: ");
                materias = int.Parse(Console.ReadLine());
                alumno[h] = new Alumno(nombre, matricula, materias);
                do
                {

                    Console.WriteLine($"\nEscribe la calificacion de la materia {i++}: ");
                    alumno[h].agregacalif(float.Parse(Console.ReadLine()));
                    
                } while (alumno[h].GetNumeroCalificacion != materias);
                promedio[h] = alumno[h].ObtenerPromedio();
                h++;
                
            } while (h != nalumnos);
            h--;
            int alumnolisto = Array.IndexOf(promedio,promedio.Max());
            Console.WriteLine($"El alumno con el promedio mas alto siendo este de {promedio.Max()} es el alumno con id {alumnolisto}, con el nombre {alumno[alumnolisto].GetNombre}");
            Console.ReadKey();
        }
        static int Incrementar(int x)
        {
            return x + 1;
        }
    }

}
