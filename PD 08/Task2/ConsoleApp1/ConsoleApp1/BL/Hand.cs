using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    using System.Collections.Generic;

    namespace CardGame.BusinessLogic
    {
        public class Hand
        {
            private readonly List<Card> cards = new List<Card>();

            public void Clear()
            {
                cards.Clear();
            }

            public void AddCard(Card c)
            {
                if (c != null)
                {
                    cards.Add(c);
                }
            }

            public void RemoveCard(Card c)
            {
                cards.Remove(c);
            }

            public void RemoveCard(int position)
            {
                if (position >= 0 && position < cards.Count)
                {
                    cards.RemoveAt(position);
                }
            }

            public int GetCardCount() => cards.Count;

            public Card GetCard(int position)
            {
                if (position >= 0 && position < cards.Count)
                {
                    return cards[position];
                }
                return null;
            }

            public void SortBySuit()
            {
                cards.Sort((x, y) =>
                {
                    if (x.GetSuit() == y.GetSuit())
                    {
                        return x.GetValue().CompareTo(y.GetValue());
                    }
                    return x.GetSuit().CompareTo(y.GetSuit());
                });
            }

            public void SortByValue()
            {
                cards.Sort((x, y) =>
                {
                    if (x.GetValue() == y.GetValue())
                    {
                        return x.GetSuit().CompareTo(y.GetSuit());
                    }
                    return x.GetValue().CompareTo(y.GetValue());
                });
            }
        }
    }
}
