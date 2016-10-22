
using System.Collections;

namespace Card
{
    public class FatefulShowdown : Card
    {
        /*
        Fateful Showdown deals damage to target creature or player equal to the number of cards in your hand. Discard all the cards in your hand, then draw that many cards.
        */
        private const string UniqueCardName = "Fateful Showdown";
        public FatefulShowdown() : base(UniqueCardName) { }

    }
}
