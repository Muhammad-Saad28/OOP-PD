using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.Person person = new UI.Person();
            person.getPersonInfo();
            
            UI.Student student = new UI.Student();
            student.student();

            UI.Staff staff = new UI.Staff();
            staff.StaffInfo();



        }
    }
}
