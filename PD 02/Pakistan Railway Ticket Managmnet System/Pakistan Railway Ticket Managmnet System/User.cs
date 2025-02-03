using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakistan_Railway_Ticket_Managmnet_System
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            SaveUser();
        }
        private void SaveUser()
        {
            using (StreamWriter writer = new StreamWriter("E:\\University\\Semester 2\\OOP lab\\Project\\Pakistan Railway Ticket Managmnet System\\Pakistan Railway Ticket Managmnet System\\User.txt", append: true))
            {
                writer.WriteLine($"{Username},{Password}");
            }
        }
        public static bool ValidateUsername(string username)
        {
            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidatePassword(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

