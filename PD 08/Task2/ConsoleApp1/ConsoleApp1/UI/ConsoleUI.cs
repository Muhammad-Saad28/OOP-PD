using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI
{
    using System;
    using ConsoleApp1.UI.CardGame;
    using ConsoleApp1.BL.CardGame.BusinessLogic;

    namespace CardGame.Presentation
    {
        public class HighLowGame
        {
            private readonly Deck deck;
            private int score;
            private Card currentCard;

            public HighLowGame()
            {
                deck = new Deck();
                score = 0;
            }

            public void StartGame()
            {
                deck.Shuffle();
                currentCard = deck.DealCard();
                PlayRound();
            }

            private void PlayRound()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("***********");
                    Console.WriteLine(currentCard.ToString());
                    Console.WriteLine("***********");
                    Console.WriteLine($"Remaining cards: {deck.CardsLeft()}");
                    Console.WriteLine($"Current score: {score}");
                    Console.WriteLine("1. Next card will be higher");
                    Console.WriteLine("2. Next card will be lower");
                    Console.WriteLine("3. Exit game");

                    if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 3)
                    {
                        Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                        Console.ReadKey();
                        continue;
                    }

                    if (choice == 3)
                    {
                        Console.WriteLine($"Game ended. Your final score: {score}");
                        return;
                    }

                    Card nextCard = deck.DealCard();
                    if (nextCard == null)
                    {
                        Console.WriteLine("No more cards in the deck!");
                        Console.WriteLine($"Final score: {score}");
                        return;
                    }

                    bool isCorrect = false;
                    if (choice == 1)
                    {
                        isCorrect = nextCard.GetValue() >= currentCard.GetValue();
                    }
                    else if (choice == 2)
                    {
                        isCorrect = nextCard.GetValue() < currentCard.GetValue();
                    }

                    if (isCorrect)
                    {
                        score++;
                        currentCard = nextCard;
                        Console.WriteLine($"Correct! The card was: {nextCard}");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, you lose! The card was: {nextCard}");
                        Console.WriteLine($"Final score: {score}");
                        return;
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
