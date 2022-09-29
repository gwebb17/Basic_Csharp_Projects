using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects265
{
    public class Card
    {
        public Card()
        {
            Face = "Two";
            Suit = "Spades";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
