using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public string Color { get; set; }
        public int CardValue { get; set; }
    }

    public enum Suit
    {
        clubs,
        diamonds,
        spades,
        hearts
    }

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



