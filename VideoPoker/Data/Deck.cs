using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoPoker
{
    public static class Deck
    {
        public static List<Card> deck;

        public static void newDeck()
        {
            deck = new List<Card>();
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(Value value in Enum.GetValues(typeof(Value)))
                {
                    deck.Add(new Card(suit, value));
                }
            }
        }

        public static List<Card> dealHand(List<Card> hand)
        {
            Random random = new Random();
            int index;
            while(hand.Count < 5)
            {
                index = random.Next(deck.Count);
                hand.Add(deck[index]);
                deck.RemoveAt(index);
            }
            return hand;
        }

        public static List<Card> changeCards(List<Card> hand, List<int> indexes)
        {
            foreach (int index in indexes.OrderByDescending(v => v))
            {
                hand.RemoveAt(index-1);
            }
            return dealHand(hand);
        }
    }
}