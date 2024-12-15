using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    internal class HojasHielo
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public double SumaColumna {  get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }
        public double Subtotal { get; set; }
        public double Descuento { get; set; }
        public void Descontar()
        {
            if (Tipo == 1)
            {
                Descuento = Subtotal * .05;
                Total = Subtotal-Descuento;
            }
            if (Tipo == 2)
            {
                Descuento = Subtotal * .08;
                Total = Subtotal - Descuento;
            }
            if (Tipo == 3)
            {
                Descuento = Subtotal * .12;
                Total = Subtotal - Descuento;
            }
            if (Tipo == 4)
            {
                Descuento = Subtotal * .15;
                Total = Subtotal - Descuento;
            }
        }
        public void Subtotales()
        {
            Subtotal = Precio * Cantidad;
        }
    }
}
