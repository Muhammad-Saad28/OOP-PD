using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Stats
    {
        public string name;
        public float damage;
        public string description;
        public float penetration;
        public int cost;
        public int heal;


        public Stats(string name, float damage, float penetration, int heal, int cost, string description)
        {
            this.name = name;
            this.damage = damage;
            this.penetration = penetration;
            this.cost = cost;
            this.heal = heal;
            this.description = description;
        }
    }
}
