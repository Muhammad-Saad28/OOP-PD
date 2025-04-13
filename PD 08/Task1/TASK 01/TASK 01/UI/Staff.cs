using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD8.UI
{
    internal class Staff : Person
    {
        public void StaffInfo()
        {
            Console.Write("Enter Staff Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Staff Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter School: ");
            string school = Console.ReadLine();
            Console.Write("Enter Pay: ");
            double pay = double.Parse(Console.ReadLine());
            BL.Staff staff = new BL.Staff(name , address , school , pay);
            staff.setschool("Educators");
            string Getschool = staff.getschool();
            Console.WriteLine("Chnaged to "+ Getschool);
            staff.setpay(100000);
            double Getpay = staff.getpay();
            Console.Write("Chnaged to " + Getpay);

            Console.Write("To String !!\n");
            string staffline = staff.tostring();
            Console.Write(staffline);   
            

        }
    }
}
