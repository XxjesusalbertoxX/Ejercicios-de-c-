using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    internal class Operaciones
    {
        public double Base{ get; set; }
        public double Lado1 {  get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        public double Altura { get; set; }
        public double Radio { get; set; }
        public double Perimetro { get; set; }
        public double Area { get; set; }
        public double TrianguloAr()
        {
            Area = Base * Altura / 2;
            return Area;
        }
        public double TrianguloPer()
        {
            Perimetro = Lado1 + Lado2 + Lado3;
            return Perimetro;
        }
        public double CuadradoAr()
        {
            Area = Base * Altura;
            return Area;
        }
        public double CuadradoPer()
        {
            Perimetro = Lado1 * 4;
            return Perimetro;
        }
        public double RectanguloAr()
        {
            Area = Base * Altura;
            return Area;
        }
        public double RectanguloPer()
        {
            Perimetro = (Base * 2)+(Altura * 2); 
            return Area;
        }
        public double CirculoAr()
        {
            Area = Math.Pow((Math.PI * Radio),2);
            return Area;
        }
        public double CirculoPer()
        {
            Perimetro = Math.PI * (Radio*2);
            return Perimetro;
        }
    }
}
