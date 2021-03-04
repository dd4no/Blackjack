namespace Blackjack
{
    public class Card
    {
        // Properties.
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public string Color { get; set; }
        public int CardValue { get; set; }
    }

    // Card Suits.
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }

    // Card Faces.
    public enum Face
    {
        Ace,
        Two,
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
        King
    }
}



