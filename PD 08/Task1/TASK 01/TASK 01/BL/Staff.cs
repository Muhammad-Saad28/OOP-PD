using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD8.BL
{
    internal class Staff : Person
     {

        private string school;
        private double pay;

        public Staff (string name , string address , string school , double pay) : base (name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string getschool()
        {
            return school;
        }
        public double getpay()
        {
            return pay;
        }
        public void setschool(string school)
        {
            this.school = school;
        }
        public void setpay(double pay)
        {
            this.pay = pay;
        }

        public new string tostring()
        {
            string line = base.tostring();
            return line + school + pay; 
        }
        
    }
}
