using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ninja_Hunt
{
    public class Game
    {
        Player player;
        Enemy enemy1, enemy2;
        char[,] maze;

        public Game()
        {
            player = new Player(5, 5);
            enemy1 = new Enemy(20, 10);
            enemy2 = new Enemy(40, 15);
            maze = new char[120, 40];
            InitializeMaze();
        }
        public void InitializeMaze()
        {
            string[] mazeLines = {
                "####################################################################################################################",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                              ____|",
                "|                                                                                                             |    |",
                "|                                                                                                             |    |",
                "|                                                                                                             |    |",
                "|                                              ####################################################################|",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|####################################                                               ###############################|",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "|                                                                                                                  |",
                "####################################################################################################################"
            };

            for (int y = 0; y < mazeLines.Length; y++)
            {
                for (int x = 0; x < mazeLines[y].Length; x++)
                {
                    maze[x, y] = mazeLines[y][x];
                }
            }
        }

        private void PrintMaze()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int y = 0; y < 36; y++)
            {
                for (int x = 0; x < 120; x++)
                {
                    Console.Write(maze[x, y]);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }

        public void Run()
        {
            PrintMaze();
            player.Draw();
            enemy1.Draw();
            enemy2.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            player.Move('W', maze);
                            break;
                        case ConsoleKey.DownArrow:
                            player.Move('S', maze);
                            break;
                        case ConsoleKey.LeftArrow:
                            player.Move('A', maze);
                            break;
                        case ConsoleKey.RightArrow:
                            player.Move('D', maze);
                            break;
                        case ConsoleKey.Escape:
                            return;
                    }
                }

                enemy1.MoveRandom(maze);
                enemy2.MoveRandom(maze);
                Thread.Sleep(200);
            }
        }
    }
}

