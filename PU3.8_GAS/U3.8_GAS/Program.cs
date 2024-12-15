using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._8_GAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lt, cosreal, registro;
            Console.WriteLine("Cantidad surtida en galones: ");
            registro = float.Parse(Console.ReadLine());
            lt = registro * (float)3.79;
            cosreal = lt * (float)23.24;

            Console.WriteLine("El precio del total de los galones de gasolina es: " + cosreal);
            Console.ReadLine();
            

        }
    }
}
