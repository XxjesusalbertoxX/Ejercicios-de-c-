using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Empleado
    {
        private double _salario { get; set; }
        public string nombre {  get; set; }
        public double cuota {  get; set; }
        public int horas {  get; set; }

        public double salario
        {
            get
            {
                if(cuota==0||horas==0)
                {
                    return 0;
                }
                return _salario = CalcularSalario();
            }
            set
            {
                _salario = value;
            }
        }
        public double CalcularSalario()
        {
            return horas * cuota;
        }
        
    }
}
