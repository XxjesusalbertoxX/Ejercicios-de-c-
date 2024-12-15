using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //clase sobrecargada sin argumentos
            Pitagoras triangulo = new Pitagoras();
            Console.WriteLine(triangulo.Tipodetriangulo());
            Console.ReadKey();


            //clase sobrecargada con argumentos
            int catado, catopu, hipo;
            Console.Write("Escribe el lado del cateto adyacente ");
            catado = int.Parse(Console.ReadLine());
            Console.Write("Escribe el lado del cateto opuesto ");
            catopu = int.Parse(Console.ReadLine());
            Console.Write("Escribe el lado del cateto hipotenusa ");
            hipo = int.Parse(Console.ReadLine());
            Pitagoras triangulo2 = new Pitagoras(catado, catopu, hipo);
            Console.WriteLine(triangulo2.Tipodetriangulo());
            Console.ReadKey();
        }
    }
}
