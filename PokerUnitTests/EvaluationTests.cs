using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VideoPoker;

namespace PokerUnitTests
{
    [TestClass]
    public class EvaluationTests
    {
        [TestMethod]
        public void TestTwoPair()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Five));
            hand.Add(new Card(Suit.Diamonds, Value.Four));
            hand.Add(new Card(Suit.Clubs, Value.King));
            hand.Add(new Card(Suit.Spades, Value.Five));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Two Pair! Your Prize: 2", actual);
        }

        [TestMethod]
        public void TestRoyalFlush()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Queen));
            hand.Add(new Card(Suit.Spades, Value.Ten));
            hand.Add(new Card(Suit.Spades, Value.Jack));
            hand.Add(new Card(Suit.Spades, Value.King));
            hand.Add(new Card(Suit.Spades, Value.Ace));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Royal Flush! Your Prize: 800", actual);
        }

        [TestMethod]
        public void TestFlush()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Queen));
            hand.Add(new Card(Suit.Spades, Value.Nine));
            hand.Add(new Card(Suit.Spades, Value.Five));
            hand.Add(new Card(Suit.Spades, Value.King));
            hand.Add(new Card(Suit.Spades, Value.Ace));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Flush! Your Prize: 6", actual);
        }

        [TestMethod]
        public void TestStraightFlush()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));
            hand.Add(new Card(Suit.Spades, Value.Seven));
            hand.Add(new Card(Suit.Spades, Value.Five));
            hand.Add(new Card(Suit.Spades, Value.Six));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Straight Flush! Your Prize: 50", actual);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Diamonds, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Eight));
            hand.Add(new Card(Suit.Hearts, Value.Eight));
            hand.Add(new Card(Suit.Clubs, Value.Ace));
            hand.Add(new Card(Suit.Spades, Value.Ace));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Full House! Your Prize: 9", actual);
        }

        [TestMethod]
        public void TestStraight()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));
            hand.Add(new Card(Suit.Diamonds, Value.Seven));
            hand.Add(new Card(Suit.Hearts, Value.Five));
            hand.Add(new Card(Suit.Spades, Value.Six));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Straight! Your Prize: 4", actual);
        }

        [TestMethod]
        public void TestThree()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Clubs, Value.Nine));
            hand.Add(new Card(Suit.Diamonds, Value.Seven));
            hand.Add(new Card(Suit.Hearts, Value.Nine));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Three of a Kind! Your Prize: 3", actual);
        }

        [TestMethod]
        public void TestFour()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));
            hand.Add(new Card(Suit.Diamonds, Value.Eight));
            hand.Add(new Card(Suit.Hearts, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Eight));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Four of a Kind! Your Prize: 25", actual);
        }

        [TestMethod]
        public void TestJacksPair()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Clubs, Value.Queen));
            hand.Add(new Card(Suit.Spades, Value.Nine));
            hand.Add(new Card(Suit.Diamonds, Value.Queen));
            hand.Add(new Card(Suit.Hearts, Value.Five));
            hand.Add(new Card(Suit.Spades, Value.Six));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("Jacks or Better! Your prize: 1", actual);
        }

        [TestMethod]
        public void TestNothing()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Clubs, Value.Queen));
            hand.Add(new Card(Suit.Spades, Value.Nine));
            hand.Add(new Card(Suit.Diamonds, Value.King));
            hand.Add(new Card(Suit.Hearts, Value.Five));
            hand.Add(new Card(Suit.Spades, Value.Six));

            string actual = evaluator.evaluateHand(hand);

            Assert.AreEqual("You do not have anything. Better luck next time. Your Prize: 0", actual);
        }
    }
}
