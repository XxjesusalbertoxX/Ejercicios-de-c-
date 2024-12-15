using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._1_Exprecion
{
    internal class Program
    {
        /*
         *Construye un diagrama de flujo tal que dado los datos A y B. 
         *Escriba el resultado de la siguiente expresion
         */
        static void Main(string[] args)
        {
            //Declarando variables
            float A, B, resultado;
            //Solicitando
            Console.WriteLine("Escribe el primer numero");
            A=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero");
            B=float.Parse(Console.ReadLine());
            resultado = ((A+B)*(A+B))/2;

            Console.WriteLine("El resultado de la operacion es: " + resultado);
            Console.ReadKey();//Instruccion que me sirve para detener el programa 



        }
    }
}
