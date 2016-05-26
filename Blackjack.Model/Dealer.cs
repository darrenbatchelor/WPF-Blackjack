using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Model
{
    class Dealer : Person
    {
        public override bool IsPlaying { get; set; }
        
        public bool ShuffleDeck(Deck deck)
        {
            //ShuffleCards(deck);
            return false;
        }

        public bool ShuffleDeck(List<Deck> decks)
        {

            return false;
        }
    }
}
