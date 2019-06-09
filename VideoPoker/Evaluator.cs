using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VideoPoker
{
    public class Evaluator
    {
        public Evaluator()
        {

        }

        public string evaluateHand(List<Card> hand)
        {
            if(isPair(hand))
            {
                if(isTwoKinds(hand))
                {
                    if(isFullHouse(hand))
                    {
                        return "Full House! Your Prize: 9";
                    }
                    return "Four of a Kind! Your Prize: 25";
                }
                else if(isThree(hand))
                {
                    return "Three of a Kind! Your Prize: 3";
                }
                else if(isTwoPair(hand))
                {
                    return "Two Pair! Your Prize: 2";
                }
                else if(isJackPair(hand))
                {
                    return "Jacks or Better! Your prize: 1";
                }
                else
                {
                    return "You do not have anything. Better luck next time. Your Prize: 0";
                }
            }
            else
            {
                if (isFlush(hand))
                {
                    if (isStraight(hand))
                    {
                        if (isRoyal(hand))
                        {
                            return "Royal Flush! Your Prize: 800";
                        }
                        return "Straight Flush! Your Prize: 50";
                    }
                    return "Flush! Your Prize: 6";
                }
                else if (isStraight(hand))
                {
                    return "Straight! Your Prize: 4";
                }
                else
                {
                    return "You do not have anything. Better luck next time. Your Prize: 0";
                }
            }
        }

        public bool isPair(List<Card> hand)
        {
            return hand.GroupBy(c => c.value).Count() < 5;
        }

        public bool isFlush(List<Card> hand)
        {
            return hand.GroupBy(c => c.suit).Count() == 1;
        }

        public bool isStraight(List<Card> hand)
        {
            List<Card> orderedHand = hand.OrderBy(c => c.value).ToList();
            for (int i = 1; i < hand.Count; i++)
            {
                if((orderedHand[i-1].value + 1) != orderedHand[i].value)
                return false;
            }
            return true;
        }

        public bool isRoyal(List<Card> hand)
        {
            List<Card> orderedHand = hand.OrderBy(c => c.value).ToList();
            return (orderedHand[0].value == Value.Ten && orderedHand[hand.Count-1].value == Value.Ace);
        }

        public bool isTwoKinds(List<Card> hand)
        {
            return (hand.GroupBy(c => c.value).Count() == 2);
        }

        public List<int> valueCount(List<Card> hand)
        {
            List<int> count = hand.GroupBy(c => c.value).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Value).Select(c => c.Value).ToList();
            return count;
        }

        public bool isFullHouse(List<Card> hand)
        {
            List<int> count = valueCount(hand);
            return (count[0] == 3 && count[1] == 2);
        }

        public bool isThree(List<Card> hand)
        {
            List<int> count = valueCount(hand);
            return count[0] == 3;
        }

        public bool isJackPair(List<Card> hand)
        {
            var values = hand.GroupBy(c => c.value).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Value).ToList();
            return ((values[0].Value == 2) && (values[0].Key > Value.Ten));
        }

        public bool isTwoPair(List<Card> hand)
        {
            List<int> count = valueCount(hand);
            return count[0] == 2 && count[1] == 2;
        }
    }
}
