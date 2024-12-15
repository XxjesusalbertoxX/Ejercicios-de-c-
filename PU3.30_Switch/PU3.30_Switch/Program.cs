using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._30_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            double val = 0, v;

            Console.WriteLine("Proporciona un valor(V)");
            v=double.Parse(Console.ReadLine());

            Console.WriteLine("Proporciona una opción");
            num=int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    val = 100 * v;
                    break;
                case 2:
                    val=Math.Pow(100, v);
                    break;
                case 3:
                    val=100/v;
                    break;
                case 4:
                    val = 0;
                    break;
                default:
                    Console.WriteLine("Ninguna de las opciones de las que tecleaste es correcta");
                    break;
            }
            Console.WriteLine("El resultado es: " + val);
            Console.ReadLine();
        }
    }
}
