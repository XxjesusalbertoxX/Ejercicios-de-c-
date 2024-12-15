using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PU3._40_Fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sign=true;
            int n = 0;
            string resultado="";
            Console.WriteLine("Escribe el numero entero");
            n=int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                if(i==1)
                {
                    Console.Write("+"+i);
                }
                else
                {
                    if (sign == false)
                    {
                        resultado = "+(1 /" + i + ")";
                        sign = true;
                    }
                    else
                    {
                        if (sign == true)
                        {
                            resultado = "-(1 /" + i + ")";
                            sign = false;
                        }
                    }


                    Console.Write(resultado);
                }

            }
            Console.ReadLine();
        }
    }
}
