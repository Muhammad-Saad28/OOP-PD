using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    using System;

    namespace CardGame.BusinessLogic
    {
        public class Deck
        {
            private int count;
            private readonly Card[] deck = new Card[52];

            public Deck()
            {
                count = 0;
                for (int suit = 1; suit <= 4; suit++)
                {
                    for (int value = 1; value <= 13; value++)
                    {
                        deck[count] = new Card(value, suit);
                        count++;
                    }
                }
            }

            public void Shuffle()
            {
                Random rand = new Random();
                for (int i = 0; i < 52; i++)
                {
                    int num = rand.Next(0, 52);
                    Card temp = deck[num];
                    deck[num] = deck[i];
                    deck[i] = temp;
                }
                count = 52;
            }

            public Card DealCard()
            {
                if (count > 0)
                {
                    count--;
                    return deck[count];
                }
                return null;
            }

            public int CardsLeft() => count;
        }
    }
}
