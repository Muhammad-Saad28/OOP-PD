using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Kangaroo = new Player("Kangaroo", 100, 40, 5);
            Player Rabbit = new Player("Rabbit", 50, 20, 4);
            Stats fireball = new Stats("Thuda", 23, 1.2F, 5, 15, "a magical attack");
            Kangaroo.learnSkill(fireball);
            Console.WriteLine(Kangaroo.attack(Rabbit));
            Stats superBeam = new Stats("Mukka", 200, 50, 50, 75, "a cheap attack!!!");
            Rabbit.learnSkill(superBeam);
            Console.WriteLine(Rabbit.attack(Kangaroo));
        }
    }
}
