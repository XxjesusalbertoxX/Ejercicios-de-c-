using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_v1._0
{
    internal class CuentaBancaria
    {
        public string Nombre { get; set; }
        public string NumeroCuenta { get; set; }
        public double Saldo { get; private set; }
        public string NIP { get; private set; }

        public CuentaBancaria(double saldoInicial = 0, string nip = "0000")
        {
            Saldo = saldoInicial;
            NIP = nip;
        }

        public void Abonar(double cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine($"Se abonaron {cantidad:C} a la cuenta. Operación exitosa.");
            }
            else
            {
                Console.WriteLine("La cantidad a abonar debe ser mayor a cero.");
            }
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= Saldo)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad:C} de la cuenta. Operación exitosa.");
            }
            else if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a retirar debe ser mayor a cero.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"El saldo actual es: {Saldo:C}");
        }

        public bool CambiarNIP(string nipActual, string nuevoNip)
        {

            if (nipActual == NIP && nuevoNip.Length == 4)
            {
                NIP = nuevoNip;
                Console.WriteLine("Tu NIP ha sido cambiado con éxito.");
                return true;
            }
            else
            {
                Console.WriteLine("NIP incorrecto o nuevo NIP inválido.");
                return false;
            }
        }

        public bool VerificarNIP(string nip)
        {
            return NIP == nip;
        }
    }
}
