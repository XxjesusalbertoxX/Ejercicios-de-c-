using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    internal class Empleado
    {
        public double HorasT { get; set; }
        public double CuotaHora { get; set; }
        public string NombreEmp { get; set; }
        public double Sueldo { get; set; }

        public void SumarSueldo()
        {
            Sueldo = HorasT * CuotaHora;
        }
    }
}
