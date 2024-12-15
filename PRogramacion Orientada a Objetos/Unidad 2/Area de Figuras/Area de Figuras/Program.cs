using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_Figuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Lista();
                Console.Write("Escribe la opcion que necesites: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Imprimir_Area(Calcular_Area_Triangulo(Pide_Base(), Pide_Altura()));
                        break;
                    case 2:
                        Imprimir_Area();
                        break;
                    case 3:
                        Console.WriteLine(CalculaImprimirCuadrado(Ladocuadrado()));
                        break;
                    case 4:
                        Console.WriteLine(CalculaImprimirCuadrado());
                        break;
                    case 5:
                        Console.WriteLine("Te saliste");
                        break;
                    default:
                        Lista();
                        Console.WriteLine("Por davor escribe un numero que si este dentro de la lista");

                        opcion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                }
                Console.ReadKey();
            }
            while (opcion != 5);
            Console.ReadKey();
        }
        static double Pide_Base()
        {
            Console.WriteLine("Escribe la base del triangulo");
            return double.Parse(Console.ReadLine());
        }
        static void Lista()
        {
            Console.WriteLine("1.- Calcular el area de un triangulo");//Void con parametros
            Console.WriteLine("2.- Calcular el area de un rectangulo");//Void sin parametros
            Console.WriteLine("3.- Calcular el area de un cuadrado");//retorna valor sin parametros
            Console.WriteLine("4.- Calcular el area de un circulo");//retorna valor con parametros
            Console.WriteLine("5.- Salir");
        }
        static double Pide_Radio()
        {
            Console.WriteLine("Escribe el radio del circulo");
            return double.Parse(Console.ReadLine());
        }
        static double Pide_Baser()
        {
            Console.WriteLine("Escribe la base del triangulo");
            return double.Parse(Console.ReadLine());
        }
        static double Pide_Alturar()
        {
            Console.WriteLine("Escribe la altura del rectangulo");
            return double.Parse(Console.ReadLine());
        }
        static double Pide_Altura()
        {
            Console.WriteLine("Escribe la altura del triangulo");
            return double.Parse(Console.ReadLine());
        }
        static double Ladocuadrado()
        {
            Console.WriteLine("Escribe el lado del cuadrado");
            return double.Parse(Console.ReadLine());
        }
        static double Calcular_Area_Triangulo(double bases, double altura)
        {
            return (bases * altura) / 2;
        }
        static double Calcular_Area_Rectangulo(double bases, double altura)
        {
            return bases * altura;
        }
        static void Imprimir_Area(double Area)
        {
            Console.WriteLine("El area es: " + Area);
            Console.ReadLine();
        }
        static void Imprimir_Area()
        {
            Console.WriteLine("El area del circulo es: "+Calcular_Area_Rectangulo(Pide_Baser(),Pide_Alturar()));
            Console.ReadKey();
        }
        static string CalculaImprimirCuadrado(double lado)
        {
            return $"El area del cuadrado es: {Math.Pow(lado, 2)}";
        }
        static string CalculaImprimirCuadrado()
        {
            return $"El area del circulo es: {Math.PI*Math.Pow(Pide_Radio(), 2)}";
        }


    }
}
