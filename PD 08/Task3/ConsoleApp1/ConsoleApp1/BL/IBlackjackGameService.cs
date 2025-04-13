using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.DL;

namespace ConsoleApp1.BL
{
    public interface IBlackjackGameService
    {
        void StartNewGame();
        void PlayerHit();
        void PlayerStand();
        bool IsGameOver();
        BlackjackHand GetPlayerHand();
        BlackjackHand GetDealerHand();
        bool IsPlayerBusted();
        bool IsDealerBusted();
        bool IsBlackjack();
        string DetermineWinner();
    }
}
