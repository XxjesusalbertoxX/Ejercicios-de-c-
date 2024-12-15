using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._27_Impuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Monto;
            float Preciototal;

            Console.WriteLine("Escribe el monto a pagar ");
            Monto = int.Parse(Console.ReadLine());
            if (Monto <= 20)
            {
                Console.WriteLine("Sin IVA");
            }
            else
            {
                if (Monto <=40)
                {
                    Preciototal = (float)(Monto * 1.30);
                    Console.WriteLine("El precio total con iva es de: "+Preciototal);
                }
                else
                {
                    if(Monto <=500)
                    {
                        Preciototal = (float)(Monto * 1.40);
                        Console.WriteLine("El precio total con iva es de: " + Preciototal);
                    }
                    else
                    {
                        Preciototal = (float)(Monto * 1.50);
                        Console.WriteLine("El precio total con iva es de: " + Preciototal);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
