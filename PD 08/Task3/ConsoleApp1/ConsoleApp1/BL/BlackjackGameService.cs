using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.DL;

namespace ConsoleApp1.BL
{
    public class BlackjackGameService : IBlackjackGameService
    {
        private Deck deck;
        private BlackjackHand playerHand;
        private BlackjackHand dealerHand;
        private bool playerStood;
        private bool gameOver;

        public BlackjackGameService()
        {
            deck = new Deck();
            playerHand = new BlackjackHand();
            dealerHand = new BlackjackHand();
        }

        public void StartNewGame()
        {
            deck = new Deck();
            deck.Shuffle();

            playerHand.Clear();
            dealerHand.Clear();

            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());

            playerStood = false;
            gameOver = false;
        }

        public void PlayerHit()
        {
            if (!gameOver)
            {
                playerHand.AddCard(deck.DealCard());

                if (playerHand.GetBlackjackValue() > 21)
                {
                    gameOver = true;
                }
            }
        }

        public void PlayerStand()
        {
            if (!gameOver)
            {
                playerStood = true;
                DealerPlay();
                gameOver = true;
            }
        }

        private void DealerPlay()
        {
            while (dealerHand.GetBlackjackValue() < 17)
            {
                dealerHand.AddCard(deck.DealCard());
            }
        }

        public bool IsGameOver() => gameOver;
        public BlackjackHand GetPlayerHand() => playerHand;
        public BlackjackHand GetDealerHand() => dealerHand;

        public bool IsPlayerBusted() => playerHand.GetBlackjackValue() > 21;
        public bool IsDealerBusted() => dealerHand.GetBlackjackValue() > 21;

        public bool IsBlackjack()
        {
            return playerHand.GetCardCount() == 2 && playerHand.GetBlackjackValue() == 21;
        }

        public string DetermineWinner()
        {
            int playerValue = playerHand.GetBlackjackValue();
            int dealerValue = dealerHand.GetBlackjackValue();

            if (playerValue > 21)
            {
                return "Dealer wins - Player busted!";
            }
            else if (dealerValue > 21)
            {
                return "Player wins - Dealer busted!";
            }
            else if (playerValue == dealerValue)
            {
                return "Push (tie).";
            }
            else if (playerValue > dealerValue)
            {
                return "Player wins!";
            }
            else
            {
                return "Dealer wins!";
            }
        }
    }
}
