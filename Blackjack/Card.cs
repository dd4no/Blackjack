namespace Blackjack
{
    class Card
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
        clubs,
        diamonds,
        spades,
        hearts
    }

    // Card Faces.
    public enum Face
    {
        ace,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king
    }
}



