using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._9_Volumen_y_Area_Cilindro
{
    internal class Program
    {
        /*
         * construye un diagrama de flujo tal que, dado como datos el radio y la altura de un cilindro,
         * calcule e imprima el área y volumen del cilindro.
         */
        static void Main(string[] args)
        {
            float volumen, area, radio, altura;

            Console.WriteLine("Escribe la altura:");
            altura=float.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el radio del cilindro");
            radio = float.Parse(Console.ReadLine());

            volumen = (float)(Math.PI * Math.Pow(radio, 2)*altura);
            area = (float)((2 * Math.PI * radio * altura) + (2 * Math.PI * Math.Pow(radio, 2)));

            Console.WriteLine("El area del cilindro es :" + area);
            Console.WriteLine("El volumen del cilindro es :"+volumen);
            Console.ReadKey();
                
        }
    }
}
