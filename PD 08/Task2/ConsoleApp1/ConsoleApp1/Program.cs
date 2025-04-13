using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using ConsoleApp1.UI.CardGame.Presentation;

    namespace CardGame
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to High-Low Card Game!");

                while (true)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Play High-Low Game");
                    Console.WriteLine("2. Exit");
                    Console.Write("Enter your choice: ");

                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            var game = new HighLowGame();
                            game.StartGame();
                            break;
                        case 2:
                            Console.WriteLine("Thanks for playing!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
