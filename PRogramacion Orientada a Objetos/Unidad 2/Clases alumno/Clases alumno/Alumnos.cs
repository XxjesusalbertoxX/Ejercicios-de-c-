using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_alumno
{
    internal class Alumno
    {
        private string _name;
        static private int _matricula, indice;
        static private float promedio;
        static int numerocalif;
        private float[] _Calificaciones;
        //obtiene el valor de promedio y lo guarda

        public int GetNumeroCalificacion
        {
            get { return indice; }

            set { indice = value; }
        }
        public int GetMateriasCursadas
        {
            get {return numerocalif;}
            set {numerocalif = value;}
        }
        public float GetPromedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
        //obtiene el valor de calificaciones
        public float[] Calificaciones
        {
            get;
            set;
        }
        //obtiene el valor de la matricula y lo guarda
        public int GetMatricula
        {
            get { return _matricula; }
            set
            {
                _matricula = value;
            }
        }
        //obtiene el valor del nombre
        public string GetNombre
        {
            get { return _name; }
            set { _name = value; }
        }
        public Alumno(string name, int matricula,int numerocalificaciones)
        {
            _name = name;
            _matricula = matricula;
            numerocalif = numerocalificaciones;
            indice = 0;
            _Calificaciones = new float[numerocalificaciones];
        }

        public void agregacalif(float calificacion)
        {
            if (indice < _Calificaciones.Length)
            {
                _Calificaciones[indice] = calificacion;
                indice++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más calificaciones, el arreglo está lleno.");
            }
        }
        public float ObtenerPromedio()
        {
            if (indice == 0)
            {
                return 0;
            }
                        
            float suma = 0;
            for (int i = 0; i < indice; i++)
            {
                suma += _Calificaciones[i];
            }
            return suma / indice;
        }
        public float[] ObtenerTodas()
        {
            float[] resultado = new float[indice];
            Array.Copy(_Calificaciones, resultado, indice);
            return resultado;
        }
        
    }
}
