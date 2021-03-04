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
            Deck deck = new Deck();
            deck.Shuffle();

            Player player = new Player();
            Dealer dealer = new Dealer();

            for (var i = 0; i < 2; i++)
            {
                deck.Deal(player.PlayerHand);
                deck.Deal(dealer.DealerHand);
            }

            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Clear();

            Console.WriteLine("Dealer Shows:");
            Console.WriteLine("-------------");
            Console.WriteLine($"{dealer.DealerHand[0].Face} of {dealer.DealerHand[0].Suit}\n");
            //Console.WriteLine($"{dealer.DealerHand[1].CardValue} : {dealer.DealerHand[1].Face} of {dealer.DealerHand[1].Suit}\n");

            Console.WriteLine("Your Cards:");
            Console.WriteLine("-------------");
            Rules.ShowHand(player.PlayerHand);

            int dealerHandValue = Rules.HandValue(dealer.DealerHand);
            bool dealerBlackjack = Rules.HasBlackjack(dealerHandValue);

            int playerHandValue = Rules.HandValue(player.PlayerHand);
            bool playerBlackjack = Rules.HasBlackjack(playerHandValue);

            if (playerBlackjack && !dealerBlackjack)
            {
                Rules.PlayerWin();
            }
            else if (playerBlackjack && dealerBlackjack)
            {
                Rules.Push();
            }
            else if (!playerBlackjack && dealerBlackjack)
            {
                Rules.HouseWin();
            }


            //Console.Read();
            //Console.Clear();
            Console.ReadKey();


        }



    }


}
