using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Model
{
    class Card : GamePiece
    {
        public Suit suit { get; set; }
        public int FaceValue { get; set; }
        public bool IsFaceCard { get; set; }
        public bool IsAce { get; set; }
    }
}
