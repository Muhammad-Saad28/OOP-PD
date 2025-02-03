using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ninja_Hunt
{
    class program
    {
        public static void Header()
        {
            Console.Clear();
            SetColor(ConsoleColor.Cyan);
            Console.SetCursorPosition(48, 0);
            Console.WriteLine(" _   _  _          _          _    _                _   ");
            Console.SetCursorPosition(48, 1);
            Console.WriteLine("| \\ | |(_)        (_)        | |  | |              | |  ");
            Console.SetCursorPosition(48, 2);
            Console.WriteLine("|  \\| | _  _ __    _   __ _  | |__| | _   _  _ __  | |_ ");
            Console.SetCursorPosition(48, 3);
            Console.WriteLine("| . ` || || '_ \\  | | / _` | |  __  || | | || '_ \\ | __|");
            Console.SetCursorPosition(48, 4);
            Console.WriteLine("| |\\  || || | | | | || (_| | | |  | || |_| || | | || |_ ");
            Console.SetCursorPosition(48, 5);
            Console.WriteLine("|_| \\_||_||_| |_| | | \\__,_| |_|  |_| \\__,_||_| |_| \\__|");
            Console.SetCursorPosition(48, 6);
            Console.WriteLine("                 _/ |                                   ");
            Console.SetCursorPosition(48, 7);
            Console.WriteLine("                |__/                                    ");
            SetColor(ConsoleColor.White);
        }
        public static void Maze()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan; // Equivalent to setcolor(03)

            string[] maze = {
            "####################################################################################################################",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                              ____|",
            "|                                                                                                             |    |",
            "|                                                                                                             |    |",
            "|                                                                                                             |    |",
            "|                                              ####################################################################|",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|####################################                                               ###############################|",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "|                                                                                                                  |",
            "####################################################################################################################"
        };
            foreach (string line in maze)
            {
                Console.WriteLine(line);
            }

            Console.ResetColor(); // Reset color to default
        }
        public static void Loading()
        {
            Console.Clear();
            Header();

            int x = 0;
            char loading = '█';
            for (int i = 0; i <= 10; i++)
            {
                Console.SetCursorPosition(65 + x, 20);
                Thread.Sleep(300);
                Console.Write(loading);
                x += 2;
                Console.SetCursorPosition(60, 20);
                Console.Write(i * 10 + "%");
            }
            Console.SetCursorPosition(70, 21);
            Console.Write("COMPLETE !!");
            Thread.Sleep(500);
        }
        public static int Menu()
        {
            int choice;
            Header();
            Console.SetCursorPosition(60, 10);
            Console.WriteLine("1) Start ");
            Console.SetCursorPosition(60, 12);
            Console.WriteLine("2) Options ");
            Console.SetCursorPosition(60, 14);
            Console.WriteLine("3) Exit ");
            Console.SetCursorPosition(60, 16);
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static void HowToPlay()
        {
            Console.Clear();
            Header();
            SetColor(ConsoleColor.Red);
            Console.SetCursorPosition(55, 10);
            Console.WriteLine("Menu > Option > How to Play");
            SetColor(ConsoleColor.White);
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Keys\t\t\t\t Functions");
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("Up arrow\t\t Move Character Up");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("Down arrow\t\t Move Character Down");
            Console.SetCursorPosition(50, 17);
            Console.WriteLine("Left arrow\t\t Move Character Left");
            Console.SetCursorPosition(50, 18);
            Console.WriteLine("Right arrow\t\t Move Character Right");
            Console.SetCursorPosition(50, 19);
            Console.WriteLine("Space\t\t\t Character Fire");
            Console.SetCursorPosition(60, 21);
            Console.WriteLine("Press any key for back...");
            Console.ReadKey();
        }
        public static void Game()
        {
            Game game = new Game();
            game.Run();
        }
        public static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void Main()
        {
            int choice = Menu();
            switch (choice)
            {
                case 1:
                    Header();
                    Loading();
                    Game();
                    break;
                case 2:
                    HowToPlay();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
