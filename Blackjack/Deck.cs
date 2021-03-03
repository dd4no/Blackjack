using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        // Property.
        public List<Card> Cards { get; set; } = new List<Card>();
        
        // Constructor.
        public Deck()
        {
            // Create new instance of Cards property.
            Cards = new List<Card>();

            // Iterate through suits.
            for (var i = 0; i < 4; i++)
            {
                // Iterate through faces.
                for (var j = 0; j < 13; j++)
                {
                    // Create a new card.
                    Card card = new Card()
                    {
                        // Assign current suit and face.
                        Suit = (Suit)i,
                        Face = (Face)j,
                    };
                    // Add new card to list.
                    Cards.Add(card);
                }
            }
            
            // Iterate through deck to assign color and value.
            foreach (Card card in Cards)
            {
                // Cast enum values to int
                int suit = (int)card.Suit;
                int face = (int)card.Face;

                // If suit is "clubs" or "spades", color is "black", otherwise color is "red".
                if (suit == 0 || suit == 2)
                {
                    card.Color = "black";
                }
                else
                {
                    card.Color = "red";
                }

                // If face is "ten", "jack", "queen", or "king", value is 10, otherwise value is index + 1.
                if (face == 9 || face == 10 || face == 11 || face == 12)
                {
                    card.CardValue = 10;
                }
                else
                {
                    card.CardValue = face + 1;
                }
            }
        }

        //public void Shuffle(Deck deck)
        //{
        //    Random
        //}
    }
}
