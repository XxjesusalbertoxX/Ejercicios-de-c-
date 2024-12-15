using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Banco_v1._0
{
    /*internal class Program
    {
        //varibale para el conteo de intentos de forma global
        static int intentos = 3;
        //variable para el saldo global
        static double saldo = 0;
        //variable para detectar NIP
        static String NIP = "0000";
        static void Main(string[] args)
        {
                Menu();
        }

        static void Menu()
        {
            string option;
            
            int cuenta = 0;
            string nombre = "";

            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe el numero de cuenta");
            cuenta = int.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.WriteLine("a) abonar");
                Console.WriteLine("b) retirar");
                Console.WriteLine("c) Cambio NIP");
                Console.WriteLine("d) consultar saldo");
                Console.WriteLine("e) salir");
                Console.Write("Escribe la operacion que deseas realizar: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        if (Checar_NIP() == true)
                        {
                            abonar();
                        }
                        else
                        {
                            Console.WriteLine("Contraseña Incorrecta ");
                            if (intentos == 0)
                            {
                                Console.WriteLine("Bloqueado por superar el numero de intentos posibles");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "b":
                        if (Checar_NIP() == true)
                        {
                            retirar();
                        }
                        else
                        {
                            Console.WriteLine("Contraseña Incorrecta ");
                            if (intentos == 0)
                            {
                                Console.WriteLine("Bloqueado por superar el numero de intentos posibles");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                        
                        Console.ReadKey();
                        break;
                    case "c":
                        string nvacontra;
                        if (Checar_NIP() == true)
                        {
                            Console.WriteLine("Escribe la nueva contraseña");
                            do
                            {
                                nvacontra = Console.ReadLine();
                                if (nvacontra.Length != 4)
                                {
                                    Console.WriteLine("La contraseña solo puede ser de 4 digitos");
                                    Console.WriteLine("Vuelva a escribir la nueva contraseña");
                                }
                                else
                                {
                                    NIP = nvacontra;
                                    Console.WriteLine("Tu contraseña a sido cambiada con exito");
                                }
                            } while (nvacontra.Length != 4);
                        }
                        else
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Contraseña Incorrecta, vuelve a intentarlo");
                            }
                            while (Checar_NIP() != true);
                            if (intentos == 0)
                            {
                                Console.WriteLine("Bloqueado por superar el numero de intentos posibles");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "d":
                        if (Checar_NIP() == true)
                        {
                            Consulta_Saldo(cuenta);
                        }
                        else
                        {
                            Console.WriteLine("Contraseña Incorrecta ");
                            if (intentos == 0)
                            {
                                Console.WriteLine("Bloqueado por superar el numero de intentos posibles");
                                
                                Environment.Exit(0);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "e":
                        Console.WriteLine("Te saliste");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Escribe una opcion valida");
                        option = Console.ReadLine();
                        break;
                }
            }
            while (option != "e");

        }

        static void abonar()
        {
            Console.WriteLine("Escribe cuanto vas a depositar");
            double saldos=double.Parse(Console.ReadLine());
            if (saldos > saldo || saldos == 0)
            {
                if (saldos == 0)
                {
                    Console.WriteLine("Escribe un numero valido");
                }
                else
                {
                    saldo += saldos;
                    Console.WriteLine("Operacion Exitosa");
                }
                
            }
        }
        static void retirar()
        {
            Console.WriteLine("Escribe cuanto deseas retirar");
            double saldos = double.Parse(Console.ReadLine());
            if (saldos > saldo || saldos == 0)
            {
                if (saldos == 0)
                {
                    Console.WriteLine("Escribe un numero valido");
                }
                else
                {
                    if(saldo <= 0)
                    {
                        Console.WriteLine("Tu saldo es insuficiente");
                    }
                }

            }
            else
            {
                saldo -= saldos;
                Console.WriteLine("Operacion exitosa");
            }
        }
        static void Consulta_Saldo(int cuenta)
        {
            Console.Write($"El numero de cuenta es: {cuenta}");
            Console.WriteLine($"El saldo actual es de {saldo}");
        }
        static bool Checar_NIP()
        {
            Console.WriteLine("Escribe Tu contraseña");
            string contraseña = LeerContraseña();
            Console.WriteLine();
            if (contraseña == NIP&&contraseña.Length == 4)
            {
                intentos = 3;
                return true;
            }
            else
            {
                intentos--;
                return false;
            }

        }
        static string LeerContraseña()
        {
            string contraseña = "";
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true); // true para no mostrar la tecla presionada

                // Si no es una tecla de control como Enter o Backspace, se agrega a la contraseña
                if (tecla.Key != ConsoleKey.Enter && tecla.Key != ConsoleKey.Backspace)
                {
                    contraseña += tecla.KeyChar;
                    Console.Write("*"); // Opcional: mostrar un asterisco en lugar del carácter
                }
                else if (tecla.Key == ConsoleKey.Backspace && contraseña.Length > 0 || contraseña.Length > 5)
                {
                    contraseña = contraseña.Substring(0, (contraseña.Length - 1));
                    int cursorPos = Console.CursorLeft;
                    Console.SetCursorPosition(cursorPos - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(cursorPos - 1, Console.CursorTop);
                }
            } while (tecla.Key != ConsoleKey.Enter);

            return contraseña;
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();
            Console.Write("Escribe tu nombre: ");
            cuenta.Nombre = Console.ReadLine();
            Console.Write("Escribe el número de cuenta: ");
            cuenta.NumeroCuenta = Console.ReadLine();
            
            Cajero cajero = new Cajero(cuenta);

            cajero.Menu();
        }
    }
}