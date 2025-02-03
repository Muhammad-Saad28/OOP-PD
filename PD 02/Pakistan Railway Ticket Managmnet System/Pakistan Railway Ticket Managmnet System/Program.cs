using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakistan_Railway_Ticket_Managmnet_System
{
    class Program
    {
        //Lists
        static List<string> stations = new List<string> { };
                
        static void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        static void Main()
        {
            int isAuthenticated = 1;
            bool condition = true;

            int admin, user;

            while (condition)
            {
                Authentication.Header();
                Console.WriteLine("\n1) Create Account");
                Console.WriteLine("2) Log In");
                Console.WriteLine("3) Exit");
                Console.Write("\nEnter Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Authentication.CreateAccount();
                        break;
                    case "2":
                        isAuthenticated = Authentication.LogIn();
                        if (isAuthenticated == 1)
                        {
                            condition = false;
                            Console.WriteLine("Login failed. Exiting...");
                        }
                        else if (isAuthenticated == 2)
                        {
                            admin = AdminMenu();
                            AdminPanel(admin);
                        }
                        else if (isAuthenticated == 0)
                        {
                            user = userMenu();
                            UserPanel(user);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
        public static int AdminMenu()
        {
            int choice;
            Console.Clear();
            Authentication.Header();
            SetColor(ConsoleColor.Green);
            Console.WriteLine("Admin Panel");
            Console.WriteLine("___________");
            SetColor(ConsoleColor.Gray);
            Console.WriteLine();

            Console.WriteLine("1) Add Station...");
            Console.WriteLine("2) Delete Station...");
            Console.WriteLine("3) Update Station...");
            Console.WriteLine("4) View Station...");
            Console.WriteLine();
            Console.WriteLine("5) Add Train...");
            Console.WriteLine("6) Delete Train...");
            Console.WriteLine("7) Update Train...");
            Console.WriteLine("8) View All Trains...");
            Console.WriteLine("9) Update Train Time...");
            Console.WriteLine("10) View All Train Times...");
            Console.WriteLine();
            Console.WriteLine("11) Go Back...");
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");
            string input = Console.ReadLine();
            choice = int.Parse(input);

            return choice;
        }
        public static void AdminPanel(int choice)
        {
            while (true) 
            {
                switch (choice)
                {
                    case 1:
                        AddStation();
                        break;
                    case 2:
                        DeleteStation();
                        break;
                    case 3:
                        UpdateStation();
                        break;
                    case 4:
                        ViewStationsAdmin();
                        break;
                    case 5:
                        AddTrain();
                        break;
                    case 6:
                        DeleteTrain();
                        break;
                    case 7:
                        UpdateTrain();
                        break;
                    case 8:
                        ViewTrainsAdmin();
                        break;
                    case 9:
                        UpdateTrainTimes();
                        break;
                    case 10:
                        ViewTrainTimesAdmin();
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }
                choice = AdminMenu();
            }
        }
        public static void AddStation()
        {
            Console.Clear();
            Authentication.Header();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Admin Panel > Add Station");
            Console.WriteLine("__________________________");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Current Stations: ");
            Console.WriteLine("----------------------------");

            // Display existing stations
            if (stations.Count > 0)
            {
                for (int i = 0; i < stations.Count; i++)
                {
                    Console.WriteLine($"Station {i + 1}: \t{stations[i]}");
                }
            }
            else
            {
                Console.WriteLine("No stations available.");
            }

            Console.WriteLine();
            Console.Write("Enter the name of the station you want to add: ");
            string stationName = Console.ReadLine();

            if (!string.IsNullOrEmpty(stationName))
            {
                stations.Add(stationName);  
                Console.WriteLine("\nStation added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid station name. Please try again.");
            }

            Console.WriteLine("\nUpdated Stations: ");
            Console.WriteLine("----------------------------");

            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"Station {i + 1}: \t{stations[i]}");
            }

            Console.ReadKey();
        }
        public static void DeleteStation()
        {
            Console.Clear();
            Authentication.Header();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Admin Panel > Delete Station");
            Console.WriteLine("_____________________________");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Station Number \tStation Name");
            Console.WriteLine("----------------------------");

            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"Station {i + 1}: \t{stations[i]}");
            }

            Console.WriteLine();
            Console.Write("Enter the number of the station you want to delete: ");
            int numberOfStations = int.Parse(Console.ReadLine());  
            if (numberOfStations > 0 && numberOfStations <= stations.Count)
            {
                stations.RemoveAt(numberOfStations - 1); 
                Console.WriteLine();

                Console.WriteLine("Station Number \tStation Name");
                Console.WriteLine("----------------------------");
                for (int i = 0; i < stations.Count; i++)
                {
                    Console.WriteLine($"Station {i + 1}: \t{stations[i]}");
                }
            }
            else
            {
                Console.WriteLine("Invalid station number. Try again.");
            }

            Console.ReadKey();
        }
        public static void UpdateStation()
        {
            Console.Clear();
            Authentication.Header();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Admin Panel > Update Station");
            Console.WriteLine("_____________________________");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Station Number \tStation Name");
            Console.WriteLine("----------------------------");

            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"Station {i + 1}: \t{stations[i]}");
            }

            Console.WriteLine();
            Console.Write("Enter the number of the station you want to update: ");
            int numberOfStations = int.Parse(Console.ReadLine());  
            if (numberOfStations > 0 && numberOfStations <= stations.Count)
            {
                Console.WriteLine();
                Console.Write("Enter new Station name: ");
                string stationName = Console.ReadLine();
                stations[numberOfStations - 1] = stationName; 
                Console.WriteLine();

                Console.WriteLine("Station Number \tStation Name");
                Console.WriteLine("----------------------------");
                for (int i = 0; i < stations.Count; i++)
                {
                    Console.WriteLine($"Station {i + 1}: \t{stations[i]}");
                }
            }
            else
            {
                Console.WriteLine("Invalid station number. Try again.");
            }

            Console.ReadKey();
        }
        public static void ViewStationsAdmin()
        {
            Console.Clear();
            Authentication.Header();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Admin Panel > View Stations");
            Console.WriteLine("___________________________");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Station Number \tStation Name");
            Console.WriteLine("----------------------------");

            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"Station {i + 1}: \t{stations[i]}");
            }

            Console.ReadKey();
        }
        public static void AddTrain()
        {
            Console.WriteLine("Add Train functionality not implemented yet.");
        }
        public static void DeleteTrain()
        {
            Console.WriteLine("Delete Train functionality not implemented yet.");
        }
        public static void UpdateTrain()
        {
            Console.WriteLine("Update Train functionality not implemented yet.");
        }
        public static void ViewTrainsAdmin()
        {
            Console.WriteLine("View Trains functionality not implemented yet.");
        }
        public static void UpdateTrainTimes()
        {
            Console.WriteLine("Update Train Times functionality not implemented yet.");
        }
        public static void ViewTrainTimesAdmin()
        {
            Console.WriteLine("View Train Times functionality not implemented yet.");
        }
        public static void UserPanel(int choice)
        {
            while (true) 
            {
                switch (choice)
                {
                    case 1:
                        ViewStations();
                        break;
                    case 2:
                        ViewTrains();
                        break;
                    case 3:
                        ViewTrainTimes();
                        break;
                    case 4:
                        BookTicket();
                        break;
                    case 5:
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }
                choice = userMenu();
            }
        }
        public static int userMenu()
        {
            int choice;
            Console.Clear();
            Authentication.Header();
            SetColor(ConsoleColor.Green);
            Console.WriteLine("User Panel");
            Console.WriteLine("___________");
            SetColor(ConsoleColor.Gray);
            Console.WriteLine();

            Console.WriteLine("1) View Station...");
            Console.WriteLine("2) View All Trains...");
            Console.WriteLine("3) View All Train Times...");
            Console.WriteLine();
            Console.WriteLine("4) Book Ticket...");
            Console.WriteLine();
            Console.WriteLine("5) Go Back...");
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");

            string input = Console.ReadLine();
            choice = int.Parse(input);

            return choice;
        }
        public static void ViewStations() 
    { 
        Console.WriteLine("View Stations functionality not implemented yet."); 
    }
        public static void ViewTrains() 
    { 
        Console.WriteLine("View Trains functionality not implemented yet.");
    }
        public static void ViewTrainTimes() 
    { 
        Console.WriteLine("View Train Times functionality not implemented yet."); 
    }
        public static void BookTicket() 
    { 
        Console.WriteLine("Book Ticket functionality not implemented yet."); 
    }
    }
}
