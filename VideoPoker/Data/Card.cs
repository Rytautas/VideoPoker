namespace VideoPoker
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Value
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Card
    {
        public Suit suit { get; set; }
        public Value value { get; set; }

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
