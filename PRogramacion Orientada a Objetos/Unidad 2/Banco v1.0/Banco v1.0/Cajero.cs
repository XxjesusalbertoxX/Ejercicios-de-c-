using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_v1._0
{
    internal class Cajero
    {
        private CuentaBancaria cuenta;
        private int intentos = 3;

        public Cajero(CuentaBancaria cuenta)
        {
            this.cuenta = cuenta;
        }

        public void Menu()
        {
            string opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("a) Abonar");
                Console.WriteLine("b) Retirar");
                Console.WriteLine("c) Cambiar NIP");
                Console.WriteLine("d) Consultar saldo");
                Console.WriteLine("e) Salir");
                Console.Write("Escribe la operación que deseas realizar: ");
                opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "a":
                            Abonar();
                        break;
                    case "b":
                        if (ChecarNIP())
                        {
                            Retirar();
                        }
                        break;
                    case "c":
                        CambiarNIP();
                        break;
                    case "d":
                        if (ChecarNIP())
                        {
                            ConsultarSaldo();
                        }
                        break;
                    case "e":
                        Console.WriteLine("Te saliste.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                if (opcion != "e")
                {
                    Console.ReadKey();
                }
            } while (opcion != "e");
        }

        private bool ChecarNIP()
        {
            Console.Write("Escribe tu NIP: ");
            string nip = LeerContraseña();
            if (cuenta.VerificarNIP(nip))
            {
                intentos = 3;
                return true;
            }
            else
            {
                intentos--;
                Console.WriteLine("NIP incorrecto.");
                if (intentos == 0)
                {
                    Console.WriteLine("Bloqueado por superar el número de intentos posibles.");
                    Environment.Exit(0);
                }
                return false;
            }
        }

        private void Abonar()
        {
            Console.Write("Escribe cuánto vas a depositar: ");
            if (double.TryParse(Console.ReadLine(), out double cantidad))
            {
                cuenta.Abonar(cantidad);
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }

        private void Retirar()
        {
            Console.WriteLine("Escribe cuánto deseas retirar: ");
            if (double.TryParse(Console.ReadLine(), out double cantidad))
            {
                cuenta.Retirar(cantidad);
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }

        private void ConsultarSaldo()
        {
            cuenta.ConsultarSaldo();
        }

        private void CambiarNIP()
        {
            Console.Write("Escribe tu NIP actual: ");
            string nipActual = LeerContraseña();
            Console.WriteLine();
            Console.Write("Escribe el nuevo NIP (4 dígitos): ");
            string nuevoNip = LeerContraseña();
            if (!cuenta.CambiarNIP(nipActual, nuevoNip))
            {
                if (--intentos == 0)
                {
                    Console.WriteLine("Bloqueado por superar el número de intentos posibles.");
                    Environment.Exit(0);
                }
            }
        }

        private string LeerContraseña()
        {
            string contraseña = "";
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Backspace)
                {
                    contraseña += tecla.KeyChar;
                    Console.Write("*");
                }
                else if (tecla.Key == ConsoleKey.Backspace && contraseña.Length > 0)
                {
                    contraseña = contraseña.Substring(0, (contraseña.Length - 1));
                    int cursorPos = Console.CursorLeft;
                    Console.SetCursorPosition(cursorPos - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(cursorPos - 1, Console.CursorTop);
                }
            } while (tecla.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return contraseña;
        }
    }
}
