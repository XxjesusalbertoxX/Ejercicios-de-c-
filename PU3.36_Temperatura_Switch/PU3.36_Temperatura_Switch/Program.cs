using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._36_Temperatura_Switch
{
    internal class Program
    {
        /*
         * como dato una temperatura en grados 
         * farengeit determine el deporte que es 
         * apropiado preactico a esa temperatura teniendoen cuenta la siguiente tabla
         */
        static void Main(string[] args)
        {
            int temperatura;
            Console.WriteLine("Escribe la temperatura del ambiente en farenheit");
            temperatura = int.Parse(Console.ReadLine());

            if (temperatura > 85)
            {
                Console.WriteLine("Natacion");
            }
            else
            {
                if (temperatura > 70)
                {
                    Console.WriteLine("Tenis");
                }
                else
                {
                    if (temperatura > 32)
                    {
                        Console.WriteLine("Golf");
                    }
                    else
                    {

                        if (temperatura > 10)
                        {
                            Console.WriteLine("Skie");
                        }
                        else
                        {
                            Console.WriteLine("Marcha");
                        }
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
