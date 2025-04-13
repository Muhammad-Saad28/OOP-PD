using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PD8.UI
{
    internal class Student
    {
        public void student()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Program: ");
            string program = Console.ReadLine();
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Fee: ");
            double fee = double.Parse(Console.ReadLine());
            BL.Student student = new BL.Student(name , address , program , year,fee);
            student.setProgram("CS");
            string getProgram = student.getProgram();
            Console.WriteLine("After geting program:" +  getProgram);
            student.setFee(1000);
            double getfee = student.getFee();
            Console.WriteLine("After getting fee: " + getfee);
            student.setYear(2024);
            int getyear = student.getYear();
            Console.WriteLine("After getting Year: " + getyear);

            Console.WriteLine("To String !!\n");
            string studentline = student.tostring();
            Console.WriteLine(studentline);
        }
    }
}
