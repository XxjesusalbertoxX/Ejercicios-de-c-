using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._5_Cambio_a_Cliente
{
    internal class Program
    {
        /*
         * Construya un diagrama de flujo tal quedado el costo de un articulo vendido y la cantidad de 
         * dinero entregar por el cliente calcule e imprima el cambio que se le debe de entregar.
         */
        static void Main(string[] args)
        {
            float articulo, dinrecibido, Cambio;
            Console.WriteLine("Escribe el precio del articulo");
            articulo=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el dinero recibido");
            dinrecibido=float.Parse(Console.ReadLine());
            
            Cambio = dinrecibido-articulo;
            Console.WriteLine("Su cambio es de :" + Cambio + "$");
            Console.WriteLine("Gracias por su compra!");
            Console.ReadKey();
        }
    }
}
