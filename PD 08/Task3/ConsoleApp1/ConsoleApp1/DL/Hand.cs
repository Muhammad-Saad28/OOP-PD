using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DL
{
    public class Hand
    {
        protected List<Card> cards = new List<Card>();

        public void Clear() => cards.Clear();

        public void AddCard(Card card)
        {
            if (card != null)
                cards.Add(card);
        }

        public void RemoveCard(Card card) => cards.Remove(card);

        public void RemoveCard(int position)
        {
            if (position >= 0 && position < cards.Count)
                cards.RemoveAt(position);
        }

        public int GetCardCount() => cards.Count;

        public Card GetCard(int position)
        {
            if (position >= 0 && position < cards.Count)
                return cards[position];
            return null;
        }

        public void SortBySuit()
        {
            cards.Sort((x, y) =>
            {
                if (x.GetSuit() == y.GetSuit())
                    return x.GetValue().CompareTo(y.GetValue());
                return x.GetSuit().CompareTo(y.GetSuit());
            });
        }

        public void SortByValue()
        {
            cards.Sort((x, y) =>
            {
                if (x.GetValue() == y.GetValue())
                    return x.GetSuit().CompareTo(y.GetSuit());
                return x.GetValue().CompareTo(y.GetValue());
            });
        }

        public List<Card> GetCards() => new List<Card>(cards);
    }
}
