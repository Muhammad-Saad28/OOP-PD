using System;
using System.IO;

namespace BootingCSharp
{
    class Program
    {
        static string AdminUsername = "admin";
        static string AdminPassword = "admin";

        static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        static void Header()
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

        static int Account()
        {
            Header();
            Console.WriteLine("\n1) Create Account");
            Console.WriteLine("\n2) Log in");
            Console.WriteLine("\n3) Exit");
            Console.Write("\nEnter Choice: ");

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static bool ValidateUsername(string username)
        {
            for (int i = 0; i < username.Length; i++)
            {
                char c = username[i];
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidatePassword(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
}

        static int CreateAccount()
        {
            Header();
            Console.WriteLine("Create an Account");
            Console.WriteLine("_________________\n");
            Console.Write("Select Username: ");
            string storedUsername = Console.ReadLine();

            if (!ValidateUsername(storedUsername))
            {
                Console.WriteLine("\nInvalid username. It can only contain alphanumeric characters and underscores.");
                Console.ReadKey();
                return 1; // Failure
            }

            Console.Write("Select Password: ");
            string storedPassword = Console.ReadLine();

            if (!ValidatePassword(storedPassword))
            {
                Console.WriteLine("\nInvalid password. It can only contain alphanumeric characters.");
                Console.ReadKey();
                return 1; // Failure
            }

            // Save username to a file
            using (StreamWriter usernameWriter = new StreamWriter("E:\\University\\Semester 2\\OOP lab\\Project\\Application\\Usernames.txt", append: true))
            {
                usernameWriter.WriteLine(storedUsername);
            }

            // Save password to a file
            using (StreamWriter passwordWriter = new StreamWriter("E:\\University\\Semester 2\\OOP lab\\Project\\Application\\Passwords.txt", append: true))
            {
                passwordWriter.WriteLine(storedPassword);
            }

            Console.WriteLine("\nAccount created successfully!");
            Console.ReadKey();
            return 0; // Success
        }

        static int LogIn()
        {
            Header();
            Console.WriteLine("Log In");
            Console.WriteLine("______\n");
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Check admin credentials
            if (username == AdminUsername && password == AdminPassword)
            {
                Console.WriteLine("\nWelcome, admin!");
                Console.ReadKey();
                return 2; // Admin success
            }

            // Check user credentials from files
            string[] usernames = File.ReadAllLines("E:\\University\\Semester 2\\OOP lab\\Project\\Application\\Usernames.txt");
            string[] passwords = File.ReadAllLines("E:\\University\\Semester 2\\OOP lab\\Project\\Application\\Passwords.txt");

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    Console.WriteLine("\nLogin successful!");
                    Console.ReadKey();
                    return 0; // User success
                }
            }

            Console.WriteLine("\nInvalid username or password.");
            Console.ReadKey();
            return 1; // Failure
        }

        static void Main(string[] args)
        {
            Header();
            while (true)
            {
                int choice = Account();

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;
                    case 2:
                        LogIn();
                        break;
                    case 3:
                        Console.WriteLine("\nExiting...");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
