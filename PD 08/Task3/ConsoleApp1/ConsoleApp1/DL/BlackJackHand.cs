using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DL
{
    public class BlackjackHand : Hand
    {
        public int GetBlackjackValue()
        {
            int value = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                int cardValue = card.GetValue();
                if (cardValue == 1) 
                {
                    aceCount++;
                    value += 11;
                }
                else if (cardValue >= 10) 
                {
                    value += 10;
                }
                else
                {
                    value += cardValue;
                }
            }

            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }
    }
}
