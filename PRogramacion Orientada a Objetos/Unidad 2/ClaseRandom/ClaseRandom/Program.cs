using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(1, 101),intentos=0;
            Console.WriteLine("This is a game of luck. In this game, we generate a random number between 1 and 100.");
            Console.WriteLine("You need to try to predict this number. You only have 5 tries to complete the game. If you can't predict the number, you lose. Good luck!");

            int tries = 5;
            while (true)
            {

                while (tries > 0)
                {

                    Console.Write("Enter your guess: ");
                    int number;
                    if (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }
                    else
                    {

                        if (number < 100)
                        {
                            intentos++;
                            tries--;
                            if (number > numeroAleatorio)
                            {
                                Console.WriteLine($"Your number is too high. attempt {intentos} to 5");
                            }
                            else if (number < numeroAleatorio)
                            {
                                Console.WriteLine($"Your number is too low. attempt {intentos} to 5");
                            }
                            else
                            {
                                Console.WriteLine($"Congratulations! You guessed the number in {intentos} attempt");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("This is a game of luck. In this game, we generate a random number between 1 and 100.");
                                Console.WriteLine("You need to try to predict this number. You only have 5 tries to complete the game. If you can't predict the number, you lose. Good luck!");

                            }
                        }
                        else
                        {
                            Console.WriteLine("only type numbers 0 to 100");

                        }
                    }


                    if (tries == 0)
                    {
                        Console.WriteLine($"GAME OVER. You have ran out {intentos} attempts. the number was {numeroAleatorio}");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("This is a game of luck. In this game, we generate a random number between 1 and 100.");
                        Console.WriteLine("You need to try to predict this number. You only have 5 tries to complete the game. If you can't predict the number, you lose. Good luck!");
                        intentos = 0;
                        tries = 5;
                        numeroAleatorio = rnd.Next(1, 101);
                    }
                }

            }

        }
        static string Cadenainicio()
        {
            string instructions = "This is a game of luck. In this game, we generate a random number between 1 and 100.\n";
            instructions += "You need to try to predict this number. You only have 5 tries to complete the game. If you can't predict the number, you lose. Good luck!\n";
            return instructions;
        }

    }
}
