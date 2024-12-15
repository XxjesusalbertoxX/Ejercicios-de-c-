using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Carroscarrera
{
    internal class Carro
    {
        public int matricula {  get; set; }
        public double speed {  get; set; }
        public string nameconductor { get; set; }
        public bool encendido { get; set; }
        
        public void acelerar(double velocidad, int numerocarro)
        {
            if (encendido)
            {
                    speed += velocidad;
                Console.WriteLine($"El carro {numerocarro} esta acelerando a {speed}");
            }
            else
            {
                Console.WriteLine($"Enciende el carro {numerocarro} para poder acelerar");
                Console.WriteLine("Y/N");
                if (Console.ReadLine() == "Y")
                {
                    Console.Clear();
                    encendido = true;
                    Console.WriteLine("Carro encendido");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No lo encendiste");
                }
            }
        }

        public void frenar(double velocidad)
        {
            if(speed> 0)
            {
                speed -= velocidad;
                if (speed < 0)
                {
                    Console.WriteLine("La carreara termino");
                    speed = 0;
                }
                else
                {
                    Console.WriteLine("El carro esta frenando");
                }
            }
        }

    }

}
