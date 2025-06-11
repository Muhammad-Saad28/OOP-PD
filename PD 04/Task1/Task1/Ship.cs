using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1
{
    internal class Ship
    {
        public string ShipNumber;
        public Angle ShipLocation1;
        public Angle ShipLocation2;
        public Ship(string shipnumber, int degree, float minutes, char direction, int degree1, float minutes1, char direction1)
        {
            this.ShipNumber = shipnumber;
            this.ShipLocation1 = new Angle(degree, minutes, direction);
            this.ShipLocation2 = new Angle(degree1, minutes1, direction);
        }

        public Ship(int degree, float minutes, char direction, int degree1, float minutes1, char direction1)
        {
            ShipLocation1 = new Angle(degree, minutes, direction);
            ShipLocation2 = new Angle(degree1, minutes1, direction);
        }
    }
}
