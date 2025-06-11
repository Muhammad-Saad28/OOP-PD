using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            List<Stats> stats = new List<Stats>();
            int choice;
            do
            {
                Console.Clear();
                Header();
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Header();
                        Player p = Input1();
                        AddPlayer(players, p);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Header();
                        Stats s = Input2();
                        AddStats(stats, s);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Header();
                        Console.Write("Enter Player's Name: ");
                        string name = Console.ReadLine();
                        PlayerInfo(players, name);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Header();
                        Console.Write("Enter Player's Name: ");
                        string playerName = Console.ReadLine();
                        Console.Write("Enter Skill's Name: ");
                        string skillName = Console.ReadLine();
                        AddSkill(players, stats, playerName, skillName);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Enter Attacking Player Name: ");
                        string p1name = Console.ReadLine();
                        Console.Write("Enter Target Player Name: ");
                        string p2name = Console.ReadLine();
                        AttackPlayer(players, stats, p1name, p2name);
                        Console.ReadKey();
                        break;
                }
            }
            while (choice != 6);

        }

        static void Header()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("          MAGIC DUEL         ");
            Console.WriteLine("*****************************");
        }

        static int Menu()
        {
            int option;
            Console.WriteLine("1.Add Player");
            Console.WriteLine("2.Add Skill Statistics");
            Console.WriteLine("3.Display Player Info");
            Console.WriteLine("4.Learn A Skill");
            Console.WriteLine("5.Attack");
            Console.WriteLine("6.Exit");
            Console.Write("Enter Your Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static Player Input1()
        {
            Console.Write("Enter Player Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Player Health: ");
            float HP = float.Parse(Console.ReadLine());
            Console.Write("Enter Player Energy Level: ");
            int energy = int.Parse(Console.ReadLine());
            Console.Write("Enter Player's Armor Strength: ");
            int armor = int.Parse(Console.ReadLine());
            Player p = new Player(name, HP, energy, armor);
            return p;
        }

        static void AddPlayer(List<Player> players, Player p)
        {
            players.Add(p);
        }

        static Stats Input2()
        {
            Console.Write("Enter Skill Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Skill Damage: ");
            float damage = float.Parse(Console.ReadLine());
            Console.Write("Enter Skill Penetration: ");
            float penetration = float.Parse(Console.ReadLine());
            Console.Write("Enter Heal Amount Of Skill: ");
            int heal = int.Parse(Console.ReadLine());
            Console.Write("Enter Cost Of This Skill: ");
            int cost = int.Parse(Console.ReadLine());
            Console.Write("Enter Description Of Skill: ");
            string description = Console.ReadLine();
            Stats s = new Stats(name, damage, penetration, heal, cost, description);
            return s;
        }

        static void AddStats(List<Stats> stats, Stats s)
        {
            stats.Add(s);
        }

        static void PlayerInfo(List<Player> players, string name)
        {
            foreach (Player p in players)
            {
                if (name == p.name)
                {
                    Console.WriteLine("Player's Name: " + p.name);
                    Console.WriteLine("Player's HP: " + p.HP);
                    Console.WriteLine("Player;s Energy Level: " + p.energy);
                    Console.WriteLine("Player's Armor Strength: " + p.armor);
                }
            }
        }

        static void AddSkill(List<Player> players, List<Stats> stats, string playerName, string skillName)
        {
            foreach (Player p in players)
            {
                if (playerName == p.name)
                {
                    foreach (Stats s in stats)
                    {
                        if (skillName == s.name)
                        {
                            p.learnSkill(s);
                        }
                    }
                }
            }
        }

        static void AttackPlayer(List<Player> players, List<Stats> stats, string p1name, string p2name)
        {
            Player attacker = null, target = null;
            foreach (Player player in players)
            {
                if (p1name == player.name)
                {
                    attacker = player;
                }
                if (p2name == player.name)
                {
                    target = player;
                }
            }
            Console.WriteLine(attacker.attack(target));
        }
    }
}
