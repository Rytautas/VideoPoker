using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VideoPoker;

namespace PokerUnitTests
{
    [TestClass]
    public class EvaluatorTests
    {
        [TestMethod]
        public void TestIsPairFalse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Ace));
            hand.Add(new Card(Suit.Hearts, Value.Five));
            hand.Add(new Card(Suit.Diamonds, Value.Four));
            hand.Add(new Card(Suit.Clubs, Value.King));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isPair(hand);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestIsPairTrue()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Ace));
            hand.Add(new Card(Suit.Hearts, Value.Ace));
            hand.Add(new Card(Suit.Diamonds, Value.Four));
            hand.Add(new Card(Suit.Clubs, Value.King));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isPair(hand);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestIsFlushTrue()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Five));
            hand.Add(new Card(Suit.Spades, Value.Ace));
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Spades, Value.King));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isFlush(hand);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestIsFlushFalse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Ace));
            hand.Add(new Card(Suit.Hearts, Value.Ace));
            hand.Add(new Card(Suit.Diamonds, Value.Four));
            hand.Add(new Card(Suit.Clubs, Value.King));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isFlush(hand);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestIsStraightTrue()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Six));
            hand.Add(new Card(Suit.Diamonds, Value.Five));
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Seven));

            bool actual = evaluator.isStraight(hand);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestIsStraightFalse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Six));
            hand.Add(new Card(Suit.Diamonds, Value.Five));
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isStraight(hand);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestIsRoyalTrue()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.King));
            hand.Add(new Card(Suit.Hearts, Value.Ten));
            hand.Add(new Card(Suit.Diamonds, Value.Jack));
            hand.Add(new Card(Suit.Clubs, Value.Ace));
            hand.Add(new Card(Suit.Spades, Value.Queen));

            bool actual = evaluator.isStraight(hand);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestIsRoyalFalse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Six));
            hand.Add(new Card(Suit.Diamonds, Value.Five));
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isStraight(hand);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestIsTwoPairTrue()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Four));
            hand.Add(new Card(Suit.Diamonds, Value.Five));
            hand.Add(new Card(Suit.Clubs, Value.Nine));
            hand.Add(new Card(Suit.Spades, Value.Five));

            bool actual = evaluator.isTwoPair(hand);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestIsTwoPairFalse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Six));
            hand.Add(new Card(Suit.Diamonds, Value.Five));
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isTwoPair(hand);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestIsThreeTrue()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Four));
            hand.Add(new Card(Suit.Diamonds, Value.Four));
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isThree(hand);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestIsThreeFalse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Six));
            hand.Add(new Card(Suit.Diamonds, Value.Five));
            hand.Add(new Card(Suit.Clubs, Value.Eight));
            hand.Add(new Card(Suit.Spades, Value.Nine));

            bool actual = evaluator.isThree(hand);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestIsJackPairTrue()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.King));
            hand.Add(new Card(Suit.Hearts, Value.King));
            hand.Add(new Card(Suit.Diamonds, Value.Five));
            hand.Add(new Card(Suit.Clubs, Value.Three));
            hand.Add(new Card(Suit.Spades, Value.Three));

            bool actual = evaluator.isJackPair(hand);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestIsJackPairFalse()
        {
            Evaluator evaluator = new Evaluator();
            List<Card> hand = new List<Card>();
            hand.Add(new Card(Suit.Spades, Value.Four));
            hand.Add(new Card(Suit.Hearts, Value.Five));
            hand.Add(new Card(Suit.Diamonds, Value.King));
            hand.Add(new Card(Suit.Clubs, Value.Nine));
            hand.Add(new Card(Suit.Spades, Value.King));

            bool actual = evaluator.isJackPair(hand);

            Assert.AreEqual(true, actual);
        }
    }
}
