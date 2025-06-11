using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            List<Ship> ships = new List<Ship>();
            while (true) 
            {
                Console.Clear();
                option = Menu();
                if (option == 1)
                {
                    Ship s = TakeInput();
                    ListStore(ships, s);
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter Ship Number: ");
                    string shipNumber = Console.ReadLine();
                    Location(ships, shipNumber);
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.WriteLine("Enter Latitude's Degree: ");
                    int degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Minutes: ");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Direction: ");
                    char direction = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ship Longitude: ");
                    Console.WriteLine("Enter Longitude's Degree: ");
                    int degree1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Minutes: ");
                    float minutes1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Direction: ");
                    char direction1 = char.Parse(Console.ReadLine());
                    Ship s1 = new Ship(degree, minutes, direction, degree1, minutes1, direction1);
                    Location2(ships, s1);
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.WriteLine("Enter Ship Number: ");
                    string shipNumber = Console.ReadLine();
                    IndexShip(ships, shipNumber);
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    break;
                }
            }
            
        }
        static int Menu()
        {
            int option;
            Console.WriteLine("<===Ship Management System===>");
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter Your Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static Ship TakeInput()
        {
            Console.WriteLine("Enter Ship Number: ");
            string shipNumber = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude: ");
            Console.WriteLine("Enter Latitude's Degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Minutes: ");
            float minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Direction: ");
            char direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.WriteLine("Enter Longitude's Degree: ");
            int degree1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Minutes: ");
            float minutes1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Direction: ");
            char direction1 = char.Parse(Console.ReadLine());
            Ship s = new Ship(shipNumber, degree, minutes, direction, degree1, minutes1, direction1);
            return s;
        }
        static void Location(List<Ship> ships, string shipNumber)
        {
            foreach (Ship ship in ships)
            {
                if (ship.ShipNumber == shipNumber)
                {
                    Console.WriteLine("Ship is at " + ship.ShipLocation1.Degrees + "\u00b0" + ship.ShipLocation1.Minutes + "\'" + ship.ShipLocation1.Direction + " and " + ship.ShipLocation2.Degrees + "\u00b0" + ship.ShipLocation2.Minutes + "\'" + ship.ShipLocation2.Direction);
                }
            }
        }

        static void IndexShip(List<Ship> ships, string shipNumber)
        {
            foreach (Ship ship in ships)
            {
                if (ship.ShipNumber == shipNumber)
                {
                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.WriteLine("Enter Latitude's Degree: ");
                    int degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Minutes: ");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Direction: ");
                    char direction = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ship Longitude: ");
                    Console.WriteLine("Enter Longitude's Degree: ");
                    int degree1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Minutes: ");
                    float minutes1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Direction: ");
                    char direction1 = char.Parse(Console.ReadLine());
                    Angle shipLocation1 = new Angle(degree, minutes, direction);
                    Angle shipLocation2 = new Angle(degree1, minutes1, direction1);
                    ship.ShipLocation1 = shipLocation1;
                    ship.ShipLocation2 = shipLocation2;
                }

            }
        }

        static void Location2(List<Ship> ships, Ship s1)
        {
            foreach (Ship ship in ships)
            {
                if (ship.ShipLocation1.Degrees == s1.ShipLocation1.Degrees && ship.ShipLocation1.Minutes == s1.ShipLocation1.Minutes && ship.ShipLocation1.Direction == s1.ShipLocation1.Direction && ship.ShipLocation2.Degrees == s1.ShipLocation2.Degrees && ship.ShipLocation2.Minutes == s1.ShipLocation2.Minutes && ship.ShipLocation2.Direction == s1.ShipLocation2.Direction)
                {
                    Console.WriteLine("Ship's Serial Number is: " + ship.ShipNumber);
                }

            }

        }

        static void ListStore(List<Ship> ships, Ship s)
        {
            ships.Add(s);
        }
    }
}