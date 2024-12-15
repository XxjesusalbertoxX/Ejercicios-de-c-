using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                    Console.Clear();
                    Imprimir_Area(Calcular_Area_Triangulo(Pide_Base(), Pide_Altura()));
            }
        }
        static double Pide_Base()
        {
            Console.WriteLine("Escribe la base del triangulo");
            return double.Parse(Console.ReadLine());
        }
        static double Pide_Altura()
        {
            Console.WriteLine("Escribe la altura del triangulo");
            return double.Parse(Console.ReadLine());
        }
        static double Calcular_Area_Triangulo(double bases,double altura)
        {
            return (bases * altura)/2;
        }
        static void Imprimir_Area(double Area)
        {
            Console.WriteLine("El area es: "+Area);
            Console.ReadLine();
        }
    }
}