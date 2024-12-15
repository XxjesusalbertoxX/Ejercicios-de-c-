using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    internal class Pitagoras
    {


        public Pitagoras()
        {
            Console.Write("Escribe el lado del cateto adyacente ");
            catady = int.Parse(Console.ReadLine());
            Console.Write("Escribe el lado del cateto opuesto ");
            catopu = int.Parse(Console.ReadLine());
            Console.Write("Escribe el lado del cateto hipotenusa ");
            hipote = int.Parse(Console.ReadLine());
        }
        public Pitagoras(int catetoadyacente, int catetoopuesto, int hipotenusa)
        {
            catady = catetoadyacente;
            catopu = catetoopuesto;
            hipote = hipotenusa;
        }
        public int catady { get; set; }
        public int catopu { get; set; }
        public int hipote { get; set; }

        public string Tipodetriangulo()
        {
            if (Math.Pow(hipote,2) == Math.Pow(catady,2)+Math.Pow(catopu,2))
            {
                return "Es un triangulo rectangulo";
            }
            else
            {
                if (Math.Pow(hipote, 2) < Math.Pow(catady, 2) + Math.Pow(catopu, 2))
                {
                    return "Es un triangulo ocutangulo";
                }
                else
                {
                    return "Es un triangulo obtusangulo";
                }

            }
        }
    }
}
