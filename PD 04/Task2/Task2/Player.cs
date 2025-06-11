using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Player
    {
        public float HP;
        public int maxHP;
        public int energy;
        public int maxEnergy;
        public float armor;
        public string name;
        public Stats skillStats;


        public Player(string name, float HP, int energy, int armor)
        {
            this.name = name;
            this.HP = HP;
            this.energy = energy;
            this.armor = armor;
        }

        public string attack(Player p1)
        {
            string output = "";


            if (skillStats.cost > energy)
            {
                output = name + " attempted to use " + skillStats.name + ", but didn't have enough energy!";
            }
            else
            {
                float effectiveval = p1.armor - skillStats.penetration;
                float damage = skillStats.damage * ((100 - effectiveval) / 100);
                energy = energy - skillStats.cost;
                output = name + " used skill " + skillStats.name + ", " + skillStats.description + ", against " + p1.name + ", doing " + damage + "!";
                if (skillStats.heal != 0)
                {
                    output += "\n" + name + " healed for " + skillStats.heal + " health";
                }
                if (p1.HP - damage <= 0)
                {
                    output += "\n" + p1.name + " dead!";
                }
                else if (p1.HP - damage > 0)
                {
                    p1.HP = p1.HP - damage;
                    output += "\n" + p1.name + " is at " + p1.HP + "% health";
                }
            }
            return output;

        }

        public void learnSkill(Stats ss)
        {
            skillStats = ss;
        }

        public void updateHealth(int hp)
        {
            HP = hp;

        }

        public void updateArmor(int a)
        {
            armor = a;
        }

        public void updateEnergy(int e)
        {
            energy = e;
        }

        public void updateName(string n)
        {
            name = n;
        }

    }
}
