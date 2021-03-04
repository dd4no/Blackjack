using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        // Constructor.
        public Deck()
        {
            // Create new list of Cards.
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

        // Property.
        public List<Card> Cards { get; set; } = new List<Card>();
        

        // Shuffle Method.
        public void Shuffle(int times = 1)
        {
            // Shuffle deck number of specified times (default = once).
            for (var i = 0; i < times; i++)
            {
                // Generate a random number object.
                Random randomNumber = new Random();
                // Create a new list to store shuffled cards.
                var shuffledDeck = new List<Card>();
                // Iterate while cards still exist in the deck.
                while (Cards.Count > 0)
                {
                    // Create a random index number.
                    int index = randomNumber.Next(0, Cards.Count);
                    // Add the card at that index to the new list.
                    shuffledDeck.Add(Cards[index]);
                    // Remove the card from the deck.
                    Cards.RemoveAt(index);
                }
                // Replace the deck with the shuffled deck.
                Cards = shuffledDeck;
            }
        }

        // Deal Method.
        public void Deal(List<Card> hand)
        {
            // Add last (top) card from deck to hand.
            hand.Add(Cards[Cards.Count - 1]);
            // Remove card from the deck.
            Cards.RemoveAt(Cards.Count - 1);
        }
    }
}
