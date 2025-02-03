using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ninja_Hunt
{
    public class Player
    {
        public int px, py;

        public Player(int startX, int startY)
        {
            px = startX;
            py = startY;
        }
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            PrintAt(px, py, "(0-0)");
            PrintAt(px, py + 1, "/|_|\\");
            PrintAt(px, py + 2, " / \\");
            Console.ResetColor();
        }
        public void Erase()
        {
            PrintAt(px, py, "     ");
            PrintAt(px, py + 1, "     ");
            PrintAt(px, py + 2, "     ");
        }
        public void Move(char direction, char[,] maze)
        {
            Erase();
            switch (direction)
            {
                case 'W': if (GetCharAt(px, py - 1, maze) != '#') py -= 1; break;
                case 'S': if (GetCharAt(px, py + 1, maze) != '#') py += 1; break;
                case 'A': if (GetCharAt(px - 1, py, maze) != '#') px -= 1; break;
                case 'D': if (GetCharAt(px + 1, py, maze) != '#') px += 1; break;
            }
            RestrictToMazeBounds();
            Draw();
        }
        public void RestrictToMazeBounds()
        {
            px = Math.Max(1, Math.Min(px, 110));
            py = Math.Max(2, Math.Min(py, 32));
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