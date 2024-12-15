using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            double a = 3.98, b = 4.65, c = 23;
            operacion2();
            operacion2(a,b,c);
        }
        static void operacion2(double numeroa,double numerob,double numeroc)
        {
            double resultado=((Math.Pow(numeroa + numerob, 2)) / (2 * numeroc)) + (Math.Pow(numeroa, 2) / numerob);
            Console.WriteLine(resultado);
        }
        static void operacion2()
        {
            double a=2.23,b=5.65,c=6.4;
            double resultado = ((Math.Pow(a + b, 2)) / (2 * c)) + (Math.Pow(a, 2) / b);
            Console.WriteLine(resultado);
        }
        static double operacion3()
        {
            double a = 2.23, b = 5.65, c = 6.4;
            double resultado = ((Math.Pow(a + b, 2)) / (2 * c)) + (Math.Pow(a, 2) / b);
            return resultado;
        }
        static double operacion3(double numeroa, double numerob, double numeroc)
        {
            return ((Math.Pow(numeroa + numerob, 2)) / (2 * numeroc)) + (Math.Pow(numeroa, 2) / numerob);
            
        }
        */
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.PedirNumeros();
            calculadora.MostrarSuma();
            Console.ReadKey();
        }

    }
}
