using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.BL;
using ConsoleApp1.DL;

namespace ConsoleApp1.UI
{
    public class ConsoleUI
    {
        private readonly IBlackjackGameService gameService;

        public ConsoleUI(IBlackjackGameService gameService)
        {
            this.gameService = gameService;
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("BLACKJACK GAME");
                Console.WriteLine("1. Play Blackjack");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    PlayGame();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (input == "2")
                {
                    break;
                }
            }
        }

        private void PlayGame()
        {
            gameService.StartNewGame();

            while (!gameService.IsGameOver())
            {
                Console.Clear();
                DisplayGameState();

                if (gameService.IsBlackjack())
                {
                    Console.WriteLine("Blackjack! You got 21!");
                    break;
                }

                Console.Write("\nDo you want to (H)it or (S)tand? ");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "H")
                {
                    gameService.PlayerHit();
                }
                else if (choice == "S")
                {
                    gameService.PlayerStand();
                }
            }

            Console.Clear();
            DisplayFinalResult();
        }

        private void DisplayGameState()
        {
            Console.WriteLine("Your cards:");
            PrintHand(gameService.GetPlayerHand());
            Console.WriteLine($"Your total: {gameService.GetPlayerHand().GetBlackjackValue()}");

            Console.WriteLine("\nDealer's showing:");
            Console.WriteLine(gameService.GetDealerHand().GetCard(0).ToString());
            Console.WriteLine("[Hidden card]");
        }

        private void DisplayFinalResult()
        {
            Console.WriteLine("Final Results:");
            Console.WriteLine("\nYour cards:");
            PrintHand(gameService.GetPlayerHand());
            Console.WriteLine($"Your total: {gameService.GetPlayerHand().GetBlackjackValue()}");

            Console.WriteLine("\nDealer's cards:");
            PrintHand(gameService.GetDealerHand());
            Console.WriteLine($"Dealer's total: {gameService.GetDealerHand().GetBlackjackValue()}");

            Console.WriteLine($"\n{gameService.DetermineWinner()}");
        }

        private void PrintHand(BlackjackHand hand)
        {
            foreach (Card card in hand.GetCards())
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}
