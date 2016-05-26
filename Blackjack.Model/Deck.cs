using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Model
{
    class Deck
    {
        public int NumberOfCards { get; set; }
        public LinkedList<Card> Cards { get; set; }
    }
}
