using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Dealer
    {
        public decimal Bank { get; set; }
        public List<Card> DealerHand { get; set; } = new List<Card>();
    }
}
