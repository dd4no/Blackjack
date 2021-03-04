using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public abstract class Game
    {
        public string GameName { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();

        public abstract void Play();

    }
}
