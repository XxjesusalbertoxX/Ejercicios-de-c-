using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Banco
    {
        public string Nombre { get; set; }
        public int Cuenta {  get; set; }
        public double Saldo { get; set; }
        public double Abono {  get; set; }
        public double Retiro {  get; set; }
        public double Abonar()
        {
            Saldo += Abono;
            return Saldo;
        }
        public double Retirar()
        {
            Saldo -= Retiro;
            return Saldo;
        }

    }
}
