using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._26_Descuentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float monto, Descuento;
            Console.WriteLine("Escribe el monto de la compra");
            monto=float.Parse(Console.ReadLine());

            if (monto <= 500)
            {
                Console.WriteLine("No hay descuento");
            }
            else
            {
                if (monto <=1000)
                {
                    Descuento = monto * (float)0.05;
                    monto -= Descuento;
                    Console.WriteLine("Recibio un descuento del 5% en su compra el cual fue de " + Descuento + ", el total seria: " + monto);
                }
                else
                {
                    if (monto <= 7000)
                    {
                        Descuento = monto * (float)0.07;
                        monto -= Descuento;
                        Console.WriteLine("Recibio un descuento del 7% en su compra el cual fue de " + Descuento + ", el total seria: " + monto);
                    }
                    else
                    {
                        if (monto <= 15000)
                        {
                            Descuento = monto * (float)0.18;
                            monto -= Descuento;
                            Console.WriteLine("Recibio un descuento del 18% en su compra el cual fue de " + Descuento + ", el total seria: " + monto);
                        }
                        else
                        {
                            Descuento = monto * (float)0.25;
                            monto -= Descuento;
                            Console.WriteLine("Recibio un descuento del 25% en su compra el cual fue de " + Descuento + ", el total seria: " + monto);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
