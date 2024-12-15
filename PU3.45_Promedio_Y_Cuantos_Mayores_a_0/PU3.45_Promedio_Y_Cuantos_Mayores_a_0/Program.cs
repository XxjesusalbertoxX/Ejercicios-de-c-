using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._45_Promedio_Y_Cuantos_Mayores_a_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, numero, j = 0;
            float positivos = 0, total = 0;
            Console.WriteLine("Escribe N");
            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Proporciona un numero");
                numero = int.Parse(Console.ReadLine());
                total += numero;


                if (numero > 0)
                {

                    positivos += numero;

                    j++;

                }
            }
            Console.WriteLine("El promedio total de todos los numeros de " + N + $" es: {total/N}");
            Console.WriteLine("El promedio de todos los positivos de los numeros: " + N + $" es: {positivos / j}");
            Console.WriteLine("los numero mayores a cero de todos los numeros de " + N + " es: " + j);
            Console.ReadLine();
        }
    }
}
