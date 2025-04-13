using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using ConsoleApp1.UI;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            IBlackjackGameService gameService = new BlackjackGameService();
            ConsoleUI ui = new ConsoleUI(gameService);
            ui.Run();
        }
    }
}