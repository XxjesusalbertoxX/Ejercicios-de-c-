using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Carroscarrera
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            Carro automovil1 = new Carro(), automovil2 = new Carro();
            Console.WriteLine("Carrera de carros");
            Console.WriteLine($"Escribe el nombre del dueño del carro 1 :");
            automovil1.nameconductor = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Escribe el nombre del dueño del carro 2 :");
            automovil2.nameconductor = Console.ReadLine();
            Console.Clear();
            Carrera(automovil1, automovil2);
            Console.ReadKey();
        }
        static void Carrera(Carro carro1, Carro carro2)
        {
            int victoria;
            Console.WriteLine("La carrera comienza ya!");
            Random velocidad = new Random();
            for (int i = 0; i <= 3; i++)
            {
                carro1.acelerar(velocidad.Next(1, 100),1);
                carro2.acelerar(velocidad.Next(1, 100),2);
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"El ganador de los 2 carros es :{ganador(carro1.nameconductor,carro2.nameconductor,carro1.speed,carro2.speed)}");
            Console.ReadKey();
            while (carro1.speed != 0)
            {
                carro1.frenar(velocidad.Next(100));
                carro2.frenar(velocidad.Next(100));
            }
            Console.WriteLine("La carrera termino");
            Console.ReadLine();
        }
        static string ganador(string namecarr1, string namecarr2, double velocitycarr1, double velocitycarr2)
        {
            if (velocitycarr1 > velocitycarr2 )
            {
                return namecarr1;
            }
            else
            {
                return namecarr2;
            }
        }
    }
}
