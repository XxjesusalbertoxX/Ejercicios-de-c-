using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Triangulo trinagulo1 = new Triangulo();
                Console.Write("Escribe La base: ");
                trinagulo1.Labase = float.Parse(Console.ReadLine());
                Console.Write("\nEscribe La altura: ");
                trinagulo1.Latura = float.Parse(Console.ReadLine());

                Console.WriteLine($"El area es de: {trinagulo1.CalcularElArea()}cm");
                Console.ReadKey();
            }
        }
    }
}
