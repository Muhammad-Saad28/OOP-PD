using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ninja_Hunt
{
    class Enemy
    {
        public int ex, ey;
        public Random random = new Random();
        public Enemy(int startX, int startY)
        {
            ex = startX;
            ey = startY;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintAt(ex, ey, "(o)");
            PrintAt(ex, ey + 1, " |");
            PrintAt(ex, ey + 2, "/ \\");
            Console.ResetColor();
        }

        public void Erase()
        {
            PrintAt(ex, ey, "   ");
            PrintAt(ex, ey + 1, "   ");
            PrintAt(ex, ey + 2, "   ");
        }

        public void MoveRandom(char[,] maze)
        {
            Erase();
            int direction = random.Next(1, 5);
            switch (direction)
            {
                case 1: 
                    if (GetCharAt(ex, ey - 1, maze) != '#') 
                        ey -= 1; break; 
                case 2: if (GetCharAt(ex, ey + 1, maze) != '#') ey += 1; break; 
                case 3: if (GetCharAt(ex - 1, ey, maze) != '#') ex -= 1; break; 
                case 4: if (GetCharAt(ex + 1, ey, maze) != '#') ex += 1; break; 
            }
            RestrictToMazeBounds();
            Draw();
        }

        public void RestrictToMazeBounds()
        {
            ex = Math.Max(10, Math.Min(ex, 75));
            ey = Math.Max(5, Math.Min(ey, 30));
        }

        public char GetCharAt(int x, int y, char[,] maze)
        {
            if (x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1))
            {
                return maze[x, y];
            }
            return ' ';
        }

        public void PrintAt(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }
}