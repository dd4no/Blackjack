using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Rules
    {

        public static void ShowHand(List<Card> hand)
        {
            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Face} of {card.Suit}");
            }
        }

        public static int HandValue(List<Card> hand)
        {
            int sum = 0;
            foreach (var card in hand)
            {
                int face = (int)card.Face;
                if (card.Face == 0 && sum <= 21 && sum < 11)
                {
                    card.CardValue += 10;
                }
                sum += card.CardValue;
            }
            return sum;
        }

        public static bool HasBlackjack(int handValue)
        {
            if (handValue == 21)
            {
                return true;
            }
            else return false;
        }
            

        public static void PlayerWin()
        {
            Console.WriteLine("You win!");
        }

        public static void Push()
        {
            Console.WriteLine("No one wins.");
        }

        public static void HouseWin()
        {
            Console.WriteLine("House wins.");
        }


    }
}
