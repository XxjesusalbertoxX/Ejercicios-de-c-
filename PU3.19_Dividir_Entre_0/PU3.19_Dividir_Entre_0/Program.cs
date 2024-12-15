using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PU3._19_Dividir_Entre_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, resultado;
            Console.WriteLine("Escribe el valor que quieres dividir");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe a que valor quieres dividir el numero anterior");
            b = float.Parse(Console.ReadLine());

            if (b <= 0)
            {
                Console.WriteLine("No se puede dividir entre o menor a cero");
            }
            else
            {
                resultado = a / b;
                Console.WriteLine("El resultado de la división es: " + resultado);
            }
            Console.ReadLine();
        }
    }
}
