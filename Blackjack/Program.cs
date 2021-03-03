using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            Deck deck = new Deck();
            deck.Shuffle();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine("{0} {1} of {2}, worth {3}", card.Color, card.Face, card.Suit, card.CardValue);

            }
            Console.Read();
        }

    }
    
}
