using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._7_Nombre_Dinosaurio
{
    internal class Program
    {
        /*
         * Escribe un diagrama de flujo tal que, dado la base y la altura de un triangulo 
         * equilátero calcule e imprima el área y perímetro de las figuras
         */
        static void Main(string[] args)
        {
            string Ndino;
            float dinolongi, dinopeso;

            Console.WriteLine("Escribe el nombre del Dinosaurio");
            Ndino = Console.ReadLine();
            Console.WriteLine("Escribe cuantos pies mide el dinosaurio");
            dinolongi = float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe cuantas libras pesa el dinosaurio");
            dinopeso = float.Parse(Console.ReadLine());

            dinopeso /= (float)2.205;
            dinolongi /= (float)3.281;

            Console.WriteLine("El dinosaurio llamado " + Ndino + " Pesa " + dinopeso + "Kg y mide " + dinolongi + "mts.");
            Console.ReadLine();
        }
    } 
}
