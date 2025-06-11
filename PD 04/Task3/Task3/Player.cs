
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Player
    {
        public float HP;
        public int maxHP;
        public int energy;
        public int maxEnergy;
        public float armor;
        public string name;
        public Stats skillStat;

        public Player(string name, float HP, int energy, int armor)
        {
            this.name = name;
            this.HP = HP;
            this.energy = energy;
            this.armor = armor;
        }

        public string attack(Player p1)
        {
            if (skillStat == null)
            {
                return name + " has no skill assigned!";
            }

            string output = "";
            if (skillStat.cost > energy)
            {
                output = name + " attempted to use " + skillStat.name + ", but didn't have enough energy!";
            }
            else
            {
                float effectiveval = p1.armor - skillStat.penetration;
                float damage = skillStat.damage * ((100 - effectiveval) / 100);
                energy = energy - skillStat.cost;
                output = name + " used skill " + skillStat.name + ", " + skillStat.description + ", against " + p1.name + ", doing " + damage + " damage!";
                if (skillStat.heal != 0)
                {
                    output += "\n" + name + " healed for " + skillStat.heal + " health";
                }
                if (p1.HP - damage <= 0)
                {
                    output += "\n" + p1.name + " died!";
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
            skillStat = ss;
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

