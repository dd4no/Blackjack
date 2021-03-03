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
            Player player = new Player
            {
                PlayerName = "Dave",
                Purse = 100.00m
            };
            Dealer dealer = new Dealer
            {
                Bank = 1000000.00m
            };

            Console.WriteLine($"Welcome {player.PlayerName}!\nYou are starting with ${player.Purse}");
            Console.WriteLine("The house has ${0} as a bank", dealer.Bank);
            //foreach (var card in deck.Cards)
            //{
            //    Console.WriteLine("{0} {1} of {2}, worth {3}", card.Color, card.Face, card.Suit, card.CardValue);
            //}
            Console.Read();
        }

    }
    
}
