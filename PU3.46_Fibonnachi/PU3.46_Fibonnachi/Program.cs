using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._46_Fibonnachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el número de términos: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[numero];

            fibonacci[0] = 0;
            if (numero > 1)
            {
                fibonacci[1] = 1;
                for (int i = 2; i < numero; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            Console.WriteLine("Los primeros " + numero + " términos de la secuencia de Fibonacci son:");
            for (int i = 0; i < numero; i++)
            {
                Console.Write(fibonacci[i]+ " ");

            }
            Console.ReadKey();

        }
    }
}
