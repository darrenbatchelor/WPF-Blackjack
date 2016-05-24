using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Model
{
    abstract class CardGame : Game
    {
        public override string Name { get; set; }
        public abstract int DeckSize { get; set; }
        public abstract bool IsMultiDeck { get; set; }
    }
}
