using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD8.UI
{
    internal class Person
    {
        public void getPersonInfo()
        {
            Console.Write("Enter Person Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Person Address: ");
            string address = Console.ReadLine();

            BL.Person person = new BL.Person(name, address);

            
            string getName = person.getname();

            Console.Write("Enter Person Address To change: ");
            string changeaddress = Console.ReadLine();

            person.setaddress(changeaddress);
            string getAddress = person.getaddress();
            Console.WriteLine(getName + " Address is " + getAddress);

            string personline = person.tostring();
            Console.Write("To String !!\n");
            Console.WriteLine(personline);

        }
    }
}
