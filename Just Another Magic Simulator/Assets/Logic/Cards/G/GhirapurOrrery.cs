
using System.Collections;

namespace Card
{
    public class GhirapurOrrery : Card
    {
        /*
        Each player may play an additional land on each of his or her turns.
At the beginning of each player's upkeep, if that player has no cards in hand, that player draws three cards.
        */
        private const string UniqueCardName = "Ghirapur Orrery";
        public GhirapurOrrery() : base(UniqueCardName) { }

    }
}
