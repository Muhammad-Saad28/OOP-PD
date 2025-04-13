using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD8.BL
{
    internal class Person
    {


        protected string name;
        protected string address;




        public Person()
        {
        
        }
        public Person(string name , string address)
            {
                this.name = name;
            this.address = address; 
            }
        
        public string tostring()
        {
            string line = name + address;
            return line;
        }
        public string getname()
        {
            return name;
             
        }

        public string getaddress()
        {
            return address;

        }

        public void setaddress(string address)
        {
            this.address = address;
            
        }
    }


}
