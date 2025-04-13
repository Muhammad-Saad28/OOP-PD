using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    namespace CardGame.BusinessLogic
    {
        public class Card
        {
            private readonly int value;
            private readonly int suit;

            public Card(int value, int suit)
            {
                this.value = value;
                this.suit = suit;
            }

            public int GetValue() => value;
            public int GetSuit() => suit;

            public string GetValueAsString()
            {
                switch (value)
                {
                    case 1:
                        return "Ace";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    default:
                        return value.ToString();
                }
            }

            public string GetSuitAsString()
            {
                switch (suit)
                {
                    case 1:
                        return "Clubs";
                    case 2:
                        return "Diamonds";
                    case 3:
                        return "Spades";
                    case 4:
                        return "Hearts";
                    default:
                        return "Unknown";
                }
            }

            public override string ToString()
            {
                return $"{GetValueAsString()} of {GetSuitAsString()}";
            }
        }
    }
}