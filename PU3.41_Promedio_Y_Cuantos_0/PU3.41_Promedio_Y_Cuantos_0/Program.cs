using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PU3._41_Promedio_Y_Cuantos_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0, ceros = 0, numero, j=0;
            float promedio = 0,promediot = 0,positivos=0,total = 0;
            Console.WriteLine("Escribe N");
            N=int.Parse(Console.ReadLine());
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

                if (i == N)
                {
                    promedio = (float)(positivos / j);
                    promediot = (float)(total / N);
                }
                if (numero == 0)
                {
                    ceros++;
                }
            }
            Console.WriteLine("El promedio total de todos los numeros de " + N + " es: " + promediot);
            Console.WriteLine("El promedio de todos los positivos de los numeros: " + N + " es: " + promedio);
            Console.WriteLine("El numero de ceros de todos los numeros de " + N + " es: " + ceros); 
            Console.ReadLine();
        }
    }
}
