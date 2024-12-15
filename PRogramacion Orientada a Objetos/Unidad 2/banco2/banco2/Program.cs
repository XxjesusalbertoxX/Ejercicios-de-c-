using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco2
{
    using System;

    class Program
    {
        static string nombre;
        static string numeroCuenta;
        static double saldo;
        static string nip;
        static int intentos = 3;

        static void Main(string[] args)
        {
            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Escribe el número de cuenta: ");
            numeroCuenta = Console.ReadLine();
            InicializarCuenta();
            Menu();
        }

        static void InicializarCuenta(double saldoInicial = 0, string nipInicial = "0000")
        {
            saldo = saldoInicial;
            nip = nipInicial;
        }

        static void Menu()
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

        static void Abonar()
        {
            Console.Write("Escribe cuánto vas a depositar: ");
            if (double.TryParse(Console.ReadLine(), out double cantidad))
            {
                if (cantidad > 0)
                {
                    saldo += cantidad;
                    Console.WriteLine($"Se abonaron {cantidad:C} a la cuenta. Operación exitosa.");
                }
                else
                {
                    Console.WriteLine("La cantidad a abonar debe ser mayor a cero.");
                }
            }
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }

        static void Retirar()
        {
            Console.WriteLine("Escribe cuánto deseas retirar: ");
            if (double.TryParse(Console.ReadLine(), out double cantidad))
            {
                if (cantidad > 0 && cantidad <= saldo)
                {
                    saldo -= cantidad;
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
            else
            {
                Console.WriteLine("Cantidad inválida.");
            }
        }

        static void ConsultarSaldo()
        {
            Console.WriteLine($"El saldo actual es: {saldo:C}");
        }

        static void CambiarNIP()
        {
            Console.Write("Escribe tu NIP actual: ");
            string nipActual = LeerContraseña();
            Console.WriteLine();
            Console.Write("Escribe el nuevo NIP (4 dígitos): ");
            string nuevoNip = LeerContraseña();

            if (nipActual == nip && nuevoNip.Length == 4)
            {
                nip = nuevoNip;
                Console.WriteLine("Tu NIP ha sido cambiado con éxito.");
            }
            else
            {
                Console.WriteLine("NIP incorrecto o nuevo NIP inválido.");
                if (--intentos == 0)
                {
                    Console.WriteLine("Bloqueado por superar el número de intentos posibles.");
                    Environment.Exit(0);
                }
            }
        }

        static bool ChecarNIP()
        {
            Console.Write("Escribe tu NIP: ");
            string nipIngresado = LeerContraseña();
            if (nipIngresado == nip)
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

        static string LeerContraseña()
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
                    contraseña = contraseña.Substring(0, contraseña.Length - 1);
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
