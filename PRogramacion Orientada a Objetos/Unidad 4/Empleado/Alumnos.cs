using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public double Cal1 { get; set; }
        public double Cal2 { get; set; }
        public double Cal3 { get; set; }
        public double Cal4 { get; set; }

        public double Promediar()
        {
            return (Cal1 + Cal2 + Cal3 + Cal4) / 4;
        }
    }

}
