using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._39_Promedio_de_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int impa=0, par=0;
            int j = 0;
            for (int i=1; i<=10;i++)
            {
                Console.WriteLine("Escribe el numero");
                int numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    par = numero;
                }
                else
                {
                    int r = numero % 2;
                    if (r == 0)
                    {
                        par = par + numero;
                        j++;

                    }
                    else
                    {
                        impa += numero;

                    }


                }
            }
            Console.WriteLine($"El promedio de los pares es de: {par/j} y los impares son: {impa}");
            Console.ReadLine();
        }
    }
}
