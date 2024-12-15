using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Alumnos
    {
        public string nombre { get; set; }
        public float[] calificacion { get; set; } = new float[4];
        static float promedio { get; set; }
        public Alumnos(string nombredelalumno, float[] calificacionesdelosalumnos)
        {
            int i=0;
            for (i=0; i < 4;)
            {
                calificacion[i] = calificacionesdelosalumnos[i++];
            }
            nombre = nombredelalumno;

        }

        public Alumnos(string nombredelalumno, string C1, string C2, string C3, string C4)
        {
            nombre = nombredelalumno;
            calificacion[0] = float.Parse(C1);
            calificacion[1] = float.Parse(C2);
            calificacion[2] = float.Parse(C3);
            calificacion[3] = float.Parse(C4);
        }

        public float Promedio()
        {
            promedio = calificacion.Sum();
            return promedio /= calificacion.Length;
            
        }
        public Alumnos() { }
    }
}
