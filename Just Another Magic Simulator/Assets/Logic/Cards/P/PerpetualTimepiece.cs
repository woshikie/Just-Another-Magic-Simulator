
using System.Collections;

namespace Card
{
    public class PerpetualTimepiece : Card
    {
        /*
        {T}: Put the top two cards of your library into your graveyard.
{2}, Exile Perpetual Timepiece: Shuffle any number of target cards from your graveyard into your library.
        */
        private const string UniqueCardName = "Perpetual Timepiece";
        public PerpetualTimepiece() : base(UniqueCardName) { }

    }
}
