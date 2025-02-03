using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakistan_Railway_Ticket_Managmnet_System
{
    class FeedbackSystem
    {
        private static string feedbackFilePath = "E:\\University\\Semester 2\\OOP lab\\Project\\Pakistan Railway Ticket Managmnet System\\Pakistan Railway Ticket Managmnet System\\Feedback.txt";

        public static void SubmitFeedback()
        {
            Console.Clear();
            Console.WriteLine("\n--- Submit Feedback ---");
            Console.WriteLine("___________________________\n");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your ticket ID: ");
            string ticketID = Console.ReadLine();

            Console.Write("Enter your feedback: ");
            string feedback = Console.ReadLine();

            using (StreamWriter feedbackFile = new StreamWriter(feedbackFilePath, true))
            {
                feedbackFile.WriteLine("Name: " + name);
                feedbackFile.WriteLine("Ticket ID: " + ticketID);
                feedbackFile.WriteLine("Feedback: " + feedback);
                feedbackFile.WriteLine("---------------------------");
            }

            Console.WriteLine("\nThank you for your feedback!");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void ViewFeedback()
        {
            Console.Clear();
            Console.WriteLine("\n--- View Feedback ---");
            Console.WriteLine("_________________________\n");

            if (File.Exists(feedbackFilePath))
            {
                string[] feedbacks = File.ReadAllLines(feedbackFilePath);
                foreach (string line in feedbacks)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No feedback available or file cannot be opened.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static int FeedbackMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--- Feedback ---");
            Console.WriteLine("____________________\n");

            Console.WriteLine("1) Submit Feedback");
            Console.WriteLine("2) View Feedback");
            Console.WriteLine("3) Back to Main Menu");
            Console.Write("\nEnter Your Choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 3))
            {
                Console.Write("Invalid input. Please enter 1, 2, or 3: ");
            }

            return choice;
        }
    }
}
