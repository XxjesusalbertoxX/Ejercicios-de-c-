using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    public class Calculadora
    {
        public Calculadora() { }
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        // es una forma de asignarle una operacion a la propiedad
        public double Suma => Numero1 + Numero2;

        public void PedirNumeros()
        {
            Console.Write("Ingrese el primer número: ");
            Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            Numero2 = Convert.ToDouble(Console.ReadLine());
        }

        public void MostrarSuma()
        {
            Console.WriteLine($"La suma de {Numero1} y {Numero2} es: {Suma}");
        }
    }
}
