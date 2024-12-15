using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using FuzzySharp;

namespace PU3._32_Llamadas_Switch
{
    internal class Program
    {
        static int minutos=0, clave;
        static double preciot ;
        static string names,a;
        static string[] namestrue = { "América del Norte", "América Central", "América del Sur", "Europa", "Asía", "África", "Oceanía" };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escribe la clave de tu país o la zona geográfica");
                names = Console.ReadLine();
                Console.WriteLine("escribe cuantos minutos duro la llamada");
                string solonumeros = Console.ReadLine();
                while (minutos == 0||solonumeros =="0")
                {
                    if (int.TryParse(solonumeros, out minutos))
                    {
                        
                        minutos = Convert.ToInt32(solonumeros);
                        if (minutos == 0)
                        {
                            Console.WriteLine("No se pueden poner 0 minutos, escribe minutos validos");
                            solonumeros = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("ese no es un numero, por favor escribe un el numero de minutos");
                        solonumeros = Console.ReadLine();
                    }
                }
                Validarcadenas();
                if (preciot == 0|| a == "La clave es incorrecta")
                {
                    
                    while (preciot == 0)
                    {
                        Console.WriteLine("Zona o clave equivocada, escribe nuevamente una zona o clave");
                        names = Console.ReadLine();
                        Validarcadenas();

                    }

                }
                Console.ReadKey();

            }





        }
        static void Validarcadenas()
        {
            if (int.TryParse(names, out clave))
            {
                switch (clave)
                {
                    case 12:
                        preciot = minutos * 2;
                        names = "America del norte"; break;
                    case 15:
                        preciot = minutos * 2.2;
                        names = "America central"; break;
                    case 18:
                        preciot = minutos * 4.5;
                        names = "America del sur"; break;
                    case 19:
                        preciot = minutos * 3.5;
                        names = "Europa"; break;
                    case 23:
                    case 25:
                        preciot = minutos * 6;
                        names = "Asia o Africa"; break;
                    case 29:
                        preciot = minutos * 5;
                        names = "Oceania"; break;
                    default:
                        Console.WriteLine("La clave es incorrecta");
                        preciot = 0; break;
                }
                if (preciot != 0)
                {
                    Console.WriteLine("El precio total es de: " + preciot + "$ en " + names + ".");
                }
                minutos = 0;

            }
            else
            {
                foreach (string nametrue in namestrue)
                {
                    double score = Fuzz.WeightedRatio(names, nametrue);
                    if (score > 70)
                    {
                        preciot = 0;
                        switch (nametrue)
                        {

                            case "América del norte":
                                preciot = minutos * 2; break;
                            case "América central":
                                preciot = minutos * 2.2; break;
                            case "América del sur":
                                preciot = minutos * 4.5; break;
                            case "Europa":
                                preciot = minutos * 3.5; break;
                            case "Asía":
                            case "África":
                                preciot = minutos * 6;
                                names = "Asia o áfrica"; break;
                            case "Oceanía":
                                preciot = minutos * 5; break;

                        }
                        Console.WriteLine("El precio total es de: " + preciot + "$ en " + nametrue + ".");
                        break;
                        
                    }
                    else
                    {

                        preciot = 0;
                    }

                }
                minutos = 0;
            }
        }
    }
}
