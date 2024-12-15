using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Valor de c: ");
            double c = double.Parse(Console.ReadLine());

            M3(a, b, c);
            Console.WriteLine($"El reultado es {M4(a, b, c)}");
            M1();
            Console.WriteLine($"{M2()}");

            Console.ReadLine();

        }

        //Metodo sin regresar valor sin parametros
        static void M1()
        {
            double a, b, c, r;
            Console.WriteLine("Escriba el valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());
            r = (Math.Pow(a + b, 2) / (2 * c)) + (Math.Pow(a, 2) / b);
            Console.WriteLine($"Resultado1: {r}");
        }
        //Metodo regresando valor sin parametros
        static double M2()
        {
            double a, b, c, r;
            Console.WriteLine("Escriba el valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());
            r = (Math.Pow(a + b, 2) / (2 * c)) + (Math.Pow(a, 2) / b);
            Console.WriteLine($"Resultado1: {r}");
            return r;
        }
        //Metodo sin regresar valor con parametros
        static void M3(double a, double b, double c)
        {
            double r = (Math.Pow(a + b, 2) / (2 * c)) + (Math.Pow(a, 2) / b);
            Console.WriteLine($"Resultado3: {r}");

        }
        //Metodo regresando valor con parametros
        static double M4(double a, double b, double c)
        {
            double R = (Math.Pow(a + b, 2) / (2 * c)) + (Math.Pow(a, 2) / b);
            return R;
        }

    

    }
}
    

