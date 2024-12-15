using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._29_Descuento_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float monto, descuento;
            Console.WriteLine("Escribe el monto al que se le hara el descuento");
            monto=float.Parse(Console.ReadLine());
            if( monto <= 500 )
            {
                Console.WriteLine("No hay descuento");
            }
            else
            {
                if ( monto >= 700 || 1000 >= monto)
                {
                    descuento= monto*(float)0.07;
                    monto -= descuento;
                }
                else
                {
                    if (monto > 1000 || 9000 >= monto)
                    {
                        descuento=monto*(float)0.12;
                        monto -= descuento;
                    }
                    else
                    {
                        descuento=monto* (float)0.30;
                        monto -= descuento;
                    }
                }
            }
            Console.WriteLine("El monto con el descuento es de "+monto);
            Console.ReadLine();
        }
    }
}
