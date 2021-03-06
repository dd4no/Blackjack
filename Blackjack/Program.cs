using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Program
    {
        static void Main()
        {
            // Create a Table.
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            // Create and Shuffle a new Deck.
            Deck deck = new Deck();
            deck.Shuffle();

            // Set up Player and Dealer.
            Player player = new Player();
            Dealer dealer = new Dealer();

            // Deal Hand.
            for (var i = 0; i < 2; i++)
            {
                deck.Deal(player.PlayerHand);
                deck.Deal(dealer.DealerHand);
            }

            // Show Initial Hands.
            Console.WriteLine("Dealer Shows:");
            Console.WriteLine("-------------");
            Console.WriteLine($"{dealer.DealerHand[0].Face} of {dealer.DealerHand[0].Suit}\n");

            // Dealer Hole Card (Uncomment for testing and debugging).
            //Console.WriteLine($"{dealer.DealerHand[1].CardValue} : {dealer.DealerHand[1].Face} of {dealer.DealerHand[1].Suit}\n");

            Console.WriteLine("Your Hand:");
            Console.WriteLine("-------------");
            Rules.ShowHand(player.PlayerHand);
            Console.WriteLine("\n\n");

            // Sum Hands.
            int playerHandValue = Rules.HandValue(player.PlayerHand);
            int dealerHandValue = Rules.HandValue(dealer.DealerHand);

            // Check for Blackjack.
            bool dealerBlackjack = Rules.HasBlackjack(dealerHandValue);
            bool playerBlackjack = Rules.HasBlackjack(playerHandValue);
            if (playerBlackjack && !dealerBlackjack)
            {
                Console.WriteLine("You got Blackjack!");
                Rules.PlayerWin();
                return;
            }
            else if (playerBlackjack && dealerBlackjack)
            {
                Console.WriteLine("You and the Dealer both have Blackjack.");
                Rules.Push();
                return;
            }
            else if (!playerBlackjack && dealerBlackjack)
            {
                Console.WriteLine("The dealer has Blackjack!");
                Rules.HouseWin();
                return;
            }

            // Player Turn.
            Console.WriteLine("Player Turn:\n");
            bool playerStays = false;
            while (playerStays == false)
            {
                Console.WriteLine("Your Hand totals: {0}", playerHandValue);
                Console.WriteLine("(H)it or (S)tay?");
                string choice = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (choice == "S")
                {
                    playerStays = true;
                }
                else if (choice == "H")
                {
                    deck.Deal(player.PlayerHand);
                    Console.WriteLine("Your new Hand:\n");
                    Rules.ShowHand(player.PlayerHand);
                    Console.WriteLine();
                    playerHandValue = Rules.HandValue(player.PlayerHand);
                    if (playerHandValue > 21)
                    {
                        Console.WriteLine($"Your hand totals: {playerHandValue}.\nYou busted!");
                        Console.ReadLine();
                        return;
                    }
                }
                else 
                { 
                    Console.WriteLine("Please type \"H\" to Hit\nor \"S\" to Stay"); 
                }

            }

            // Dealer Turn.
            Console.WriteLine("Dealer's Turn:\n");

            // Show Hand.
            Console.WriteLine("Cards:\n");
            Rules.ShowHand(dealer.DealerHand);
            //Console.WriteLine();

            // Sum Hand and Show Value.
            dealerHandValue = Rules.HandValue(dealer.DealerHand);
            //Console.WriteLine($"Dealer's hand totals: {dealerHandValue}\n");

            while (dealerHandValue <= 16)
            {
                Console.WriteLine($"\nDealer's hand totals: {dealerHandValue}");
                Console.WriteLine("Dealer Hits\n");
                deck.Deal(dealer.DealerHand);
                Rules.ShowHand(dealer.DealerHand);
                dealerHandValue = Rules.HandValue(dealer.DealerHand);
            }               
                
            if (dealerHandValue > 21)
            {
                Console.WriteLine($"\nDealer's hand totals: {dealerHandValue}\nDealer busts.\nYou Win!");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine($"\nDealer's hand totals: {dealerHandValue}\nDealer Stays\n");
            }

            // Compare Hands.
            if (playerHandValue > dealerHandValue)
            {
                Rules.PlayerWin();
            }
            else if (playerHandValue == dealerHandValue)
            {
                Rules.Push();
            }
            else
            {
                Rules.HouseWin();
            }

            Console.ReadKey();
        }
    }
}
