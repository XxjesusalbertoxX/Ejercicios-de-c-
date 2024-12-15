using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES
{
    internal class Triangulo
    {
        private float Base, Altura, Area;

        public float Labase
        {
            get { return Base; }
            set
            {
                do
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("No puedes escribir una base menor o igual a cero, vuele a repetirlo");
                        value = float.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    else
                    {
                        Base = value;
                    }
                } while(value < 1);
            }
        }
        public float Latura
        {
            get { return Latura; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La altura no puede ser menor o igual a cero");
                Altura = value;
            }
        }

        public float CalcularElArea()
        {
            return Base*Altura/2;
        }
    }
}
