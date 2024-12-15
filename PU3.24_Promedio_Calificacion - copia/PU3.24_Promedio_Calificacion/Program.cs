using System;
using System.Timers;


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
            float[] a = new float[5];
            string[] nombres = new string[5];
            float promedio;
            string[] Resultado = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escribe el nombre del alumno");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("Escribe la caliicación de matemáticas");
                a[0] = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación de historia");
                a[1] = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación de geografía");
                a[2] = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación de educación física");
                a[3] = float.Parse(Console.ReadLine());
                Console.WriteLine("Escribe la calificación de ingles");
                a[4] = float.Parse(Console.ReadLine());

                promedio = (a[0] + a[1] + a[2] + a[3] + a[4]) / 5;

                if (promedio < 8)
                {

                    Resultado[i] = nombres[i] + " Esta reprobado";
                }
                else
                {
                    Resultado[i] = nombres[i] + " Esta aprobado";
                }
                if(i== 4)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(Resultado[j]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
