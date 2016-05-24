using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack.Model
{
    class Blackjack : CardGame
    {
        private string _name;
        public override string Name  
        {
            get 
            { 
                return _name; 
            } 
            set 
            {
                if (String.IsNullOrEmpty(_name))
                {
                    _name = "Blackjack";
                }
            } 
        }

        public override int DeckSize { get; set; }
        public override bool IsMultiDeck { get; set; }
    }
}
