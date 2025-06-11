using System;
using System.IO;


namespace Pakistan_Railway_Ticket_Managmnet_System
{
    class Authentication
    {
        private static string AdminUsername = "admin";
        private static string AdminPassword = "admin";

        public static void Header()
        {
            Console.Clear();
            SetColor(ConsoleColor.Cyan);
            Console.WriteLine("     _____          _        _____          _  _                               ");
            Console.WriteLine("    |  _ _\\        | |      |  __ \\        (_)| |                              ");
            Console.WriteLine("    | |__) |  __ _ | | __   | |__) |  __ _  _ | |__      __  __ _  _   _       ");
            Console.WriteLine("    |  ___/  / _` || |/ /   |  _  /  / _` || || |\\ \\ /\\ / / / _` || | | |      ");
            Console.WriteLine("    | |     | (_| ||   <    | |  \\ \\| (_| || || | \\ V  V / | (_| || |_| |     ");
            Console.WriteLine("    |_|      \\__,_||_|\\_\\   |_|   \\_\\\\__,_||_||_|  \\_/\\_/   \\__,_| \\__, |      ");
            Console.WriteLine("                                                                    __/ /     ");
            Console.WriteLine("                                                                   |___/          ");
            SetColor(ConsoleColor.Red);
            Console.WriteLine(" _______  _        _            _      _____              _                     ");
            Console.WriteLine("|__   __|(_)      | |          | |    / ____|            | |                   ");
            Console.WriteLine("   | |    _   ___ | | __   ___ | |_  | (___   _   _  ___ | |_   ___  _ __ ___  ");
            Console.WriteLine("   | |   | | / __|| |/ /  / _ \\| __|  \\___ \\ | | | |/ __|| __| / _ \\| '_ ` _ \\ ");
            Console.WriteLine("   | |   | || (__ |   <  |  __/| |_   ____) || |_| |\\__ \\| |_ |  __/| | | | | |");
            Console.WriteLine("   |_|   |_| \\___||_|\\_\\  \\___| \\__| |_____/  \\__, ||___/ \\__| \\___||_| |_| |_|");
            Console.WriteLine("                                              __/ /                           ");
            Console.WriteLine("                                             |___/                            ");
            SetColor(ConsoleColor.Gray);
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine();
        }
        static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void CreateAccount()
        {
            Header();
            Console.WriteLine("Create an Account\n");

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            if (!User.ValidateUsername(username))
            {
                Console.WriteLine("Invalid username. Use letters, numbers, and underscores only.");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (!User.ValidatePassword(password))
            {
                Console.WriteLine("Invalid password. Use letters and numbers only.");
                Console.ReadKey();
                return;
            }

            new User(username, password); // Using constructor to create a user
            Console.WriteLine("Account created successfully!");
            Console.ReadKey();
        }
        public static int LogIn()
        {
            Header();
            Console.WriteLine("Log In");
            Console.WriteLine("______\n");

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username == AdminUsername && password == AdminPassword)
            {
                Console.WriteLine("\nWelcome, admin!");
                Console.ReadKey();
                return 2;
            }

            string filePath = "E:\\University\\Semester 2\\OOP lab\\Project\\Pakistan Railway Ticket Managmnet System\\Pakistan Railway Ticket Managmnet System\\User.txt";

            if (File.Exists(filePath))
            {
                string[] users = File.ReadAllLines(filePath);

                for (int i = 0; i < users.Length; i++)
                {
                    string[] data = users[i].Split(','); // Splitting username and password

                    if (data.Length == 2 && data[0] == username && data[1] == password)
                    {
                        Console.WriteLine("\nLogin successful!");
                        Console.ReadKey();
                        return 0; // User success
                    }
                }
            }

            Console.WriteLine("\nInvalid username or password.");
            Console.ReadKey();
            return 1; // Failure
        }


    }
}
