using System.Collections.Generic;

namespace Blackjack
{
    class Player
    {
        public string PlayerName { get; set; }
        public decimal Purse { get; set; }
        public List<Card> PlayerHand { get; set; } = new List<Card>();
    }
}
