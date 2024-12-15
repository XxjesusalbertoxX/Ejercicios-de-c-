using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Banco
    {
        public double Abonar(double saldoActual, double abono)
        {
            return saldoActual + abono;
        }

        public double Retirar(double saldoActual, double retiro)
        {
            return saldoActual - retiro;
        }
    }

}
